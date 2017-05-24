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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.IntegrationTests
{
    [TestClass]
    public class NaturalLanguageUnderstandingIntegrationTests
    {
        public string _username;
        public string _password;
        public string _endpoint;
        public NaturalLanguageUnderstandingService naturalLanguageUnderstanding;

        [TestInitialize]
        public void Setup()
        {
            var environmentVariable =
            Environment.GetEnvironmentVariable("VCAP_SERVICES");

            var fileContent =
                File.ReadAllText(environmentVariable);

            var vcapServices =
            JObject.Parse(fileContent);

            _endpoint = vcapServices["natural_language_understanding"][0]["credentials"]["url"].Value<string>();
            _username = vcapServices["natural_language_understanding"][0]["credentials"]["username"].Value<string>();
            _password = vcapServices["natural_language_understanding"][0]["credentials"]["password"].Value<string>();

            naturalLanguageUnderstanding = new NaturalLanguageUnderstandingService(_username, _password, NaturalLanguageUnderstandingService.NATURAL_LANGUAGE_UNDERSTANDING_VERSION_DATE_2017_02_27);
        }
    }
}
