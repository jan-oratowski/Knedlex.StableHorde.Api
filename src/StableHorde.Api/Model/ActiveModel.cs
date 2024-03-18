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
    /// ActiveModel
    /// </summary>
    [DataContract(Name = "ActiveModel")]
    public partial class ActiveModel : IEquatable<ActiveModel>, IValidatableObject
    {
        /// <summary>
        /// The model type (text or image).
        /// </summary>
        /// <value>The model type (text or image).</value>
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
            Text = 2

        }


        /// <summary>
        /// The model type (text or image).
        /// </summary>
        /// <value>The model type (text or image).</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveModel" /> class.
        /// </summary>
        /// <param name="name">The Name of a model available by workers in this horde..</param>
        /// <param name="count">How many of workers in this horde are running this model..</param>
        /// <param name="performance">The average speed of generation for this model..</param>
        /// <param name="queued">The amount waiting to be generated by this model..</param>
        /// <param name="jobs">The job count waiting to be generated by this model..</param>
        /// <param name="eta">Estimated time in seconds for this model&#39;s queue to be cleared..</param>
        /// <param name="type">The model type (text or image)..</param>
        public ActiveModel(string name = default(string), int count = default(int), decimal performance = default(decimal), decimal queued = default(decimal), decimal jobs = default(decimal), int eta = default(int), TypeEnum? type = default(TypeEnum?))
        {
            this.Name = name;
            this.Count = count;
            this.Performance = performance;
            this.Queued = queued;
            this.Jobs = jobs;
            this.Eta = eta;
            this.Type = type;
        }

        /// <summary>
        /// The Name of a model available by workers in this horde.
        /// </summary>
        /// <value>The Name of a model available by workers in this horde.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// How many of workers in this horde are running this model.
        /// </summary>
        /// <value>How many of workers in this horde are running this model.</value>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// The average speed of generation for this model.
        /// </summary>
        /// <value>The average speed of generation for this model.</value>
        [DataMember(Name = "performance", EmitDefaultValue = false)]
        public decimal Performance { get; set; }

        /// <summary>
        /// The amount waiting to be generated by this model.
        /// </summary>
        /// <value>The amount waiting to be generated by this model.</value>
        [DataMember(Name = "queued", EmitDefaultValue = false)]
        public decimal Queued { get; set; }

        /// <summary>
        /// The job count waiting to be generated by this model.
        /// </summary>
        /// <value>The job count waiting to be generated by this model.</value>
        [DataMember(Name = "jobs", EmitDefaultValue = false)]
        public decimal Jobs { get; set; }

        /// <summary>
        /// Estimated time in seconds for this model&#39;s queue to be cleared.
        /// </summary>
        /// <value>Estimated time in seconds for this model&#39;s queue to be cleared.</value>
        [DataMember(Name = "eta", EmitDefaultValue = false)]
        public int Eta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActiveModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Performance: ").Append(Performance).Append("\n");
            sb.Append("  Queued: ").Append(Queued).Append("\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
            sb.Append("  Eta: ").Append(Eta).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ActiveModel);
        }

        /// <summary>
        /// Returns true if ActiveModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ActiveModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActiveModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Performance == input.Performance ||
                    this.Performance.Equals(input.Performance)
                ) && 
                (
                    this.Queued == input.Queued ||
                    this.Queued.Equals(input.Queued)
                ) && 
                (
                    this.Jobs == input.Jobs ||
                    this.Jobs.Equals(input.Jobs)
                ) && 
                (
                    this.Eta == input.Eta ||
                    this.Eta.Equals(input.Eta)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                hashCode = (hashCode * 59) + this.Performance.GetHashCode();
                hashCode = (hashCode * 59) + this.Queued.GetHashCode();
                hashCode = (hashCode * 59) + this.Jobs.GetHashCode();
                hashCode = (hashCode * 59) + this.Eta.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
