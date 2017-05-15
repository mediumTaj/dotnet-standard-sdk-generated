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

using Newtonsoft.Json;
using System;

namespace IBM.WatsonDeveloperCloud.Conversation.v1.Model
{
    /// <summary>
    /// IntentResponse.
    /// </summary>
    public class IntentResponse
    {
        /// <summary>
        /// The name of the intent.
        /// </summary>
        /// <value>The name of the intent.</value>
        [JsonProperty("intent")]
        public string Intent { get; set; }
        /// <summary>
        /// The timestamp for creation of the intent.
        /// </summary>
        /// <value>The timestamp for creation of the intent.</value>
        [JsonProperty("created")]
        public DateTime Created { get; set; }
        /// <summary>
        /// The timestamp for the last update to the intent.
        /// </summary>
        /// <value>The timestamp for the last update to the intent.</value>
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }
        /// <summary>
        /// The description of the intent.
        /// </summary>
        /// <value>The description of the intent.</value>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
