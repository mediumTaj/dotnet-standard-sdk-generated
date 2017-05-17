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
        private string _workspaceID;
        private string _inputString = "Turn on the winshield wipers";
        private string _createdWorkspaceId;
        private string _createdEntityName;
        private string _createdValueName;
        private string _createdIntentName;

        public ConversationServiceExample(string username, string password, string workspaceID)
        {
            _conversation = new ConversationService(username, password, ConversationService.CONVERSATION_VERSION_DATE_2017_04_21);
            _workspaceID = workspaceID;

            ListWorkspaces();
            CreateWorkspace();
            GetWorkspace();
            UpdateWorkspace();
            DeleteWorkspace();

            Message();
            ListCounterExamples();
            CreateCounterExample();
            GetCounterExample();
            UpdateCounterExample();
            DeleteCounterExample();

            ListEntities();
            CreateEntity();
            GetEntity();
            UpdateEntity();
            DeleteEntity();

            ListValues();
            CreateValue();
            GetValue();
            UpdateValue();
            DeleteValue();

            ListSynonyms();
            CreateSynonym();
            GetSynonym();
            UpdateSynonym();
            DeleteSynonym();

            ListIntents();
            CreateIntent();
            GetIntent();
            UpdateIntent();
            DeleteIntent();

            ListExamples();
            CreateExample();
            GetExample();
            UpdateExample();
            DeleteExample();

            ListLogEvents();
        }

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
            throw new NotImplementedException();
        }

        private void GetWorkspace()
        {
            throw new NotImplementedException();
        }

        private void UpdateWorkspace()
        {
            throw new NotImplementedException();
        }

        private void DeleteWorkspace()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private void GetCounterExample()
        {
            throw new NotImplementedException();
        }

        private void UpdateCounterExample()
        {
            throw new NotImplementedException();
        }

        private void DeleteCounterExample()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private void GetEntity()
        {
            throw new NotImplementedException();
        }

        private void UpdateEntity()
        {
            throw new NotImplementedException();
        }

        private void DeleteEntity()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private void GetValue()
        {
            throw new NotImplementedException();
        }

        private void UpdateValue()
        {
            throw new NotImplementedException();
        }

        private void DeleteValue()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private void GetSynonym()
        {
            throw new NotImplementedException();
        }

        private void UpdateSynonym()
        {
            throw new NotImplementedException();
        }

        private void DeleteSynonym()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private void GetIntent()
        {
            throw new NotImplementedException();
        }

        private void UpdateIntent()
        {
            throw new NotImplementedException();
        }

        private void DeleteIntent()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private void GetExample()
        {
            throw new NotImplementedException();
        }

        private void UpdateExample()
        {
            throw new NotImplementedException();
        }

        private void DeleteExample()
        {
            throw new NotImplementedException();
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
