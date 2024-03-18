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
    /// ModifyWorkerInput
    /// </summary>
    [DataContract(Name = "ModifyWorkerInput")]
    public partial class ModifyWorkerInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyWorkerInput" /> class.
        /// </summary>
        /// <param name="maintenance">Set to true to put this worker into maintenance..</param>
        /// <param name="maintenanceMsg">if maintenance is True, you can optionally provide a message to be used instead of the default maintenance message, so that the owner is informed..</param>
        /// <param name="paused">(Mods only) Set to true to pause this worker..</param>
        /// <param name="info">You can optionally provide a server note which will be seen in the server details. No profanity allowed!.</param>
        /// <param name="name">When this is set, it will change the worker&#39;s name. No profanity allowed!.</param>
        /// <param name="team">The team towards which this worker contributes kudos.  It an empty string (&#39;&#39;) is passed, it will leave the worker without a team. No profanity allowed!.</param>
        public ModifyWorkerInput(bool maintenance = default(bool), string maintenanceMsg = default(string), bool paused = default(bool), string info = default(string), string name = default(string), string team = default(string))
        {
            this.Maintenance = maintenance;
            this.MaintenanceMsg = maintenanceMsg;
            this.Paused = paused;
            this.Info = info;
            this.Name = name;
            this.Team = team;
        }

        /// <summary>
        /// Set to true to put this worker into maintenance.
        /// </summary>
        /// <value>Set to true to put this worker into maintenance.</value>
        [DataMember(Name = "maintenance", EmitDefaultValue = true)]
        public bool Maintenance { get; set; }

        /// <summary>
        /// if maintenance is True, you can optionally provide a message to be used instead of the default maintenance message, so that the owner is informed.
        /// </summary>
        /// <value>if maintenance is True, you can optionally provide a message to be used instead of the default maintenance message, so that the owner is informed.</value>
        [DataMember(Name = "maintenance_msg", EmitDefaultValue = false)]
        public string MaintenanceMsg { get; set; }

        /// <summary>
        /// (Mods only) Set to true to pause this worker.
        /// </summary>
        /// <value>(Mods only) Set to true to pause this worker.</value>
        [DataMember(Name = "paused", EmitDefaultValue = true)]
        public bool Paused { get; set; }

        /// <summary>
        /// You can optionally provide a server note which will be seen in the server details. No profanity allowed!
        /// </summary>
        /// <value>You can optionally provide a server note which will be seen in the server details. No profanity allowed!</value>
        [DataMember(Name = "info", EmitDefaultValue = false)]
        public string Info { get; set; }

        /// <summary>
        /// When this is set, it will change the worker&#39;s name. No profanity allowed!
        /// </summary>
        /// <value>When this is set, it will change the worker&#39;s name. No profanity allowed!</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The team towards which this worker contributes kudos.  It an empty string (&#39;&#39;) is passed, it will leave the worker without a team. No profanity allowed!
        /// </summary>
        /// <value>The team towards which this worker contributes kudos.  It an empty string (&#39;&#39;) is passed, it will leave the worker without a team. No profanity allowed!</value>
        /// <example>0bed257b-e57c-4327-ac64-40cdfb1ac5e6</example>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        public string Team { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModifyWorkerInput {\n");
            sb.Append("  Maintenance: ").Append(Maintenance).Append("\n");
            sb.Append("  MaintenanceMsg: ").Append(MaintenanceMsg).Append("\n");
            sb.Append("  Paused: ").Append(Paused).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
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
            // Info (string) maxLength
            if (this.Info != null && this.Info.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Info, length must be less than 1000.", new [] { "Info" });
            }

            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 5.", new [] { "Name" });
            }

            // Team (string) maxLength
            if (this.Team != null && this.Team.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Team, length must be less than 36.", new [] { "Team" });
            }

            yield break;
        }
    }

}