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
    /// PopInputKoboldAllOf
    /// </summary>
    [DataContract(Name = "PopInputKobold_allOf")]
    public partial class PopInputKoboldAllOf : IEquatable<PopInputKoboldAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PopInputKoboldAllOf" /> class.
        /// </summary>
        /// <param name="maxLength">The maximum amount of tokens this worker can generate..</param>
        /// <param name="maxContextLength">The max amount of context to submit to this AI for sampling..</param>
        /// <param name="softprompts">softprompts.</param>
        public PopInputKoboldAllOf(int maxLength = default(int), int maxContextLength = default(int), List<string> softprompts = default(List<string>))
        {
            this.MaxLength = maxLength;
            this.MaxContextLength = maxContextLength;
            this.Softprompts = softprompts;
        }

        /// <summary>
        /// The maximum amount of tokens this worker can generate.
        /// </summary>
        /// <value>The maximum amount of tokens this worker can generate.</value>
        [DataMember(Name = "max_length", EmitDefaultValue = false)]
        public int MaxLength { get; set; }

        /// <summary>
        /// The max amount of context to submit to this AI for sampling.
        /// </summary>
        /// <value>The max amount of context to submit to this AI for sampling.</value>
        [DataMember(Name = "max_context_length", EmitDefaultValue = false)]
        public int MaxContextLength { get; set; }

        /// <summary>
        /// Gets or Sets Softprompts
        /// </summary>
        [DataMember(Name = "softprompts", EmitDefaultValue = false)]
        public List<string> Softprompts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PopInputKoboldAllOf {\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  MaxContextLength: ").Append(MaxContextLength).Append("\n");
            sb.Append("  Softprompts: ").Append(Softprompts).Append("\n");
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
            return this.Equals(input as PopInputKoboldAllOf);
        }

        /// <summary>
        /// Returns true if PopInputKoboldAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PopInputKoboldAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PopInputKoboldAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaxLength == input.MaxLength ||
                    this.MaxLength.Equals(input.MaxLength)
                ) && 
                (
                    this.MaxContextLength == input.MaxContextLength ||
                    this.MaxContextLength.Equals(input.MaxContextLength)
                ) && 
                (
                    this.Softprompts == input.Softprompts ||
                    this.Softprompts != null &&
                    input.Softprompts != null &&
                    this.Softprompts.SequenceEqual(input.Softprompts)
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
                hashCode = (hashCode * 59) + this.MaxLength.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxContextLength.GetHashCode();
                if (this.Softprompts != null)
                {
                    hashCode = (hashCode * 59) + this.Softprompts.GetHashCode();
                }
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
