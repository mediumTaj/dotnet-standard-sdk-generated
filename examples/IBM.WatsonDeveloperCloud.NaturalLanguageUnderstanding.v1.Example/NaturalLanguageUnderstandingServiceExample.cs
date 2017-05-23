


using IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Model;
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
using System;

namespace IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Example
{
    public class NaturalLanguageUnderstandingServiceExample
    {
        private NaturalLanguageUnderstandingService _naturalLanguageUnderstandingService;

        private string _nluText = "Analyze various features of text content at scale. Provide text, raw HTML, or a public URL, and IBM Watson Natural Language Understanding will give you results for the features you request. The service cleans HTML content before analysis by default, so the results can ignore most advertisements and other unwanted content.";
        #region Constructor
        public NaturalLanguageUnderstandingServiceExample(string username, string password)
        {
            _naturalLanguageUnderstandingService = new NaturalLanguageUnderstandingService(username, password, NaturalLanguageUnderstandingService.NATURAL_LANGUAGE_UNDERSTANDING_VERSION_DATE_2017_02_27);
            //_naturalLanguageUnderstandingService.Endpoint = "http://localhost:1234";

            Analyze();
            Console.WriteLine("\n~ Natural Language Understanding examples complete.");
        }
        #endregion

        #region Analyze
        public void Analyze()
        {
            Parameters parameters = new Parameters()
            {
                Text = _nluText,
                Features = new Features()
                {
                    Keywords = new KeywordsOptions()
                    {
                        Limit = 8,
                        Sentiment = true,
                        Emotion = true
                    }
                }
            };

            Console.WriteLine(string.Format("\nCalling Analyze()..."));
            var result = _naturalLanguageUnderstandingService.Analyze(parameters);

            if(result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }
        #endregion
    }
}
