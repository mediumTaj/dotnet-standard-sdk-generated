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

namespace IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.Model
{
    /// <summary>
    /// The score of a particular tone.
    /// </summary>
    public class ToneScore
    {
        /// <summary>
        /// The name of the tone. Human-readable, localized.
        /// </summary>
        /// <value>The name of the tone. Human-readable, localized.</value>
        [JsonProperty("tone_name")]
        public string ToneName { get; set; }
        /// <summary>
        /// Identifier of this tone. It does not vary across languages and localizations.
        /// </summary>
        /// <value>Identifier of this tone. It does not vary across languages and localizations.</value>
        [JsonProperty("tone_id")]
        public string ToneId { get; set; }
        /// <summary>
        /// A raw score computed by the algorithms. This can be compared to other raw scores and used to build your own normalizations.
        /// </summary>
        /// <value>A raw score computed by the algorithms. This can be compared to other raw scores and used to build your own normalizations.</value>
        [JsonProperty("score")]
        public double? Score { get; set; }
    }
}
