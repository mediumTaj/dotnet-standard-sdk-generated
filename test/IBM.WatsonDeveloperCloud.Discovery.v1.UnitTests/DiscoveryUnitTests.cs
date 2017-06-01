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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using IBM.WatsonDeveloperCloud.Http;

namespace IBM.WatsonDeveloperCloud.Discovery.v1.UnitTests
{
    [TestClass]
    public class DiscoveryUnitTests
    {
        #region Constructor
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_HttpClient_Null()
        {
            DiscoveryService service =
                new DiscoveryService(null);
        }

        [TestMethod]
        public void Constructor_HttpClient()
        {
            DiscoveryService service =
                new DiscoveryService(CreateClient());

            Assert.IsNotNull(service);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_UserName_Null()
        {
            DiscoveryService service =
                new DiscoveryService(null, "password", DiscoveryService.DISCOVERY_VERSION_DATE_2016_12_01);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_Password_Null()
        {
            DiscoveryService service =
                new DiscoveryService("username", null, DiscoveryService.DISCOVERY_VERSION_DATE_2016_12_01);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_Version_Null()
        {
            DiscoveryService service =
                new DiscoveryService("username", "password", null);
        }

        [TestMethod]
        public void Constructor_With_UserName_Password()
        {
            DiscoveryService service =
                new DiscoveryService("username", "password", DiscoveryService.DISCOVERY_VERSION_DATE_2016_12_01);

            Assert.IsNotNull(service);
        }

        [TestMethod]
        public void Constructor()
        {
            DiscoveryService service =
                new DiscoveryService();

            Assert.IsNotNull(service);
        }
        #endregion

        #region Create Client
        private IClient CreateClient()
        {
            IClient client = Substitute.For<IClient>();

            client.WithAuthentication(Arg.Any<string>(), Arg.Any<string>())
                    .Returns(client);

            return client;
        }
        #endregion
    }
}
