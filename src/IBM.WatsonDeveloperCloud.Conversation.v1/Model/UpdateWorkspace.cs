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

using System.Collections.Generic;
using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.Conversation.v1.Model
{
    /// <summary>
    /// UpdateWorkspace.
    /// </summary>
    public class UpdateWorkspace
    {
        /// <summary>
        /// The name of the workspace.
        /// </summary>
        /// <value>The name of the workspace.</value>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// The description of the workspace.
        /// </summary>
        /// <value>The description of the workspace.</value>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// The language of the workspace.
        /// </summary>
        /// <value>The language of the workspace.</value>
        [JsonProperty("language")]
        public string Language { get; set; }
        /// <summary>
        /// An array of CreateIntent objects defining the intents for the workspace.
        /// </summary>
        /// <value>An array of CreateIntent objects defining the intents for the workspace.</value>
        [JsonProperty("intents")]
        public List<CreateIntent> Intents { get; set; }
        /// <summary>
        /// An array of CreateEntity objects defining the entities for the workspace.
        /// </summary>
        /// <value>An array of CreateEntity objects defining the entities for the workspace.</value>
        [JsonProperty("entities")]
        public List<CreateEntity> Entities { get; set; }
        /// <summary>
        /// An array of CreateDialogNode objects defining the nodes in the workspace dialog.
        /// </summary>
        /// <value>An array of CreateDialogNode objects defining the nodes in the workspace dialog.</value>
        [JsonProperty("dialog_nodes")]
        public List<CreateDialogNode> DialogNodes { get; set; }
        /// <summary>
        /// An array of CreateExample objects defining input examples that have been marked as irrelevant input.
        /// </summary>
        /// <value>An array of CreateExample objects defining input examples that have been marked as irrelevant input.</value>
        [JsonProperty("counterexamples")]
        public List<CreateExample> Counterexamples { get; set; }
        /// <summary>
        /// Any metadata related to the workspace.
        /// </summary>
        /// <value>Any metadata related to the workspace.</value>
        [JsonProperty("metadata")]
        public object Metadata { get; set; }
    }
}
