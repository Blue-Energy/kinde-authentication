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
    /// AddOrganizationUsersRequest
    /// </summary>
    [DataContract(Name = "AddOrganizationUsers_request")]
    public partial class AddOrganizationUsersRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrganizationUsersRequest" /> class.
        /// </summary>
        /// <param name="users">Users to be added to the organization..</param>
        public AddOrganizationUsersRequest(List<AddOrganizationUsersRequestUsersInner> users = default(List<AddOrganizationUsersRequestUsersInner>))
        {
            this.Users = users;
        }

        /// <summary>
        /// Users to be added to the organization.
        /// </summary>
        /// <value>Users to be added to the organization.</value>
        [DataMember(Name = "users", EmitDefaultValue = false)]
        public List<AddOrganizationUsersRequestUsersInner> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddOrganizationUsersRequest {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
