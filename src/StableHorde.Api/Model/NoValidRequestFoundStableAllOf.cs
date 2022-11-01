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
    /// NoValidRequestFoundStableAllOf
    /// </summary>
    [DataContract(Name = "NoValidRequestFoundStable_allOf")]
    public partial class NoValidRequestFoundStableAllOf : IEquatable<NoValidRequestFoundStableAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoValidRequestFoundStableAllOf" /> class.
        /// </summary>
        /// <param name="maxPixels">How many waiting requests were skipped because they demanded a higher size than this worker provides.</param>
        /// <param name="unsafeIp">How many waiting requests were skipped because they came from an unsafe IP.</param>
        /// <param name="img2img">How many waiting requests were skipped because they requested img2img.</param>
        /// <param name="painting">How many waiting requests were skipped because they requested inpainting/outpainting.</param>
        public NoValidRequestFoundStableAllOf(int maxPixels = default(int), int unsafeIp = default(int), int img2img = default(int), int painting = default(int))
        {
            this.MaxPixels = maxPixels;
            this.UnsafeIp = unsafeIp;
            this.Img2img = img2img;
            this.Painting = painting;
        }

        /// <summary>
        /// How many waiting requests were skipped because they demanded a higher size than this worker provides
        /// </summary>
        /// <value>How many waiting requests were skipped because they demanded a higher size than this worker provides</value>
        [DataMember(Name = "max_pixels", EmitDefaultValue = false)]
        public int MaxPixels { get; set; }

        /// <summary>
        /// How many waiting requests were skipped because they came from an unsafe IP
        /// </summary>
        /// <value>How many waiting requests were skipped because they came from an unsafe IP</value>
        [DataMember(Name = "unsafe_ip", EmitDefaultValue = false)]
        public int UnsafeIp { get; set; }

        /// <summary>
        /// How many waiting requests were skipped because they requested img2img
        /// </summary>
        /// <value>How many waiting requests were skipped because they requested img2img</value>
        [DataMember(Name = "img2img", EmitDefaultValue = false)]
        public int Img2img { get; set; }

        /// <summary>
        /// How many waiting requests were skipped because they requested inpainting/outpainting
        /// </summary>
        /// <value>How many waiting requests were skipped because they requested inpainting/outpainting</value>
        [DataMember(Name = "painting", EmitDefaultValue = false)]
        public int Painting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NoValidRequestFoundStableAllOf {\n");
            sb.Append("  MaxPixels: ").Append(MaxPixels).Append("\n");
            sb.Append("  UnsafeIp: ").Append(UnsafeIp).Append("\n");
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
            return this.Equals(input as NoValidRequestFoundStableAllOf);
        }

        /// <summary>
        /// Returns true if NoValidRequestFoundStableAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of NoValidRequestFoundStableAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoValidRequestFoundStableAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaxPixels == input.MaxPixels ||
                    this.MaxPixels.Equals(input.MaxPixels)
                ) && 
                (
                    this.UnsafeIp == input.UnsafeIp ||
                    this.UnsafeIp.Equals(input.UnsafeIp)
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
                hashCode = (hashCode * 59) + this.MaxPixels.GetHashCode();
                hashCode = (hashCode * 59) + this.UnsafeIp.GetHashCode();
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
