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
    /// AestheticsPayload
    /// </summary>
    [DataContract(Name = "AestheticsPayload")]
    public partial class AestheticsPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AestheticsPayload" /> class.
        /// </summary>
        /// <param name="best">The UUID of the best image in this generation batch (only used when 2+ images generated). If 2+ aesthetic ratings are also provided, then they take precedence if they&#39;re not tied..</param>
        /// <param name="ratings">ratings.</param>
        public AestheticsPayload(string best = default(string), List<AestheticRating> ratings = default(List<AestheticRating>))
        {
            this.Best = best;
            this.Ratings = ratings;
        }

        /// <summary>
        /// The UUID of the best image in this generation batch (only used when 2+ images generated). If 2+ aesthetic ratings are also provided, then they take precedence if they&#39;re not tied.
        /// </summary>
        /// <value>The UUID of the best image in this generation batch (only used when 2+ images generated). If 2+ aesthetic ratings are also provided, then they take precedence if they&#39;re not tied.</value>
        /// <example>6038971e-f0b0-4fdd-a3bb-148f561f815e</example>
        [DataMember(Name = "best", EmitDefaultValue = false)]
        public string Best { get; set; }

        /// <summary>
        /// Gets or Sets Ratings
        /// </summary>
        [DataMember(Name = "ratings", EmitDefaultValue = false)]
        public List<AestheticRating> Ratings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AestheticsPayload {\n");
            sb.Append("  Best: ").Append(Best).Append("\n");
            sb.Append("  Ratings: ").Append(Ratings).Append("\n");
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
            // Best (string) maxLength
            if (this.Best != null && this.Best.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Best, length must be less than 36.", new [] { "Best" });
            }

            // Best (string) minLength
            if (this.Best != null && this.Best.Length < 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Best, length must be greater than 36.", new [] { "Best" });
            }

            yield break;
        }
    }

}