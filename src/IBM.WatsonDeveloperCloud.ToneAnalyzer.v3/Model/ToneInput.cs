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
    /// ToneInput.
    /// </summary>
    public class ToneInput
    {
        /// <summary>
        /// The content to be analyzed. The Tone Analyzer service supports up to 128 KB of text, or about 1000 sentences. Sentences with less than three words cannot be analyzed.
        /// </summary>
        /// <value>The content to be analyzed. The Tone Analyzer service supports up to 128 KB of text, or about 1000 sentences. Sentences with less than three words cannot be analyzed.</value>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
