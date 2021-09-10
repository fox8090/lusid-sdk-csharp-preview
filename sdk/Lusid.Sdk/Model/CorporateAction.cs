/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3471
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
    /// A corporate action
    /// </summary>
    [DataContract(Name = "CorporateAction")]
    public partial class CorporateAction : IEquatable<CorporateAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorporateAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CorporateAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CorporateAction" /> class.
        /// </summary>
        /// <param name="corporateActionCode">The unique identifier of this corporate action (required).</param>
        /// <param name="description">description.</param>
        /// <param name="announcementDate">The announcement date of the corporate action.</param>
        /// <param name="exDate">The ex date of the corporate action.</param>
        /// <param name="recordDate">The record date of the corporate action.</param>
        /// <param name="paymentDate">The payment date of the corporate action.</param>
        /// <param name="transitions">The transitions that result from this corporate action.</param>
        public CorporateAction(string corporateActionCode = default(string), string description = default(string), DateTimeOffset announcementDate = default(DateTimeOffset), DateTimeOffset exDate = default(DateTimeOffset), DateTimeOffset recordDate = default(DateTimeOffset), DateTimeOffset paymentDate = default(DateTimeOffset), List<CorporateActionTransition> transitions = default(List<CorporateActionTransition>))
        {
            // to ensure "corporateActionCode" is required (not null)
            this.CorporateActionCode = corporateActionCode ?? throw new ArgumentNullException("corporateActionCode is a required property for CorporateAction and cannot be null");
            this.Description = description;
            this.AnnouncementDate = announcementDate;
            this.ExDate = exDate;
            this.RecordDate = recordDate;
            this.PaymentDate = paymentDate;
            this.Transitions = transitions;
        }

        /// <summary>
        /// The unique identifier of this corporate action
        /// </summary>
        /// <value>The unique identifier of this corporate action</value>
        [DataMember(Name = "corporateActionCode", IsRequired = true, EmitDefaultValue = false)]
        public string CorporateActionCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The announcement date of the corporate action
        /// </summary>
        /// <value>The announcement date of the corporate action</value>
        [DataMember(Name = "announcementDate", EmitDefaultValue = false)]
        public DateTimeOffset AnnouncementDate { get; set; }

        /// <summary>
        /// The ex date of the corporate action
        /// </summary>
        /// <value>The ex date of the corporate action</value>
        [DataMember(Name = "exDate", EmitDefaultValue = false)]
        public DateTimeOffset ExDate { get; set; }

        /// <summary>
        /// The record date of the corporate action
        /// </summary>
        /// <value>The record date of the corporate action</value>
        [DataMember(Name = "recordDate", EmitDefaultValue = false)]
        public DateTimeOffset RecordDate { get; set; }

        /// <summary>
        /// The payment date of the corporate action
        /// </summary>
        /// <value>The payment date of the corporate action</value>
        [DataMember(Name = "paymentDate", EmitDefaultValue = false)]
        public DateTimeOffset PaymentDate { get; set; }

        /// <summary>
        /// The transitions that result from this corporate action
        /// </summary>
        /// <value>The transitions that result from this corporate action</value>
        [DataMember(Name = "transitions", EmitDefaultValue = true)]
        public List<CorporateActionTransition> Transitions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorporateAction {\n");
            sb.Append("  CorporateActionCode: ").Append(CorporateActionCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AnnouncementDate: ").Append(AnnouncementDate).Append("\n");
            sb.Append("  ExDate: ").Append(ExDate).Append("\n");
            sb.Append("  RecordDate: ").Append(RecordDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  Transitions: ").Append(Transitions).Append("\n");
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
            return this.Equals(input as CorporateAction);
        }

        /// <summary>
        /// Returns true if CorporateAction instances are equal
        /// </summary>
        /// <param name="input">Instance of CorporateAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorporateAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CorporateActionCode == input.CorporateActionCode ||
                    (this.CorporateActionCode != null &&
                    this.CorporateActionCode.Equals(input.CorporateActionCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AnnouncementDate == input.AnnouncementDate ||
                    (this.AnnouncementDate != null &&
                    this.AnnouncementDate.Equals(input.AnnouncementDate))
                ) && 
                (
                    this.ExDate == input.ExDate ||
                    (this.ExDate != null &&
                    this.ExDate.Equals(input.ExDate))
                ) && 
                (
                    this.RecordDate == input.RecordDate ||
                    (this.RecordDate != null &&
                    this.RecordDate.Equals(input.RecordDate))
                ) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.Transitions == input.Transitions ||
                    this.Transitions != null &&
                    input.Transitions != null &&
                    this.Transitions.SequenceEqual(input.Transitions)
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
                if (this.CorporateActionCode != null)
                    hashCode = hashCode * 59 + this.CorporateActionCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AnnouncementDate != null)
                    hashCode = hashCode * 59 + this.AnnouncementDate.GetHashCode();
                if (this.ExDate != null)
                    hashCode = hashCode * 59 + this.ExDate.GetHashCode();
                if (this.RecordDate != null)
                    hashCode = hashCode * 59 + this.RecordDate.GetHashCode();
                if (this.PaymentDate != null)
                    hashCode = hashCode * 59 + this.PaymentDate.GetHashCode();
                if (this.Transitions != null)
                    hashCode = hashCode * 59 + this.Transitions.GetHashCode();
                return hashCode;
            }
        }

    }
}
