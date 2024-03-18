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
    /// ModelPayloadLorasStable
    /// </summary>
    [DataContract(Name = "ModelPayloadLorasStable")]
    public partial class ModelPayloadLorasStable : IEquatable<ModelPayloadLorasStable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPayloadLorasStable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModelPayloadLorasStable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPayloadLorasStable" /> class.
        /// </summary>
        /// <param name="name">The exact name or CivitAI Model Page ID of the LoRa. If is_version is true, this should be the CivitAI version ID. (required).</param>
        /// <param name="model">The strength of the LoRa to apply to the SD model..</param>
        /// <param name="clip">The strength of the LoRa to apply to the clip model..</param>
        /// <param name="injectTrigger">If set, will try to discover a trigger for this LoRa which matches or is similar to this string and inject it into the prompt. If &#39;any&#39; is specified it will be pick the first trigger..</param>
        /// <param name="isVersion">If true, will consider the LoRa ID as a CivitAI version ID and search accordingly. Ensure the name is an integer. (default to false).</param>
        public ModelPayloadLorasStable(string name = default(string), decimal model = default(decimal), decimal clip = default(decimal), string injectTrigger = default(string), bool isVersion = false)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ModelPayloadLorasStable and cannot be null");
            }
            this.Name = name;
            this.Model = model;
            this.Clip = clip;
            this.InjectTrigger = injectTrigger;
            this.IsVersion = isVersion;
        }

        /// <summary>
        /// The exact name or CivitAI Model Page ID of the LoRa. If is_version is true, this should be the CivitAI version ID.
        /// </summary>
        /// <value>The exact name or CivitAI Model Page ID of the LoRa. If is_version is true, this should be the CivitAI version ID.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The strength of the LoRa to apply to the SD model.
        /// </summary>
        /// <value>The strength of the LoRa to apply to the SD model.</value>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public decimal Model { get; set; }

        /// <summary>
        /// The strength of the LoRa to apply to the clip model.
        /// </summary>
        /// <value>The strength of the LoRa to apply to the clip model.</value>
        [DataMember(Name = "clip", EmitDefaultValue = false)]
        public decimal Clip { get; set; }

        /// <summary>
        /// If set, will try to discover a trigger for this LoRa which matches or is similar to this string and inject it into the prompt. If &#39;any&#39; is specified it will be pick the first trigger.
        /// </summary>
        /// <value>If set, will try to discover a trigger for this LoRa which matches or is similar to this string and inject it into the prompt. If &#39;any&#39; is specified it will be pick the first trigger.</value>
        [DataMember(Name = "inject_trigger", EmitDefaultValue = false)]
        public string InjectTrigger { get; set; }

        /// <summary>
        /// If true, will consider the LoRa ID as a CivitAI version ID and search accordingly. Ensure the name is an integer.
        /// </summary>
        /// <value>If true, will consider the LoRa ID as a CivitAI version ID and search accordingly. Ensure the name is an integer.</value>
        [DataMember(Name = "is_version", EmitDefaultValue = true)]
        public bool IsVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModelPayloadLorasStable {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Clip: ").Append(Clip).Append("\n");
            sb.Append("  InjectTrigger: ").Append(InjectTrigger).Append("\n");
            sb.Append("  IsVersion: ").Append(IsVersion).Append("\n");
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
            return this.Equals(input as ModelPayloadLorasStable);
        }

        /// <summary>
        /// Returns true if ModelPayloadLorasStable instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelPayloadLorasStable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelPayloadLorasStable input)
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
                    this.Model == input.Model ||
                    this.Model.Equals(input.Model)
                ) && 
                (
                    this.Clip == input.Clip ||
                    this.Clip.Equals(input.Clip)
                ) && 
                (
                    this.InjectTrigger == input.InjectTrigger ||
                    (this.InjectTrigger != null &&
                    this.InjectTrigger.Equals(input.InjectTrigger))
                ) && 
                (
                    this.IsVersion == input.IsVersion ||
                    this.IsVersion.Equals(input.IsVersion)
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
                hashCode = (hashCode * 59) + this.Model.GetHashCode();
                hashCode = (hashCode * 59) + this.Clip.GetHashCode();
                if (this.InjectTrigger != null)
                {
                    hashCode = (hashCode * 59) + this.InjectTrigger.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsVersion.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Model (decimal) maximum
            if (this.Model > (decimal)5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Model, must be a value less than or equal to 5.", new [] { "Model" });
            }

            // Model (decimal) minimum
            if (this.Model < (decimal)-5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Model, must be a value greater than or equal to -5.", new [] { "Model" });
            }

            // Clip (decimal) maximum
            if (this.Clip > (decimal)5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Clip, must be a value less than or equal to 5.", new [] { "Clip" });
            }

            // Clip (decimal) minimum
            if (this.Clip < (decimal)-5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Clip, must be a value greater than or equal to -5.", new [] { "Clip" });
            }

            // InjectTrigger (string) maxLength
            if (this.InjectTrigger != null && this.InjectTrigger.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InjectTrigger, length must be less than 30.", new [] { "InjectTrigger" });
            }

            // InjectTrigger (string) minLength
            if (this.InjectTrigger != null && this.InjectTrigger.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InjectTrigger, length must be greater than 1.", new [] { "InjectTrigger" });
            }

            yield break;
        }
    }

}