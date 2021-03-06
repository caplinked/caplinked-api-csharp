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
    /// Get status of downloads created by current user within a specified workspace
    /// </summary>
    [DataContract]
    public partial class Meta :  IEquatable<Meta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Meta" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="FileIds">FileIds.</param>
        /// <param name="FolderIds">FolderIds.</param>
        /// <param name="Status">Status.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        public Meta(int? Id = default(int?), int? UserId = default(int?), int? FileIds = default(int?), int? FolderIds = default(int?), string Status = default(string), string CreatedAt = default(string))
        {
            this.Id = Id;
            this.UserId = UserId;
            this.FileIds = FileIds;
            this.FolderIds = FolderIds;
            this.Status = Status;
            this.CreatedAt = CreatedAt;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets FileIds
        /// </summary>
        [DataMember(Name="file_ids", EmitDefaultValue=false)]
        public int? FileIds { get; set; }

        /// <summary>
        /// Gets or Sets FolderIds
        /// </summary>
        [DataMember(Name="folder_ids", EmitDefaultValue=false)]
        public int? FolderIds { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Meta {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  FileIds: ").Append(FileIds).Append("\n");
            sb.Append("  FolderIds: ").Append(FolderIds).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(obj as Meta);
        }

        /// <summary>
        /// Returns true if Meta instances are equal
        /// </summary>
        /// <param name="other">Instance of Meta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Meta other)
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
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.FileIds == other.FileIds ||
                    this.FileIds != null &&
                    this.FileIds.Equals(other.FileIds)
                ) && 
                (
                    this.FolderIds == other.FolderIds ||
                    this.FolderIds != null &&
                    this.FolderIds.Equals(other.FolderIds)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.FileIds != null)
                    hash = hash * 59 + this.FileIds.GetHashCode();
                if (this.FolderIds != null)
                    hash = hash * 59 + this.FolderIds.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
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
