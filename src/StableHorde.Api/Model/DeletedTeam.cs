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
    /// DeletedTeam
    /// </summary>
    [DataContract(Name = "DeletedTeam")]
    public partial class DeletedTeam : IEquatable<DeletedTeam>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedTeam" /> class.
        /// </summary>
        /// <param name="deletedId">The ID of the deleted team..</param>
        /// <param name="deletedName">The Name of the deleted team..</param>
        public DeletedTeam(string deletedId = default(string), string deletedName = default(string))
        {
            this.DeletedId = deletedId;
            this.DeletedName = deletedName;
        }

        /// <summary>
        /// The ID of the deleted team.
        /// </summary>
        /// <value>The ID of the deleted team.</value>
        [DataMember(Name = "deleted_id", EmitDefaultValue = false)]
        public string DeletedId { get; set; }

        /// <summary>
        /// The Name of the deleted team.
        /// </summary>
        /// <value>The Name of the deleted team.</value>
        [DataMember(Name = "deleted_name", EmitDefaultValue = false)]
        public string DeletedName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeletedTeam {\n");
            sb.Append("  DeletedId: ").Append(DeletedId).Append("\n");
            sb.Append("  DeletedName: ").Append(DeletedName).Append("\n");
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
            return this.Equals(input as DeletedTeam);
        }

        /// <summary>
        /// Returns true if DeletedTeam instances are equal
        /// </summary>
        /// <param name="input">Instance of DeletedTeam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeletedTeam input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeletedId == input.DeletedId ||
                    (this.DeletedId != null &&
                    this.DeletedId.Equals(input.DeletedId))
                ) && 
                (
                    this.DeletedName == input.DeletedName ||
                    (this.DeletedName != null &&
                    this.DeletedName.Equals(input.DeletedName))
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
                if (this.DeletedId != null)
                {
                    hashCode = (hashCode * 59) + this.DeletedId.GetHashCode();
                }
                if (this.DeletedName != null)
                {
                    hashCode = (hashCode * 59) + this.DeletedName.GetHashCode();
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
