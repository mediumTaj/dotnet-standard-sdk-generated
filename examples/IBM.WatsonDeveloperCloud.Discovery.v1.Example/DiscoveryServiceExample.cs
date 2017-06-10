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
using IBM.WatsonDeveloperCloud.Discovery.v1.Model;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace IBM.WatsonDeveloperCloud.Discovery.v1.Example
{
    public class DiscoveryServiceExample
    {
        private DiscoveryService _discovery;
        private string _createdEnvironmentId = "3f8a7134-a575-4d53-8cfa-ed826e57b5e1";

        private string _createdConfigurationId = "da22b889-0ecb-470c-905f-876ddb3c27c7";
        private string _createdConfigurationName = "configName";
        private string _createdConfigurationNameUpdated = "configName-updated";
        private string _createdConfigurationDescription = "configDescription";
        private string _createdConfigurationSourceField = "sourceField";
        private string _createdConfigurationDestinationField = "destionationField";
        private string _createdConfigurationPdfFontName = "font";
        private string _createdConfigurationWordStyleName = "style";
        private string _createdConfigurationHtmlExcludeTag = "tag";
        private string _createdConfigurationHtmlXpath = "xpath";
        private string _createdConfigurationEnrichmentDescription = "enrichmentDescription";
        private string _createdConfigurationEnrichmentDestinationField = "destinationField";
        private string _createdConfigurationEnrichmentSourceField = "sourceField";
        private string _createdConfigurationEnrichmentName = "sourceField";
        private string _filepathToIngest = @"DiscoveryTestData\watson_beats_jeopardy.html";
        private string _metadata = "{\"Creator\": \"DotnetSDK Test\",\"Subject\": \"Discovery service\"}";
        private string _defaultConfigurationName = "Default Configuration";

        AutoResetEvent autoEvent = new AutoResetEvent(false);

        #region Constructor
        public DiscoveryServiceExample(string username, string password)
        {
            _discovery = new DiscoveryService(username, password, DiscoveryService.DISCOVERY_VERSION_DATE_2016_12_01);
            //_discovery.Endpoint = "http://localhost:1234";

            GetEnvironments();
            CreateEnvironment();
            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("\nChecking environment status in 30 seconds.");
                System.Threading.Thread.Sleep(30000);
                IsEnvironmentReady(_createdEnvironmentId);
            });
            autoEvent.WaitOne();
            GetEnvironment();
            UpdateEnvironment();


            GetConfigurations();
            CreateConfiguration();
            GetConfiguration();
            UpdateConfiguration();

            PreviewEnvironment();

            //GetCollections();
            //CreateCollection();
            //GetCollection();
            //GetCollectionFields();
            //UpdateCollection();

            //AddDocument();
            //GetDocument();
            //UpdateDocument();

            //Query();
            //GetNotices();

            //DeleteDocument();
            //DeleteCollection();
            DeleteConfiguration();
            DeleteEnvironment();

            Console.WriteLine("\n~ Discovery examples complete.");
        }
        #endregion

        #region Environments
        public void GetEnvironments()
        {
            Console.WriteLine(string.Format("\nCalling GetEnvironments()..."));
            var result = _discovery.ListEnvironments();

            if (result != null)
            {
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("result is null.");
            }
        }

        public void CreateEnvironment()
        {
            CreateEnvironmentRequest createEnvironmentRequest = new CreateEnvironmentRequest()
            {
                Name = "dotnet-test-environment",
                Description = "Environment created in the .NET SDK Examples",
                Size = 1
            };

            Console.WriteLine(string.Format("\nCalling CreateEnvironment()..."));
            var result = _discovery.CreateEnvironment(createEnvironmentRequest);

            if(result != null)
            {
                if (result != null)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                }
                else
                {
                    Console.WriteLine("result is null.");
                }

                _createdEnvironmentId = result.EnvironmentId;
            }
            else
            {
                Console.WriteLine("result is null.");
            }
        }

        public void GetEnvironment()
        {
            Console.WriteLine(string.Format("\nCalling GetEnvironment()..."));
            var result = _discovery.GetEnvironment(_createdEnvironmentId);

            if (result != null)
            {
                if (result != null)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                }
                else
                {
                    Console.WriteLine("result is null.");
                }
            }
            else
            {
                Console.WriteLine("result is null.");
            }
        }

        public void UpdateEnvironment()
        {
            Console.WriteLine(string.Format("\nCalling UpdateEnvironment()..."));

            UpdateEnvironmentRequest updateEnvironmentRequest = new UpdateEnvironmentRequest()
            {
                Name = "dotnet-test-environment-updated",
                Description = "Environment created in the .NET SDK Examples-updated"
            };

            var result = _discovery.UpdateEnvironment(_createdEnvironmentId, updateEnvironmentRequest);

            if (result != null)
            {
                if (result != null)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                }
                else
                {
                    Console.WriteLine("result is null.");
                }
            }
            else
            {
                Console.WriteLine("result is null.");
            }
        }

        public void DeleteEnvironment()
        {
            Console.WriteLine(string.Format("\nCalling DeleteEnvironment()..."));
            var result = _discovery.DeleteEnvironment(_createdEnvironmentId);

            if(result != null)
            {
                if (result != null)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                }
                else
                {
                    Console.WriteLine("result is null.");
                }

                _createdEnvironmentId = null;
            }
            else
            {
                Console.WriteLine("result is null.");
            }
        }
        #endregion

        #region Is Environment Ready
        private bool IsEnvironmentReady(string environmentId)
        {
            var result = _discovery.GetEnvironment(environmentId);
            Console.WriteLine(string.Format("\tEnvironment {0} status is {1}.", environmentId, result.Status));

            if (result.Status == ModelEnvironment.StatusEnum.ACTIVE)
            {
                autoEvent.Set();
            }
            else
            {
                Task.Factory.StartNew(() =>
                {
                    System.Threading.Thread.Sleep(30000);
                    IsEnvironmentReady(environmentId);
                });
            }

            return result.Status == ModelEnvironment.StatusEnum.ACTIVE;
        }
        #endregion

        #region Preview Environment
        private void PreviewEnvironment()
        {
            Console.WriteLine(string.Format("\nCalling PreviewEnvironment()..."));

            using (FileStream fs = File.OpenRead(_filepathToIngest))
            {
                var result = _discovery.TestConfigurationInEnvironment(_createdEnvironmentId, null, "html_input", _createdConfigurationId, fs, _metadata);

                if (result != null)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                }
                else
                {
                    Console.WriteLine("result is null.");
                }
            }
        }
        #endregion

        #region Configurations
        private void GetConfigurations()
        {
            Console.WriteLine(string.Format("\nCalling GetConfigurations()..."));

            var result = _discovery.ListConfigurations(_createdEnvironmentId);

            if (result != null)
            {
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("result is null.");
            }
        }

        private void CreateConfiguration()
        {
            Console.WriteLine(string.Format("\nCalling CreateConfiguration()..."));

            Configuration configuration = new Configuration()
            {
                Name = _createdConfigurationName,
                Description = _createdConfigurationDescription,
                
            };

            var result = _discovery.CreateConfiguration(_createdEnvironmentId, configuration);

            if (result != null)
            {
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
                _createdConfigurationId = result.ConfigurationId;
            }
            else
            {
                Console.WriteLine("result is null.");
            }
        }

        private void GetConfiguration()
        {
            Console.WriteLine(string.Format("\nCalling GetConfiguration()..."));

            var result = _discovery.GetConfiguration(_createdEnvironmentId, _createdConfigurationId);

            if (result != null)
            {
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("result is null.");
            }
        }

        private void UpdateConfiguration()
        {
            Console.WriteLine(string.Format("\nCalling UpdateConfiguration()..."));

            Configuration configuration = new Configuration()
            {
                Name = _createdConfigurationNameUpdated
            };

            var result = _discovery.UpdateConfiguration(_createdEnvironmentId, _createdConfigurationId, configuration);

            if (result != null)
            {
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("result is null.");
            }
        }

        private void DeleteConfiguration()
        {
            Console.WriteLine(string.Format("\nCalling DeleteConfiguration()..."));

            var result = _discovery.DeleteCollection(_createdEnvironmentId, _createdConfigurationId);

            if (result != null)
            {
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("result is null.");
            }
        }
        #endregion

        #region Collections
        private void GetCollections()
        {
            Console.WriteLine(string.Format("\nCalling GetCollections()..."));
        }

        private void CreateCollection()
        {
            Console.WriteLine(string.Format("\nCalling CreateCollection()..."));
        }

        private void GetCollection()
        {
            Console.WriteLine(string.Format("\nCalling GetCollection()..."));
        }

        private void UpdateCollection()
        {
            Console.WriteLine(string.Format("\nCalling UpdateCollection()..."));
        }

        private void GetCollectionFields()
        {
            Console.WriteLine(string.Format("\nCalling GetCollectionFields()..."));
        }

        private void DeleteCollection()
        {
            Console.WriteLine(string.Format("\nCalling DeleteCollection()..."));
        }
        #endregion

        #region Documents
        private void AddDocument()
        {
            Console.WriteLine(string.Format("\nCalling AddDocument()..."));
        }

        private void GetDocument()
        {
            Console.WriteLine(string.Format("\nCalling GetDocument()..."));
        }

        private void UpdateDocument()
        {
            Console.WriteLine(string.Format("\nCalling UpdateDocument()..."));
        }

        private void DeleteDocument()
        {
            Console.WriteLine(string.Format("\nCalling DeleteDocument()..."));
        }
        #endregion

        #region Query
        private void Query()
        {
            Console.WriteLine(string.Format("\nCalling Query()..."));
        }
        #endregion

        #region Notices
        private void GetNotices()
        {
            Console.WriteLine(string.Format("\nCalling GetNoticies()..."));
        }
        #endregion
    }
}
