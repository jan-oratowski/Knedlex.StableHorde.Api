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
    /// UsageDetails
    /// </summary>
    [DataContract(Name = "UsageDetails")]
    public partial class UsageDetails : IEquatable<UsageDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageDetails" /> class.
        /// </summary>
        /// <param name="megapixelsteps">How many megapixelsteps this user has requested..</param>
        /// <param name="requests">How many images this user has requested..</param>
        public UsageDetails(decimal megapixelsteps = default(decimal), int requests = default(int))
        {
            this.Megapixelsteps = megapixelsteps;
            this.Requests = requests;
        }

        /// <summary>
        /// How many megapixelsteps this user has requested.
        /// </summary>
        /// <value>How many megapixelsteps this user has requested.</value>
        [DataMember(Name = "megapixelsteps", EmitDefaultValue = false)]
        public decimal Megapixelsteps { get; set; }

        /// <summary>
        /// How many images this user has requested.
        /// </summary>
        /// <value>How many images this user has requested.</value>
        [DataMember(Name = "requests", EmitDefaultValue = false)]
        public int Requests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsageDetails {\n");
            sb.Append("  Megapixelsteps: ").Append(Megapixelsteps).Append("\n");
            sb.Append("  Requests: ").Append(Requests).Append("\n");
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
            return this.Equals(input as UsageDetails);
        }

        /// <summary>
        /// Returns true if UsageDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of UsageDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsageDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Megapixelsteps == input.Megapixelsteps ||
                    this.Megapixelsteps.Equals(input.Megapixelsteps)
                ) && 
                (
                    this.Requests == input.Requests ||
                    this.Requests.Equals(input.Requests)
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
                hashCode = (hashCode * 59) + this.Megapixelsteps.GetHashCode();
                hashCode = (hashCode * 59) + this.Requests.GetHashCode();
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
