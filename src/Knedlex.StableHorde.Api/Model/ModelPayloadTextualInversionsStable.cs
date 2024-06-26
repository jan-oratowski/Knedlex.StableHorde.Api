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
    /// ModelPayloadTextualInversionsStable
    /// </summary>
    [DataContract(Name = "ModelPayloadTextualInversionsStable")]
    public partial class ModelPayloadTextualInversionsStable : IValidatableObject
    {
        /// <summary>
        /// If set, Will automatically add this TI filename to the prompt or negative prompt accordingly using the provided strength. If this is set to None, then the user will have to manually add the embed to the prompt themselves.
        /// </summary>
        /// <value>If set, Will automatically add this TI filename to the prompt or negative prompt accordingly using the provided strength. If this is set to None, then the user will have to manually add the embed to the prompt themselves.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InjectTiEnum
        {
            /// <summary>
            /// Enum Prompt for value: prompt
            /// </summary>
            [EnumMember(Value = "prompt")]
            Prompt = 1,

            /// <summary>
            /// Enum Negprompt for value: negprompt
            /// </summary>
            [EnumMember(Value = "negprompt")]
            Negprompt = 2
        }


        /// <summary>
        /// If set, Will automatically add this TI filename to the prompt or negative prompt accordingly using the provided strength. If this is set to None, then the user will have to manually add the embed to the prompt themselves.
        /// </summary>
        /// <value>If set, Will automatically add this TI filename to the prompt or negative prompt accordingly using the provided strength. If this is set to None, then the user will have to manually add the embed to the prompt themselves.</value>
        /// <example>prompt</example>
        [DataMember(Name = "inject_ti", EmitDefaultValue = false)]
        public InjectTiEnum? InjectTi { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPayloadTextualInversionsStable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModelPayloadTextualInversionsStable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPayloadTextualInversionsStable" /> class.
        /// </summary>
        /// <param name="name">The exact name or CivitAI ID of the Textual Inversion. (required).</param>
        /// <param name="injectTi">If set, Will automatically add this TI filename to the prompt or negative prompt accordingly using the provided strength. If this is set to None, then the user will have to manually add the embed to the prompt themselves..</param>
        /// <param name="strength">The strength with which to apply the TI to the prompt. Only used when inject_ti is not None.</param>
        public ModelPayloadTextualInversionsStable(string name = default(string), InjectTiEnum? injectTi = default(InjectTiEnum?), decimal strength = default(decimal))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ModelPayloadTextualInversionsStable and cannot be null");
            }
            this.Name = name;
            this.InjectTi = injectTi;
            this.Strength = strength;
        }

        /// <summary>
        /// The exact name or CivitAI ID of the Textual Inversion.
        /// </summary>
        /// <value>The exact name or CivitAI ID of the Textual Inversion.</value>
        /// <example>7808</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The strength with which to apply the TI to the prompt. Only used when inject_ti is not None
        /// </summary>
        /// <value>The strength with which to apply the TI to the prompt. Only used when inject_ti is not None</value>
        [DataMember(Name = "strength", EmitDefaultValue = false)]
        public decimal Strength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModelPayloadTextualInversionsStable {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InjectTi: ").Append(InjectTi).Append("\n");
            sb.Append("  Strength: ").Append(Strength).Append("\n");
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

            // Strength (decimal) maximum
            if (this.Strength > (decimal)5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Strength, must be a value less than or equal to 5.", new [] { "Strength" });
            }

            // Strength (decimal) minimum
            if (this.Strength < (decimal)-5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Strength, must be a value greater than or equal to -5.", new [] { "Strength" });
            }

            yield break;
        }
    }

}
