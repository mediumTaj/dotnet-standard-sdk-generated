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

using IBM.WatsonDeveloperCloud.Conversation.v1.Model;
using System;

namespace IBM.WatsonDeveloperCloud.Conversation.v1.Example
{
    public class ConversationServiceExample
    {
        private ConversationService _conversation;

        //  The car example workspace
        private string _workspaceID;
        private string _inputString = "Turn on the winshield wipers";

        private string _createdWorkspaceName = "dotnet-sdk-example-workspace-delete";
        private string _createdWorkspaceDescription = "A Workspace created by the .NET SDK Conversation example script.";
        private string _createdWorkspaceLanguage = "en";
        private string _createdWorkspaceId;
        private string _createdEntityName;
        private string _createdValueName;
        private string _createdIntentName;

        #region Constructor
        public ConversationServiceExample(string username, string password, string workspaceID)
        {
            _conversation = new ConversationService(username, password, ConversationService.CONVERSATION_VERSION_DATE_2017_04_21);
            _workspaceID = workspaceID;
            //_conversation.Endpoint = "http://localhost:1234";

            ListWorkspaces();
            CreateWorkspace();
            GetWorkspace();
            UpdateWorkspace();
            DeleteWorkspace();

            Message();
            //ListCounterExamples();
            //CreateCounterExample();
            //GetCounterExample();
            //UpdateCounterExample();
            //DeleteCounterExample();

            //ListEntities();
            //CreateEntity();
            //GetEntity();
            //UpdateEntity();
            //DeleteEntity();

            //ListValues();
            //CreateValue();
            //GetValue();
            //UpdateValue();
            //DeleteValue();

            //ListSynonyms();
            //CreateSynonym();
            //GetSynonym();
            //UpdateSynonym();
            //DeleteSynonym();

            //ListIntents();
            //CreateIntent();
            //GetIntent();
            //UpdateIntent();
            //DeleteIntent();

            //ListExamples();
            //CreateExample();
            //GetExample();
            //UpdateExample();
            //DeleteExample();

            //ListLogEvents();

            Console.WriteLine("\n~ Conversation examples complete.");
        }
        #endregion

        #region Message
        private void Message()
        {
            MessageRequest messageRequest = new MessageRequest()
            {
                Input = new InputData()
                {
                    Text = _inputString
                },
                AlternateIntents = true
            };

            Console.WriteLine(string.Format("\nCalling Message(\"{0}\")...", _inputString));
            var result = _conversation.Message(_workspaceID, messageRequest);

            if (result != null)
            {
                if (result.Intents != null)
                {
                    foreach (RuntimeIntent intent in result.Intents)
                    {
                        Console.WriteLine(string.Format("intent: {0} | confidence: {1}", intent.Intent, intent.Confidence));
                    }
                }
                else
                {
                    Console.WriteLine("Intents is null.");
                }

                if (result.Output != null)
                {
                    if (result.Output.Text != null && result.Output.Text.Count > 0)
                    {
                        foreach (string output in result.Output.Text)
                            Console.WriteLine(string.Format("Output: \"{0}\"", output));
                    }
                    else
                    {
                        Console.WriteLine("There is no output.");
                    }
                }
                else
                {
                    Console.WriteLine("Output is null.");
                }
            }
            else
            {
                Console.WriteLine("Failed to message.");
            }
        }
        #endregion

        #region Workspaces
        private void ListWorkspaces()
        {
            Console.WriteLine("\nCalling ListWorkspaces()...");
            var result = _conversation.ListWorkspaces();

            if (result != null)
            {
                foreach(WorkspaceResponse workspace in result.Workspaces)
                    Console.WriteLine(string.Format("Workspace name: {0} | WorkspaceID: {1}", workspace.Name, workspace.WorkspaceId));
            }
            else
            {
                Console.WriteLine("Workspaces are null.");
            }
        }

