﻿/**
* Copyright 2017 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System;
using System.Collections.Generic;
using IBM.WatsonDeveloperCloud.Service;
using IBM.WatsonDeveloperCloud.VisualRecognition.v3.Model;
using IBM.WatsonDeveloperCloud.Http;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.IO;

namespace IBM.WatsonDeveloperCloud.VisualRecognition.v3
{
    public class VisualRecognitionService : WatsonService, IVisualRecognitionService
    {
        const string PATH_CLASSIFY = "/v3/classify";
        const string PATH_DETECT_FACES = "/v3/detect_faces";
        const string PATH_CLASSIFIERS = "/v3/classifiers";
        const string PATH_CLASSIFIER = "/v3/classifiers/{0}";
        const string PATH_COLLECTIONS = "/v3/collections";
        const string PATH_COLLECTION = "/v3/collections/{0}";
        const string PATH_COLLECTION_IMAGES = "/v3/collections/{0}/images";
        const string PATH_COLLECTION_IMAGE = "/v3/collections/{0}/images/{1}";
        const string PATH_COLLECTION_IMAGE_METADATA = "/v3/collections/{0}/images/{1}/metadata";
        const string PATH_FIND_SIMILAR = "/v3/collections/{0}/find_similar";
        const string VERSION_DATE_2016_05_20 = "2016-05-20";
        const string SERVICE_NAME = "visual_recognition";
        const string URL = "https://gateway-a.watsonplatform.net/visual-recognition/api";

        public VisualRecognitionService()
            : base(SERVICE_NAME, URL)
        {
            if (!string.IsNullOrEmpty(this.Endpoint))
                this.Endpoint = URL;
        }

        public VisualRecognitionService(string apikey, string endpoint)
            : this()
        {
            if (string.IsNullOrEmpty(apikey))
                throw new ArgumentNullException("'apikey' is required");

            if (!string.IsNullOrEmpty(endpoint))
                this.Endpoint = endpoint;

            this.SetCredential(apikey);
        }

        public VisualRecognitionService(IClient httpClient)
            : this()
        {
            if (httpClient == null)
                throw new ArgumentNullException("'httpClient' is required");

            this.Client = httpClient;
        }

        private string _VersionDate;
        public string VersionDate
        {
            get { return string.IsNullOrEmpty(_VersionDate) ? VERSION_DATE_2016_05_20 : _VersionDate; }
            set { _VersionDate = value; }
        }

        #region Classify
        public ClassifyTopLevelMultiple Classify(string url, string[] classifierIDs = null, string[] owners = null, float threshold = 0, string acceptLanguage = "en")
        {
            ClassifyTopLevelMultiple result = null;

            if (string.IsNullOrEmpty(url))
                throw new ArgumentNullException("'url' is required for 'Classify()'");

            string _classifierIDs = classifierIDs != null ? string.Join(",", classifierIDs) : "default";

            if (owners != null)
                foreach (string owner in owners)
                    if (owner.ToLower() != "ibm" && owner.ToLower() != "me")
                        throw new ArgumentOutOfRangeException("Owners can only be a combination of IBM and me ('IBM', 'me', 'IBM,me').");

            string _owners = owners != null ? string.Join(",", owners) : "IBM,me";

            try
            {
                result = this.Client.GetAsync($"{this.Endpoint}{PATH_CLASSIFY}")
                    .WithHeader("Accept-Language", "en")
                    .WithArgument("url", url)
                    .WithArgument("classifier_ids", _classifierIDs)
                    .WithArgument("owners", _owners)
                    .WithArgument("threshold", threshold.ToString())
                    .WithArgument("version", VERSION_DATE_2016_05_20)
                    .WithArgument("api_key", ApiKey)
                    .As<ClassifyTopLevelMultiple>()
                    .Result;
            }
            catch (AggregateException ae)
            {
                throw ae.Flatten();
            }

            return result;
        }

        public ClassifyPost Classify(byte[] imageData = null, string imageDataName = null, string imageDataMimeType = null, string[] urls = null, string[] classifierIDs = null, string[] owners = null, float threshold = 0, string acceptLanguage = "en")
        {
            ClassifyPost result = null;

            if (imageData == null && (urls == null || urls.Length < 1))
                throw new ArgumentNullException(string.Format("{0} and {1} are required for 'Classify()'", "'imageData'", "'urls'"));

            if (imageData != null)
            {
                if (string.IsNullOrEmpty(imageDataName) || string.IsNullOrEmpty(imageDataMimeType))
                    throw new ArgumentException(string.Format("{0} or {1} are required for 'Classify()'", "'imageDataName'", "'imageDataMimeType'"));
            }

            if (owners != null)
                foreach (string owner in owners)
                    if (owner.ToLower() != "ibm" && owner.ToLower() != "me")
                        throw new ArgumentOutOfRangeException("Owners can only be a combination of IBM and me ('IBM', 'me', 'IBM,me').");

            try
            {
                ClassifyParameters parametersObject = new ClassifyParameters();
                parametersObject.ClassifierIds = classifierIDs != null ? classifierIDs : new string[] { "default" };
                parametersObject.URLs = urls != null ? urls : new string[0];
                parametersObject.Owners = owners != null ? owners : new string[0];
                parametersObject.Threshold = threshold;

                string parameters = JsonConvert.SerializeObject(parametersObject);

                var formData = new MultipartFormDataContent();

                if (imageData != null)
                {
                    var imageContent = new ByteArrayContent(imageData);
                    imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse(imageDataMimeType);
                    formData.Add(imageContent, "images_file", imageDataName);
                }

                if (!string.IsNullOrEmpty(parameters))
                {
                    var parametersContent = new StringContent(parameters, Encoding.UTF8, HttpMediaType.TEXT_PLAIN);
                    parametersContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    formData.Add(parametersContent, "parameters");
                }

                result = this.Client.PostAsync($"{ this.Endpoint}{PATH_CLASSIFY}")
                    .WithHeader("Accept-Language", "en")
                    .WithArgument("version", VERSION_DATE_2016_05_20)
                    .WithArgument("api_key", ApiKey)
                    .WithBodyContent(formData)
                    .As<ClassifyPost>()
                    .Result;
            }
            catch (AggregateException ae)
            {
                throw ae.Flatten();
            }

            return result;
        }
        #endregion

        #region Detect Faces
        public Faces DetectFaces(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentNullException("'url' is required for 'DetectFaces()'");

            Faces result = null;

            try
            {
                result = this.Client.GetAsync($"{this.Endpoint}{PATH_DETECT_FACES}")
                    .WithArgument("url", url)
                    .WithArgument("version", VERSION_DATE_2016_05_20)
                    .WithArgument("api_key", ApiKey)
                    .As<Faces>()
                    .Result;
            }
            catch (AggregateException ae)
            {
                throw ae.Flatten();
            }

            return result;
        }

        public Faces DetectFaces(byte[] imageData = null, string imageDataName = null, string imageDataMimeType = null, string[] urls = null)
        {
            Faces result = null;

            if (imageData == null && (urls == null || urls.Length < 1))
                throw new ArgumentNullException(string.Format("{0} and {1} are required for 'DetectFaces()'", "'imageData'", "'urls'"));

            if (imageData != null)
            {
                if (string.IsNullOrEmpty(imageDataName) || string.IsNullOrEmpty(imageDataMimeType))
                    throw new ArgumentNullException(string.Format("{0} or {1} are required for 'DetectFaces()'", "'imageDataName'", "'imageDataMimeType'"));
            }

            try
            {
                string parameters = null;

                if (urls != null && urls.Length > 0)
                {
                    DetectFacesParameters parametersObject = new DetectFacesParameters();
                    parametersObject.URLs = urls != null ? urls : new string[0];

                    parameters = JsonConvert.SerializeObject(parametersObject);
                }


                var formData = new MultipartFormDataContent();

                if (imageData != null)
                {
                    var imageContent = new ByteArrayContent(imageData);
                    imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse(imageDataMimeType);
                    formData.Add(imageContent, imageDataName, imageDataName);
                }

                if (!string.IsNullOrEmpty(parameters))
                {
                    var parametersContent = new StringContent(parameters, Encoding.UTF8, HttpMediaType.TEXT_PLAIN);
                    parametersContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    formData.Add(parametersContent);
                }

                result = this.Client.PostAsync($"{ this.Endpoint}{PATH_DETECT_FACES}")
                    .WithArgument("version", VERSION_DATE_2016_05_20)
                    .WithArgument("api_key", ApiKey)
                    .WithBodyContent(formData)
                    .As<Faces>()
                    .Result;
            }
            catch (AggregateException ae)
            {
                throw ae.Flatten();
            }

            return result;
        }
        #endregion

        #region Classifiers
        public GetClassifiersTopLevelBrief GetClassifiersBrief()
        {
            GetClassifiersTopLevelBrief result = null;

            try
            {
                result = this.Client.GetAsync($"{this.Endpoint}{PATH_CLASSIFIERS}")
                    .WithArgument("api_key", ApiKey)
                    .WithArgument("version", VERSION_DATE_2016_05_20)
                    .WithArgument("verbose", false)
                    .As<GetClassifiersTopLevelBrief>()
                    .Result;
            }
            catch (AggregateException ae)
            {
                throw ae.Flatten();
            }

            return result;
        }

        public GetClassifiersTopLevelVerbose GetClassifiersVerbose()
        {
            GetClassifiersTopLevelVerbose result = null;

            try
            {
                result = this.Client.GetAsync($"{this.Endpoint}{PATH_CLASSIFIERS}")
                    .WithArgument("api_key", ApiKey)
                    .WithArgument("version", VERSION_DATE_2016_05_20)
                    .WithArgument("verbose", true)
                    .WithFormatter(new MediaTypeHeaderValue("application/octet-stream"))
                    .As<GetClassifiersTopLevelVerbose>()
                    .Result;
            }
            catch (AggregateException ae)
            {
                throw ae.Flatten();
            }

            return result;
        }

        public GetClassifiersPerClassifierVerbose CreateClassifier(string classifierName, Dictionary<string, byte[]> positiveExamplesData, byte[] negativeExamplesData = null)
        {
            GetClassifiersPerClassifierVerbose result = null;

            if (string.IsNullOrEmpty(classifierName))
                throw new ArgumentNullException("'classifierName' is required for 'CreateClassifier()'");

            if (positiveExamplesData == null)
                throw new ArgumentNullException("'positiveExamplesData' is required for 'GetClassifier()'");

            if (positiveExamplesData.Count < 2 && negativeExamplesData == null)
                throw new ArgumentNullException("Training a Visual Recognition classifier requires at least two positive example files or one positive example and negative example file.");

            try
            {
                var formData = new MultipartFormDataContent();

                foreach (var kvp in positiveExamplesData)
                {
                    var positiveExampleDataContent = new ByteArrayContent(kvp.Value);
                    positiveExampleDataContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/zip");
                    formData.Add(positiveExampleDataContent, string.Format("{0}_positive_examples", kvp.Key), string.Format("{0}_positive_examples.zip", kvp.Key));
                }

                if (negativeExamplesData != null)
                {
                    var negativeExamplesDataContent = new ByteArrayContent(negativeExamplesData);
                    negativeExamplesDataContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/zip");
                    formData.Add(negativeExamplesDataContent, "negative_examples", "negative_examples.zip");
                }

                var nameDataContent = new StringContent(classifierName, Encoding.UTF8, HttpMediaType.TEXT_PLAIN);
                nameDataContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                formData.Add(nameDataContent, "name");

                result = this.Client.PostAsync($"{ this.Endpoint}{PATH_CLASSIFIERS}")
                    .WithArgument("version", VERSION_DATE_2016_05_20)
                    .WithArgument("api_key", ApiKey)
                    .WithBodyContent(formData)
                    .WithFormatter(new MediaTypeHeaderValue("application/octet-stream"))
                    .As<GetClassifiersPerClassifierVerbose>()
                    .Result;
            }
            catch (AggregateException ae)
            {
                throw ae.Flatten();
            }

            return result;
        }

        public object DeleteClassifier(string classifierId)
        {
            object result = null;

            if (string.IsNullOrEmpty(classifierId))
                throw new ArgumentNullException("'classifierId' is required for DeleteClassifier()");

            try
            {
                result = this.Client.DeleteAsync($"{this.Endpoint}{PATH_CLASSIFIERS}/{classifierId}")
                               .WithArgument("api_key", ApiKey)
                               .WithArgument("version", VERSION_DATE_2016_05_20)
                               .WithHeader("accept", HttpMediaType.TEXT_HTML)
                               .WithFormatter(new MediaTypeHeaderValue("application/octet-stream"))
                               .As<object>()
                               .Result;
            }
            catch (AggregateException ae)
            {
                throw ae.Flatten();
            }

            return result;
        }

        public GetClassifiersPerClassifierVerbose GetClassifier(string classifierId)
        {
            if (string.IsNullOrEmpty(classifierId))
                throw new ArgumentNullException("'classifierId' is required for 'GetClassifier()'");

            GetClassifiersPerClassifierVerbose result = null;

            try
            {
                result = this.Client.GetAsync($"{this.Endpoint}{string.Format(PATH_CLASSIFIER, classifierId)}")
                    .WithArgument("api_key", ApiKey)
                    .WithArgument("version", VERSION_DATE_2016_05_20)
                    .As<GetClassifiersPerClassifierVerbose>()
                    .Result;
            }
            catch (AggregateException ae)
            {
                throw ae.Flatten();
            }

            return result;
        }

        public GetClassifiersPerClassifierVerbose UpdateClassifier(string classifierId, Dictionary<string, byte[]> positiveExamplesData = null, byte[] negativeExamplesData = null)
        {
            GetClassifiersPerClassifierVerbose result = null;

            if (string.IsNullOrEmpty(classifierId))
                throw new ArgumentNullException("'classifierId' is required for 'UpdateClassifier()'");

            if (positiveExamplesData == null && negativeExamplesData == null)
                throw new ArgumentNullException("Positive example data and/or negative example data are required to update a classifier.");

            try
            {
                var formData = new MultipartFormDataContent();

                if (positiveExamplesData != null)
                {
                    foreach (var kvp in positiveExamplesData)
                    {
                        var positiveExampleDataContent = new ByteArrayContent(kvp.Value);
                        positiveExampleDataContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/zip");
                        formData.Add(positiveExampleDataContent, string.Format("{0}_positive_examples", kvp.Key), string.Format("{0}_positive_examples.zip", kvp.Key));
                    }
                }

                if (negativeExamplesData != null)
                {
                    var negativeExamplesDataContent = new ByteArrayContent(negativeExamplesData);
                    negativeExamplesDataContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/zip");
                    formData.Add(negativeExamplesDataContent, "negative_examples", "negative_examples.zip");
                }

                result = this.Client.PostAsync($"{ this.Endpoint}{string.Format(PATH_CLASSIFIER, classifierId)}")
                    .WithArgument("version", VERSION_DATE_2016_05_20)
                    .WithArgument("api_key", ApiKey)
                    .WithBodyContent(formData)
                    .WithFormatter(new MediaTypeHeaderValue("application/octet-stream"))
                    .As<GetClassifiersPerClassifierVerbose>()
                    .Result;
            }
            catch (AggregateException ae)
            {
                throw ae.Flatten();
            }

            return result;
        }
        #endregion

        #region Utils
        private string GetImageMimeTypeFromFilename(string filename)
        {
            string imageMimeType = "";
            if (!string.IsNullOrEmpty(filename))
            {
                string ext = Path.GetExtension(filename).ToLower();

                if (ext == ".jpg" || ext == ".jpeg")
                    imageMimeType = "image/jpeg";
                else if (ext == ".png")
                    imageMimeType = "image/png";
                else
                    throw new ArgumentOutOfRangeException(nameof(imageMimeType), "Only jpg and png images are accepted.");
            }

            return imageMimeType;
        }
        #endregion
    }
}
