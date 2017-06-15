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
using IBM.WatsonDeveloperCloud.Http.Exceptions;
using System.Net.Http;
using IBM.WatsonDeveloperCloud.Discovery.v1.Model;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Generic;

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

        #region Environments
        #region List Environments
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void ListEnvironments_No_VersionDate()
        {
            DiscoveryService service = new DiscoveryService("username", "password", "versionDate");
            service.VersionDate = null;
            service.ListEnvironments("workspaceId");
        }

        [TestMethod, ExpectedException(typeof(AggregateException))]
        public void ListEnvironments_Catch_Exception()
        {
            IClient client = CreateClient();

            IRequest request = Substitute.For<IRequest>();
            client.GetAsync(Arg.Any<string>())
                 .Returns(x =>
                 {
                     throw new AggregateException(new ServiceResponseException(Substitute.For<IResponse>(),
                                                                               Substitute.For<HttpResponseMessage>(HttpStatusCode.BadRequest),
                                                                               string.Empty));
                 });

            DiscoveryService service = new DiscoveryService(client);
            service.VersionDate = DiscoveryService.DISCOVERY_VERSION_DATE_2016_12_01;
            service.ListEnvironments("workspaceId");
        }

        [TestMethod]
        public void ListEnvironments_Success()
        {
            IClient client = CreateClient();

            IRequest request = Substitute.For<IRequest>();
            client.GetAsync(Arg.Any<string>())
                .Returns(request);

            #region Response
            ListEnvironmentsResponse response = new ListEnvironmentsResponse()
            {
                Environments = new List<ModelEnvironment>()
               {
                   new ModelEnvironment()
                   {
                       Status = ModelEnvironment.StatusEnum.PENDING,
                       Name = "name",
                       Description = "description",
                       Size = 1,
                       IndexCapacity = new IndexCapacity()
                       {
                           DiskUsage = new DiskUsage(){},
                           MemoryUsage = new MemoryUsage(){}
                       }
                   }
               }
            };
            #endregion

            request.WithArgument(Arg.Any<string>(), Arg.Any<string>())
                .Returns(request);
            request.WithArgument(Arg.Any<string>(), Arg.Any<string>())
                .Returns(request);
            request.As<ListEnvironmentsResponse>()
                .Returns(Task.FromResult(response));

            DiscoveryService service = new DiscoveryService(client);
            service.VersionDate = "versionDate";

            var result = service.ListEnvironments("workspaceId");

            Assert.IsNotNull(result);
            client.Received().GetAsync(Arg.Any<string>());
            Assert.IsTrue(result.Environments != null);
            Assert.IsTrue(result.Environments.Count > 0);
            Assert.IsTrue(result.Environments[0].Status == ModelEnvironment.StatusEnum.PENDING);
            Assert.IsTrue(result.Environments[0].Name == "name");
            Assert.IsTrue(result.Environments[0].Description == "description");
            Assert.IsTrue(result.Environments[0].Size == 1);
        }
        #endregion

        #region Create Environment
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void CreateEnvironment_No_Environment()
        {
            DiscoveryService service = new DiscoveryService("username", "password", "versionDate");
            service.CreateEnvironment(null);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void CreateCounterExample_No_VersionDate()
        {
            DiscoveryService service = new DiscoveryService("username", "password", "versionDate");
            service.VersionDate = null;

            CreateEnvironmentRequest enviroment = new CreateEnvironmentRequest()
            {
                Name = "name",
                Description = "description",
                Size = 1
            };

            service.CreateEnvironment(enviroment);
        }

        [TestMethod, ExpectedException(typeof(AggregateException))]
        public void CreateEnvironment_Catch_Exception()
        {
            IClient client = CreateClient();

            IRequest request = Substitute.For<IRequest>();
            client.PostAsync(Arg.Any<string>())
                 .Returns(x =>
                 {
                     throw new AggregateException(new ServiceResponseException(Substitute.For<IResponse>(),
                                                                               Substitute.For<HttpResponseMessage>(HttpStatusCode.BadRequest),
                                                                               string.Empty));
                 });

            CreateEnvironmentRequest enviroment = new CreateEnvironmentRequest()
            {
                Name = "name",
                Description = "description",
                Size = 1
            };
            DiscoveryService service = new DiscoveryService(client);
            service.VersionDate = DiscoveryService.DISCOVERY_VERSION_DATE_2016_12_01;

            service.CreateEnvironment(enviroment);
        }

        [TestMethod]
        public void CreateEnvironment_Success()
        {
            IClient client = CreateClient();

            IRequest request = Substitute.For<IRequest>();
            client.PostAsync(Arg.Any<string>())
                .Returns(request);

            #region Response
            ModelEnvironment response = new ModelEnvironment()
            {
                Status = ModelEnvironment.StatusEnum.PENDING,
                Name = "name",
                Description = "description",
                Size = 1,
                IndexCapacity = new IndexCapacity()
                {
                    DiskUsage = new DiskUsage(){},
                    MemoryUsage = new MemoryUsage(){}
                }
            };
            #endregion

            CreateEnvironmentRequest environment = new CreateEnvironmentRequest()
            {
                Name = "name",
                Description = "description",
                Size = 1
            };

            request.WithArgument(Arg.Any<string>(), Arg.Any<string>())
                .Returns(request);
            request.WithArgument(Arg.Any<string>(), Arg.Any<string>())
                .Returns(request);
            request.WithBody<CreateEnvironmentRequest>(environment)
                .Returns(request);
            request.As<ModelEnvironment>()
                .Returns(Task.FromResult(response));

            DiscoveryService service = new DiscoveryService(client);
            service.VersionDate = "versionDate";

            var result = service.CreateEnvironment(environment);

            Assert.IsNotNull(result);
            client.Received().PostAsync(Arg.Any<string>());
            Assert.IsTrue(result.Name == "name");
            Assert.IsTrue(result.Description == "description");
            Assert.IsTrue(result.Size == 1);
        }
        #endregion

        #region Delete Environment
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void DeleteEnvironment_No_EnvironmentId()
        {
            DiscoveryService service = new DiscoveryService("username", "password", "versionDate");
            service.DeleteEnvironment(null);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void DeleteEnvironment_No_VersionDate()
        {
            DiscoveryService service = new DiscoveryService("username", "password", "versionDate");
            service.VersionDate = null;
            service.DeleteEnvironment("environmentId");
        }

        [TestMethod, ExpectedException(typeof(AggregateException))]
        public void DeleteEnvironment_Catch_Exception()
        {
            IClient client = CreateClient();

            IRequest request = Substitute.For<IRequest>();
            client.DeleteAsync(Arg.Any<string>())
                 .Returns(x =>
                 {
                     throw new AggregateException(new ServiceResponseException(Substitute.For<IResponse>(),
                                                                               Substitute.For<HttpResponseMessage>(HttpStatusCode.BadRequest),
                                                                               string.Empty));
                 });

            DiscoveryService service = new DiscoveryService(client);
            service.VersionDate = DiscoveryService.DISCOVERY_VERSION_DATE_2016_12_01;

            service.DeleteEnvironment("workspaceId");
        }

        [TestMethod]
        public void DeleteEnvironment_Success()
        {
            IClient client = CreateClient();

            IRequest request = Substitute.For<IRequest>();
            client.DeleteAsync(Arg.Any<string>())
                .Returns(request);

            #region Response
            DeleteEnvironmentResponse response = new DeleteEnvironmentResponse()
            {
                EnvironmentId = "environmentId",
                Status = DeleteEnvironmentResponse.StatusEnum.DELETED
            };
            #endregion

            request.WithArgument(Arg.Any<string>(), Arg.Any<string>())
                .Returns(request);
            request.As<DeleteEnvironmentResponse>()
                .Returns(Task.FromResult(response));

            DiscoveryService service = new DiscoveryService(client);
            service.VersionDate = "versionDate";

            var result = service.DeleteEnvironment("environmentId");

            Assert.IsNotNull(result);
            client.Received().DeleteAsync(Arg.Any<string>());
            Assert.IsTrue(result.EnvironmentId == "environmentId");
            Assert.IsTrue(result.Status == DeleteEnvironmentResponse.StatusEnum.DELETED);
        }
        #endregion

        #region Get Envronment
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void GetEnvironment_No_EnvironmentId()
        {
            DiscoveryService service = new DiscoveryService("username", "password", "versionDate");
            service.GetEnvironment(null);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void GetEnvironment_No_VersionDate()
        {
            DiscoveryService service = new DiscoveryService("username", "password", "versionDate");
            service.VersionDate = null;
            service.GetEnvironment("environmentId");
        }

        [TestMethod, ExpectedException(typeof(AggregateException))]
        public void GetEnvironment_Catch_Exception()
        {
            IClient client = CreateClient();

            IRequest request = Substitute.For<IRequest>();
            client.GetAsync(Arg.Any<string>())
                 .Returns(x =>
                 {
                     throw new AggregateException(new ServiceResponseException(Substitute.For<IResponse>(),
                                                                               Substitute.For<HttpResponseMessage>(HttpStatusCode.BadRequest),
                                                                               string.Empty));
                 });

            DiscoveryService service = new DiscoveryService(client);
            service.VersionDate = DiscoveryService.DISCOVERY_VERSION_DATE_2016_12_01;
            service.GetEnvironment("EnvironmentId");
        }

        [TestMethod]
        public void GetEnvironment_Success()
        {
            IClient client = CreateClient();

            IRequest request = Substitute.For<IRequest>();
            client.GetAsync(Arg.Any<string>())
                .Returns(request);

            #region Response
            ModelEnvironment response = new ModelEnvironment()
            {
                Status = ModelEnvironment.StatusEnum.PENDING,
                Name = "name",
                Description = "description",
                Size = 1,
                IndexCapacity = new IndexCapacity()
                {
                    DiskUsage = new DiskUsage(){},
                    MemoryUsage = new MemoryUsage(){}
                }
            };
            #endregion

            request.WithArgument(Arg.Any<string>(), Arg.Any<string>())
                .Returns(request);
            request.As<ModelEnvironment>()
                .Returns(Task.FromResult(response));

            DiscoveryService service = new DiscoveryService(client);
            service.VersionDate = "versionDate";

            var result = service.GetEnvironment("environmentId");

            Assert.IsNotNull(result);
            client.Received().GetAsync(Arg.Any<string>());
            Assert.IsTrue(result.Status == ModelEnvironment.StatusEnum.PENDING);
            Assert.IsTrue(result.Name == "name");
            Assert.IsTrue(result.Description == "description");
            Assert.IsTrue(result.Size == 1);
        }
        #endregion

        #region Update Environment
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void UpdateEnvironment_No_EnvironmentId()
        {
            DiscoveryService service = new DiscoveryService("username", "password", "versionDate");
            UpdateEnvironmentRequest environment = new UpdateEnvironmentRequest()
            {
                Name = "name",
                Description = "description"
            };

            service.UpdateEnvironment(null, environment);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void UpdateEnvironment_No_Body()
        {
            DiscoveryService service = new DiscoveryService("username", "password", "versionDate");
            service.UpdateEnvironment("environmentId", null);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void UpdateEnvironment_No_VersionDate()
        {
            DiscoveryService service = new DiscoveryService("username", "password", "versionDate");
            service.VersionDate = null;

            UpdateEnvironmentRequest environment = new UpdateEnvironmentRequest()
            {
                Name = "name",
                Description = "description"
            };

            service.UpdateEnvironment("environmentId", environment);
        }

        [TestMethod, ExpectedException(typeof(AggregateException))]
        public void UpdateEnvironment_Catch_Exception()
        {
            IClient client = CreateClient();

            IRequest request = Substitute.For<IRequest>();
            client.PutAsync(Arg.Any<string>())
                 .Returns(x =>
                 {
                     throw new AggregateException(new ServiceResponseException(Substitute.For<IResponse>(),
                                                                               Substitute.For<HttpResponseMessage>(HttpStatusCode.BadRequest),
                                                                               string.Empty));
                 });

            UpdateEnvironmentRequest environment = new UpdateEnvironmentRequest()
            {
                Name = "name",
                Description = "description"
            };
            DiscoveryService service = new DiscoveryService(client);
            service.VersionDate = DiscoveryService.DISCOVERY_VERSION_DATE_2016_12_01;

            service.UpdateEnvironment("environmentId", environment);
        }

        [TestMethod]
        public void UpdateEnvironment_Success()
        {
            IClient client = CreateClient();

            IRequest request = Substitute.For<IRequest>();
            client.PutAsync(Arg.Any<string>())
                .Returns(request);

            #region Response
            ModelEnvironment response = new ModelEnvironment()
            {
                Status = ModelEnvironment.StatusEnum.PENDING,
                Name = "name",
                Description = "description",
                Size = 1,
                IndexCapacity = new IndexCapacity()
                {
                    DiskUsage = new DiskUsage() { },
                    MemoryUsage = new MemoryUsage() { }
                }
            };
            #endregion

            UpdateEnvironmentRequest environment = new UpdateEnvironmentRequest()
            {
                Name = "name",
                Description = "description"
            };

            request.WithArgument(Arg.Any<string>(), Arg.Any<string>())
                .Returns(request);
            request.WithBody<UpdateEnvironmentRequest>(environment)
                .Returns(request);
            request.As<ModelEnvironment>()
                .Returns(Task.FromResult(response));

            DiscoveryService service = new DiscoveryService(client);
            service.VersionDate = "versionDate";

            var result = service.UpdateEnvironment("environmentId", environment);

            Assert.IsNotNull(result);
            client.Received().PutAsync(Arg.Any<string>());
            Assert.IsTrue(result.Status == ModelEnvironment.StatusEnum.PENDING);
            Assert.IsTrue(result.Name == "name");
            Assert.IsTrue(result.Description == "description");
            Assert.IsTrue(result.Size == 1);
        }
        #endregion
        #endregion

        #region Preview Environment
        #endregion

        #region Confugrations
        #endregion

        #region Collecitons
        #endregion

        #region Documents
        #endregion

        #region Query
        #endregion

        #region Notices
        #endregion
    }
}
