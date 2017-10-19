/**
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

using IBM.WatsonDeveloperCloud.VisualRecognition.v3.Model;

namespace IBM.WatsonDeveloperCloud.VisualRecognition.v3
{
    public interface IVisualRecognitionService
    {
        /// <summary>
        /// Classify images. 
        /// </summary>
        /// <param name="imagesFile">An image file (.jpg, .png) or .zip file with images. Include no more than 20 images and limit the .zip file to 5 MB. You can also include images with the `url` property in the **parameters** object. (optional)</param>
        /// <param name="parameters">Specifies input parameters. The parameter can include these inputs in a JSON object:  - url: A string with the image URL to analyze. You can also include images in the **images_file** parameter. - classifier_ids: An array of classifier IDs to classify the images against. - owners: An array with the values IBM, me, or both to specify which classifiers to run. - threshold: A floating point value that specifies the minimum score a class must have to be displayed in the response.  For example: {"url": "...", "classifier_ids": ["...","..."], "owners": ["IBM", "me"], "threshold": 0.4}. (optional)</param>
        /// <param name="acceptLanguage">Specifies the language of the output class names.  Can be `en` (English), `ar` (Arabic), `de` (German), `es` (Spanish), `it` (Italian), `ja` (Japanese), or `ko` (Korean).  Classes for which no translation is available are omitted.  The response might not be in the specified language under these conditions: - English is returned when the requested language is not supported. - Classes are not returned when there is no translation for them. - Custom classifiers returned with this method return tags in the language of the custom classifier. (optional, default to en)</param>
        /// <param name="imagesFileContentType">The content type of imagesFile. (optional)</param>
        /// <returns><see cref="ClassifiedImages" />ClassifiedImages</returns>
        ClassifiedImages Classify(System.IO.Stream imagesFile = null, string parameters = null, string acceptLanguage = null, string imagesFileContentType = null);

        /// <summary>
        /// Detect faces in an image. 
        /// </summary>
        /// <param name="imagesFile">An image file (.jpg, .png) or .zip file with images. Include no more than 15 images. You can also include images with the `url` property in the **parameters** object.  All faces are detected, but if there are more than 10 faces in an image, age and gender confidence scores might return scores of 0. (optional)</param>
        /// <param name="parameters">A JSON string containing the image URL to analyze.   For example: {"url": "..."}. (optional)</param>
        /// <param name="imagesFileContentType">The content type of imagesFile. (optional)</param>
        /// <returns><see cref="DetectedFaces" />DetectedFaces</returns>
        DetectedFaces DetectFaces(System.IO.Stream imagesFile = null, string parameters = null, string imagesFileContentType = null);
        /// <summary>
        /// Create a classifier. 
        /// </summary>
        /// <param name="name">The name of the new classifier. Cannot contain special characters.</param>
        /// <param name="classnamePositiveExamples">A compressed (.zip) file of images that depict the visual subject for a class within the new classifier. Must contain a minimum of 10 images. The swagger limits you to training only one class. To train more classes, use the API functionality.</param>
        /// <param name="negativeExamples">A compressed (.zip) file of images that do not depict the visual subject of any of the classes of the new classifier. Must contain a minimum of 10 images. (optional)</param>
        /// <returns><see cref="Classifier" />Classifier</returns>
        Classifier CreateClassifier(string name, System.IO.Stream classnamePositiveExamples, System.IO.Stream negativeExamples = null);

        /// <summary>
        /// Delete a custom classifier. 
        /// </summary>
        /// <param name="classifierId">The ID of the classifier.</param>
        /// <returns><see cref="Empty" />Empty</returns>
        Empty DeleteClassifier(string classifierId);

        /// <summary>
        /// Retrieve information about a custom classifier. 
        /// </summary>
        /// <param name="classifierId">The ID of the classifier.</param>
        /// <returns><see cref="Classifier" />Classifier</returns>
        Classifier GetClassifier(string classifierId);

        /// <summary>
        /// Retrieve a list of custom classifiers. 
        /// </summary>
        /// <param name="verbose">Specify true to return classifier details. Omit this parameter to return a brief list of classifiers. (optional)</param>
        /// <returns><see cref="Classifiers" />Classifiers</returns>
        Classifiers ListClassifiers(bool? verbose = null);

        /// <summary>
        /// Update a classifier. 
        /// </summary>
        /// <param name="classifierId">The ID of the classifier.</param>
        /// <param name="classnamePositiveExamples">A compressed (.zip) file of images that depict the visual subject for a class within the classifier. Must contain a minimum of 10 images. (optional)</param>
        /// <param name="negativeExamples">A compressed (.zip) file of images that do not depict the visual subject of any of the classes of the new classifier. Must contain a minimum of 10 images. (optional)</param>
        /// <returns><see cref="Classifier" />Classifier</returns>
        Classifier UpdateClassifier(string classifierId, System.IO.Stream classnamePositiveExamples = null, System.IO.Stream negativeExamples = null);
    }
}
