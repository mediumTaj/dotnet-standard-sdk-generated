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

using IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.Model;

namespace IBM.WatsonDeveloperCloud.ToneAnalyzer.v3
{
    public interface IToneAnalyzerService
    {
        /// <summary>
        /// Analyze general tone. Analyze the tone of a piece of text. The message is analyzed for several tones - social, emotional, and language. For each tone, various traits are derived. For example, conscientiousness, agreeableness, and openness.
        /// </summary>
        /// <param name="text">The content to be analyzed. The Tone Analyzer service supports up to 128 KB of text, or about 1000 sentences. Sentences with less than three words cannot be analyzed.</param>
        /// <param name="tones">Filter the results by a specific tone. Valid values are `emotion`, `language`, and `social`. (optional)</param>
        /// <param name="sentences">Filter your response to remove the sentence level analysis. Valid values are `true` and `false`. This parameter defaults to `true` when it's not set, which means that a sentence level analysis is automatically provided. Change `sentences` to `false` to filter out the sentence level analysis. (optional)</param>
        /// <returns><see cref="ToneAnalysis" />ToneAnalysis</returns>
        ToneAnalysis Tone(ToneInput text, string tones = null, bool? sentences = null);

        /// <summary>
        /// Analyze customer engagement tone. Use the Tone Analyzer for Customer Engagement Endpoint to monitor customer service and customer support conversations.
        /// </summary>
        /// <param name="utterances">The content to be analyzed.</param>
        /// <returns><see cref="UtteranceAnalyses" />UtteranceAnalyses</returns>
        UtteranceAnalyses ToneChat(ToneChatInput utterances);
    }
}
