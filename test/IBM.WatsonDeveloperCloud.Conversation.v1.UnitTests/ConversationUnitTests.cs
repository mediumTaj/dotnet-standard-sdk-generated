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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Linq;
using IBM.WatsonDeveloperCloud.Http;
using IBM.WatsonDeveloperCloud.Conversation.v1.Model;
using IBM.WatsonDeveloperCloud.Http.Exceptions;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace IBM.WatsonDeveloperCloud.Conversation.v1.UnitTests
{
    [TestClass]
    public class ConversationUnitTests
    {
        #region Constructor
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_HttpClient_Null()
        {
            ConversationService service =
                new ConversationService(null);
        }

        [TestMethod]
        public void Constructor_HttpClient()
        {
            ConversationService service =
                new ConversationService(CreateClient());

            Assert.IsNotNull(service);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_UserName_Null()
        {
            ConversationService service =
                new ConversationService(null, "password", ConversationService.CONVERSATION_VERSION_DATE_2017_04_21);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_Password_Null()
        {
            ConversationService service =
                new ConversationService("username", null, ConversationService.CONVERSATION_VERSION_DATE_2017_04_21);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_Version_Null()
        {
            ConversationService service =
                new ConversationService("username", "password", null);
        }

        [TestMethod]
        public void Constructor_With_UserName_Password()
        {
            ConversationService service =
                new ConversationService("username", "password", ConversationService.CONVERSATION_VERSION_DATE_2017_04_21);

            Assert.IsNotNull(service);
        }

        [TestMethod]
        public void Constructor()
        {
            ConversationService service =
                new ConversationService();

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

        #region Create Counter Example
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void CreateCounterExample_No_WorkspaceId()
        {
            ConversationService service = new ConversationService("username", "password", "versionDate");
            CreateExample example = new CreateExample()
            {
                Text = "text"
            };

            service.CreateCounterexample(null, example);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void CreateCounterExample_No_Body()
        {
            ConversationService service = new ConversationService("username", "password", "versionDate");

            service.CreateCounterexample("workspaceId", null);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void CreateCounterExample_No_VersionDate()
        {
            ConversationService service = new ConversationService("username", "password", "versionDate");
            service.VersionDate = null;

            CreateExample example = new CreateExample()
            {
                Text = "text"
            };

            service.CreateCounterexample("workspaceId", example);
        }

        [TestMethod, ExpectedException(typeof(AggregateException))]
        public void CreateCounterExample_Catch_Exception()
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

            CreateExample example = new CreateExample()
            {
                Text = "text"
            };
            ConversationService service = new ConversationService(client);
            service.VersionDate = ConversationService.CONVERSATION_VERSION_DATE_2017_04_21;

            service.CreateCounterexample("workspaceId", example);
        }

        [TestMethod]
        public void CreateCounterExample_Success()
        {
            IClient client = CreateClient();

            IRequest request = Substitute.For<IRequest>();
            client.PostAsync(Arg.Any<string>())
                .Returns(request);

            #region Response
            ExampleResponse response = new ExampleResponse()
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Text = "text"
            };
            #endregion

            CreateExample example = new CreateExample()
            {
                Text = "text"
            };

            request.WithArgument(Arg.Any<string>(), Arg.Any<string>())
                .Returns(request);
            request.WithBody<CreateExample>(example)
                .Returns(request);
            request.As<ExampleResponse>()
                .Returns(Task.FromResult(response));

            ConversationService service = new ConversationService(client);
            service.VersionDate = "versionDate";

            var result = service.CreateCounterexample("workspaceId", example);

            Assert.IsNotNull(result);
            client.Received().PostAsync(Arg.Any<string>());
            Assert.IsTrue(result.Text == "text");
        }
        #endregion

        #region Delete Counter Example
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void DeleteCounterExample_No_WorkspaceId()
        {
            ConversationService service = new ConversationService("username", "password", "versionDate");
            service.DeleteCounterexample(null, "example");
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void DeleteCounterExample_No_Example()
        {
            ConversationService service = new ConversationService("username", "password", "versionDate");

            service.DeleteCounterexample("workspaceId", null);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void DeleteCounterExample_No_VersionDate()
        {
            ConversationService service = new ConversationService("username", "password", "versionDate");
            service.VersionDate = null;
            service.DeleteCounterexample("workspaceId", "example");
        }

        [TestMethod, ExpectedException(typeof(AggregateException))]
        public void DeleteCounterExample_Catch_Exception()
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

            ConversationService service = new ConversationService(client);
            service.VersionDate = ConversationService.CONVERSATION_VERSION_DATE_2017_04_21;

            service.DeleteCounterexample("workspaceId", "example");
        }

        [TestMethod]
        public void DeleteCounterExample_Success()
        {
            IClient client = CreateClient();

            IRequest request = Substitute.For<IRequest>();
            client.DeleteAsync(Arg.Any<string>())
                .Returns(request);

            #region Response
            object response = new object() { };
            #endregion

            request.WithArgument(Arg.Any<string>(), Arg.Any<string>())
                .Returns(request);
            request.As<object>()
                .Returns(Task.FromResult(response));

            ConversationService service = new ConversationService(client);
            service.VersionDate = "versionDate";

            var result = service.DeleteCounterexample("workspaceId", "example");

            Assert.IsNotNull(result);
            client.Received().DeleteAsync(Arg.Any<string>());
        }
        #endregion

        #region Get Counter Example
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void GetCounterExample_No_WorkspaceId()
        {
            ConversationService service = new ConversationService("username", "password", "versionDate");
            service.GetCounterexample(null, "text");
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void GetCounterExample_No_Example()
        {
            ConversationService service = new ConversationService("username", "password", "versionDate");
            service.CreateCounterexample("workspaceId", null);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void GetCounterExample_No_VersionDate()
        {
            ConversationService service = new ConversationService("username", "password", "versionDate");
            service.VersionDate = null;
            service.GetCounterexample("workspaceId", "text");
        }

        [TestMethod, ExpectedException(typeof(AggregateException))]
        public void GetCounterExample_Catch_Exception()
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

            ConversationService service = new ConversationService(client);
            service.VersionDate = ConversationService.CONVERSATION_VERSION_DATE_2017_04_21;
            service.GetCounterexample("workspaceId", "text");
        }

        [TestMethod]
        public void GetCounterExample_Success()
        {
            IClient client = CreateClient();

            IRequest request = Substitute.For<IRequest>();
            client.GetAsync(Arg.Any<string>())
                .Returns(request);

            #region Response
            ExampleResponse response = new ExampleResponse()
            {
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Text = "text"
            };
            #endregion

            request.WithArgument(Arg.Any<string>(), Arg.Any<string>())
                .Returns(request);
            request.As<ExampleResponse>()
                .Returns(Task.FromResult(response));

            ConversationService service = new ConversationService(client);
            service.VersionDate = "versionDate";

            var result = service.GetCounterexample("workspaceId", "text");

            Assert.IsNotNull(result);
            client.Received().GetAsync(Arg.Any<string>());
            Assert.IsTrue(result.Text == "text");
        }
        #endregion
    }
}
