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
    /// A reconciliation break
    /// </summary>
    [DataContract(Name = "ReconciliationBreak")]
    public partial class ReconciliationBreak : IEquatable<ReconciliationBreak>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReconciliationBreak" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReconciliationBreak() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReconciliationBreak" /> class.
        /// </summary>
        /// <param name="instrumentUid">Unique instrument identifier (required).</param>
        /// <param name="subHoldingKeys">Any other properties that comprise the Sub-Holding Key (required).</param>
        /// <param name="leftUnits">Units from the left hand side (required).</param>
        /// <param name="rightUnits">Units from the right hand side (required).</param>
        /// <param name="differenceUnits">Difference in units (required).</param>
        /// <param name="leftCost">leftCost (required).</param>
        /// <param name="rightCost">rightCost (required).</param>
        /// <param name="differenceCost">differenceCost (required).</param>
        /// <param name="instrumentProperties">Additional features relating to the instrument (required).</param>
        public ReconciliationBreak(string instrumentUid = default(string), Dictionary<string, PerpetualProperty> subHoldingKeys = default(Dictionary<string, PerpetualProperty>), decimal leftUnits = default(decimal), decimal rightUnits = default(decimal), decimal differenceUnits = default(decimal), CurrencyAndAmount leftCost = default(CurrencyAndAmount), CurrencyAndAmount rightCost = default(CurrencyAndAmount), CurrencyAndAmount differenceCost = default(CurrencyAndAmount), List<Property> instrumentProperties = default(List<Property>))
        {
            // to ensure "instrumentUid" is required (not null)
            this.InstrumentUid = instrumentUid ?? throw new ArgumentNullException("instrumentUid is a required property for ReconciliationBreak and cannot be null");
            // to ensure "subHoldingKeys" is required (not null)
            this.SubHoldingKeys = subHoldingKeys ?? throw new ArgumentNullException("subHoldingKeys is a required property for ReconciliationBreak and cannot be null");
            this.LeftUnits = leftUnits;
            this.RightUnits = rightUnits;
            this.DifferenceUnits = differenceUnits;
            // to ensure "leftCost" is required (not null)
            this.LeftCost = leftCost ?? throw new ArgumentNullException("leftCost is a required property for ReconciliationBreak and cannot be null");
            // to ensure "rightCost" is required (not null)
            this.RightCost = rightCost ?? throw new ArgumentNullException("rightCost is a required property for ReconciliationBreak and cannot be null");
            // to ensure "differenceCost" is required (not null)
            this.DifferenceCost = differenceCost ?? throw new ArgumentNullException("differenceCost is a required property for ReconciliationBreak and cannot be null");
            // to ensure "instrumentProperties" is required (not null)
            this.InstrumentProperties = instrumentProperties ?? throw new ArgumentNullException("instrumentProperties is a required property for ReconciliationBreak and cannot be null");
        }

        /// <summary>
        /// Unique instrument identifier
        /// </summary>
        /// <value>Unique instrument identifier</value>
        [DataMember(Name = "instrumentUid", IsRequired = true, EmitDefaultValue = false)]
        public string InstrumentUid { get; set; }

        /// <summary>
        /// Any other properties that comprise the Sub-Holding Key
        /// </summary>
        /// <value>Any other properties that comprise the Sub-Holding Key</value>
        [DataMember(Name = "subHoldingKeys", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, PerpetualProperty> SubHoldingKeys { get; set; }

        /// <summary>
        /// Units from the left hand side
        /// </summary>
        /// <value>Units from the left hand side</value>
        [DataMember(Name = "leftUnits", IsRequired = true, EmitDefaultValue = true)]
        public decimal LeftUnits { get; set; }

        /// <summary>
        /// Units from the right hand side
        /// </summary>
        /// <value>Units from the right hand side</value>
        [DataMember(Name = "rightUnits", IsRequired = true, EmitDefaultValue = true)]
        public decimal RightUnits { get; set; }

        /// <summary>
        /// Difference in units
        /// </summary>
        /// <value>Difference in units</value>
        [DataMember(Name = "differenceUnits", IsRequired = true, EmitDefaultValue = true)]
        public decimal DifferenceUnits { get; set; }

        /// <summary>
        /// Gets or Sets LeftCost
        /// </summary>
        [DataMember(Name = "leftCost", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount LeftCost { get; set; }

        /// <summary>
        /// Gets or Sets RightCost
        /// </summary>
        [DataMember(Name = "rightCost", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount RightCost { get; set; }

        /// <summary>
        /// Gets or Sets DifferenceCost
        /// </summary>
        [DataMember(Name = "differenceCost", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount DifferenceCost { get; set; }

        /// <summary>
        /// Additional features relating to the instrument
        /// </summary>
        /// <value>Additional features relating to the instrument</value>
        [DataMember(Name = "instrumentProperties", IsRequired = true, EmitDefaultValue = false)]
        public List<Property> InstrumentProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReconciliationBreak {\n");
            sb.Append("  InstrumentUid: ").Append(InstrumentUid).Append("\n");
            sb.Append("  SubHoldingKeys: ").Append(SubHoldingKeys).Append("\n");
            sb.Append("  LeftUnits: ").Append(LeftUnits).Append("\n");
            sb.Append("  RightUnits: ").Append(RightUnits).Append("\n");
            sb.Append("  DifferenceUnits: ").Append(DifferenceUnits).Append("\n");
            sb.Append("  LeftCost: ").Append(LeftCost).Append("\n");
            sb.Append("  RightCost: ").Append(RightCost).Append("\n");
            sb.Append("  DifferenceCost: ").Append(DifferenceCost).Append("\n");
            sb.Append("  InstrumentProperties: ").Append(InstrumentProperties).Append("\n");
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
            return this.Equals(input as ReconciliationBreak);
        }

        /// <summary>
        /// Returns true if ReconciliationBreak instances are equal
        /// </summary>
        /// <param name="input">Instance of ReconciliationBreak to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReconciliationBreak input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstrumentUid == input.InstrumentUid ||
                    (this.InstrumentUid != null &&
                    this.InstrumentUid.Equals(input.InstrumentUid))
                ) && 
                (
                    this.SubHoldingKeys == input.SubHoldingKeys ||
                    this.SubHoldingKeys != null &&
                    input.SubHoldingKeys != null &&
                    this.SubHoldingKeys.SequenceEqual(input.SubHoldingKeys)
                ) && 
                (
                    this.LeftUnits == input.LeftUnits ||
                    this.LeftUnits.Equals(input.LeftUnits)
                ) && 
                (
                    this.RightUnits == input.RightUnits ||
                    this.RightUnits.Equals(input.RightUnits)
                ) && 
                (
                    this.DifferenceUnits == input.DifferenceUnits ||
                    this.DifferenceUnits.Equals(input.DifferenceUnits)
                ) && 
                (
                    this.LeftCost == input.LeftCost ||
                    (this.LeftCost != null &&
                    this.LeftCost.Equals(input.LeftCost))
                ) && 
                (
                    this.RightCost == input.RightCost ||
                    (this.RightCost != null &&
                    this.RightCost.Equals(input.RightCost))
                ) && 
                (
                    this.DifferenceCost == input.DifferenceCost ||
                    (this.DifferenceCost != null &&
                    this.DifferenceCost.Equals(input.DifferenceCost))
                ) && 
                (
                    this.InstrumentProperties == input.InstrumentProperties ||
                    this.InstrumentProperties != null &&
                    input.InstrumentProperties != null &&
                    this.InstrumentProperties.SequenceEqual(input.InstrumentProperties)
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
                if (this.InstrumentUid != null)
                    hashCode = hashCode * 59 + this.InstrumentUid.GetHashCode();
                if (this.SubHoldingKeys != null)
                    hashCode = hashCode * 59 + this.SubHoldingKeys.GetHashCode();
                hashCode = hashCode * 59 + this.LeftUnits.GetHashCode();
                hashCode = hashCode * 59 + this.RightUnits.GetHashCode();
                hashCode = hashCode * 59 + this.DifferenceUnits.GetHashCode();
                if (this.LeftCost != null)
                    hashCode = hashCode * 59 + this.LeftCost.GetHashCode();
                if (this.RightCost != null)
                    hashCode = hashCode * 59 + this.RightCost.GetHashCode();
                if (this.DifferenceCost != null)
                    hashCode = hashCode * 59 + this.DifferenceCost.GetHashCode();
                if (this.InstrumentProperties != null)
                    hashCode = hashCode * 59 + this.InstrumentProperties.GetHashCode();
                return hashCode;
            }
        }

    }
}
