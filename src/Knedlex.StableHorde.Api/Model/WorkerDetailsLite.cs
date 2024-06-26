/*
 * AI Horde
 *
 * The API documentation for the AI Horde
 *
 * The version of the OpenAPI document: 2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Knedlex.StableHorde.Api.Client.OpenAPIDateConverter;

namespace Knedlex.StableHorde.Api.Model
{
    /// <summary>
    /// WorkerDetailsLite
    /// </summary>
    [DataContract(Name = "WorkerDetailsLite")]
    public partial class WorkerDetailsLite : IValidatableObject
    {
        /// <summary>
        /// The Type of worker this is.
        /// </summary>
        /// <value>The Type of worker this is.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Image for value: image
            /// </summary>
            [EnumMember(Value = "image")]
            Image = 1,

            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 2,

            /// <summary>
            /// Enum Interrogation for value: interrogation
            /// </summary>
            [EnumMember(Value = "interrogation")]
            Interrogation = 3
        }


        /// <summary>
        /// The Type of worker this is.
        /// </summary>
        /// <value>The Type of worker this is.</value>
        /// <example>image</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkerDetailsLite" /> class.
        /// </summary>
        /// <param name="type">The Type of worker this is..</param>
        /// <param name="name">The Name given to this worker..</param>
        /// <param name="id">The UUID of this worker..</param>
        /// <param name="online">True if the worker has checked-in the past 5 minutes..</param>
        public WorkerDetailsLite(TypeEnum? type = default(TypeEnum?), string name = default(string), string id = default(string), bool online = default(bool))
        {
            this.Type = type;
            this.Name = name;
            this.Id = id;
            this.Online = online;
        }

        /// <summary>
        /// The Name given to this worker.
        /// </summary>
        /// <value>The Name given to this worker.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The UUID of this worker.
        /// </summary>
        /// <value>The UUID of this worker.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// True if the worker has checked-in the past 5 minutes.
        /// </summary>
        /// <value>True if the worker has checked-in the past 5 minutes.</value>
        [DataMember(Name = "online", EmitDefaultValue = true)]
        public bool Online { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkerDetailsLite {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Online: ").Append(Online).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
