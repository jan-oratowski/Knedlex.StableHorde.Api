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
    /// WorkerDetailsStable
    /// </summary>
    [DataContract(Name = "WorkerDetailsStable")]
    public partial class WorkerDetailsStable : IEquatable<WorkerDetailsStable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkerDetailsStable" /> class.
        /// </summary>
        /// <param name="name">The Name given to this worker..</param>
        /// <param name="id">The UUID of this worker..</param>
        /// <param name="requestsFulfilled">How many images this worker has generated..</param>
        /// <param name="kudosRewards">How many Kudos this worker has been rewarded in total..</param>
        /// <param name="kudosDetails">kudosDetails.</param>
        /// <param name="performance">The average performance of this worker in human readable form..</param>
        /// <param name="uptime">The amount of seconds this worker has been online for this Horde..</param>
        /// <param name="maintenanceMode">When True, this worker will not pick up any new requests.</param>
        /// <param name="paused">(Privileged) When True, this worker not be given any new requests..</param>
        /// <param name="info">Extra information or comments about this worker provided by its owner..</param>
        /// <param name="nsfw">Whether this worker can generate NSFW requests or not. (default to false).</param>
        /// <param name="owner">Privileged or public if the owner has allowed it. The alias of the owner of this worker..</param>
        /// <param name="trusted">The worker is trusted to return valid generations..</param>
        /// <param name="suspicious">(Privileged) How much suspicion this worker has accumulated.</param>
        /// <param name="models">models.</param>
        /// <param name="maxPixels">The maximum pixels in resolution this worker can generate.</param>
        /// <param name="megapixelstepsGenerated">How many megapixelsteps this worker has generated until now.</param>
        /// <param name="img2img">If True, this worker supports and allows img2img requests. (default to true).</param>
        /// <param name="painting">If True, this worker supports and allows inpainting requests. (default to true).</param>
        public WorkerDetailsStable(string name = default(string), string id = default(string), int requestsFulfilled = default(int), decimal kudosRewards = default(decimal), WorkerKudosDetails kudosDetails = default(WorkerKudosDetails), string performance = default(string), int uptime = default(int), bool maintenanceMode = default(bool), bool paused = default(bool), string info = default(string), bool nsfw = false, string owner = default(string), bool trusted = default(bool), int suspicious = default(int), List<string> models = default(List<string>), int maxPixels = default(int), decimal megapixelstepsGenerated = default(decimal), bool img2img = true, bool painting = true)
        {
            this.Name = name;
            this.Id = id;
            this.RequestsFulfilled = requestsFulfilled;
            this.KudosRewards = kudosRewards;
            this.KudosDetails = kudosDetails;
            this.Performance = performance;
            this.Uptime = uptime;
            this.MaintenanceMode = maintenanceMode;
            this.Paused = paused;
            this.Info = info;
            this.Nsfw = nsfw;
            this.Owner = owner;
            this.Trusted = trusted;
            this.Suspicious = suspicious;
            this.Models = models;
            this.MaxPixels = maxPixels;
            this.MegapixelstepsGenerated = megapixelstepsGenerated;
            this.Img2img = img2img;
            this.Painting = painting;
        }

        /// <summary>
        /// The Name given to this worker.
        /// </summary>
        /// <value>The Name given to this worker.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The UUID of this worker.
        /// </summary>
        /// <value>The UUID of this worker.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

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
        /// The amount of seconds this worker has been online for this Horde.
        /// </summary>
        /// <value>The amount of seconds this worker has been online for this Horde.</value>
        [DataMember(Name = "uptime", EmitDefaultValue = false)]
        public int Uptime { get; set; }

        /// <summary>
        /// When True, this worker will not pick up any new requests
        /// </summary>
        /// <value>When True, this worker will not pick up any new requests</value>
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
        /// The worker is trusted to return valid generations.
        /// </summary>
        /// <value>The worker is trusted to return valid generations.</value>
        [DataMember(Name = "trusted", EmitDefaultValue = true)]
        public bool Trusted { get; set; }

        /// <summary>
        /// (Privileged) How much suspicion this worker has accumulated
        /// </summary>
        /// <value>(Privileged) How much suspicion this worker has accumulated</value>
        [DataMember(Name = "suspicious", EmitDefaultValue = false)]
        public int Suspicious { get; set; }

        /// <summary>
        /// Gets or Sets Models
        /// </summary>
        [DataMember(Name = "models", EmitDefaultValue = false)]
        public List<string> Models { get; set; }

        /// <summary>
        /// The maximum pixels in resolution this worker can generate
        /// </summary>
        /// <value>The maximum pixels in resolution this worker can generate</value>
        [DataMember(Name = "max_pixels", EmitDefaultValue = false)]
        public int MaxPixels { get; set; }

        /// <summary>
        /// How many megapixelsteps this worker has generated until now
        /// </summary>
        /// <value>How many megapixelsteps this worker has generated until now</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkerDetailsStable {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RequestsFulfilled: ").Append(RequestsFulfilled).Append("\n");
            sb.Append("  KudosRewards: ").Append(KudosRewards).Append("\n");
            sb.Append("  KudosDetails: ").Append(KudosDetails).Append("\n");
            sb.Append("  Performance: ").Append(Performance).Append("\n");
            sb.Append("  Uptime: ").Append(Uptime).Append("\n");
            sb.Append("  MaintenanceMode: ").Append(MaintenanceMode).Append("\n");
            sb.Append("  Paused: ").Append(Paused).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  Nsfw: ").Append(Nsfw).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Trusted: ").Append(Trusted).Append("\n");
            sb.Append("  Suspicious: ").Append(Suspicious).Append("\n");
            sb.Append("  Models: ").Append(Models).Append("\n");
            sb.Append("  MaxPixels: ").Append(MaxPixels).Append("\n");
            sb.Append("  MegapixelstepsGenerated: ").Append(MegapixelstepsGenerated).Append("\n");
            sb.Append("  Img2img: ").Append(Img2img).Append("\n");
            sb.Append("  Painting: ").Append(Painting).Append("\n");
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
            return this.Equals(input as WorkerDetailsStable);
        }

        /// <summary>
        /// Returns true if WorkerDetailsStable instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkerDetailsStable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkerDetailsStable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
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
                    this.Trusted == input.Trusted ||
                    this.Trusted.Equals(input.Trusted)
                ) && 
                (
                    this.Suspicious == input.Suspicious ||
                    this.Suspicious.Equals(input.Suspicious)
                ) && 
                (
                    this.Models == input.Models ||
                    this.Models != null &&
                    input.Models != null &&
                    this.Models.SequenceEqual(input.Models)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
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
                hashCode = (hashCode * 59) + this.Trusted.GetHashCode();
                hashCode = (hashCode * 59) + this.Suspicious.GetHashCode();
                if (this.Models != null)
                {
                    hashCode = (hashCode * 59) + this.Models.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxPixels.GetHashCode();
                hashCode = (hashCode * 59) + this.MegapixelstepsGenerated.GetHashCode();
                hashCode = (hashCode * 59) + this.Img2img.GetHashCode();
                hashCode = (hashCode * 59) + this.Painting.GetHashCode();
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
