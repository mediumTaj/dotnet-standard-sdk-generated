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
        /// Analyze general purpose tone. Uses the general purpose endpoint to analyze the tone of your input content. The service can analyze the input for several tones: emotion, language, and social. It derives various characteristics for each tone that it analyzes. The method always analyzes the tone of the full document; by default, it also analyzes the tone of each individual sentence of the input. You can submit a maximum of 128 KB of content in JSON, plain text, or HTML format.   Per the JSON specification, the default character encoding for JSON content is effectively always UTF-8; per the HTTP specification, the default encoding for plain text and HTML is ISO-8859-1 (effectively, the ASCII character set). When specifying a content type of plain text or HTML, include the `charset` parameter to indicate the character encoding of the input text; for example: `Content-Type: text/plain;charset=utf-8`. For `text/html`, the service removes HTML tags and analyzes only the textual content.   Use the `POST` request method to analyze larger amounts of content in any of the available formats. Use the `GET` request method to analyze smaller quantities of plain text content.
        /// </summary>
        /// <param name="body">JSON, plain text, or HTML input that contains the content to be analyzed. For JSON input, provide an object of type `ToneInput`. Submit a maximum of 128 KB of content. Sentences with fewer than three words cannot be analyzed.</param>
        /// <param name="tones">A comma-separated list of tones for which the service is to return its analysis of the input; the indicated tones apply both to the full document and to individual sentences of the document. You can specify one or more of the following values: `emotion`, `language`, and `social`. Omit the parameter to request results for all three tones. (optional)</param>
        /// <param name="sentences">Indicates whether the service is to return an analysis of each individual sentence in addition to its analysis of the full document. If `true` (the default), the service returns results for each sentence. The service returns results only for the first 100 sentences of the input. (optional, default to true)</param>
        /// <returns><see cref="ToneAnalysis" />ToneAnalysis</returns>
        ToneAnalysis Tone(ToneInput body, string tones = null, bool? sentences = null);

        /// <summary>
        /// Analyze customer engagement tone. Uses the customer engagement endpoint to analyze the tone of customer service and customer support conversations. For each utterance of a conversation, the method reports the most prevalent subset of the following seven tones: sad, frustrated, satisfied, excited, polite, impolite, and sympathetic. You can submit a maximum of 128 KB of JSON input. Per the JSON specification, the default character encoding for JSON content is effectively always UTF-8.   **Note**: The `tone_chat` method is currently beta functionality.
        /// </summary>
        /// <param name="utterances">A JSON object that contains the content to be analyzed.</param>
        /// <returns><see cref="UtteranceAnalyses" />UtteranceAnalyses</returns>
        UtteranceAnalyses ToneChat(ToneChatInput utterances);
    }
}
