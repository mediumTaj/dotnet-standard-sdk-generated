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

using IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.Model;
using IBM.WatsonDeveloperCloud.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.IntegrationTests
{

    [TestClass]
    public class ToneAnalyzerServiceIntegrationTests
    {
        private static string _username;
        private static string _password;
        private static string _endpoint;
        private string inputText = "Hello! Welcome to IBM Watson! How can I help you?";
        private string chatUser = "testChatUser";
        private string versionDate = "2016-05-19";
        private static string credentials = string.Empty;
        private ToneAnalyzerService _toneAnalyzer;

        [TestInitialize]
        public void Setup()
        {
            if (string.IsNullOrEmpty(credentials))
            {
                try
                {
                    credentials = Utility.SimpleGet(
                        Environment.GetEnvironmentVariable("VCAP_URL"),
                        Environment.GetEnvironmentVariable("VCAP_USERNAME"),
                        Environment.GetEnvironmentVariable("VCAP_PASSWORD")).Result;
                }
                catch (Exception e)
                {
                    Console.WriteLine(string.Format("Failed to get credentials: {0}", e.Message));
                }

                Task.WaitAll();

                var vcapServices = JObject.Parse(credentials);
                _endpoint = vcapServices["tone_analyzer"]["url"].Value<string>();
                _username = vcapServices["tone_analyzer"]["username"].Value<string>();
                _password = vcapServices["tone_analyzer"]["password"].Value<string>();
            }
        }

        [TestMethod]
        public void PostTone_Success()
        {
            _toneAnalyzer = new ToneAnalyzerService(_username, _password, versionDate);

            ToneInput toneInput = new ToneInput()
            {
                Text = inputText
            };

            var result = _toneAnalyzer.Tone(toneInput, "text/html", null);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.DocumentTone.ToneCategories.Count >= 1);
            Assert.IsTrue(result.DocumentTone.ToneCategories[0].Tones.Count >= 1);
        }

        [TestMethod]
        public void ToneChat_Success()
        {
            _toneAnalyzer = new ToneAnalyzerService(_username, _password, versionDate);

            ToneChatInput toneChatInput = new ToneChatInput()
            {
                Utterances = new List<Utterance>()
                {
                    new Utterance()
                    {
                        Text = inputText,
                        User = chatUser
                    }
                }
            };
            var result = _toneAnalyzer.ToneChat(toneChatInput);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.UtterancesTone.Count > 0);
        }
    }
}
