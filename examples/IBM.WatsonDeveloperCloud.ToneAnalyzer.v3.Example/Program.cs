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

using IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var environmentVariable = Environment.GetEnvironmentVariable("VCAP_SERVICES");
            var fileContent = File.ReadAllText(environmentVariable);
            var vcapServices = JObject.Parse(fileContent);
            var _username = vcapServices["tone_analyzer"][0]["credentials"]["username"];
            var _password = vcapServices["tone_analyzer"][0]["credentials"]["password"];
            string versionDate = "2016-05-19";
            string _inputText = "I was asked to sign a third party contract a week out from stay. If it wasn't an 8 person group that took a lot of wrangling I would have cancelled the booking straight away. Bathrooms - there are no stand alone bathrooms. Please consider this - you have to clear out the main bedroom to use that bathroom. Other option is you walk through a different bedroom to get to its en-suite. Signs all over the apartment - there are signs everywhere - some helpful - some telling you rules. Perhaps some people like this but It negatively affected our enjoyment of the accommodation. Stairs - lots of them - some had slightly bending wood which caused a minor injury.";
            string _utternaceText = "I was asked to sign a third party contract a week out from stay. If it wasn't an 8 person group that took a lot of wrangling I would have cancelled the booking straight away. Bathrooms - there are no stand alone bathrooms. Please consider this - you have to clear out the main bedroom to use that bathroom. Other option is you walk through a different bedroom to get to its en-suite. Signs all over the apartment - there are signs everywhere - some helpful - some telling you rules.";

            ToneAnalyzerService _toneAnalyzer = new ToneAnalyzerService(_username.ToString(), _password.ToString(), versionDate);

            //  Test PostTone
            ToneInput toneInput = new ToneInput()
            {
                Text = _inputText
            };

            var postToneResult = _toneAnalyzer.Tone(toneInput, "application/json");
            Console.WriteLine(string.Format("postToneResult: {0}", JsonConvert.SerializeObject(postToneResult)));

            //  Test ToneChat
            ToneChatInput toneChatInput = new ToneChatInput()
            {
                Utterances = new List<Utterance>()
                {
                    new Utterance()
                    {
                        Text = _utternaceText
                    }
                }
            };

            var toneChatResult = _toneAnalyzer.ToneChat(toneChatInput);
            Console.WriteLine(string.Format("toneChatResult: {0}", JsonConvert.SerializeObject(toneChatResult)));


            Console.ReadKey();

        }
    }
}
