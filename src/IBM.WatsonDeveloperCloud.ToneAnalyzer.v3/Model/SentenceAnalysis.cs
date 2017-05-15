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
    /// The result of analyzing a sentence within a document.
    /// </summary>
    public class SentenceAnalysis
    {
        /// <summary>
        /// A unique number identifying this sentence within this document. Reserved for future use (when sentences need to be referred from different places).
        /// </summary>
        /// <value>A unique number identifying this sentence within this document. Reserved for future use (when sentences need to be referred from different places).</value>
        [JsonProperty("sentence_id")]
        public int? SentenceId { get; set; }
        /// <summary>
        /// Index of the character in the document where this sentence starts.
        /// </summary>
        /// <value>Index of the character in the document where this sentence starts.</value>
        [JsonProperty("input_from")]
        public int? InputFrom { get; set; }
        /// <summary>
        /// Index of the character in the document after the end of this sentence (input_to minus input_from is the length of this sentence in characters).
        /// </summary>
        /// <value>Index of the character in the document after the end of this sentence (input_to minus input_from is the length of this sentence in characters).</value>
        [JsonProperty("input_to")]
        public int? InputTo { get; set; }
        /// <summary>
        /// The text in this sentence - as just taken from the input text from input_from to input_to.
        /// </summary>
        /// <value>The text in this sentence - as just taken from the input text from input_from to input_to.</value>
        [JsonProperty("text")]
        public string Text { get; set; }
        /// <summary>
        /// Tone analysis results for this sentence; divided in three Tone categories: Social Tone, Emotion Tone and Writing Tone.
        /// </summary>
        /// <value>Tone analysis results for this sentence; divided in three Tone categories: Social Tone, Emotion Tone and Writing Tone.</value>
        [JsonProperty("tone_categories")]
        public List<ToneCategory> ToneCategories { get; set; }
    }
}
