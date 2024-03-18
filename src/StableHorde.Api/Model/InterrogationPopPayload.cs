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
    /// InterrogationPopPayload
    /// </summary>
    [DataContract(Name = "InterrogationPopPayload")]
    public partial class InterrogationPopPayload : IEquatable<InterrogationPopPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterrogationPopPayload" /> class.
        /// </summary>
        /// <param name="forms">forms.</param>
        /// <param name="skipped">skipped.</param>
        public InterrogationPopPayload(List<InterrogationPopFormPayload> forms = default(List<InterrogationPopFormPayload>), NoValidInterrogationsFound skipped = default(NoValidInterrogationsFound))
        {
            this.Forms = forms;
            this.Skipped = skipped;
        }

        /// <summary>
        /// Gets or Sets Forms
        /// </summary>
        [DataMember(Name = "forms", EmitDefaultValue = false)]
        public List<InterrogationPopFormPayload> Forms { get; set; }

        /// <summary>
        /// Gets or Sets Skipped
        /// </summary>
        [DataMember(Name = "skipped", EmitDefaultValue = false)]
        public NoValidInterrogationsFound Skipped { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterrogationPopPayload {\n");
            sb.Append("  Forms: ").Append(Forms).Append("\n");
            sb.Append("  Skipped: ").Append(Skipped).Append("\n");
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
            return this.Equals(input as InterrogationPopPayload);
        }

        /// <summary>
        /// Returns true if InterrogationPopPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of InterrogationPopPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterrogationPopPayload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Forms == input.Forms ||
                    this.Forms != null &&
                    input.Forms != null &&
                    this.Forms.SequenceEqual(input.Forms)
                ) && 
                (
                    this.Skipped == input.Skipped ||
                    (this.Skipped != null &&
                    this.Skipped.Equals(input.Skipped))
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
                if (this.Forms != null)
                {
                    hashCode = (hashCode * 59) + this.Forms.GetHashCode();
                }
                if (this.Skipped != null)
                {
                    hashCode = (hashCode * 59) + this.Skipped.GetHashCode();
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