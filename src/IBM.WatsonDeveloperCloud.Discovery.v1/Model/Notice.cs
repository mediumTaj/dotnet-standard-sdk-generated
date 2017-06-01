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

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace IBM.WatsonDeveloperCloud.Discovery.v1.Model
{
    /// <summary>
    /// A notice produced by the ingestion process.
    /// </summary>
    public class Notice
    {
        /// <summary>
        /// Severity level of the notice.
        /// </summary>
        /// <value>Severity level of the notice.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SeverityEnum
        {
            
            /// <summary>
            /// Enum WARNING for warning
            /// </summary>
            [EnumMember(Value = "warning")]
            WARNING,
            
            /// <summary>
            /// Enum ERROR for error
            /// </summary>
            [EnumMember(Value = "error")]
            ERROR
        }

        /// <summary>
        /// Severity level of the notice.
        /// </summary>
        /// <value>Severity level of the notice.</value>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public SeverityEnum? Severity { get; set; }
        /// <summary>
        /// Identifies the notice. Many notices may have the same ID. This field exists so that user applications can programatically identify a notice and take automatic corrective action.
        /// </summary>
        /// <value>Identifies the notice. Many notices may have the same ID. This field exists so that user applications can programatically identify a notice and take automatic corrective action.</value>
        [JsonProperty("notice_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NoticeId { get; set; }
        /// <summary>
        /// The creation date of the collection in the format yyyy-MM-dd'T'HH:mm:ss.SSS'Z'.
        /// </summary>
        /// <value>The creation date of the collection in the format yyyy-MM-dd'T'HH:mm:ss.SSS'Z'.</value>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Created { get; set; }
        /// <summary>
        /// Unique identifier of the ingested document.
        /// </summary>
        /// <value>Unique identifier of the ingested document.</value>
        [JsonProperty("document_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentId { get; set; }
        /// <summary>
        /// Ingestion step in which the notice occurred.
        /// </summary>
        /// <value>Ingestion step in which the notice occurred.</value>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public string Step { get; set; }
        /// <summary>
        /// The description of the notice.
        /// </summary>
        /// <value>The description of the notice.</value>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

}
