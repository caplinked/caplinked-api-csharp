/* 
 * CapLinked API v1.0
 *
 * Core information security endpoints for managing files/folders, users/groups, uploads/downloads, and more.
 *
 * OpenAPI spec version: 2017-05-23
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Caplinked.Client.SwaggerDateConverter;

namespace Caplinked.Model
{
    /// <summary>
    /// Update organization information
    /// </summary>
    [DataContract]
    public partial class Organization :  IEquatable<Organization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Location">Location.</param>
        /// <param name="BillingEmail">BillingEmail.</param>
        /// <param name="Url">Url.</param>
        /// <param name="SupportNumber">SupportNumber.</param>
        /// <param name="SupportEmail">SupportEmail.</param>
        /// <param name="SupportWebsite">SupportWebsite.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        public Organization(int? Id = default(int?), string Name = default(string), string Description = default(string), string Location = default(string), string BillingEmail = default(string), string Url = default(string), string SupportNumber = default(string), string SupportEmail = default(string), string SupportWebsite = default(string), string CreatedAt = default(string), string UpdatedAt = default(string))
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Location = Location;
            this.BillingEmail = BillingEmail;
            this.Url = Url;
            this.SupportNumber = SupportNumber;
            this.SupportEmail = SupportEmail;
            this.SupportWebsite = SupportWebsite;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets BillingEmail
        /// </summary>
        [DataMember(Name="billing_email", EmitDefaultValue=false)]
        public string BillingEmail { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets SupportNumber
        /// </summary>
        [DataMember(Name="support_number", EmitDefaultValue=false)]
        public string SupportNumber { get; set; }

        /// <summary>
        /// Gets or Sets SupportEmail
        /// </summary>
        [DataMember(Name="support_email", EmitDefaultValue=false)]
        public string SupportEmail { get; set; }

        /// <summary>
        /// Gets or Sets SupportWebsite
        /// </summary>
        [DataMember(Name="support_website", EmitDefaultValue=false)]
        public string SupportWebsite { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Organization {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  BillingEmail: ").Append(BillingEmail).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  SupportNumber: ").Append(SupportNumber).Append("\n");
            sb.Append("  SupportEmail: ").Append(SupportEmail).Append("\n");
            sb.Append("  SupportWebsite: ").Append(SupportWebsite).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Organization);
        }

        /// <summary>
        /// Returns true if Organization instances are equal
        /// </summary>
        /// <param name="other">Instance of Organization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Organization other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.BillingEmail == other.BillingEmail ||
                    this.BillingEmail != null &&
                    this.BillingEmail.Equals(other.BillingEmail)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.SupportNumber == other.SupportNumber ||
                    this.SupportNumber != null &&
                    this.SupportNumber.Equals(other.SupportNumber)
                ) && 
                (
                    this.SupportEmail == other.SupportEmail ||
                    this.SupportEmail != null &&
                    this.SupportEmail.Equals(other.SupportEmail)
                ) && 
                (
                    this.SupportWebsite == other.SupportWebsite ||
                    this.SupportWebsite != null &&
                    this.SupportWebsite.Equals(other.SupportWebsite)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.BillingEmail != null)
                    hash = hash * 59 + this.BillingEmail.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.SupportNumber != null)
                    hash = hash * 59 + this.SupportNumber.GetHashCode();
                if (this.SupportEmail != null)
                    hash = hash * 59 + this.SupportEmail.GetHashCode();
                if (this.SupportWebsite != null)
                    hash = hash * 59 + this.SupportWebsite.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
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
