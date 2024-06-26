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
    /// AddWorkerTimeout
    /// </summary>
    [DataContract(Name = "AddWorkerTimeout")]
    public partial class AddWorkerTimeout : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddWorkerTimeout" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddWorkerTimeout() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddWorkerTimeout" /> class.
        /// </summary>
        /// <param name="days">For how many days to put this worker&#39;s IP in timeout. (required).</param>
        public AddWorkerTimeout(int days = default(int))
        {
            this.Days = days;
        }

        /// <summary>
        /// For how many days to put this worker&#39;s IP in timeout.
        /// </summary>
        /// <value>For how many days to put this worker&#39;s IP in timeout.</value>
        /// <example>7</example>
        [DataMember(Name = "days", IsRequired = true, EmitDefaultValue = true)]
        public int Days { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddWorkerTimeout {\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
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
            // Days (int) maximum
            if (this.Days > (int)30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Days, must be a value less than or equal to 30.", new [] { "Days" });
            }

            // Days (int) minimum
            if (this.Days < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Days, must be a value greater than or equal to 1.", new [] { "Days" });
            }

            yield break;
        }
    }

}
