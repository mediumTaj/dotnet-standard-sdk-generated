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
    /// BaseMessage.
    /// </summary>
    public class BaseMessage
    {
        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [JsonProperty("input")]
        public MessageInput Input { get; set; }
        /// <summary>
        /// Gets or Sets Intents
        /// </summary>
        [JsonProperty("intents")]
        public List<RuntimeIntent> Intents { get; set; }
        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [JsonProperty("entities")]
        public List<RuntimeEntity> Entities { get; set; }
        /// <summary>
        /// Whether to return more than one intent. `true` indicates that all matching intents are returned.
        /// </summary>
        /// <value>Whether to return more than one intent. `true` indicates that all matching intents are returned.</value>
        [JsonProperty("alternate_intents")]
        public bool? AlternateIntents { get; set; }
    }
}
