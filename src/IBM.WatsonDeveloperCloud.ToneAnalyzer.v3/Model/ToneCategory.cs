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

namespace IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.Model
{
    /// <summary>
    /// The tone analysis for a particular tone category (e.g. social, emotion, or writing).
    /// </summary>
    public class ToneCategory
    {
        /// <summary>
        /// Name of this tone category: one of Emotion, Social or Language Tone. Human-readable, localized.
        /// </summary>
        /// <value>Name of this tone category: one of Emotion, Social or Language Tone. Human-readable, localized.</value>
        [JsonProperty("category_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }
        /// <summary>
        /// Identifier of this category. It does not vary across languages or localizations.
        /// </summary>
        /// <value>Identifier of this category. It does not vary across languages or localizations.</value>
        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryId { get; set; }
        /// <summary>
        /// All individual tone results within this category. For example, the Social Tones category contains one element for each of the dimensions in Big 5 model: Agreeableness, Openness, etc.
        /// </summary>
        /// <value>All individual tone results within this category. For example, the Social Tones category contains one element for each of the dimensions in Big 5 model: Agreeableness, Openness, etc.</value>
        [JsonProperty("tones", NullValueHandling = NullValueHandling.Ignore)]
        public List<ToneScore> Tones { get; set; }
    }
}
