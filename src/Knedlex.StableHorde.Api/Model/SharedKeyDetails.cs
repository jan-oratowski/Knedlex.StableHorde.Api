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
    /// SharedKeyDetails
    /// </summary>
    [DataContract(Name = "SharedKeyDetails")]
    public partial class SharedKeyDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedKeyDetails" /> class.
        /// </summary>
        /// <param name="id">The SharedKey ID..</param>
        /// <param name="username">The owning user&#39;s unique Username. It is a combination of their chosen alias plus their ID..</param>
        /// <param name="name">The Shared Key Name..</param>
        /// <param name="kudos">The Kudos limit assigned to this key..</param>
        /// <param name="expiry">The date at which this API key will expire..</param>
        /// <param name="utilized">How much kudos has been utilized via this shared key until now..</param>
        /// <param name="maxImagePixels">The maximum amount of image pixels this key can generate per job. -1 means unlimited..</param>
        /// <param name="maxImageSteps">The maximum amount of image steps this key can use per job. -1 means unlimited..</param>
        /// <param name="maxTextTokens">The maximum amount of text tokens this key can generate per job. -1 means unlimited..</param>
        public SharedKeyDetails(string id = default(string), string username = default(string), string name = default(string), int kudos = default(int), DateTime expiry = default(DateTime), int utilized = default(int), int maxImagePixels = default(int), int maxImageSteps = default(int), int maxTextTokens = default(int))
        {
            this.Id = id;
            this.Username = username;
            this.Name = name;
            this.Kudos = kudos;
            this.Expiry = expiry;
            this.Utilized = utilized;
            this.MaxImagePixels = maxImagePixels;
            this.MaxImageSteps = maxImageSteps;
            this.MaxTextTokens = maxTextTokens;
        }

        /// <summary>
        /// The SharedKey ID.
        /// </summary>
        /// <value>The SharedKey ID.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The owning user&#39;s unique Username. It is a combination of their chosen alias plus their ID.
        /// </summary>
        /// <value>The owning user&#39;s unique Username. It is a combination of their chosen alias plus their ID.</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// The Shared Key Name.
        /// </summary>
        /// <value>The Shared Key Name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The Kudos limit assigned to this key.
        /// </summary>
        /// <value>The Kudos limit assigned to this key.</value>
        [DataMember(Name = "kudos", EmitDefaultValue = false)]
        public int Kudos { get; set; }

        /// <summary>
        /// The date at which this API key will expire.
        /// </summary>
        /// <value>The date at which this API key will expire.</value>
        [DataMember(Name = "expiry", EmitDefaultValue = false)]
        public DateTime Expiry { get; set; }

        /// <summary>
        /// How much kudos has been utilized via this shared key until now.
        /// </summary>
        /// <value>How much kudos has been utilized via this shared key until now.</value>
        [DataMember(Name = "utilized", EmitDefaultValue = false)]
        public int Utilized { get; set; }

        /// <summary>
        /// The maximum amount of image pixels this key can generate per job. -1 means unlimited.
        /// </summary>
        /// <value>The maximum amount of image pixels this key can generate per job. -1 means unlimited.</value>
        [DataMember(Name = "max_image_pixels", EmitDefaultValue = false)]
        public int MaxImagePixels { get; set; }

        /// <summary>
        /// The maximum amount of image steps this key can use per job. -1 means unlimited.
        /// </summary>
        /// <value>The maximum amount of image steps this key can use per job. -1 means unlimited.</value>
        [DataMember(Name = "max_image_steps", EmitDefaultValue = false)]
        public int MaxImageSteps { get; set; }

        /// <summary>
        /// The maximum amount of text tokens this key can generate per job. -1 means unlimited.
        /// </summary>
        /// <value>The maximum amount of text tokens this key can generate per job. -1 means unlimited.</value>
        [DataMember(Name = "max_text_tokens", EmitDefaultValue = false)]
        public int MaxTextTokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SharedKeyDetails {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Kudos: ").Append(Kudos).Append("\n");
            sb.Append("  Expiry: ").Append(Expiry).Append("\n");
            sb.Append("  Utilized: ").Append(Utilized).Append("\n");
            sb.Append("  MaxImagePixels: ").Append(MaxImagePixels).Append("\n");
            sb.Append("  MaxImageSteps: ").Append(MaxImageSteps).Append("\n");
            sb.Append("  MaxTextTokens: ").Append(MaxTextTokens).Append("\n");
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
