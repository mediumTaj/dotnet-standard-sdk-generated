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

using IBM.WatsonDeveloperCloud.Conversation.v1.Model;
using System;

namespace IBM.WatsonDeveloperCloud.Conversation.v1.Example
{
    public class ConversationServiceExample
    {
        private ConversationService _conversation;
        private string _workspaceID;
        private string _inputString = "Turn on the winshield wipers";

        public ConversationServiceExample(string username, string password, string workspaceID)
        {
            _conversation = new ConversationService(username, password, ConversationService.CONVERSATION_VERSION_DATE_2017_04_21);
            _workspaceID = workspaceID;
            Message();
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

        #region Get Workspaces
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
        #endregion
    }
}
