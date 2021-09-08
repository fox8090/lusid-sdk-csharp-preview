/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3463
 * Contact: info@finbourne.com
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
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// CustomEntityIdRequest
    /// </summary>
    [DataContract(Name = "CustomEntityIdRequest")]
    public partial class CustomEntityIdRequest : IEquatable<CustomEntityIdRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEntityIdRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomEntityIdRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEntityIdRequest" /> class.
        /// </summary>
        /// <param name="identifierScope">identifierScope (required).</param>
        /// <param name="identifierType">identifierType (required).</param>
        /// <param name="identifierValue">identifierValue (required).</param>
        public CustomEntityIdRequest(string identifierScope = default(string), string identifierType = default(string), string identifierValue = default(string))
        {
            // to ensure "identifierScope" is required (not null)
            this.IdentifierScope = identifierScope ?? throw new ArgumentNullException("identifierScope is a required property for CustomEntityIdRequest and cannot be null");
            // to ensure "identifierType" is required (not null)
            this.IdentifierType = identifierType ?? throw new ArgumentNullException("identifierType is a required property for CustomEntityIdRequest and cannot be null");
            // to ensure "identifierValue" is required (not null)
            this.IdentifierValue = identifierValue ?? throw new ArgumentNullException("identifierValue is a required property for CustomEntityIdRequest and cannot be null");
        }

        /// <summary>
        /// Gets or Sets IdentifierScope
        /// </summary>
        [DataMember(Name = "identifierScope", IsRequired = true, EmitDefaultValue = false)]
        public string IdentifierScope { get; set; }

        /// <summary>
        /// Gets or Sets IdentifierType
        /// </summary>
        [DataMember(Name = "identifierType", IsRequired = true, EmitDefaultValue = false)]
        public string IdentifierType { get; set; }

        /// <summary>
        /// Gets or Sets IdentifierValue
        /// </summary>
        [DataMember(Name = "identifierValue", IsRequired = true, EmitDefaultValue = false)]
        public string IdentifierValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomEntityIdRequest {\n");
            sb.Append("  IdentifierScope: ").Append(IdentifierScope).Append("\n");
            sb.Append("  IdentifierType: ").Append(IdentifierType).Append("\n");
            sb.Append("  IdentifierValue: ").Append(IdentifierValue).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomEntityIdRequest);
        }

        /// <summary>
        /// Returns true if CustomEntityIdRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomEntityIdRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomEntityIdRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentifierScope == input.IdentifierScope ||
                    (this.IdentifierScope != null &&
                    this.IdentifierScope.Equals(input.IdentifierScope))
                ) && 
                (
                    this.IdentifierType == input.IdentifierType ||
                    (this.IdentifierType != null &&
                    this.IdentifierType.Equals(input.IdentifierType))
                ) && 
                (
                    this.IdentifierValue == input.IdentifierValue ||
                    (this.IdentifierValue != null &&
                    this.IdentifierValue.Equals(input.IdentifierValue))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IdentifierScope != null)
                    hashCode = hashCode * 59 + this.IdentifierScope.GetHashCode();
                if (this.IdentifierType != null)
                    hashCode = hashCode * 59 + this.IdentifierType.GetHashCode();
                if (this.IdentifierValue != null)
                    hashCode = hashCode * 59 + this.IdentifierValue.GetHashCode();
                return hashCode;
            }
        }

    }
}
