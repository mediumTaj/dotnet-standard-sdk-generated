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
using System;

namespace IBM.WatsonDeveloperCloud.Conversation.v1.Model
{
    /// <summary>
    /// ValueExport.
    /// </summary>
    public class ValueExport
    {
        /// <summary>
        /// The text of the entity value.
        /// </summary>
        /// <value>The text of the entity value.</value>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityValue { get; set; }
        /// <summary>
        /// Any metadata related to the entity value.
        /// </summary>
        /// <value>Any metadata related to the entity value.</value>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public object Metadata { get; set; }
        /// <summary>
        /// The timestamp for creation of the entity value.
        /// </summary>
        /// <value>The timestamp for creation of the entity value.</value>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Created { get; private set; }
        /// <summary>
        /// The timestamp for the last update to the entity value.
        /// </summary>
        /// <value>The timestamp for the last update to the entity value.</value>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Updated { get; private set; }
        /// <summary>
        /// An array of synonyms.
        /// </summary>
        /// <value>An array of synonyms.</value>
        [JsonProperty("synonyms", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Synonyms { get; set; }
    }

}