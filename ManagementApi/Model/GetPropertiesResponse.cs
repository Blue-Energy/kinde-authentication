/*
 * Kinde Management API
 *
 * Provides endpoints to manage your Kinde Businesses
 *
 * The version of the OpenAPI document: 1
 * Contact: support@kinde.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Clinically.Kinde.Authentication.ManagementApi.Model
{
    /// <summary>
    /// GetPropertiesResponse
    /// </summary>
    [DataContract(Name = "get_properties_response")]
    public partial class GetPropertiesResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPropertiesResponse" /> class.
        /// </summary>
        /// <param name="code">Response code..</param>
        /// <param name="message">Response message..</param>
        /// <param name="properties">properties.</param>
        /// <param name="hasMore">Whether more records exist..</param>
        public GetPropertiesResponse(string code = default(string), string message = default(string), List<Property> properties = default(List<Property>), bool hasMore = default(bool))
        {
            this.Code = code;
            this.Message = message;
            this.Properties = properties;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Response code.
        /// </summary>
        /// <value>Response code.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Response message.
        /// </summary>
        /// <value>Response message.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public List<Property> Properties { get; set; }

        /// <summary>
        /// Whether more records exist.
        /// </summary>
        /// <value>Whether more records exist.</value>
        [DataMember(Name = "has_more", EmitDefaultValue = true)]
        public bool HasMore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetPropertiesResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
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
