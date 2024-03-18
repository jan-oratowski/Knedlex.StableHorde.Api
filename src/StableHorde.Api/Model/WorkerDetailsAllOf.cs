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
    /// WorkerDetailsAllOf
    /// </summary>
    [DataContract(Name = "WorkerDetails_allOf")]
    public partial class WorkerDetailsAllOf : IEquatable<WorkerDetailsAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkerDetailsAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkerDetailsAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkerDetailsAllOf" /> class.
        /// </summary>
        /// <param name="requestsFulfilled">How many images this worker has generated..</param>
        /// <param name="kudosRewards">How many Kudos this worker has been rewarded in total..</param>
        /// <param name="kudosDetails">kudosDetails.</param>
        /// <param name="performance">The average performance of this worker in human readable form..</param>
        /// <param name="threads">How many threads this worker is running..</param>
        /// <param name="uptime">The amount of seconds this worker has been online for this AI Horde..</param>
        /// <param name="maintenanceMode">When True, this worker will not pick up any new requests..</param>
        /// <param name="paused">(Privileged) When True, this worker not be given any new requests..</param>
        /// <param name="info">Extra information or comments about this worker provided by its owner..</param>
        /// <param name="nsfw">Whether this worker can generate NSFW requests or not. (default to false).</param>
        /// <param name="owner">Privileged or public if the owner has allowed it. The alias of the owner of this worker..</param>
        /// <param name="ipaddr">Privileged. The last known IP this worker has connected from..</param>
        /// <param name="trusted">The worker is trusted to return valid generations..</param>
        /// <param name="flagged">The worker&#39;s owner has been flagged for suspicious activity. This worker will not be given any jobs to process..</param>
        /// <param name="suspicious">(Privileged) How much suspicion this worker has accumulated..</param>
        /// <param name="uncompletedJobs">How many jobs this worker has left uncompleted after it started them..</param>
        /// <param name="models">models.</param>
        /// <param name="forms">forms.</param>
        /// <param name="team">team.</param>
        /// <param name="contact">(Privileged) Contact details for the horde admins to reach the owner of this worker in emergencies..</param>
        /// <param name="bridgeAgent">The bridge agent name, version and website. (required) (default to &quot;unknown:0:unknown&quot;).</param>
        /// <param name="maxPixels">The maximum pixels in resolution this worker can generate..</param>
        /// <param name="megapixelstepsGenerated">How many megapixelsteps this worker has generated until now..</param>
        /// <param name="img2img">If True, this worker supports and allows img2img requests..</param>
        /// <param name="painting">If True, this worker supports and allows inpainting requests..</param>
        /// <param name="postProcessing">If True, this worker supports and allows post-processing requests..</param>
        /// <param name="lora">If True, this worker supports and allows lora requests..</param>
        /// <param name="maxLength">The maximum tokens this worker can generate..</param>
        /// <param name="maxContextLength">The maximum tokens this worker can read..</param>
        /// <param name="tokensGenerated">How many tokens this worker has generated until now..</param>
        public WorkerDetailsAllOf(int requestsFulfilled = default(int), decimal kudosRewards = default(decimal), WorkerKudosDetails kudosDetails = default(WorkerKudosDetails), string performance = default(string), int threads = default(int), int uptime = default(int), bool maintenanceMode = default(bool), bool paused = default(bool), string info = default(string), bool nsfw = false, string owner = default(string), string ipaddr = default(string), bool trusted = default(bool), bool flagged = default(bool), int suspicious = default(int), int uncompletedJobs = default(int), List<string> models = default(List<string>), List<string> forms = default(List<string>), TeamDetailsLite team = default(TeamDetailsLite), string contact = default(string), string bridgeAgent = "unknown:0:unknown", int maxPixels = default(int), decimal megapixelstepsGenerated = default(decimal), bool img2img = default(bool), bool painting = default(bool), bool postProcessing = default(bool), bool lora = default(bool), int maxLength = default(int), int maxContextLength = default(int), decimal tokensGenerated = default(decimal))
        {
            // to ensure "bridgeAgent" is required (not null)
            if (bridgeAgent == null)
            {
                throw new ArgumentNullException("bridgeAgent is a required property for WorkerDetailsAllOf and cannot be null");
            }
            this.BridgeAgent = bridgeAgent;
            this.RequestsFulfilled = requestsFulfilled;
            this.KudosRewards = kudosRewards;
            this.KudosDetails = kudosDetails;
            this.Performance = performance;
            this.Threads = threads;
            this.Uptime = uptime;
            this.MaintenanceMode = maintenanceMode;
            this.Paused = paused;
            this.Info = info;
            this.Nsfw = nsfw;
            this.Owner = owner;
            this.Ipaddr = ipaddr;
            this.Trusted = trusted;
            this.Flagged = flagged;
            this.Suspicious = suspicious;
            this.UncompletedJobs = uncompletedJobs;
            this.Models = models;
            this.Forms = forms;
            this.Team = team;
            this.Contact = contact;
            this.MaxPixels = maxPixels;
            this.MegapixelstepsGenerated = megapixelstepsGenerated;
            this.Img2img = img2img;
            this.Painting = painting;
            this.PostProcessing = postProcessing;
            this.Lora = lora;
            this.MaxLength = maxLength;
            this.MaxContextLength = maxContextLength;
            this.TokensGenerated = tokensGenerated;
        }

        /// <summary>
        /// How many images this worker has generated.
        /// </summary>
        /// <value>How many images this worker has generated.</value>
        [DataMember(Name = "requests_fulfilled", EmitDefaultValue = false)]
        public int RequestsFulfilled { get; set; }

        /// <summary>
        /// How many Kudos this worker has been rewarded in total.
        /// </summary>
        /// <value>How many Kudos this worker has been rewarded in total.</value>
        [DataMember(Name = "kudos_rewards", EmitDefaultValue = false)]
        public decimal KudosRewards { get; set; }

        /// <summary>
        /// Gets or Sets KudosDetails
        /// </summary>
        [DataMember(Name = "kudos_details", EmitDefaultValue = false)]
        public WorkerKudosDetails KudosDetails { get; set; }

        /// <summary>
        /// The average performance of this worker in human readable form.
        /// </summary>
        /// <value>The average performance of this worker in human readable form.</value>
        [DataMember(Name = "performance", EmitDefaultValue = false)]
        public string Performance { get; set; }

        /// <summary>
        /// How many threads this worker is running.
        /// </summary>
        /// <value>How many threads this worker is running.</value>
        [DataMember(Name = "threads", EmitDefaultValue = false)]
        public int Threads { get; set; }

        /// <summary>
        /// The amount of seconds this worker has been online for this AI Horde.
        /// </summary>
        /// <value>The amount of seconds this worker has been online for this AI Horde.</value>
        [DataMember(Name = "uptime", EmitDefaultValue = false)]
        public int Uptime { get; set; }

        /// <summary>
        /// When True, this worker will not pick up any new requests.
        /// </summary>
        /// <value>When True, this worker will not pick up any new requests.</value>
        [DataMember(Name = "maintenance_mode", EmitDefaultValue = true)]
        public bool MaintenanceMode { get; set; }

        /// <summary>
        /// (Privileged) When True, this worker not be given any new requests.
        /// </summary>
        /// <value>(Privileged) When True, this worker not be given any new requests.</value>
        [DataMember(Name = "paused", EmitDefaultValue = true)]
        public bool Paused { get; set; }

        /// <summary>
        /// Extra information or comments about this worker provided by its owner.
        /// </summary>
        /// <value>Extra information or comments about this worker provided by its owner.</value>
        [DataMember(Name = "info", EmitDefaultValue = false)]
        public string Info { get; set; }

        /// <summary>
        /// Whether this worker can generate NSFW requests or not.
        /// </summary>
        /// <value>Whether this worker can generate NSFW requests or not.</value>
        [DataMember(Name = "nsfw", EmitDefaultValue = true)]
        public bool Nsfw { get; set; }

        /// <summary>
        /// Privileged or public if the owner has allowed it. The alias of the owner of this worker.
        /// </summary>
        /// <value>Privileged or public if the owner has allowed it. The alias of the owner of this worker.</value>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public string Owner { get; set; }

        /// <summary>
        /// Privileged. The last known IP this worker has connected from.
        /// </summary>
        /// <value>Privileged. The last known IP this worker has connected from.</value>
        [DataMember(Name = "ipaddr", EmitDefaultValue = false)]
        public string Ipaddr { get; set; }

        /// <summary>
        /// The worker is trusted to return valid generations.
        /// </summary>
        /// <value>The worker is trusted to return valid generations.</value>
        [DataMember(Name = "trusted", EmitDefaultValue = true)]
        public bool Trusted { get; set; }

        /// <summary>
        /// The worker&#39;s owner has been flagged for suspicious activity. This worker will not be given any jobs to process.
        /// </summary>
        /// <value>The worker&#39;s owner has been flagged for suspicious activity. This worker will not be given any jobs to process.</value>
        [DataMember(Name = "flagged", EmitDefaultValue = true)]
        public bool Flagged { get; set; }

        /// <summary>
        /// (Privileged) How much suspicion this worker has accumulated.
        /// </summary>
        /// <value>(Privileged) How much suspicion this worker has accumulated.</value>
        [DataMember(Name = "suspicious", EmitDefaultValue = false)]
        public int Suspicious { get; set; }

        /// <summary>
        /// How many jobs this worker has left uncompleted after it started them.
        /// </summary>
        /// <value>How many jobs this worker has left uncompleted after it started them.</value>
        [DataMember(Name = "uncompleted_jobs", EmitDefaultValue = false)]
        public int UncompletedJobs { get; set; }

        /// <summary>
        /// Gets or Sets Models
        /// </summary>
        [DataMember(Name = "models", EmitDefaultValue = false)]
        public List<string> Models { get; set; }

        /// <summary>
        /// Gets or Sets Forms
        /// </summary>
        [DataMember(Name = "forms", EmitDefaultValue = false)]
        public List<string> Forms { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        public TeamDetailsLite Team { get; set; }

        /// <summary>
        /// (Privileged) Contact details for the horde admins to reach the owner of this worker in emergencies.
        /// </summary>
        /// <value>(Privileged) Contact details for the horde admins to reach the owner of this worker in emergencies.</value>
        [DataMember(Name = "contact", EmitDefaultValue = false)]
        public string Contact { get; set; }

        /// <summary>
        /// The bridge agent name, version and website.
        /// </summary>
        /// <value>The bridge agent name, version and website.</value>
        [DataMember(Name = "bridge_agent", IsRequired = true, EmitDefaultValue = true)]
        public string BridgeAgent { get; set; }

        /// <summary>
        /// The maximum pixels in resolution this worker can generate.
        /// </summary>
        /// <value>The maximum pixels in resolution this worker can generate.</value>
        [DataMember(Name = "max_pixels", EmitDefaultValue = false)]
        public int MaxPixels { get; set; }

        /// <summary>
        /// How many megapixelsteps this worker has generated until now.
        /// </summary>
        /// <value>How many megapixelsteps this worker has generated until now.</value>
        [DataMember(Name = "megapixelsteps_generated", EmitDefaultValue = false)]
        public decimal MegapixelstepsGenerated { get; set; }

        /// <summary>
        /// If True, this worker supports and allows img2img requests.
        /// </summary>
        /// <value>If True, this worker supports and allows img2img requests.</value>
        [DataMember(Name = "img2img", EmitDefaultValue = true)]
        public bool Img2img { get; set; }

        /// <summary>
        /// If True, this worker supports and allows inpainting requests.
        /// </summary>
        /// <value>If True, this worker supports and allows inpainting requests.</value>
        [DataMember(Name = "painting", EmitDefaultValue = true)]
        public bool Painting { get; set; }

        /// <summary>
        /// If True, this worker supports and allows post-processing requests.
        /// </summary>
        /// <value>If True, this worker supports and allows post-processing requests.</value>
        [DataMember(Name = "post-processing", EmitDefaultValue = true)]
        public bool PostProcessing { get; set; }

        /// <summary>
        /// If True, this worker supports and allows lora requests.
        /// </summary>
        /// <value>If True, this worker supports and allows lora requests.</value>
        [DataMember(Name = "lora", EmitDefaultValue = true)]
        public bool Lora { get; set; }

        /// <summary>
        /// The maximum tokens this worker can generate.
        /// </summary>
        /// <value>The maximum tokens this worker can generate.</value>
        [DataMember(Name = "max_length", EmitDefaultValue = false)]
        public int MaxLength { get; set; }

        /// <summary>
        /// The maximum tokens this worker can read.
        /// </summary>
        /// <value>The maximum tokens this worker can read.</value>
        [DataMember(Name = "max_context_length", EmitDefaultValue = false)]
        public int MaxContextLength { get; set; }

        /// <summary>
        /// How many tokens this worker has generated until now.
        /// </summary>
        /// <value>How many tokens this worker has generated until now.</value>
        [DataMember(Name = "tokens_generated", EmitDefaultValue = false)]
        public decimal TokensGenerated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkerDetailsAllOf {\n");
            sb.Append("  RequestsFulfilled: ").Append(RequestsFulfilled).Append("\n");
            sb.Append("  KudosRewards: ").Append(KudosRewards).Append("\n");
            sb.Append("  KudosDetails: ").Append(KudosDetails).Append("\n");
            sb.Append("  Performance: ").Append(Performance).Append("\n");
            sb.Append("  Threads: ").Append(Threads).Append("\n");
            sb.Append("  Uptime: ").Append(Uptime).Append("\n");
            sb.Append("  MaintenanceMode: ").Append(MaintenanceMode).Append("\n");
            sb.Append("  Paused: ").Append(Paused).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  Nsfw: ").Append(Nsfw).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Ipaddr: ").Append(Ipaddr).Append("\n");
            sb.Append("  Trusted: ").Append(Trusted).Append("\n");
            sb.Append("  Flagged: ").Append(Flagged).Append("\n");
            sb.Append("  Suspicious: ").Append(Suspicious).Append("\n");
            sb.Append("  UncompletedJobs: ").Append(UncompletedJobs).Append("\n");
            sb.Append("  Models: ").Append(Models).Append("\n");
            sb.Append("  Forms: ").Append(Forms).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  BridgeAgent: ").Append(BridgeAgent).Append("\n");
            sb.Append("  MaxPixels: ").Append(MaxPixels).Append("\n");
            sb.Append("  MegapixelstepsGenerated: ").Append(MegapixelstepsGenerated).Append("\n");
            sb.Append("  Img2img: ").Append(Img2img).Append("\n");
            sb.Append("  Painting: ").Append(Painting).Append("\n");
            sb.Append("  PostProcessing: ").Append(PostProcessing).Append("\n");
            sb.Append("  Lora: ").Append(Lora).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  MaxContextLength: ").Append(MaxContextLength).Append("\n");
            sb.Append("  TokensGenerated: ").Append(TokensGenerated).Append("\n");
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
            return this.Equals(input as WorkerDetailsAllOf);
        }

        /// <summary>
        /// Returns true if WorkerDetailsAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkerDetailsAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkerDetailsAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequestsFulfilled == input.RequestsFulfilled ||
                    this.RequestsFulfilled.Equals(input.RequestsFulfilled)
                ) && 
                (
                    this.KudosRewards == input.KudosRewards ||
                    this.KudosRewards.Equals(input.KudosRewards)
                ) && 
                (
                    this.KudosDetails == input.KudosDetails ||
                    (this.KudosDetails != null &&
                    this.KudosDetails.Equals(input.KudosDetails))
                ) && 
                (
                    this.Performance == input.Performance ||
                    (this.Performance != null &&
                    this.Performance.Equals(input.Performance))
                ) && 
                (
                    this.Threads == input.Threads ||
                    this.Threads.Equals(input.Threads)
                ) && 
                (
                    this.Uptime == input.Uptime ||
                    this.Uptime.Equals(input.Uptime)
                ) && 
                (
                    this.MaintenanceMode == input.MaintenanceMode ||
                    this.MaintenanceMode.Equals(input.MaintenanceMode)
                ) && 
                (
                    this.Paused == input.Paused ||
                    this.Paused.Equals(input.Paused)
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) && 
                (
                    this.Nsfw == input.Nsfw ||
                    this.Nsfw.Equals(input.Nsfw)
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Ipaddr == input.Ipaddr ||
                    (this.Ipaddr != null &&
                    this.Ipaddr.Equals(input.Ipaddr))
                ) && 
                (
                    this.Trusted == input.Trusted ||
                    this.Trusted.Equals(input.Trusted)
                ) && 
                (
                    this.Flagged == input.Flagged ||
                    this.Flagged.Equals(input.Flagged)
                ) && 
                (
                    this.Suspicious == input.Suspicious ||
                    this.Suspicious.Equals(input.Suspicious)
                ) && 
                (
                    this.UncompletedJobs == input.UncompletedJobs ||
                    this.UncompletedJobs.Equals(input.UncompletedJobs)
                ) && 
                (
                    this.Models == input.Models ||
                    this.Models != null &&
                    input.Models != null &&
                    this.Models.SequenceEqual(input.Models)
                ) && 
                (
                    this.Forms == input.Forms ||
                    this.Forms != null &&
                    input.Forms != null &&
                    this.Forms.SequenceEqual(input.Forms)
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.BridgeAgent == input.BridgeAgent ||
                    (this.BridgeAgent != null &&
                    this.BridgeAgent.Equals(input.BridgeAgent))
                ) && 
                (
                    this.MaxPixels == input.MaxPixels ||
                    this.MaxPixels.Equals(input.MaxPixels)
                ) && 
                (
                    this.MegapixelstepsGenerated == input.MegapixelstepsGenerated ||
                    this.MegapixelstepsGenerated.Equals(input.MegapixelstepsGenerated)
                ) && 
                (
                    this.Img2img == input.Img2img ||
                    this.Img2img.Equals(input.Img2img)
                ) && 
                (
                    this.Painting == input.Painting ||
                    this.Painting.Equals(input.Painting)
                ) && 
                (
                    this.PostProcessing == input.PostProcessing ||
                    this.PostProcessing.Equals(input.PostProcessing)
                ) && 
                (
                    this.Lora == input.Lora ||
                    this.Lora.Equals(input.Lora)
                ) && 
                (
                    this.MaxLength == input.MaxLength ||
                    this.MaxLength.Equals(input.MaxLength)
                ) && 
                (
                    this.MaxContextLength == input.MaxContextLength ||
                    this.MaxContextLength.Equals(input.MaxContextLength)
                ) && 
                (
                    this.TokensGenerated == input.TokensGenerated ||
                    this.TokensGenerated.Equals(input.TokensGenerated)
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
                hashCode = (hashCode * 59) + this.RequestsFulfilled.GetHashCode();
                hashCode = (hashCode * 59) + this.KudosRewards.GetHashCode();
                if (this.KudosDetails != null)
                {
                    hashCode = (hashCode * 59) + this.KudosDetails.GetHashCode();
                }
                if (this.Performance != null)
                {
                    hashCode = (hashCode * 59) + this.Performance.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Threads.GetHashCode();
                hashCode = (hashCode * 59) + this.Uptime.GetHashCode();
                hashCode = (hashCode * 59) + this.MaintenanceMode.GetHashCode();
                hashCode = (hashCode * 59) + this.Paused.GetHashCode();
                if (this.Info != null)
                {
                    hashCode = (hashCode * 59) + this.Info.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Nsfw.GetHashCode();
                if (this.Owner != null)
                {
                    hashCode = (hashCode * 59) + this.Owner.GetHashCode();
                }
                if (this.Ipaddr != null)
                {
                    hashCode = (hashCode * 59) + this.Ipaddr.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Trusted.GetHashCode();
                hashCode = (hashCode * 59) + this.Flagged.GetHashCode();
                hashCode = (hashCode * 59) + this.Suspicious.GetHashCode();
                hashCode = (hashCode * 59) + this.UncompletedJobs.GetHashCode();
                if (this.Models != null)
                {
                    hashCode = (hashCode * 59) + this.Models.GetHashCode();
                }
                if (this.Forms != null)
                {
                    hashCode = (hashCode * 59) + this.Forms.GetHashCode();
                }
                if (this.Team != null)
                {
                    hashCode = (hashCode * 59) + this.Team.GetHashCode();
                }
                if (this.Contact != null)
                {
                    hashCode = (hashCode * 59) + this.Contact.GetHashCode();
                }
                if (this.BridgeAgent != null)
                {
                    hashCode = (hashCode * 59) + this.BridgeAgent.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxPixels.GetHashCode();
                hashCode = (hashCode * 59) + this.MegapixelstepsGenerated.GetHashCode();
                hashCode = (hashCode * 59) + this.Img2img.GetHashCode();
                hashCode = (hashCode * 59) + this.Painting.GetHashCode();
                hashCode = (hashCode * 59) + this.PostProcessing.GetHashCode();
                hashCode = (hashCode * 59) + this.Lora.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxLength.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxContextLength.GetHashCode();
                hashCode = (hashCode * 59) + this.TokensGenerated.GetHashCode();
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
            // Contact (string) maxLength
            if (this.Contact != null && this.Contact.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contact, length must be less than 500.", new [] { "Contact" });
            }

            // Contact (string) minLength
            if (this.Contact != null && this.Contact.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contact, length must be greater than 5.", new [] { "Contact" });
            }

            // BridgeAgent (string) maxLength
            if (this.BridgeAgent != null && this.BridgeAgent.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BridgeAgent, length must be less than 1000.", new [] { "BridgeAgent" });
            }

            yield break;
        }
    }

}
