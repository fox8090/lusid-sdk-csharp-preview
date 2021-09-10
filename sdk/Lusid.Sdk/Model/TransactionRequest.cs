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
    /// TransactionRequest
    /// </summary>
    [DataContract(Name = "TransactionRequest")]
    public partial class TransactionRequest : IEquatable<TransactionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRequest" /> class.
        /// </summary>
        /// <param name="transactionId">The unique identifier of the transaction. (required).</param>
        /// <param name="type">The type of the transaction, for example &#39;Buy&#39; or &#39;Sell&#39;. The transaction type must have been pre-configured using the System Configuration API. If not, this operation will succeed but you are not able to calculate holdings for the portfolio that include this transaction. (required).</param>
        /// <param name="instrumentIdentifiers">A set of instrument identifiers that can resolve the transaction to a unique instrument. (required).</param>
        /// <param name="transactionDate">The date of the transaction. (required).</param>
        /// <param name="settlementDate">The settlement date of the transaction. (required).</param>
        /// <param name="units">The number of units of the transacted instrument. (required).</param>
        /// <param name="transactionPrice">transactionPrice.</param>
        /// <param name="totalConsideration">totalConsideration (required).</param>
        /// <param name="exchangeRate">The exchange rate between the transaction and settlement currency (settlement currency being represented by TotalConsideration.Currency). For example, if the transaction currency is USD and the settlement currency is GBP, this would be the appropriate USD/GBP rate..</param>
        /// <param name="transactionCurrency">The transaction currency..</param>
        /// <param name="properties">A list of unique transaction properties and associated values to store for the transaction. Each property must be from the &#39;Transaction&#39; domain..</param>
        /// <param name="counterpartyId">The identifier for the counterparty of the transaction..</param>
        /// <param name="source">The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration..</param>
        public TransactionRequest(string transactionId = default(string), string type = default(string), Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), DateTimeOrCutLabel transactionDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel settlementDate = default(DateTimeOrCutLabel), decimal units = default(decimal), TransactionPrice transactionPrice = default(TransactionPrice), CurrencyAndAmount totalConsideration = default(CurrencyAndAmount), decimal? exchangeRate = default(decimal?), string transactionCurrency = default(string), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), string counterpartyId = default(string), string source = default(string))
        {
            // to ensure "transactionId" is required (not null)
            this.TransactionId = transactionId ?? throw new ArgumentNullException("transactionId is a required property for TransactionRequest and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for TransactionRequest and cannot be null");
            // to ensure "instrumentIdentifiers" is required (not null)
            this.InstrumentIdentifiers = instrumentIdentifiers ?? throw new ArgumentNullException("instrumentIdentifiers is a required property for TransactionRequest and cannot be null");
            // to ensure "transactionDate" is required (not null)
            this.TransactionDate = transactionDate ?? throw new ArgumentNullException("transactionDate is a required property for TransactionRequest and cannot be null");
            // to ensure "settlementDate" is required (not null)
            this.SettlementDate = settlementDate ?? throw new ArgumentNullException("settlementDate is a required property for TransactionRequest and cannot be null");
            this.Units = units;
            // to ensure "totalConsideration" is required (not null)
            this.TotalConsideration = totalConsideration ?? throw new ArgumentNullException("totalConsideration is a required property for TransactionRequest and cannot be null");
            this.TransactionPrice = transactionPrice;
            this.ExchangeRate = exchangeRate;
            this.TransactionCurrency = transactionCurrency;
            this.Properties = properties;
            this.CounterpartyId = counterpartyId;
            this.Source = source;
        }

        /// <summary>
        /// The unique identifier of the transaction.
        /// </summary>
        /// <value>The unique identifier of the transaction.</value>
        [DataMember(Name = "transactionId", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// The type of the transaction, for example &#39;Buy&#39; or &#39;Sell&#39;. The transaction type must have been pre-configured using the System Configuration API. If not, this operation will succeed but you are not able to calculate holdings for the portfolio that include this transaction.
        /// </summary>
        /// <value>The type of the transaction, for example &#39;Buy&#39; or &#39;Sell&#39;. The transaction type must have been pre-configured using the System Configuration API. If not, this operation will succeed but you are not able to calculate holdings for the portfolio that include this transaction.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// A set of instrument identifiers that can resolve the transaction to a unique instrument.
        /// </summary>
        /// <value>A set of instrument identifiers that can resolve the transaction to a unique instrument.</value>
        [DataMember(Name = "instrumentIdentifiers", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// The date of the transaction.
        /// </summary>
        /// <value>The date of the transaction.</value>
        [DataMember(Name = "transactionDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOrCutLabel TransactionDate { get; set; }

        /// <summary>
        /// The settlement date of the transaction.
        /// </summary>
        /// <value>The settlement date of the transaction.</value>
        [DataMember(Name = "settlementDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOrCutLabel SettlementDate { get; set; }

        /// <summary>
        /// The number of units of the transacted instrument.
        /// </summary>
        /// <value>The number of units of the transacted instrument.</value>
        [DataMember(Name = "units", IsRequired = true, EmitDefaultValue = true)]
        public decimal Units { get; set; }

        /// <summary>
        /// Gets or Sets TransactionPrice
        /// </summary>
        [DataMember(Name = "transactionPrice", EmitDefaultValue = false)]
        public TransactionPrice TransactionPrice { get; set; }

        /// <summary>
        /// Gets or Sets TotalConsideration
        /// </summary>
        [DataMember(Name = "totalConsideration", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount TotalConsideration { get; set; }

        /// <summary>
        /// The exchange rate between the transaction and settlement currency (settlement currency being represented by TotalConsideration.Currency). For example, if the transaction currency is USD and the settlement currency is GBP, this would be the appropriate USD/GBP rate.
        /// </summary>
        /// <value>The exchange rate between the transaction and settlement currency (settlement currency being represented by TotalConsideration.Currency). For example, if the transaction currency is USD and the settlement currency is GBP, this would be the appropriate USD/GBP rate.</value>
        [DataMember(Name = "exchangeRate", EmitDefaultValue = true)]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// The transaction currency.
        /// </summary>
        /// <value>The transaction currency.</value>
        [DataMember(Name = "transactionCurrency", EmitDefaultValue = true)]
        public string TransactionCurrency { get; set; }

        /// <summary>
        /// A list of unique transaction properties and associated values to store for the transaction. Each property must be from the &#39;Transaction&#39; domain.
        /// </summary>
        /// <value>A list of unique transaction properties and associated values to store for the transaction. Each property must be from the &#39;Transaction&#39; domain.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// The identifier for the counterparty of the transaction.
        /// </summary>
        /// <value>The identifier for the counterparty of the transaction.</value>
        [DataMember(Name = "counterpartyId", EmitDefaultValue = true)]
        public string CounterpartyId { get; set; }

        /// <summary>
        /// The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration.
        /// </summary>
        /// <value>The source of the transaction. This is used to look up the appropriate transaction group set in the transaction type configuration.</value>
        [DataMember(Name = "source", EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionRequest {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  TransactionPrice: ").Append(TransactionPrice).Append("\n");
            sb.Append("  TotalConsideration: ").Append(TotalConsideration).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  TransactionCurrency: ").Append(TransactionCurrency).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  CounterpartyId: ").Append(CounterpartyId).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as TransactionRequest);
        }

        /// <summary>
        /// Returns true if TransactionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.SettlementDate == input.SettlementDate ||
                    (this.SettlementDate != null &&
                    this.SettlementDate.Equals(input.SettlementDate))
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
                ) && 
                (
                    this.TransactionPrice == input.TransactionPrice ||
                    (this.TransactionPrice != null &&
                    this.TransactionPrice.Equals(input.TransactionPrice))
                ) && 
                (
                    this.TotalConsideration == input.TotalConsideration ||
                    (this.TotalConsideration != null &&
                    this.TotalConsideration.Equals(input.TotalConsideration))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
                ) && 
                (
                    this.TransactionCurrency == input.TransactionCurrency ||
                    (this.TransactionCurrency != null &&
                    this.TransactionCurrency.Equals(input.TransactionCurrency))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.CounterpartyId == input.CounterpartyId ||
                    (this.CounterpartyId != null &&
                    this.CounterpartyId.Equals(input.CounterpartyId))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.InstrumentIdentifiers != null)
                    hashCode = hashCode * 59 + this.InstrumentIdentifiers.GetHashCode();
                if (this.TransactionDate != null)
                    hashCode = hashCode * 59 + this.TransactionDate.GetHashCode();
                if (this.SettlementDate != null)
                    hashCode = hashCode * 59 + this.SettlementDate.GetHashCode();
                hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.TransactionPrice != null)
                    hashCode = hashCode * 59 + this.TransactionPrice.GetHashCode();
                if (this.TotalConsideration != null)
                    hashCode = hashCode * 59 + this.TotalConsideration.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.TransactionCurrency != null)
                    hashCode = hashCode * 59 + this.TransactionCurrency.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.CounterpartyId != null)
                    hashCode = hashCode * 59 + this.CounterpartyId.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                return hashCode;
            }
        }

    }
}
