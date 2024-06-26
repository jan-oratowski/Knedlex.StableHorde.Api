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
    /// ContributionsDetails
    /// </summary>
    [DataContract(Name = "ContributionsDetails")]
    public partial class ContributionsDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContributionsDetails" /> class.
        /// </summary>
        /// <param name="megapixelsteps">How many megapixelsteps this user has generated..</param>
        /// <param name="fulfillments">How many images this user has generated..</param>
        public ContributionsDetails(decimal megapixelsteps = default(decimal), int fulfillments = default(int))
        {
            this.Megapixelsteps = megapixelsteps;
            this.Fulfillments = fulfillments;
        }

        /// <summary>
        /// How many megapixelsteps this user has generated.
        /// </summary>
        /// <value>How many megapixelsteps this user has generated.</value>
        [DataMember(Name = "megapixelsteps", EmitDefaultValue = false)]
        public decimal Megapixelsteps { get; set; }

        /// <summary>
        /// How many images this user has generated.
        /// </summary>
        /// <value>How many images this user has generated.</value>
        [DataMember(Name = "fulfillments", EmitDefaultValue = false)]
        public int Fulfillments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContributionsDetails {\n");
            sb.Append("  Megapixelsteps: ").Append(Megapixelsteps).Append("\n");
            sb.Append("  Fulfillments: ").Append(Fulfillments).Append("\n");
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
