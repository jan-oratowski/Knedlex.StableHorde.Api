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
    /// UserKudosDetails
    /// </summary>
    [DataContract(Name = "UserKudosDetails")]
    public partial class UserKudosDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserKudosDetails" /> class.
        /// </summary>
        /// <param name="accumulated">The ammount of Kudos accumulated or used for generating images..</param>
        /// <param name="gifted">The amount of Kudos this user has given to other users..</param>
        /// <param name="donated">The amount of Kudos this user has donated to public goods accounts like education..</param>
        /// <param name="admin">The amount of Kudos this user has been given by the AI Horde admins..</param>
        /// <param name="received">The amount of Kudos this user has been given by other users..</param>
        /// <param name="recurring">The amount of Kudos this user has received from recurring rewards..</param>
        /// <param name="awarded">The amount of Kudos this user has been awarded from things like rating images..</param>
        public UserKudosDetails(decimal accumulated = default(decimal), decimal gifted = default(decimal), decimal donated = default(decimal), decimal admin = default(decimal), decimal received = default(decimal), decimal recurring = default(decimal), decimal awarded = default(decimal))
        {
            this.Accumulated = accumulated;
            this.Gifted = gifted;
            this.Donated = donated;
            this.Admin = admin;
            this.Received = received;
            this.Recurring = recurring;
            this.Awarded = awarded;
        }

        /// <summary>
        /// The ammount of Kudos accumulated or used for generating images.
        /// </summary>
        /// <value>The ammount of Kudos accumulated or used for generating images.</value>
        [DataMember(Name = "accumulated", EmitDefaultValue = false)]
        public decimal Accumulated { get; set; }

        /// <summary>
        /// The amount of Kudos this user has given to other users.
        /// </summary>
        /// <value>The amount of Kudos this user has given to other users.</value>
        [DataMember(Name = "gifted", EmitDefaultValue = false)]
        public decimal Gifted { get; set; }

        /// <summary>
        /// The amount of Kudos this user has donated to public goods accounts like education.
        /// </summary>
        /// <value>The amount of Kudos this user has donated to public goods accounts like education.</value>
        [DataMember(Name = "donated", EmitDefaultValue = false)]
        public decimal Donated { get; set; }

        /// <summary>
        /// The amount of Kudos this user has been given by the AI Horde admins.
        /// </summary>
        /// <value>The amount of Kudos this user has been given by the AI Horde admins.</value>
        [DataMember(Name = "admin", EmitDefaultValue = false)]
        public decimal Admin { get; set; }

        /// <summary>
        /// The amount of Kudos this user has been given by other users.
        /// </summary>
        /// <value>The amount of Kudos this user has been given by other users.</value>
        [DataMember(Name = "received", EmitDefaultValue = false)]
        public decimal Received { get; set; }

        /// <summary>
        /// The amount of Kudos this user has received from recurring rewards.
        /// </summary>
        /// <value>The amount of Kudos this user has received from recurring rewards.</value>
        [DataMember(Name = "recurring", EmitDefaultValue = false)]
        public decimal Recurring { get; set; }

        /// <summary>
        /// The amount of Kudos this user has been awarded from things like rating images.
        /// </summary>
        /// <value>The amount of Kudos this user has been awarded from things like rating images.</value>
        [DataMember(Name = "awarded", EmitDefaultValue = false)]
        public decimal Awarded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserKudosDetails {\n");
            sb.Append("  Accumulated: ").Append(Accumulated).Append("\n");
            sb.Append("  Gifted: ").Append(Gifted).Append("\n");
            sb.Append("  Donated: ").Append(Donated).Append("\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
            sb.Append("  Received: ").Append(Received).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  Awarded: ").Append(Awarded).Append("\n");
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
            yield break;
        }
    }

}