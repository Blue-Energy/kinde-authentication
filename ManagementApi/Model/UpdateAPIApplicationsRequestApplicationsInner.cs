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
using Newtonsoft.Json;

namespace Clinically.Kinde.Authentication.ManagementApi.Model
{
    /// <summary>
    /// UpdateAPIApplicationsRequestApplicationsInner
    /// </summary>
    [DataContract(Name = "updateAPIApplications_request_applications_inner")]
    public partial class UpdateAPIApplicationsRequestApplicationsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAPIApplicationsRequestApplicationsInner" /> class.
        /// </summary>
        [JsonConstructor]
        protected UpdateAPIApplicationsRequestApplicationsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAPIApplicationsRequestApplicationsInner" /> class.
        /// </summary>
        /// <param name="id">The application&#39;s id. (required).</param>
        /// <param name="operation">Optional operation, set to &#39;delete&#39; to remove the user from the organization..</param>
        public UpdateAPIApplicationsRequestApplicationsInner(string id = default(string), string operation = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for UpdateAPIApplicationsRequestApplicationsInner and cannot be null");
            }
            this.Id = id;
            this.Operation = operation;
        }

        /// <summary>
        /// The application&#39;s id.
        /// </summary>
        /// <value>The application&#39;s id.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Optional operation, set to &#39;delete&#39; to remove the user from the organization.
        /// </summary>
        /// <value>Optional operation, set to &#39;delete&#39; to remove the user from the organization.</value>
        [DataMember(Name = "operation", EmitDefaultValue = false)]
        public string Operation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateAPIApplicationsRequestApplicationsInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
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
