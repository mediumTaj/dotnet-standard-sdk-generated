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

namespace IBM.WatsonDeveloperCloud.Discovery.v1.Model
{
    /// <summary>
    /// Field.
    /// </summary>
    public class Field
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum NESTED for nested
            /// </summary>
            [EnumMember(Value = "nested")]
            NESTED,
            
            /// <summary>
            /// Enum STRING for string
            /// </summary>
            [EnumMember(Value = "string")]
            STRING,
            
            /// <summary>
            /// Enum DATE for date
            /// </summary>
            [EnumMember(Value = "date")]
            DATE,
            
            /// <summary>
            /// Enum LONG for long
            /// </summary>
            [EnumMember(Value = "long")]
            LONG,
            
            /// <summary>
            /// Enum INTEGER for integer
            /// </summary>
            [EnumMember(Value = "integer")]
            INTEGER,
            
            /// <summary>
            /// Enum SHORT for short
            /// </summary>
            [EnumMember(Value = "short")]
            SHORT,
            
            /// <summary>
            /// Enum BYTE for byte
            /// </summary>
            [EnumMember(Value = "byte")]
            BYTE,
            
            /// <summary>
            /// Enum DOUBLE for double
            /// </summary>
            [EnumMember(Value = "double")]
            DOUBLE,
            
            /// <summary>
            /// Enum FLOAT for float
            /// </summary>
            [EnumMember(Value = "float")]
            FLOAT,
            
            /// <summary>
            /// Enum BOOLEAN for boolean
            /// </summary>
            [EnumMember(Value = "boolean")]
            BOOLEAN,
            
            /// <summary>
            /// Enum BINARY for binary
            /// </summary>
            [EnumMember(Value = "binary")]
            BINARY
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }
    }

}
