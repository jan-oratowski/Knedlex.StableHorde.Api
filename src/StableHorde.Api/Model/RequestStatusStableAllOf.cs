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
    /// RequestStatusStableAllOf
    /// </summary>
    [DataContract(Name = "RequestStatusStable_allOf")]
    public partial class RequestStatusStableAllOf : IEquatable<RequestStatusStableAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestStatusStableAllOf" /> class.
        /// </summary>
        /// <param name="generations">generations.</param>
        /// <param name="shared">If True, These images have been shared with LAION..</param>
        public RequestStatusStableAllOf(List<GenerationStable> generations = default(List<GenerationStable>), bool shared = default(bool))
        {
            this.Generations = generations;
            this.Shared = shared;
        }

        /// <summary>
        /// Gets or Sets Generations
        /// </summary>
        [DataMember(Name = "generations", EmitDefaultValue = false)]
        public List<GenerationStable> Generations { get; set; }

        /// <summary>
        /// If True, These images have been shared with LAION.
        /// </summary>
        /// <value>If True, These images have been shared with LAION.</value>
        [DataMember(Name = "shared", EmitDefaultValue = true)]
        public bool Shared { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestStatusStableAllOf {\n");
            sb.Append("  Generations: ").Append(Generations).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
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
            return this.Equals(input as RequestStatusStableAllOf);
        }

        /// <summary>
        /// Returns true if RequestStatusStableAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestStatusStableAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestStatusStableAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Generations == input.Generations ||
                    this.Generations != null &&
                    input.Generations != null &&
                    this.Generations.SequenceEqual(input.Generations)
                ) && 
                (
                    this.Shared == input.Shared ||
                    this.Shared.Equals(input.Shared)
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
                if (this.Generations != null)
                {
                    hashCode = (hashCode * 59) + this.Generations.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Shared.GetHashCode();
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
