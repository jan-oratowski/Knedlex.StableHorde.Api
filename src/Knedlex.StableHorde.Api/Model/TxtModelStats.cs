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
    /// TxtModelStats
    /// </summary>
    [DataContract(Name = "TxtModelStats")]
    public partial class TxtModelStats : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TxtModelStats" /> class.
        /// </summary>
        /// <param name="day">day.</param>
        /// <param name="month">month.</param>
        /// <param name="total">total.</param>
        public TxtModelStats(SinglePeriodTxtModelStats day = default(SinglePeriodTxtModelStats), SinglePeriodTxtModelStats month = default(SinglePeriodTxtModelStats), SinglePeriodTxtModelStats total = default(SinglePeriodTxtModelStats))
        {
            this.Day = day;
            this.Month = month;
            this.Total = total;
        }

        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name = "day", EmitDefaultValue = false)]
        public SinglePeriodTxtModelStats Day { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name = "month", EmitDefaultValue = false)]
        public SinglePeriodTxtModelStats Month { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public SinglePeriodTxtModelStats Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TxtModelStats {\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
