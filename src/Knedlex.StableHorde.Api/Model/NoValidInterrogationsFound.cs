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
    /// NoValidInterrogationsFound
    /// </summary>
    [DataContract(Name = "NoValidInterrogationsFound")]
    public partial class NoValidInterrogationsFound : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoValidInterrogationsFound" /> class.
        /// </summary>
        /// <param name="workerId">How many waiting requests were skipped because they demanded a specific worker..</param>
        /// <param name="untrusted">How many waiting requests were skipped because they demanded a trusted worker which this worker is not..</param>
        /// <param name="bridgeVersion">How many waiting requests were skipped because they require a higher version of the bridge than this worker is running (upgrade if you see this in your skipped list)..</param>
        public NoValidInterrogationsFound(int workerId = default(int), int untrusted = default(int), int bridgeVersion = default(int))
        {
            this.WorkerId = workerId;
            this.Untrusted = untrusted;
            this.BridgeVersion = bridgeVersion;
        }

        /// <summary>
        /// How many waiting requests were skipped because they demanded a specific worker.
        /// </summary>
        /// <value>How many waiting requests were skipped because they demanded a specific worker.</value>
        [DataMember(Name = "worker_id", EmitDefaultValue = false)]
        public int WorkerId { get; set; }

        /// <summary>
        /// How many waiting requests were skipped because they demanded a trusted worker which this worker is not.
        /// </summary>
        /// <value>How many waiting requests were skipped because they demanded a trusted worker which this worker is not.</value>
        [DataMember(Name = "untrusted", EmitDefaultValue = false)]
        public int Untrusted { get; set; }

        /// <summary>
        /// How many waiting requests were skipped because they require a higher version of the bridge than this worker is running (upgrade if you see this in your skipped list).
        /// </summary>
        /// <value>How many waiting requests were skipped because they require a higher version of the bridge than this worker is running (upgrade if you see this in your skipped list).</value>
        /// <example>0</example>
        [DataMember(Name = "bridge_version", EmitDefaultValue = false)]
        public int BridgeVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NoValidInterrogationsFound {\n");
            sb.Append("  WorkerId: ").Append(WorkerId).Append("\n");
            sb.Append("  Untrusted: ").Append(Untrusted).Append("\n");
            sb.Append("  BridgeVersion: ").Append(BridgeVersion).Append("\n");
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
            // WorkerId (int) minimum
            if (this.WorkerId < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WorkerId, must be a value greater than or equal to 0.", new [] { "WorkerId" });
            }

            // Untrusted (int) minimum
            if (this.Untrusted < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Untrusted, must be a value greater than or equal to 0.", new [] { "Untrusted" });
            }

            // BridgeVersion (int) minimum
            if (this.BridgeVersion < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BridgeVersion, must be a value greater than or equal to 0.", new [] { "BridgeVersion" });
            }

            yield break;
        }
    }

}