        private void CreateWorkspace()
        {
            Console.WriteLine("\nCalling CreateWorkspace()...");
            CreateWorkspace workspace = new CreateWorkspace()
            {
                Name = _createdWorkspaceName,
                Description = _createdWorkspaceDescription,
                Language = _createdWorkspaceLanguage
            };

            var result = _conversation.CreateWorkspace(workspace);

            if(result != null)
            {
                Console.WriteLine(string.Format("Workspace Name: {0}, id: {1}, description: {2}", result.Name, result.WorkspaceId, result.Description));
                if (!string.IsNullOrEmpty(result.WorkspaceId))
                    _createdWorkspaceId = result.WorkspaceId;
            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void GetWorkspace()
        {
            Console.WriteLine(string.Format("\nCalling GetWorkspace({0})...", _createdWorkspaceId));

            var result = _conversation.GetWorkspace(_createdWorkspaceId);

            if (result != null)
            {
                Console.WriteLine(string.Format("Workspace name: {0} | id: {1} | description: {2}", result.Name, result.WorkspaceId, result.Description));
            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void UpdateWorkspace()
        {
            Console.WriteLine(string.Format("\nCalling UpdateWorkspace({0})...", _createdWorkspaceId));

            UpdateWorkspace workspace = new UpdateWorkspace()
            {
                Name = _createdWorkspaceName + "-updated",
                Description = _createdWorkspaceDescription + "-updated",
                Language = _createdWorkspaceLanguage
            };

            var result = _conversation.UpdateWorkspace(_createdWorkspaceId, workspace);

            if (result != null)
            {
                Console.WriteLine(string.Format("Updated Workspace name: {0} | id: {1} | description: {2}", result.Name, result.WorkspaceId, result.Description));
            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void DeleteWorkspace()
        {
            Console.WriteLine(string.Format("\nCalling DeleteWorkspace({0})...", _createdWorkspaceId));
            var result = _conversation.DeleteWorkspace(_createdWorkspaceId);

            if (result != null)
            {
                Console.WriteLine(string.Format("Workspace {0} deleted.", _createdWorkspaceId));
            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }
        #endregion

        #region Counter Examples
        private void ListCounterExamples()
        {
            Console.WriteLine(string.Format("\nCalling ListCounterExamples({0})...", _createdWorkspaceId));
            var result = _conversation.ListCounterexamples(_createdWorkspaceId);

            if (result != null)
            {
                foreach (ExampleResponse counterExample in result.Counterexamples)
                    Console.WriteLine(string.Format("CounterExample name: {0} | Created: {1}", counterExample.Text, counterExample.Created));
            }
            else
            {
                Console.WriteLine("CounterExamples are null.");
            }
        }
        private void CreateCounterExample()
        {
            Console.WriteLine("\nCalling CreateCounterExample()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void GetCounterExample()
        {
            Console.WriteLine("\nCalling GetCounterExample()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void UpdateCounterExample()
        {
            Console.WriteLine("\nCalling UpdateCounterExample()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void DeleteCounterExample()
        {
            Console.WriteLine("\nCalling DeleteCounterExample()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }
        #endregion

        #region Entities
        private void ListEntities()
        {
            Console.WriteLine(string.Format("\nCalling ListEntities({0})...", _createdWorkspaceId));
            var result = _conversation.ListEntities(_createdWorkspaceId);

            if (result != null)
            {
                foreach (EntityExportResponse entity in result.Entities)
                    Console.WriteLine(string.Format("Entity: {0} | Created: {1}", entity.Entity, entity.Description));
            }
            else
            {
                Console.WriteLine("Entities are null.");
            }
        }
        private void CreateEntity()
        {
            Console.WriteLine("\nCalling CreateEntity()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void GetEntity()
        {
            Console.WriteLine("\nCalling GetEntity()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void UpdateEntity()
        {
            Console.WriteLine("\nCalling UpdateEntity()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void DeleteEntity()
        {
            Console.WriteLine("\nCalling DeleteEntity()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }
        #endregion

        #region Values
        private void ListValues()
        {
            Console.WriteLine(string.Format("\nCalling ListValues({0}, {1})...", _createdWorkspaceId, _createdEntityName));
            var result = _conversation.ListValues(_createdWorkspaceId, _createdEntityName);

            if (result != null)
            {
                foreach (ValueExportResponse value in result.Values)
                    Console.WriteLine(string.Format("value: {0} | Created: {1}", value.Value, value.Created));
            }
            else
            {
                Console.WriteLine("Values are null.");
            }
        }
        private void CreateValue()
        {
            Console.WriteLine("\nCalling CreateValue()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void GetValue()
        {
            Console.WriteLine("\nCalling GetValue()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void UpdateValue()
        {
            Console.WriteLine("\nCalling UpdateValue()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void DeleteValue()
        {
            Console.WriteLine("\nCalling DeleteValue()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }
        #endregion

        #region Synonyms
        private void ListSynonyms()
        {
            Console.WriteLine(string.Format("\nCalling ListSynonyms({0}, {1}, {2})...", _createdWorkspaceId, _createdEntityName, _createdValueName));
            var result = _conversation.ListSynonyms(_createdWorkspaceId, _createdEntityName, _createdValueName);

            if (result != null)
            {
                foreach (SynonymResponse synonym in result.Synonyms)
                    Console.WriteLine(string.Format("Synonym: {0} | Created: {1}", synonym.Synonym, synonym.Created));
            }
            else
            {
                Console.WriteLine("Synonyms are null.");
            }
        }
        private void CreateSynonym()
        {
            Console.WriteLine("\nCalling CreateSynonym()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void GetSynonym()
        {
            Console.WriteLine("\nCalling GetSynonym()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void UpdateSynonym()
        {
            Console.WriteLine("\nCalling UpdateSynonym()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void DeleteSynonym()
        {
            Console.WriteLine("\nCalling DeleteSynonym()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }
        #endregion

        #region Intents
        private void ListIntents()
        {
            Console.WriteLine(string.Format("\nCalling ListIntents({0})...", _createdWorkspaceId));
            var result = _conversation.ListIntents(_createdWorkspaceId);

            if (result != null)
            {
                foreach (IntentExportResponse intent in result.Intents)
                    Console.WriteLine(string.Format("Intent: {0} | Created: {1}", intent.Intent, intent.Created));
            }
            else
            {
                Console.WriteLine("Intents are null.");
            }
        }
        private void CreateIntent()
        {
            Console.WriteLine("\nCalling CreateIntent()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void GetIntent()
        {
            Console.WriteLine("\nCalling GetIntent()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void UpdateIntent()
        {
            Console.WriteLine("\nCalling UpdateIntent()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void DeleteIntent()
        {
            Console.WriteLine("\nCalling DeleteIntent()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }
        #endregion

        #region Examples
        private void ListExamples()
        {
            Console.WriteLine(string.Format("\nCalling ListExamples({0}, {1})...", _createdWorkspaceId, _createdIntentName));
            var result = _conversation.ListExamples(_createdWorkspaceId, _createdIntentName);

            if (result != null)
            {
                foreach (ExampleResponse example in result.Examples)
                    Console.WriteLine(string.Format("Example: {0} | Created: {1}", example.Text, example.Created));
            }
            else
            {
                Console.WriteLine("Examples are null.");
            }
        }
        private void CreateExample()
        {
            Console.WriteLine("\nCalling CreateExample()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void GetExample()
        {
            Console.WriteLine("\nCalling GetExample()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void UpdateExample()
        {
            Console.WriteLine("\nCalling UpdateExample()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }

        private void DeleteExample()
        {
            Console.WriteLine("\nCalling DeleteExample()...");
            var result = _conversation.CreateWorkspace();

            if (result != null)
            {

            }
            else
            {
                Console.WriteLine("Result is null.");
            }
        }
        #endregion

        #region Logs
        private void ListLogEvents()
        {
            Console.WriteLine(string.Format("\nCalling ListLogEvents({0})...", _createdWorkspaceId));
            var result = _conversation.ListLogs(_createdWorkspaceId);

            if (result != null)
            {
                foreach (LogExportResponse log in result.Logs)
                    Console.WriteLine(string.Format("Log: {0} | Request timestamp: {1}", log.LogId, log.RequestTimestamp));
            }
            else
            {
                Console.WriteLine("Logs are null.");
            }
        }
        #endregion
    }
}
