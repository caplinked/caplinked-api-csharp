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
    /// FileViewerImage
    /// </summary>
    [DataContract]
    public partial class FileViewerImage :  IEquatable<FileViewerImage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileViewerImage" /> class.
        /// </summary>
        /// <param name="Status">Status.</param>
        /// <param name="PageNumber">PageNumber.</param>
        /// <param name="ExpiringUrl">ExpiringUrl.</param>
        /// <param name="ExpiringThumbnailUrl">ExpiringThumbnailUrl.</param>
        public FileViewerImage(string Status = default(string), int? PageNumber = default(int?), string ExpiringUrl = default(string), string ExpiringThumbnailUrl = default(string))
        {
            this.Status = Status;
            this.PageNumber = PageNumber;
            this.ExpiringUrl = ExpiringUrl;
            this.ExpiringThumbnailUrl = ExpiringThumbnailUrl;
        }
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name="page_number", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Gets or Sets ExpiringUrl
        /// </summary>
        [DataMember(Name="expiring_url", EmitDefaultValue=false)]
        public string ExpiringUrl { get; set; }

        /// <summary>
        /// Gets or Sets ExpiringThumbnailUrl
        /// </summary>
        [DataMember(Name="expiring_thumbnail_url", EmitDefaultValue=false)]
        public string ExpiringThumbnailUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileViewerImage {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  ExpiringUrl: ").Append(ExpiringUrl).Append("\n");
            sb.Append("  ExpiringThumbnailUrl: ").Append(ExpiringThumbnailUrl).Append("\n");
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
            return this.Equals(obj as FileViewerImage);
        }

        /// <summary>
        /// Returns true if FileViewerImage instances are equal
        /// </summary>
        /// <param name="other">Instance of FileViewerImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileViewerImage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) && 
                (
                    this.ExpiringUrl == other.ExpiringUrl ||
                    this.ExpiringUrl != null &&
                    this.ExpiringUrl.Equals(other.ExpiringUrl)
                ) && 
                (
                    this.ExpiringThumbnailUrl == other.ExpiringThumbnailUrl ||
                    this.ExpiringThumbnailUrl != null &&
                    this.ExpiringThumbnailUrl.Equals(other.ExpiringThumbnailUrl)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                if (this.ExpiringUrl != null)
                    hash = hash * 59 + this.ExpiringUrl.GetHashCode();
                if (this.ExpiringThumbnailUrl != null)
                    hash = hash * 59 + this.ExpiringThumbnailUrl.GetHashCode();
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
