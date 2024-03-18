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
using OpenAPIDateConverter = StableHorde.Api.Client.OpenAPIDateConverter;

namespace StableHorde.Api.Model
{
    /// <summary>
    /// Generation
    /// </summary>
    [DataContract(Name = "Generation")]
    public partial class Generation : IEquatable<Generation>, IValidatableObject
    {
        /// <summary>
        /// OBSOLETE (Use the gen_metadata field). The state of this generation.
        /// </summary>
        /// <value>OBSOLETE (Use the gen_metadata field). The state of this generation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Ok for value: ok
            /// </summary>
            [EnumMember(Value = "ok")]
            Ok = 1,

            /// <summary>
            /// Enum Censored for value: censored
            /// </summary>
            [EnumMember(Value = "censored")]
            Censored = 2

        }


        /// <summary>
        /// OBSOLETE (Use the gen_metadata field). The state of this generation.
        /// </summary>
        /// <value>OBSOLETE (Use the gen_metadata field). The state of this generation.</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Generation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        /// <param name="workerId">The UUID of the worker which generated this image..</param>
        /// <param name="workerName">The name of the worker which generated this image..</param>
        /// <param name="model">The model which generated this image..</param>
        /// <param name="state">OBSOLETE (Use the gen_metadata field). The state of this generation. (required) (default to StateEnum.Ok).</param>
        public Generation(string workerId = default(string), string workerName = default(string), string model = default(string), StateEnum state = StateEnum.Ok)
        {
            this.State = state;
            this.WorkerId = workerId;
            this.WorkerName = workerName;
            this.Model = model;
        }

        /// <summary>
        /// The UUID of the worker which generated this image.
        /// </summary>
        /// <value>The UUID of the worker which generated this image.</value>
        [DataMember(Name = "worker_id", EmitDefaultValue = false)]
        public string WorkerId { get; set; }

        /// <summary>
        /// The name of the worker which generated this image.
        /// </summary>
        /// <value>The name of the worker which generated this image.</value>
        [DataMember(Name = "worker_name", EmitDefaultValue = false)]
        public string WorkerName { get; set; }

        /// <summary>
        /// The model which generated this image.
        /// </summary>
        /// <value>The model which generated this image.</value>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public string Model { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Generation {\n");
            sb.Append("  WorkerId: ").Append(WorkerId).Append("\n");
            sb.Append("  WorkerName: ").Append(WorkerName).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Generation);
        }

        /// <summary>
        /// Returns true if Generation instances are equal
        /// </summary>
        /// <param name="input">Instance of Generation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Generation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WorkerId == input.WorkerId ||
                    (this.WorkerId != null &&
                    this.WorkerId.Equals(input.WorkerId))
                ) && 
                (
                    this.WorkerName == input.WorkerName ||
                    (this.WorkerName != null &&
                    this.WorkerName.Equals(input.WorkerName))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.WorkerId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkerId.GetHashCode();
                }
                if (this.WorkerName != null)
                {
                    hashCode = (hashCode * 59) + this.WorkerName.GetHashCode();
                }
                if (this.Model != null)
                {
                    hashCode = (hashCode * 59) + this.Model.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
