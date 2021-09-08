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
    /// A list of holdings.
    /// </summary>
    [DataContract(Name = "PortfolioHolding")]
    public partial class PortfolioHolding : IEquatable<PortfolioHolding>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioHolding" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PortfolioHolding() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioHolding" /> class.
        /// </summary>
        /// <param name="instrumentUid">The unique Lusid Instrument Id (LUID) of the instrument that the holding is in. (required).</param>
        /// <param name="subHoldingKeys">The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured when a transaction portfolio is created..</param>
        /// <param name="properties">The properties which have been requested to be decorated onto the holding. These will be from the &#39;Instrument&#39; or &#39;Holding&#39; domain..</param>
        /// <param name="holdingType">The type of the holding e.g. Position, Balance, CashCommitment, Receivable, ForwardFX etc. (required).</param>
        /// <param name="units">The total number of units of the holding. (required).</param>
        /// <param name="settledUnits">The total number of settled units of the holding. (required).</param>
        /// <param name="cost">cost (required).</param>
        /// <param name="costPortfolioCcy">costPortfolioCcy (required).</param>
        /// <param name="transaction">transaction.</param>
        /// <param name="currency">The holding currency..</param>
        public PortfolioHolding(string instrumentUid = default(string), Dictionary<string, PerpetualProperty> subHoldingKeys = default(Dictionary<string, PerpetualProperty>), Dictionary<string, Property> properties = default(Dictionary<string, Property>), string holdingType = default(string), decimal units = default(decimal), decimal settledUnits = default(decimal), CurrencyAndAmount cost = default(CurrencyAndAmount), CurrencyAndAmount costPortfolioCcy = default(CurrencyAndAmount), Transaction transaction = default(Transaction), string currency = default(string))
        {
            // to ensure "instrumentUid" is required (not null)
            this.InstrumentUid = instrumentUid ?? throw new ArgumentNullException("instrumentUid is a required property for PortfolioHolding and cannot be null");
            // to ensure "holdingType" is required (not null)
            this.HoldingType = holdingType ?? throw new ArgumentNullException("holdingType is a required property for PortfolioHolding and cannot be null");
            this.Units = units;
            this.SettledUnits = settledUnits;
            // to ensure "cost" is required (not null)
            this.Cost = cost ?? throw new ArgumentNullException("cost is a required property for PortfolioHolding and cannot be null");
            // to ensure "costPortfolioCcy" is required (not null)
            this.CostPortfolioCcy = costPortfolioCcy ?? throw new ArgumentNullException("costPortfolioCcy is a required property for PortfolioHolding and cannot be null");
            this.SubHoldingKeys = subHoldingKeys;
            this.Properties = properties;
            this.Transaction = transaction;
            this.Currency = currency;
        }

        /// <summary>
        /// The unique Lusid Instrument Id (LUID) of the instrument that the holding is in.
        /// </summary>
        /// <value>The unique Lusid Instrument Id (LUID) of the instrument that the holding is in.</value>
        [DataMember(Name = "instrumentUid", IsRequired = true, EmitDefaultValue = false)]
        public string InstrumentUid { get; set; }

        /// <summary>
        /// The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured when a transaction portfolio is created.
        /// </summary>
        /// <value>The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured when a transaction portfolio is created.</value>
        [DataMember(Name = "subHoldingKeys", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> SubHoldingKeys { get; set; }

        /// <summary>
        /// The properties which have been requested to be decorated onto the holding. These will be from the &#39;Instrument&#39; or &#39;Holding&#39; domain.
        /// </summary>
        /// <value>The properties which have been requested to be decorated onto the holding. These will be from the &#39;Instrument&#39; or &#39;Holding&#39; domain.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, Property> Properties { get; set; }

        /// <summary>
        /// The type of the holding e.g. Position, Balance, CashCommitment, Receivable, ForwardFX etc.
        /// </summary>
        /// <value>The type of the holding e.g. Position, Balance, CashCommitment, Receivable, ForwardFX etc.</value>
        [DataMember(Name = "holdingType", IsRequired = true, EmitDefaultValue = false)]
        public string HoldingType { get; set; }

        /// <summary>
        /// The total number of units of the holding.
        /// </summary>
        /// <value>The total number of units of the holding.</value>
        [DataMember(Name = "units", IsRequired = true, EmitDefaultValue = true)]
        public decimal Units { get; set; }

        /// <summary>
        /// The total number of settled units of the holding.
        /// </summary>
        /// <value>The total number of settled units of the holding.</value>
        [DataMember(Name = "settledUnits", IsRequired = true, EmitDefaultValue = true)]
        public decimal SettledUnits { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name = "cost", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount Cost { get; set; }

        /// <summary>
        /// Gets or Sets CostPortfolioCcy
        /// </summary>
        [DataMember(Name = "costPortfolioCcy", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount CostPortfolioCcy { get; set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public Transaction Transaction { get; set; }

        /// <summary>
        /// The holding currency.
        /// </summary>
        /// <value>The holding currency.</value>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortfolioHolding {\n");
            sb.Append("  InstrumentUid: ").Append(InstrumentUid).Append("\n");
            sb.Append("  SubHoldingKeys: ").Append(SubHoldingKeys).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  HoldingType: ").Append(HoldingType).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  SettledUnits: ").Append(SettledUnits).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  CostPortfolioCcy: ").Append(CostPortfolioCcy).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(input as PortfolioHolding);
        }

        /// <summary>
        /// Returns true if PortfolioHolding instances are equal
        /// </summary>
        /// <param name="input">Instance of PortfolioHolding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortfolioHolding input)
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
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.HoldingType == input.HoldingType ||
                    (this.HoldingType != null &&
                    this.HoldingType.Equals(input.HoldingType))
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
                ) && 
                (
                    this.SettledUnits == input.SettledUnits ||
                    this.SettledUnits.Equals(input.SettledUnits)
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.CostPortfolioCcy == input.CostPortfolioCcy ||
                    (this.CostPortfolioCcy != null &&
                    this.CostPortfolioCcy.Equals(input.CostPortfolioCcy))
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
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
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.HoldingType != null)
                    hashCode = hashCode * 59 + this.HoldingType.GetHashCode();
                hashCode = hashCode * 59 + this.Units.GetHashCode();
                hashCode = hashCode * 59 + this.SettledUnits.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.CostPortfolioCcy != null)
                    hashCode = hashCode * 59 + this.CostPortfolioCcy.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                return hashCode;
            }
        }

    }
}
