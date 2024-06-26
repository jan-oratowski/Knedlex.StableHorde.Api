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
    /// PopInputKobold
    /// </summary>
    [DataContract(Name = "PopInputKobold")]
    public partial class PopInputKobold : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PopInputKobold" /> class.
        /// </summary>
        /// <param name="name">The Name of the Worker..</param>
        /// <param name="priorityUsernames">priorityUsernames.</param>
        /// <param name="nsfw">Whether this worker can generate NSFW requests or not. (default to false).</param>
        /// <param name="models">models.</param>
        /// <param name="bridgeAgent">The worker name, version and website. (default to &quot;unknown:0:unknown&quot;).</param>
        /// <param name="threads">How many threads this worker is running. This is used to accurately the current power available in the horde..</param>
        /// <param name="requireUpfrontKudos">If True, this worker will only pick up requests where the owner has the required kudos to consume already available. (default to false).</param>
        /// <param name="amount">How many jobvs to pop at the same time.</param>
        /// <param name="maxLength">The maximum amount of tokens this worker can generate..</param>
        /// <param name="maxContextLength">The max amount of context to submit to this AI for sampling..</param>
        /// <param name="softprompts">softprompts.</param>
        public PopInputKobold(string name = default(string), List<string> priorityUsernames = default(List<string>), bool nsfw = false, List<string> models = default(List<string>), string bridgeAgent = @"unknown:0:unknown", int threads = default(int), bool requireUpfrontKudos = false, int amount = default(int), int maxLength = default(int), int maxContextLength = default(int), List<string> softprompts = default(List<string>))
        {
            this.Name = name;
            this.PriorityUsernames = priorityUsernames;
            this.Nsfw = nsfw;
            this.Models = models;
            // use default value if no "bridgeAgent" provided
            this.BridgeAgent = bridgeAgent ?? @"unknown:0:unknown";
            this.Threads = threads;
            this.RequireUpfrontKudos = requireUpfrontKudos;
            this.Amount = amount;
            this.MaxLength = maxLength;
            this.MaxContextLength = maxContextLength;
            this.Softprompts = softprompts;
        }

        /// <summary>
        /// The Name of the Worker.
        /// </summary>
        /// <value>The Name of the Worker.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PriorityUsernames
        /// </summary>
        [DataMember(Name = "priority_usernames", EmitDefaultValue = false)]
        public List<string> PriorityUsernames { get; set; }

        /// <summary>
        /// Whether this worker can generate NSFW requests or not.
        /// </summary>
        /// <value>Whether this worker can generate NSFW requests or not.</value>
        [DataMember(Name = "nsfw", EmitDefaultValue = true)]
        public bool Nsfw { get; set; }

        /// <summary>
        /// Gets or Sets Models
        /// </summary>
        [DataMember(Name = "models", EmitDefaultValue = false)]
        public List<string> Models { get; set; }

        /// <summary>
        /// The worker name, version and website.
        /// </summary>
        /// <value>The worker name, version and website.</value>
        /// <example>AI Horde Worker reGen:4.1.0:https://github.com/Haidra-Org/horde-worker-reGen</example>
        [DataMember(Name = "bridge_agent", EmitDefaultValue = false)]
        public string BridgeAgent { get; set; }

        /// <summary>
        /// How many threads this worker is running. This is used to accurately the current power available in the horde.
        /// </summary>
        /// <value>How many threads this worker is running. This is used to accurately the current power available in the horde.</value>
        [DataMember(Name = "threads", EmitDefaultValue = false)]
        public int Threads { get; set; }

        /// <summary>
        /// If True, this worker will only pick up requests where the owner has the required kudos to consume already available.
        /// </summary>
        /// <value>If True, this worker will only pick up requests where the owner has the required kudos to consume already available.</value>
        /// <example>false</example>
        [DataMember(Name = "require_upfront_kudos", EmitDefaultValue = true)]
        public bool RequireUpfrontKudos { get; set; }

        /// <summary>
        /// How many jobvs to pop at the same time
        /// </summary>
        /// <value>How many jobvs to pop at the same time</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// The maximum amount of tokens this worker can generate.
        /// </summary>
        /// <value>The maximum amount of tokens this worker can generate.</value>
        [DataMember(Name = "max_length", EmitDefaultValue = false)]
        public int MaxLength { get; set; }

        /// <summary>
        /// The max amount of context to submit to this AI for sampling.
        /// </summary>
        /// <value>The max amount of context to submit to this AI for sampling.</value>
        [DataMember(Name = "max_context_length", EmitDefaultValue = false)]
        public int MaxContextLength { get; set; }

        /// <summary>
        /// Gets or Sets Softprompts
        /// </summary>
        [DataMember(Name = "softprompts", EmitDefaultValue = false)]
        public List<string> Softprompts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PopInputKobold {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PriorityUsernames: ").Append(PriorityUsernames).Append("\n");
            sb.Append("  Nsfw: ").Append(Nsfw).Append("\n");
            sb.Append("  Models: ").Append(Models).Append("\n");
            sb.Append("  BridgeAgent: ").Append(BridgeAgent).Append("\n");
            sb.Append("  Threads: ").Append(Threads).Append("\n");
            sb.Append("  RequireUpfrontKudos: ").Append(RequireUpfrontKudos).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  MaxContextLength: ").Append(MaxContextLength).Append("\n");
            sb.Append("  Softprompts: ").Append(Softprompts).Append("\n");
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
            // BridgeAgent (string) maxLength
            if (this.BridgeAgent != null && this.BridgeAgent.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BridgeAgent, length must be less than 1000.", new [] { "BridgeAgent" });
            }

            // Threads (int) maximum
            if (this.Threads > (int)50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Threads, must be a value less than or equal to 50.", new [] { "Threads" });
            }

            // Threads (int) minimum
            if (this.Threads < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Threads, must be a value greater than or equal to 1.", new [] { "Threads" });
            }

            // Amount (int) maximum
            if (this.Amount > (int)20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must be a value less than or equal to 20.", new [] { "Amount" });
            }

            // Amount (int) minimum
            if (this.Amount < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must be a value greater than or equal to 1.", new [] { "Amount" });
            }

            yield break;
        }
    }

}
