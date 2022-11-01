/*
 * Stable Horde
 *
 * The API documentation for the Stable Horde
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
    /// ContributionsDetailsStable
    /// </summary>
    [DataContract(Name = "ContributionsDetailsStable")]
    public partial class ContributionsDetailsStable : IEquatable<ContributionsDetailsStable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContributionsDetailsStable" /> class.
        /// </summary>
        /// <param name="fulfillments">How many images this user has generated.</param>
        /// <param name="megapixelsteps">How many megapixelsteps this user has generated.</param>
        public ContributionsDetailsStable(int fulfillments = default(int), decimal megapixelsteps = default(decimal))
        {
            this.Fulfillments = fulfillments;
            this.Megapixelsteps = megapixelsteps;
        }

        /// <summary>
        /// How many images this user has generated
        /// </summary>
        /// <value>How many images this user has generated</value>
        [DataMember(Name = "fulfillments", EmitDefaultValue = false)]
        public int Fulfillments { get; set; }

        /// <summary>
        /// How many megapixelsteps this user has generated
        /// </summary>
        /// <value>How many megapixelsteps this user has generated</value>
        [DataMember(Name = "megapixelsteps", EmitDefaultValue = false)]
        public decimal Megapixelsteps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContributionsDetailsStable {\n");
            sb.Append("  Fulfillments: ").Append(Fulfillments).Append("\n");
            sb.Append("  Megapixelsteps: ").Append(Megapixelsteps).Append("\n");
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
            return this.Equals(input as ContributionsDetailsStable);
        }

        /// <summary>
        /// Returns true if ContributionsDetailsStable instances are equal
        /// </summary>
        /// <param name="input">Instance of ContributionsDetailsStable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContributionsDetailsStable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Fulfillments == input.Fulfillments ||
                    this.Fulfillments.Equals(input.Fulfillments)
                ) && 
                (
                    this.Megapixelsteps == input.Megapixelsteps ||
                    this.Megapixelsteps.Equals(input.Megapixelsteps)
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
                hashCode = (hashCode * 59) + this.Fulfillments.GetHashCode();
                hashCode = (hashCode * 59) + this.Megapixelsteps.GetHashCode();
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
