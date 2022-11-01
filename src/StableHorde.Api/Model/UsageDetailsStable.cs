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
    /// UsageDetailsStable
    /// </summary>
    [DataContract(Name = "UsageDetailsStable")]
    public partial class UsageDetailsStable : IEquatable<UsageDetailsStable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageDetailsStable" /> class.
        /// </summary>
        /// <param name="requests">How many images this user has requested.</param>
        /// <param name="megapixelsteps">How many megapixelsteps this user has requested.</param>
        public UsageDetailsStable(int requests = default(int), decimal megapixelsteps = default(decimal))
        {
            this.Requests = requests;
            this.Megapixelsteps = megapixelsteps;
        }

        /// <summary>
        /// How many images this user has requested
        /// </summary>
        /// <value>How many images this user has requested</value>
        [DataMember(Name = "requests", EmitDefaultValue = false)]
        public int Requests { get; set; }

        /// <summary>
        /// How many megapixelsteps this user has requested
        /// </summary>
        /// <value>How many megapixelsteps this user has requested</value>
        [DataMember(Name = "megapixelsteps", EmitDefaultValue = false)]
        public decimal Megapixelsteps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsageDetailsStable {\n");
            sb.Append("  Requests: ").Append(Requests).Append("\n");
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
            return this.Equals(input as UsageDetailsStable);
        }

        /// <summary>
        /// Returns true if UsageDetailsStable instances are equal
        /// </summary>
        /// <param name="input">Instance of UsageDetailsStable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsageDetailsStable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Requests == input.Requests ||
                    this.Requests.Equals(input.Requests)
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
                hashCode = (hashCode * 59) + this.Requests.GetHashCode();
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
