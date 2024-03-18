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
    /// FilterDetails
    /// </summary>
    [DataContract(Name = "FilterDetails")]
    public partial class FilterDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FilterDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterDetails" /> class.
        /// </summary>
        /// <param name="id">The UUID of this filter. (required).</param>
        /// <param name="regex">The regex for this filter. (required).</param>
        /// <param name="filterType">The integer defining this filter type. (required).</param>
        /// <param name="description">Description about this regex..</param>
        /// <param name="replacement">The replacement string for this regex. (default to &quot;&quot;).</param>
        /// <param name="user">The moderator which added or last updated this regex. (required).</param>
        public FilterDetails(string id = default(string), string regex = default(string), int filterType = default(int), string description = default(string), string replacement = @"", string user = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for FilterDetails and cannot be null");
            }
            this.Id = id;
            // to ensure "regex" is required (not null)
            if (regex == null)
            {
                throw new ArgumentNullException("regex is a required property for FilterDetails and cannot be null");
            }
            this.Regex = regex;
            this.FilterType = filterType;
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new ArgumentNullException("user is a required property for FilterDetails and cannot be null");
            }
            this.User = user;
            this.Description = description;
            // use default value if no "replacement" provided
            this.Replacement = replacement ?? @"";
        }

        /// <summary>
        /// The UUID of this filter.
        /// </summary>
        /// <value>The UUID of this filter.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The regex for this filter.
        /// </summary>
        /// <value>The regex for this filter.</value>
        /// <example>ac.param</example>
        [DataMember(Name = "regex", IsRequired = true, EmitDefaultValue = true)]
        public string Regex { get; set; }

        /// <summary>
        /// The integer defining this filter type.
        /// </summary>
        /// <value>The integer defining this filter type.</value>
        /// <example>10</example>
        [DataMember(Name = "filter_type", IsRequired = true, EmitDefaultValue = true)]
        public int FilterType { get; set; }

        /// <summary>
        /// Description about this regex.
        /// </summary>
        /// <value>Description about this regex.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The replacement string for this regex.
        /// </summary>
        /// <value>The replacement string for this regex.</value>
        [DataMember(Name = "replacement", EmitDefaultValue = false)]
        public string Replacement { get; set; }

        /// <summary>
        /// The moderator which added or last updated this regex.
        /// </summary>
        /// <value>The moderator which added or last updated this regex.</value>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = true)]
        public string User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FilterDetails {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Regex: ").Append(Regex).Append("\n");
            sb.Append("  FilterType: ").Append(FilterType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Replacement: ").Append(Replacement).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            // FilterType (int) maximum
            if (this.FilterType > (int)29)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FilterType, must be a value less than or equal to 29.", new [] { "FilterType" });
            }

            // FilterType (int) minimum
            if (this.FilterType < (int)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FilterType, must be a value greater than or equal to 10.", new [] { "FilterType" });
            }

            yield break;
        }
    }

}