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
    /// HordePerformance
    /// </summary>
    [DataContract(Name = "HordePerformance")]
    public partial class HordePerformance : IEquatable<HordePerformance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HordePerformance" /> class.
        /// </summary>
        /// <param name="queuedRequests">The amount of waiting and processing requests currently in this Horde.</param>
        /// <param name="workerCount">How many workers are actively processing image generations in this Horde in the past 5 minutes.</param>
        public HordePerformance(int queuedRequests = default(int), int workerCount = default(int))
        {
            this.QueuedRequests = queuedRequests;
            this.WorkerCount = workerCount;
        }

        /// <summary>
        /// The amount of waiting and processing requests currently in this Horde
        /// </summary>
        /// <value>The amount of waiting and processing requests currently in this Horde</value>
        [DataMember(Name = "queued_requests", EmitDefaultValue = false)]
        public int QueuedRequests { get; set; }

        /// <summary>
        /// How many workers are actively processing image generations in this Horde in the past 5 minutes
        /// </summary>
        /// <value>How many workers are actively processing image generations in this Horde in the past 5 minutes</value>
        [DataMember(Name = "worker_count", EmitDefaultValue = false)]
        public int WorkerCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HordePerformance {\n");
            sb.Append("  QueuedRequests: ").Append(QueuedRequests).Append("\n");
            sb.Append("  WorkerCount: ").Append(WorkerCount).Append("\n");
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
            return this.Equals(input as HordePerformance);
        }

        /// <summary>
        /// Returns true if HordePerformance instances are equal
        /// </summary>
        /// <param name="input">Instance of HordePerformance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HordePerformance input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QueuedRequests == input.QueuedRequests ||
                    this.QueuedRequests.Equals(input.QueuedRequests)
                ) && 
                (
                    this.WorkerCount == input.WorkerCount ||
                    this.WorkerCount.Equals(input.WorkerCount)
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
                hashCode = (hashCode * 59) + this.QueuedRequests.GetHashCode();
                hashCode = (hashCode * 59) + this.WorkerCount.GetHashCode();
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
