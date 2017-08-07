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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.IntegrationTests
{

    [TestClass]
    public class ToneAnalyzerServiceIntegrationTests
    {
        private string _userName;
        private string _password;
        private string _endpoint;
        private string _inputText = "I was asked to sign a third party contract a week out from stay. If it wasn't an 8 person group that took a lot of wrangling I would have cancelled the booking straight away. Bathrooms - there are no stand alone bathrooms. Please consider this - you have to clear out the main bedroom to use that bathroom. Other option is you walk through a different bedroom to get to its en-suite. Signs all over the apartment - there are signs everywhere - some helpful - some telling you rules. Perhaps some people like this but It negatively affected our enjoyment of the accommodation. Stairs - lots of them - some had slightly bending wood which caused a minor injury.";
        private string _utternaceText = "I was asked to sign a third party contract a week out from stay. If it wasn't an 8 person group that took a lot of wrangling I would have cancelled the booking straight away. Bathrooms - there are no stand alone bathrooms. Please consider this - you have to clear out the main bedroom to use that bathroom. Other option is you walk through a different bedroom to get to its en-suite. Signs all over the apartment - there are signs everywhere - some helpful - some telling you rules.";
        private string _chatUser = "testChatUser";
        private string _versionDate = "2016-05-19";

        [TestInitialize]
        public void Setup()
        {
            var environmentVariable =
            Environment.GetEnvironmentVariable("VCAP_SERVICES");

            var fileContent =
            File.ReadAllText(environmentVariable);

            var vcapServices =
            JObject.Parse(fileContent);

            _endpoint = vcapServices["tone_analyzer"][0]["credentials"]["url"].Value<string>();
            _userName = vcapServices["tone_analyzer"][0]["credentials"]["username"].Value<string>();
            _password = vcapServices["tone_analyzer"][0]["credentials"]["password"].Value<string>();
        }

        [TestMethod]
        public void PostTone_Success()
        {
            ToneAnalyzerService service = new ToneAnalyzerService(_userName, _password, _versionDate);

            ToneInput toneInput = new ToneInput()
            {
                Text = _inputText
            };

            var result = service.Tone(toneInput, "application/json", null);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.DocumentTone.ToneCategories.Count >= 1);
            Assert.IsTrue(result.DocumentTone.ToneCategories[0].Tones.Count >= 1);
        }

        [TestMethod]
        public void ToneChat_Success()
        {
            ToneAnalyzerService service = new ToneAnalyzerService(_userName, _password, _versionDate);

            ToneChatInput toneChatInput = new ToneChatInput()
            {
                Utterances = new List<Utterance>()
                {
                    new Utterance()
                    {
                        Text = _utternaceText,
                        User = _chatUser
                    }
                }
            };

            var result = service.ToneChat(toneChatInput);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.UtterancesTone.Count > 0);
            Assert.IsTrue(result.UtterancesTone[0].Tones.Count > 0);
        }
    }
}
