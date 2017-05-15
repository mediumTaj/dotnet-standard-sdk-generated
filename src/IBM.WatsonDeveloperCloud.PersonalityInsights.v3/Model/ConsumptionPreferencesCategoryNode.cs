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

namespace IBM.WatsonDeveloperCloud.PersonalityInsights.v3.Model
{
    /// <summary>
    /// ConsumptionPreferencesCategoryNode.
    /// </summary>
    public class ConsumptionPreferencesCategoryNode
    {
        /// <summary>
        /// The unique identifier of the consumption preferences category to which the results pertain. IDs have the form `consumption_preferences_{category}`.
        /// </summary>
        /// <value>The unique identifier of the consumption preferences category to which the results pertain. IDs have the form `consumption_preferences_{category}`.</value>
        [JsonProperty("consumption_preference_category_id")]
        public string ConsumptionPreferenceCategoryId { get; set; }
        /// <summary>
        /// The user-visible name of the consumption preferences category.
        /// </summary>
        /// <value>The user-visible name of the consumption preferences category.</value>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Detailed results inferred from the input text for the individual preferences of the category.
        /// </summary>
        /// <value>Detailed results inferred from the input text for the individual preferences of the category.</value>
        [JsonProperty("consumption_preferences")]
        public List<ConsumptionPreferencesNode> ConsumptionPreferences { get; set; }
    }
}
