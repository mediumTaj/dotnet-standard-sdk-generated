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
    /// CounterexampleCollectionResponse.
    /// </summary>
    public class CounterexampleCollectionResponse
    {
        /// <summary>
        /// An array of ExampleResponse objects describing the examples marked as irrelevant input.
        /// </summary>
        /// <value>An array of ExampleResponse objects describing the examples marked as irrelevant input.</value>
        [JsonProperty("counterexamples")]
        public List<ExampleResponse> Counterexamples { get; set; }
        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [JsonProperty("pagination")]
        public PaginationResponse Pagination { get; set; }
    }
}
