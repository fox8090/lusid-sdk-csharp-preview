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
    /// CorporateActionTransitionComponentRequest
    /// </summary>
    [DataContract(Name = "CorporateActionTransitionComponentRequest")]
    public partial class CorporateActionTransitionComponentRequest : IEquatable<CorporateActionTransitionComponentRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorporateActionTransitionComponentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CorporateActionTransitionComponentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CorporateActionTransitionComponentRequest" /> class.
        /// </summary>
        /// <param name="instrumentIdentifiers">Unique instrument identifiers (required).</param>
        /// <param name="unitsFactor">unitsFactor (required).</param>
        /// <param name="costFactor">costFactor (required).</param>
        public CorporateActionTransitionComponentRequest(Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), decimal unitsFactor = default(decimal), decimal costFactor = default(decimal))
        {
            // to ensure "instrumentIdentifiers" is required (not null)
            this.InstrumentIdentifiers = instrumentIdentifiers ?? throw new ArgumentNullException("instrumentIdentifiers is a required property for CorporateActionTransitionComponentRequest and cannot be null");
            this.UnitsFactor = unitsFactor;
            this.CostFactor = costFactor;
        }

        /// <summary>
        /// Unique instrument identifiers
        /// </summary>
        /// <value>Unique instrument identifiers</value>
        [DataMember(Name = "instrumentIdentifiers", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// Gets or Sets UnitsFactor
        /// </summary>
        [DataMember(Name = "unitsFactor", IsRequired = true, EmitDefaultValue = true)]
        public decimal UnitsFactor { get; set; }

        /// <summary>
        /// Gets or Sets CostFactor
        /// </summary>
        [DataMember(Name = "costFactor", IsRequired = true, EmitDefaultValue = true)]
        public decimal CostFactor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorporateActionTransitionComponentRequest {\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  UnitsFactor: ").Append(UnitsFactor).Append("\n");
            sb.Append("  CostFactor: ").Append(CostFactor).Append("\n");
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
            return this.Equals(input as CorporateActionTransitionComponentRequest);
        }

        /// <summary>
        /// Returns true if CorporateActionTransitionComponentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CorporateActionTransitionComponentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorporateActionTransitionComponentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.UnitsFactor == input.UnitsFactor ||
                    this.UnitsFactor.Equals(input.UnitsFactor)
                ) && 
                (
                    this.CostFactor == input.CostFactor ||
                    this.CostFactor.Equals(input.CostFactor)
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
                if (this.InstrumentIdentifiers != null)
                    hashCode = hashCode * 59 + this.InstrumentIdentifiers.GetHashCode();
                hashCode = hashCode * 59 + this.UnitsFactor.GetHashCode();
                hashCode = hashCode * 59 + this.CostFactor.GetHashCode();
                return hashCode;
            }
        }

    }
}
