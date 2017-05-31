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
    /// Tone analysis results performed on the entire document's text. This includes three tone categories: Social Tone, Emotion Tone and Language Tone.
    /// </summary>
    public class ToneAnalysisDocumentTone
    {
        /// <summary>
        /// Tone analysis results for this sentence; divided in three Tone categories: Social Tone, Emotion Tone and Writing Tone.
        /// </summary>
        /// <value>Tone analysis results for this sentence; divided in three Tone categories: Social Tone, Emotion Tone and Writing Tone.</value>
        [JsonProperty("tone_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<ToneCategory> ToneCategories { get; set; }
    }

}
