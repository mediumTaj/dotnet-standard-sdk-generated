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
    /// Customer Engagement Tone analysis results performed on the entire document's text. This includes seven tone categories: Sad, Frustrated, Satisfied, Excited, Polite, Impolite, Sympathetic.
    /// </summary>
    public class UtteranceAnalysis
    {
        /// <summary>
        /// The ID of the text being analyzed.
        /// </summary>
        /// <value>The ID of the text being analyzed.</value>
        [JsonProperty("utterance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UtteranceId { get; set; }
        /// <summary>
        /// The text being analyzed.
        /// </summary>
        /// <value>The text being analyzed.</value>
        [JsonProperty("utterance_text", NullValueHandling = NullValueHandling.Ignore)]
        public string UtteranceText { get; set; }
        /// <summary>
        /// Tone analysis results from seven possible categories: Sad, Frustrated, Satisfied, Excited, Polite, Impolite, Sympathetic.
        /// </summary>
        /// <value>Tone analysis results from seven possible categories: Sad, Frustrated, Satisfied, Excited, Polite, Impolite, Sympathetic.</value>
        [JsonProperty("tones", NullValueHandling = NullValueHandling.Ignore)]
        public List<ToneScore> Tones { get; set; }
    }
}
