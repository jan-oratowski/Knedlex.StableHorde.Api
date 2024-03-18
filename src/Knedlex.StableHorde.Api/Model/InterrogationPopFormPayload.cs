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
    /// InterrogationPopFormPayload
    /// </summary>
    [DataContract(Name = "InterrogationPopFormPayload")]
    public partial class InterrogationPopFormPayload : IValidatableObject
    {
        /// <summary>
        /// The name of this interrogation form
        /// </summary>
        /// <value>The name of this interrogation form</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormEnum
        {
            /// <summary>
            /// Enum Caption for value: caption
            /// </summary>
            [EnumMember(Value = "caption")]
            Caption = 1,

            /// <summary>
            /// Enum Interrogation for value: interrogation
            /// </summary>
            [EnumMember(Value = "interrogation")]
            Interrogation = 2,

            /// <summary>
            /// Enum Nsfw for value: nsfw.
            /// </summary>
            [EnumMember(Value = "nsfw.")]
            Nsfw = 3,

            /// <summary>
            /// Enum GFPGAN for value: GFPGAN
            /// </summary>
            [EnumMember(Value = "GFPGAN")]
            GFPGAN = 4,

            /// <summary>
            /// Enum RealESRGANX4plus for value: RealESRGAN_x4plus
            /// </summary>
            [EnumMember(Value = "RealESRGAN_x4plus")]
            RealESRGANX4plus = 5,

            /// <summary>
            /// Enum RealESRGANX2plus for value: RealESRGAN_x2plus
            /// </summary>
            [EnumMember(Value = "RealESRGAN_x2plus")]
            RealESRGANX2plus = 6,

            /// <summary>
            /// Enum RealESRGANX4plusAnime6B for value: RealESRGAN_x4plus_anime_6B
            /// </summary>
            [EnumMember(Value = "RealESRGAN_x4plus_anime_6B")]
            RealESRGANX4plusAnime6B = 7,

            /// <summary>
            /// Enum NMKDSiax for value: NMKD_Siax
            /// </summary>
            [EnumMember(Value = "NMKD_Siax")]
            NMKDSiax = 8,

            /// <summary>
            /// Enum _4xAnimeSharp for value: 4x_AnimeSharp
            /// </summary>
            [EnumMember(Value = "4x_AnimeSharp")]
            _4xAnimeSharp = 9,

            /// <summary>
            /// Enum CodeFormers for value: CodeFormers
            /// </summary>
            [EnumMember(Value = "CodeFormers")]
            CodeFormers = 10,

            /// <summary>
            /// Enum StripBackground for value: strip_background
            /// </summary>
            [EnumMember(Value = "strip_background")]
            StripBackground = 11
        }


        /// <summary>
        /// The name of this interrogation form
        /// </summary>
        /// <value>The name of this interrogation form</value>
        /// <example>caption</example>
        [DataMember(Name = "form", EmitDefaultValue = false)]
        public FormEnum? Form { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InterrogationPopFormPayload" /> class.
        /// </summary>
        /// <param name="id">The UUID of the interrogation form. Use this to post the results in the future..</param>
        /// <param name="form">The name of this interrogation form.</param>
        /// <param name="payload">payload.</param>
        /// <param name="sourceImage">The URL From which the source image can be downloaded..</param>
        /// <param name="r2Upload">The URL in which the post-processed image can be uploaded..</param>
        public InterrogationPopFormPayload(string id = default(string), FormEnum? form = default(FormEnum?), ModelInterrogationFormPayloadStable payload = default(ModelInterrogationFormPayloadStable), string sourceImage = default(string), string r2Upload = default(string))
        {
            this.Id = id;
            this.Form = form;
            this.Payload = payload;
            this.SourceImage = sourceImage;
            this.R2Upload = r2Upload;
        }

        /// <summary>
        /// The UUID of the interrogation form. Use this to post the results in the future.
        /// </summary>
        /// <value>The UUID of the interrogation form. Use this to post the results in the future.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public ModelInterrogationFormPayloadStable Payload { get; set; }

        /// <summary>
        /// The URL From which the source image can be downloaded.
        /// </summary>
        /// <value>The URL From which the source image can be downloaded.</value>
        [DataMember(Name = "source_image", EmitDefaultValue = false)]
        public string SourceImage { get; set; }

        /// <summary>
        /// The URL in which the post-processed image can be uploaded.
        /// </summary>
        /// <value>The URL in which the post-processed image can be uploaded.</value>
        [DataMember(Name = "r2_upload", EmitDefaultValue = false)]
        public string R2Upload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterrogationPopFormPayload {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  SourceImage: ").Append(SourceImage).Append("\n");
            sb.Append("  R2Upload: ").Append(R2Upload).Append("\n");
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
            yield break;
        }
    }

}