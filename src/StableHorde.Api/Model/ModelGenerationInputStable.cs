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
    /// ModelGenerationInputStable
    /// </summary>
    [DataContract(Name = "ModelGenerationInputStable")]
    public partial class ModelGenerationInputStable : IEquatable<ModelGenerationInputStable>, IValidatableObject
    {
        /// <summary>
        /// Defines SamplerName
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SamplerNameEnum
        {
            /// <summary>
            /// Enum DDIM for value: DDIM
            /// </summary>
            [EnumMember(Value = "DDIM")]
            DDIM = 1,

            /// <summary>
            /// Enum KEulerA for value: k_euler_a
            /// </summary>
            [EnumMember(Value = "k_euler_a")]
            KEulerA = 2,

            /// <summary>
            /// Enum KLms for value: k_lms
            /// </summary>
            [EnumMember(Value = "k_lms")]
            KLms = 3,

            /// <summary>
            /// Enum KHeun for value: k_heun
            /// </summary>
            [EnumMember(Value = "k_heun")]
            KHeun = 4,

            /// <summary>
            /// Enum KDpmpp2sA for value: k_dpmpp_2s_a
            /// </summary>
            [EnumMember(Value = "k_dpmpp_2s_a")]
            KDpmpp2sA = 5,

            /// <summary>
            /// Enum KDpm2 for value: k_dpm_2
            /// </summary>
            [EnumMember(Value = "k_dpm_2")]
            KDpm2 = 6,

            /// <summary>
            /// Enum KDpmppSde for value: k_dpmpp_sde
            /// </summary>
            [EnumMember(Value = "k_dpmpp_sde")]
            KDpmppSde = 7,

            /// <summary>
            /// Enum KEuler for value: k_euler
            /// </summary>
            [EnumMember(Value = "k_euler")]
            KEuler = 8,

            /// <summary>
            /// Enum Dpmsolver for value: dpmsolver
            /// </summary>
            [EnumMember(Value = "dpmsolver")]
            Dpmsolver = 9,

            /// <summary>
            /// Enum KDpmpp2m for value: k_dpmpp_2m
            /// </summary>
            [EnumMember(Value = "k_dpmpp_2m")]
            KDpmpp2m = 10,

            /// <summary>
            /// Enum KDpmFast for value: k_dpm_fast
            /// </summary>
            [EnumMember(Value = "k_dpm_fast")]
            KDpmFast = 11,

            /// <summary>
            /// Enum Lcm for value: lcm
            /// </summary>
            [EnumMember(Value = "lcm")]
            Lcm = 12,

            /// <summary>
            /// Enum KDpm2A for value: k_dpm_2_a
            /// </summary>
            [EnumMember(Value = "k_dpm_2_a")]
            KDpm2A = 13,

            /// <summary>
            /// Enum KDpmAdaptive for value: k_dpm_adaptive
            /// </summary>
            [EnumMember(Value = "k_dpm_adaptive")]
            KDpmAdaptive = 14

        }


        /// <summary>
        /// Gets or Sets SamplerName
        /// </summary>
        [DataMember(Name = "sampler_name", EmitDefaultValue = false)]
        public SamplerNameEnum? SamplerName { get; set; }
        /// <summary>
        /// The list of post-processors to apply to the image, in the order to be applied.
        /// </summary>
        /// <value>The list of post-processors to apply to the image, in the order to be applied.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PostProcessingEnum
        {
            /// <summary>
            /// Enum GFPGAN for value: GFPGAN
            /// </summary>
            [EnumMember(Value = "GFPGAN")]
            GFPGAN = 1,

            /// <summary>
            /// Enum RealESRGANX4plus for value: RealESRGAN_x4plus
            /// </summary>
            [EnumMember(Value = "RealESRGAN_x4plus")]
            RealESRGANX4plus = 2,

            /// <summary>
            /// Enum RealESRGANX2plus for value: RealESRGAN_x2plus
            /// </summary>
            [EnumMember(Value = "RealESRGAN_x2plus")]
            RealESRGANX2plus = 3,

            /// <summary>
            /// Enum RealESRGANX4plusAnime6B for value: RealESRGAN_x4plus_anime_6B
            /// </summary>
            [EnumMember(Value = "RealESRGAN_x4plus_anime_6B")]
            RealESRGANX4plusAnime6B = 4,

            /// <summary>
            /// Enum NMKDSiax for value: NMKD_Siax
            /// </summary>
            [EnumMember(Value = "NMKD_Siax")]
            NMKDSiax = 5,

            /// <summary>
            /// Enum _4xAnimeSharp for value: 4x_AnimeSharp
            /// </summary>
            [EnumMember(Value = "4x_AnimeSharp")]
            _4xAnimeSharp = 6,

            /// <summary>
            /// Enum CodeFormers for value: CodeFormers
            /// </summary>
            [EnumMember(Value = "CodeFormers")]
            CodeFormers = 7,

            /// <summary>
            /// Enum StripBackground for value: strip_background
            /// </summary>
            [EnumMember(Value = "strip_background")]
            StripBackground = 8

        }



        /// <summary>
        /// Gets or Sets PostProcessing
        /// </summary>
        [DataMember(Name = "post_processing", EmitDefaultValue = false)]
        public List<PostProcessingEnum> PostProcessing { get; set; }
        /// <summary>
        /// Defines ControlType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ControlTypeEnum
        {
            /// <summary>
            /// Enum Canny for value: canny
            /// </summary>
            [EnumMember(Value = "canny")]
            Canny = 1,

            /// <summary>
            /// Enum Hed for value: hed
            /// </summary>
            [EnumMember(Value = "hed")]
            Hed = 2,

            /// <summary>
            /// Enum Depth for value: depth
            /// </summary>
            [EnumMember(Value = "depth")]
            Depth = 3,

            /// <summary>
            /// Enum Normal for value: normal
            /// </summary>
            [EnumMember(Value = "normal")]
            Normal = 4,

            /// <summary>
            /// Enum Openpose for value: openpose
            /// </summary>
            [EnumMember(Value = "openpose")]
            Openpose = 5,

            /// <summary>
            /// Enum Seg for value: seg
            /// </summary>
            [EnumMember(Value = "seg")]
            Seg = 6,

            /// <summary>
            /// Enum Scribble for value: scribble
            /// </summary>
            [EnumMember(Value = "scribble")]
            Scribble = 7,

            /// <summary>
            /// Enum Fakescribbles for value: fakescribbles
            /// </summary>
            [EnumMember(Value = "fakescribbles")]
            Fakescribbles = 8,

            /// <summary>
            /// Enum Hough for value: hough
            /// </summary>
            [EnumMember(Value = "hough")]
            Hough = 9

        }


        /// <summary>
        /// Gets or Sets ControlType
        /// </summary>
        [DataMember(Name = "control_type", EmitDefaultValue = false)]
        public ControlTypeEnum? ControlType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelGenerationInputStable" /> class.
        /// </summary>
        /// <param name="samplerName">samplerName (default to SamplerNameEnum.KEulerA).</param>
        /// <param name="cfgScale">cfgScale.</param>
        /// <param name="denoisingStrength">denoisingStrength.</param>
        /// <param name="seed">The seed to use to generate this request. You can pass text as well as numbers..</param>
        /// <param name="height">The height of the image to generate..</param>
        /// <param name="width">The width of the image to generate..</param>
        /// <param name="seedVariation">If passed with multiple n, the provided seed will be incremented every time by this value..</param>
        /// <param name="postProcessing">postProcessing.</param>
        /// <param name="karras">Set to True to enable karras noise scheduling tweaks. (default to false).</param>
        /// <param name="tiling">Set to True to create images that stitch together seamlessly. (default to false).</param>
        /// <param name="hiresFix">Set to True to process the image at base resolution before upscaling and re-processing. (default to false).</param>
        /// <param name="clipSkip">The number of CLIP language processor layers to skip..</param>
        /// <param name="controlType">controlType.</param>
        /// <param name="imageIsControl">Set to True if the image submitted is a pre-generated control map for ControlNet use. (default to false).</param>
        /// <param name="returnControlMap">Set to True if you want the ControlNet map returned instead of a generated image. (default to false).</param>
        /// <param name="facefixerStrength">facefixerStrength.</param>
        /// <param name="loras">loras.</param>
        /// <param name="tis">tis.</param>
        /// <param name="special">special.</param>
        /// <param name="steps">steps.</param>
        /// <param name="n">The amount of images to generate..</param>
        public ModelGenerationInputStable(SamplerNameEnum? samplerName = SamplerNameEnum.KEulerA, decimal cfgScale = default(decimal), decimal denoisingStrength = default(decimal), string seed = default(string), int height = default(int), int width = default(int), int seedVariation = default(int), List<PostProcessingEnum> postProcessing = default(List<PostProcessingEnum>), bool karras = false, bool tiling = false, bool hiresFix = false, int clipSkip = default(int), ControlTypeEnum? controlType = default(ControlTypeEnum?), bool imageIsControl = false, bool returnControlMap = false, decimal facefixerStrength = default(decimal), List<ModelPayloadLorasStable> loras = default(List<ModelPayloadLorasStable>), List<ModelPayloadTextualInversionsStable> tis = default(List<ModelPayloadTextualInversionsStable>), ModelSpecialPayloadStable special = default(ModelSpecialPayloadStable), int steps = default(int), int n = default(int))
        {
            this.SamplerName = samplerName;
            this.CfgScale = cfgScale;
            this.DenoisingStrength = denoisingStrength;
            this.Seed = seed;
            this.Height = height;
            this.Width = width;
            this.SeedVariation = seedVariation;
            this.PostProcessing = postProcessing;
            this.Karras = karras;
            this.Tiling = tiling;
            this.HiresFix = hiresFix;
            this.ClipSkip = clipSkip;
            this.ControlType = controlType;
            this.ImageIsControl = imageIsControl;
            this.ReturnControlMap = returnControlMap;
            this.FacefixerStrength = facefixerStrength;
            this.Loras = loras;
            this.Tis = tis;
            this.Special = special;
            this.Steps = steps;
            this.N = n;
        }

        /// <summary>
        /// Gets or Sets CfgScale
        /// </summary>
        [DataMember(Name = "cfg_scale", EmitDefaultValue = false)]
        public decimal CfgScale { get; set; }

        /// <summary>
        /// Gets or Sets DenoisingStrength
        /// </summary>
        [DataMember(Name = "denoising_strength", EmitDefaultValue = false)]
        public decimal DenoisingStrength { get; set; }

        /// <summary>
        /// The seed to use to generate this request. You can pass text as well as numbers.
        /// </summary>
        /// <value>The seed to use to generate this request. You can pass text as well as numbers.</value>
        [DataMember(Name = "seed", EmitDefaultValue = false)]
        public string Seed { get; set; }

        /// <summary>
        /// The height of the image to generate.
        /// </summary>
        /// <value>The height of the image to generate.</value>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// The width of the image to generate.
        /// </summary>
        /// <value>The width of the image to generate.</value>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// If passed with multiple n, the provided seed will be incremented every time by this value.
        /// </summary>
        /// <value>If passed with multiple n, the provided seed will be incremented every time by this value.</value>
        [DataMember(Name = "seed_variation", EmitDefaultValue = false)]
        public int SeedVariation { get; set; }

        /// <summary>
        /// Set to True to enable karras noise scheduling tweaks.
        /// </summary>
        /// <value>Set to True to enable karras noise scheduling tweaks.</value>
        [DataMember(Name = "karras", EmitDefaultValue = true)]
        public bool Karras { get; set; }

        /// <summary>
        /// Set to True to create images that stitch together seamlessly.
        /// </summary>
        /// <value>Set to True to create images that stitch together seamlessly.</value>
        [DataMember(Name = "tiling", EmitDefaultValue = true)]
        public bool Tiling { get; set; }

        /// <summary>
        /// Set to True to process the image at base resolution before upscaling and re-processing.
        /// </summary>
        /// <value>Set to True to process the image at base resolution before upscaling and re-processing.</value>
        [DataMember(Name = "hires_fix", EmitDefaultValue = true)]
        public bool HiresFix { get; set; }

        /// <summary>
        /// The number of CLIP language processor layers to skip.
        /// </summary>
        /// <value>The number of CLIP language processor layers to skip.</value>
        [DataMember(Name = "clip_skip", EmitDefaultValue = false)]
        public int ClipSkip { get; set; }

        /// <summary>
        /// Set to True if the image submitted is a pre-generated control map for ControlNet use.
        /// </summary>
        /// <value>Set to True if the image submitted is a pre-generated control map for ControlNet use.</value>
        [DataMember(Name = "image_is_control", EmitDefaultValue = true)]
        public bool ImageIsControl { get; set; }

        /// <summary>
        /// Set to True if you want the ControlNet map returned instead of a generated image.
        /// </summary>
        /// <value>Set to True if you want the ControlNet map returned instead of a generated image.</value>
        [DataMember(Name = "return_control_map", EmitDefaultValue = true)]
        public bool ReturnControlMap { get; set; }

        /// <summary>
        /// Gets or Sets FacefixerStrength
        /// </summary>
        [DataMember(Name = "facefixer_strength", EmitDefaultValue = false)]
        public decimal FacefixerStrength { get; set; }

        /// <summary>
        /// Gets or Sets Loras
        /// </summary>
        [DataMember(Name = "loras", EmitDefaultValue = false)]
        public List<ModelPayloadLorasStable> Loras { get; set; }

        /// <summary>
        /// Gets or Sets Tis
        /// </summary>
        [DataMember(Name = "tis", EmitDefaultValue = false)]
        public List<ModelPayloadTextualInversionsStable> Tis { get; set; }

        /// <summary>
        /// Gets or Sets Special
        /// </summary>
        [DataMember(Name = "special", EmitDefaultValue = false)]
        public ModelSpecialPayloadStable Special { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name = "steps", EmitDefaultValue = false)]
        public int Steps { get; set; }

        /// <summary>
        /// The amount of images to generate.
        /// </summary>
        /// <value>The amount of images to generate.</value>
        [DataMember(Name = "n", EmitDefaultValue = false)]
        public int N { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModelGenerationInputStable {\n");
            sb.Append("  SamplerName: ").Append(SamplerName).Append("\n");
            sb.Append("  CfgScale: ").Append(CfgScale).Append("\n");
            sb.Append("  DenoisingStrength: ").Append(DenoisingStrength).Append("\n");
            sb.Append("  Seed: ").Append(Seed).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  SeedVariation: ").Append(SeedVariation).Append("\n");
            sb.Append("  PostProcessing: ").Append(PostProcessing).Append("\n");
            sb.Append("  Karras: ").Append(Karras).Append("\n");
            sb.Append("  Tiling: ").Append(Tiling).Append("\n");
            sb.Append("  HiresFix: ").Append(HiresFix).Append("\n");
            sb.Append("  ClipSkip: ").Append(ClipSkip).Append("\n");
            sb.Append("  ControlType: ").Append(ControlType).Append("\n");
            sb.Append("  ImageIsControl: ").Append(ImageIsControl).Append("\n");
            sb.Append("  ReturnControlMap: ").Append(ReturnControlMap).Append("\n");
            sb.Append("  FacefixerStrength: ").Append(FacefixerStrength).Append("\n");
            sb.Append("  Loras: ").Append(Loras).Append("\n");
            sb.Append("  Tis: ").Append(Tis).Append("\n");
            sb.Append("  Special: ").Append(Special).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
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
            return this.Equals(input as ModelGenerationInputStable);
        }

        /// <summary>
        /// Returns true if ModelGenerationInputStable instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelGenerationInputStable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelGenerationInputStable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SamplerName == input.SamplerName ||
                    this.SamplerName.Equals(input.SamplerName)
                ) && 
                (
                    this.CfgScale == input.CfgScale ||
                    this.CfgScale.Equals(input.CfgScale)
                ) && 
                (
                    this.DenoisingStrength == input.DenoisingStrength ||
                    this.DenoisingStrength.Equals(input.DenoisingStrength)
                ) && 
                (
                    this.Seed == input.Seed ||
                    (this.Seed != null &&
                    this.Seed.Equals(input.Seed))
                ) && 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.Width == input.Width ||
                    this.Width.Equals(input.Width)
                ) && 
                (
                    this.SeedVariation == input.SeedVariation ||
                    this.SeedVariation.Equals(input.SeedVariation)
                ) && 
                (
                    this.PostProcessing == input.PostProcessing ||
                    this.PostProcessing.SequenceEqual(input.PostProcessing)
                ) && 
                (
                    this.Karras == input.Karras ||
                    this.Karras.Equals(input.Karras)
                ) && 
                (
                    this.Tiling == input.Tiling ||
                    this.Tiling.Equals(input.Tiling)
                ) && 
                (
                    this.HiresFix == input.HiresFix ||
                    this.HiresFix.Equals(input.HiresFix)
                ) && 
                (
                    this.ClipSkip == input.ClipSkip ||
                    this.ClipSkip.Equals(input.ClipSkip)
                ) && 
                (
                    this.ControlType == input.ControlType ||
                    this.ControlType.Equals(input.ControlType)
                ) && 
                (
                    this.ImageIsControl == input.ImageIsControl ||
                    this.ImageIsControl.Equals(input.ImageIsControl)
                ) && 
                (
                    this.ReturnControlMap == input.ReturnControlMap ||
                    this.ReturnControlMap.Equals(input.ReturnControlMap)
                ) && 
                (
                    this.FacefixerStrength == input.FacefixerStrength ||
                    this.FacefixerStrength.Equals(input.FacefixerStrength)
                ) && 
                (
                    this.Loras == input.Loras ||
                    this.Loras != null &&
                    input.Loras != null &&
                    this.Loras.SequenceEqual(input.Loras)
                ) && 
                (
                    this.Tis == input.Tis ||
                    this.Tis != null &&
                    input.Tis != null &&
                    this.Tis.SequenceEqual(input.Tis)
                ) && 
                (
                    this.Special == input.Special ||
                    (this.Special != null &&
                    this.Special.Equals(input.Special))
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps.Equals(input.Steps)
                ) && 
                (
                    this.N == input.N ||
                    this.N.Equals(input.N)
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
                hashCode = (hashCode * 59) + this.SamplerName.GetHashCode();
                hashCode = (hashCode * 59) + this.CfgScale.GetHashCode();
                hashCode = (hashCode * 59) + this.DenoisingStrength.GetHashCode();
                if (this.Seed != null)
                {
                    hashCode = (hashCode * 59) + this.Seed.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Height.GetHashCode();
                hashCode = (hashCode * 59) + this.Width.GetHashCode();
                hashCode = (hashCode * 59) + this.SeedVariation.GetHashCode();
                hashCode = (hashCode * 59) + this.PostProcessing.GetHashCode();
                hashCode = (hashCode * 59) + this.Karras.GetHashCode();
                hashCode = (hashCode * 59) + this.Tiling.GetHashCode();
                hashCode = (hashCode * 59) + this.HiresFix.GetHashCode();
                hashCode = (hashCode * 59) + this.ClipSkip.GetHashCode();
                hashCode = (hashCode * 59) + this.ControlType.GetHashCode();
                hashCode = (hashCode * 59) + this.ImageIsControl.GetHashCode();
                hashCode = (hashCode * 59) + this.ReturnControlMap.GetHashCode();
                hashCode = (hashCode * 59) + this.FacefixerStrength.GetHashCode();
                if (this.Loras != null)
                {
                    hashCode = (hashCode * 59) + this.Loras.GetHashCode();
                }
                if (this.Tis != null)
                {
                    hashCode = (hashCode * 59) + this.Tis.GetHashCode();
                }
                if (this.Special != null)
                {
                    hashCode = (hashCode * 59) + this.Special.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Steps.GetHashCode();
                hashCode = (hashCode * 59) + this.N.GetHashCode();
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
            // CfgScale (decimal) maximum
            if (this.CfgScale > (decimal)1E+2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CfgScale, must be a value less than or equal to 1E+2.", new [] { "CfgScale" });
            }

            // CfgScale (decimal) minimum
            if (this.CfgScale < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CfgScale, must be a value greater than or equal to 0.", new [] { "CfgScale" });
            }

            // DenoisingStrength (decimal) maximum
            if (this.DenoisingStrength > (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DenoisingStrength, must be a value less than or equal to 1.", new [] { "DenoisingStrength" });
            }

            // DenoisingStrength (decimal) minimum
            if (this.DenoisingStrength < (decimal)0.01)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DenoisingStrength, must be a value greater than or equal to 0.01.", new [] { "DenoisingStrength" });
            }

            // Height (int) maximum
            if (this.Height > (int)3072)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Height, must be a value less than or equal to 3072.", new [] { "Height" });
            }

            // Height (int) minimum
            if (this.Height < (int)64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Height, must be a value greater than or equal to 64.", new [] { "Height" });
            }

            // Width (int) maximum
            if (this.Width > (int)3072)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Width, must be a value less than or equal to 3072.", new [] { "Width" });
            }

            // Width (int) minimum
            if (this.Width < (int)64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Width, must be a value greater than or equal to 64.", new [] { "Width" });
            }

            // SeedVariation (int) maximum
            if (this.SeedVariation > (int)1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SeedVariation, must be a value less than or equal to 1000.", new [] { "SeedVariation" });
            }

            // SeedVariation (int) minimum
            if (this.SeedVariation < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SeedVariation, must be a value greater than or equal to 1.", new [] { "SeedVariation" });
            }

            // ClipSkip (int) maximum
            if (this.ClipSkip > (int)12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClipSkip, must be a value less than or equal to 12.", new [] { "ClipSkip" });
            }

            // ClipSkip (int) minimum
            if (this.ClipSkip < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClipSkip, must be a value greater than or equal to 1.", new [] { "ClipSkip" });
            }

            // FacefixerStrength (decimal) maximum
            if (this.FacefixerStrength > (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FacefixerStrength, must be a value less than or equal to 1.", new [] { "FacefixerStrength" });
            }

            // FacefixerStrength (decimal) minimum
            if (this.FacefixerStrength < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FacefixerStrength, must be a value greater than or equal to 0.", new [] { "FacefixerStrength" });
            }

            // Steps (int) maximum
            if (this.Steps > (int)500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Steps, must be a value less than or equal to 500.", new [] { "Steps" });
            }

            // Steps (int) minimum
            if (this.Steps < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Steps, must be a value greater than or equal to 1.", new [] { "Steps" });
            }

            // N (int) maximum
            if (this.N > (int)20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for N, must be a value less than or equal to 20.", new [] { "N" });
            }

            // N (int) minimum
            if (this.N < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for N, must be a value greater than or equal to 1.", new [] { "N" });
            }

            yield break;
        }
    }

}
