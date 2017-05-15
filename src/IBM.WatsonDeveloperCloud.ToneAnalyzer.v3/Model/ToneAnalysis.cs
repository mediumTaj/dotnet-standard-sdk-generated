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
    /// The results of performing tone analysis on a document.
    /// </summary>
    public class ToneAnalysis
    {
        /// <summary>
        /// Gets or Sets DocumentTone
        /// </summary>
        [JsonProperty("document_tone")]
        public ToneAnalysisDocumentTone DocumentTone { get; set; }
        /// <summary>
        /// List of sentences contained in the document, with individual Tone analysis results for each sentence.
        /// </summary>
        /// <value>List of sentences contained in the document, with individual Tone analysis results for each sentence.</value>
        [JsonProperty("sentences_tone")]
        public List<SentenceAnalysis> SentencesTone { get; set; }
    }
}
