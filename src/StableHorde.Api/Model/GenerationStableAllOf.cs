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
    /// GenerationStableAllOf
    /// </summary>
    [DataContract(Name = "GenerationStable_allOf")]
    public partial class GenerationStableAllOf : IEquatable<GenerationStableAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationStableAllOf" /> class.
        /// </summary>
        /// <param name="img">The generated image as a Base64-encoded .webp file..</param>
        /// <param name="seed">The seed which generated this image..</param>
        /// <param name="id">The ID for this image..</param>
        /// <param name="censored">When true this image has been censored by the worker&#39;s safety filter..</param>
        /// <param name="genMetadata">genMetadata.</param>
        public GenerationStableAllOf(string img = default(string), string seed = default(string), string id = default(string), bool censored = default(bool), List<GenerationMetadataStable> genMetadata = default(List<GenerationMetadataStable>))
        {
            this.Img = img;
            this.Seed = seed;
            this.Id = id;
            this.Censored = censored;
            this.GenMetadata = genMetadata;
        }

        /// <summary>
        /// The generated image as a Base64-encoded .webp file.
        /// </summary>
        /// <value>The generated image as a Base64-encoded .webp file.</value>
        [DataMember(Name = "img", EmitDefaultValue = false)]
        public string Img { get; set; }

        /// <summary>
        /// The seed which generated this image.
        /// </summary>
        /// <value>The seed which generated this image.</value>
        [DataMember(Name = "seed", EmitDefaultValue = false)]
        public string Seed { get; set; }

        /// <summary>
        /// The ID for this image.
        /// </summary>
        /// <value>The ID for this image.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// When true this image has been censored by the worker&#39;s safety filter.
        /// </summary>
        /// <value>When true this image has been censored by the worker&#39;s safety filter.</value>
        [DataMember(Name = "censored", EmitDefaultValue = true)]
        public bool Censored { get; set; }

        /// <summary>
        /// Gets or Sets GenMetadata
        /// </summary>
        [DataMember(Name = "gen_metadata", EmitDefaultValue = false)]
        public List<GenerationMetadataStable> GenMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GenerationStableAllOf {\n");
            sb.Append("  Img: ").Append(Img).Append("\n");
            sb.Append("  Seed: ").Append(Seed).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Censored: ").Append(Censored).Append("\n");
            sb.Append("  GenMetadata: ").Append(GenMetadata).Append("\n");
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
            return this.Equals(input as GenerationStableAllOf);
        }

        /// <summary>
        /// Returns true if GenerationStableAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerationStableAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerationStableAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Img == input.Img ||
                    (this.Img != null &&
                    this.Img.Equals(input.Img))
                ) && 
                (
                    this.Seed == input.Seed ||
                    (this.Seed != null &&
                    this.Seed.Equals(input.Seed))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Censored == input.Censored ||
                    this.Censored.Equals(input.Censored)
                ) && 
                (
                    this.GenMetadata == input.GenMetadata ||
                    this.GenMetadata != null &&
                    input.GenMetadata != null &&
                    this.GenMetadata.SequenceEqual(input.GenMetadata)
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
                if (this.Img != null)
                {
                    hashCode = (hashCode * 59) + this.Img.GetHashCode();
                }
                if (this.Seed != null)
                {
                    hashCode = (hashCode * 59) + this.Seed.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Censored.GetHashCode();
                if (this.GenMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.GenMetadata.GetHashCode();
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