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
    /// EquityOptionAllOf
    /// </summary>
    [DataContract(Name = "EquityOption_allOf")]
    public partial class EquityOptionAllOf : IEquatable<EquityOptionAllOf>
    {
        /// <summary>
        /// The available values are: Cash, Physical
        /// </summary>
        /// <value>The available values are: Cash, Physical</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryTypeEnum
        {
            /// <summary>
            /// Enum Cash for value: Cash
            /// </summary>
            [EnumMember(Value = "Cash")]
            Cash = 1,

            /// <summary>
            /// Enum Physical for value: Physical
            /// </summary>
            [EnumMember(Value = "Physical")]
            Physical = 2

        }


        /// <summary>
        /// The available values are: Cash, Physical
        /// </summary>
        /// <value>The available values are: Cash, Physical</value>
        [DataMember(Name = "deliveryType", IsRequired = true, EmitDefaultValue = false)]
        public DeliveryTypeEnum DeliveryType { get; set; }
        /// <summary>
        /// The available values are: None, Call, Put
        /// </summary>
        /// <value>The available values are: None, Call, Put</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OptionTypeEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,

            /// <summary>
            /// Enum Call for value: Call
            /// </summary>
            [EnumMember(Value = "Call")]
            Call = 2,

            /// <summary>
            /// Enum Put for value: Put
            /// </summary>
            [EnumMember(Value = "Put")]
            Put = 3

        }


        /// <summary>
        /// The available values are: None, Call, Put
        /// </summary>
        /// <value>The available values are: None, Call, Put</value>
        [DataMember(Name = "optionType", IsRequired = true, EmitDefaultValue = false)]
        public OptionTypeEnum OptionType { get; set; }
        /// <summary>
        /// The available values are: LusidInstrumentId, Isin, Sedol, Cusip, ClientInternal, Figi, RIC, QuotePermId, REDCode, BBGId, ICECode
        /// </summary>
        /// <value>The available values are: LusidInstrumentId, Isin, Sedol, Cusip, ClientInternal, Figi, RIC, QuotePermId, REDCode, BBGId, ICECode</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnderlyingIdentifierEnum
        {
            /// <summary>
            /// Enum LusidInstrumentId for value: LusidInstrumentId
            /// </summary>
            [EnumMember(Value = "LusidInstrumentId")]
            LusidInstrumentId = 1,

            /// <summary>
            /// Enum Isin for value: Isin
            /// </summary>
            [EnumMember(Value = "Isin")]
            Isin = 2,

            /// <summary>
            /// Enum Sedol for value: Sedol
            /// </summary>
            [EnumMember(Value = "Sedol")]
            Sedol = 3,

            /// <summary>
            /// Enum Cusip for value: Cusip
            /// </summary>
            [EnumMember(Value = "Cusip")]
            Cusip = 4,

            /// <summary>
            /// Enum ClientInternal for value: ClientInternal
            /// </summary>
            [EnumMember(Value = "ClientInternal")]
            ClientInternal = 5,

            /// <summary>
            /// Enum Figi for value: Figi
            /// </summary>
            [EnumMember(Value = "Figi")]
            Figi = 6,

            /// <summary>
            /// Enum RIC for value: RIC
            /// </summary>
            [EnumMember(Value = "RIC")]
            RIC = 7,

            /// <summary>
            /// Enum QuotePermId for value: QuotePermId
            /// </summary>
            [EnumMember(Value = "QuotePermId")]
            QuotePermId = 8,

            /// <summary>
            /// Enum REDCode for value: REDCode
            /// </summary>
            [EnumMember(Value = "REDCode")]
            REDCode = 9,

            /// <summary>
            /// Enum BBGId for value: BBGId
            /// </summary>
            [EnumMember(Value = "BBGId")]
            BBGId = 10,

            /// <summary>
            /// Enum ICECode for value: ICECode
            /// </summary>
            [EnumMember(Value = "ICECode")]
            ICECode = 11

        }


        /// <summary>
        /// The available values are: LusidInstrumentId, Isin, Sedol, Cusip, ClientInternal, Figi, RIC, QuotePermId, REDCode, BBGId, ICECode
        /// </summary>
        /// <value>The available values are: LusidInstrumentId, Isin, Sedol, Cusip, ClientInternal, Figi, RIC, QuotePermId, REDCode, BBGId, ICECode</value>
        [DataMember(Name = "underlyingIdentifier", IsRequired = true, EmitDefaultValue = false)]
        public UnderlyingIdentifierEnum UnderlyingIdentifier { get; set; }
        /// <summary>
        /// The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CashSettled, CdsIndex, Basket, FundingLeg, CrossCurrencySwap, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo
        /// </summary>
        /// <value>The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CashSettled, CdsIndex, Basket, FundingLeg, CrossCurrencySwap, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InstrumentTypeEnum
        {
            /// <summary>
            /// Enum QuotedSecurity for value: QuotedSecurity
            /// </summary>
            [EnumMember(Value = "QuotedSecurity")]
            QuotedSecurity = 1,

            /// <summary>
            /// Enum InterestRateSwap for value: InterestRateSwap
            /// </summary>
            [EnumMember(Value = "InterestRateSwap")]
            InterestRateSwap = 2,

            /// <summary>
            /// Enum FxForward for value: FxForward
            /// </summary>
            [EnumMember(Value = "FxForward")]
            FxForward = 3,

            /// <summary>
            /// Enum Future for value: Future
            /// </summary>
            [EnumMember(Value = "Future")]
            Future = 4,

            /// <summary>
            /// Enum ExoticInstrument for value: ExoticInstrument
            /// </summary>
            [EnumMember(Value = "ExoticInstrument")]
            ExoticInstrument = 5,

            /// <summary>
            /// Enum FxOption for value: FxOption
            /// </summary>
            [EnumMember(Value = "FxOption")]
            FxOption = 6,

            /// <summary>
            /// Enum CreditDefaultSwap for value: CreditDefaultSwap
            /// </summary>
            [EnumMember(Value = "CreditDefaultSwap")]
            CreditDefaultSwap = 7,

            /// <summary>
            /// Enum InterestRateSwaption for value: InterestRateSwaption
            /// </summary>
            [EnumMember(Value = "InterestRateSwaption")]
            InterestRateSwaption = 8,

            /// <summary>
            /// Enum Bond for value: Bond
            /// </summary>
            [EnumMember(Value = "Bond")]
            Bond = 9,

            /// <summary>
            /// Enum EquityOption for value: EquityOption
            /// </summary>
            [EnumMember(Value = "EquityOption")]
            EquityOption = 10,

            /// <summary>
            /// Enum FixedLeg for value: FixedLeg
            /// </summary>
            [EnumMember(Value = "FixedLeg")]
            FixedLeg = 11,

            /// <summary>
            /// Enum FloatingLeg for value: FloatingLeg
            /// </summary>
            [EnumMember(Value = "FloatingLeg")]
            FloatingLeg = 12,

            /// <summary>
            /// Enum BespokeCashFlowsLeg for value: BespokeCashFlowsLeg
            /// </summary>
            [EnumMember(Value = "BespokeCashFlowsLeg")]
            BespokeCashFlowsLeg = 13,

            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 14,

            /// <summary>
            /// Enum TermDeposit for value: TermDeposit
            /// </summary>
            [EnumMember(Value = "TermDeposit")]
            TermDeposit = 15,

            /// <summary>
            /// Enum ContractForDifference for value: ContractForDifference
            /// </summary>
            [EnumMember(Value = "ContractForDifference")]
            ContractForDifference = 16,

            /// <summary>
            /// Enum EquitySwap for value: EquitySwap
            /// </summary>
            [EnumMember(Value = "EquitySwap")]
            EquitySwap = 17,

            /// <summary>
            /// Enum CashPerpetual for value: CashPerpetual
            /// </summary>
            [EnumMember(Value = "CashPerpetual")]
            CashPerpetual = 18,

            /// <summary>
            /// Enum CashSettled for value: CashSettled
            /// </summary>
            [EnumMember(Value = "CashSettled")]
            CashSettled = 19,

            /// <summary>
            /// Enum CdsIndex for value: CdsIndex
            /// </summary>
            [EnumMember(Value = "CdsIndex")]
            CdsIndex = 20,

            /// <summary>
            /// Enum Basket for value: Basket
            /// </summary>
            [EnumMember(Value = "Basket")]
            Basket = 21,

            /// <summary>
            /// Enum FundingLeg for value: FundingLeg
            /// </summary>
            [EnumMember(Value = "FundingLeg")]
            FundingLeg = 22,

            /// <summary>
            /// Enum CrossCurrencySwap for value: CrossCurrencySwap
            /// </summary>
            [EnumMember(Value = "CrossCurrencySwap")]
            CrossCurrencySwap = 23,

            /// <summary>
            /// Enum FxSwap for value: FxSwap
            /// </summary>
            [EnumMember(Value = "FxSwap")]
            FxSwap = 24,

            /// <summary>
            /// Enum ForwardRateAgreement for value: ForwardRateAgreement
            /// </summary>
            [EnumMember(Value = "ForwardRateAgreement")]
            ForwardRateAgreement = 25,

            /// <summary>
            /// Enum SimpleInstrument for value: SimpleInstrument
            /// </summary>
            [EnumMember(Value = "SimpleInstrument")]
            SimpleInstrument = 26,

            /// <summary>
            /// Enum Repo for value: Repo
            /// </summary>
            [EnumMember(Value = "Repo")]
            Repo = 27

        }


        /// <summary>
        /// The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CashSettled, CdsIndex, Basket, FundingLeg, CrossCurrencySwap, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo
        /// </summary>
        /// <value>The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CashSettled, CdsIndex, Basket, FundingLeg, CrossCurrencySwap, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo</value>
        [DataMember(Name = "instrumentType", IsRequired = true, EmitDefaultValue = false)]
        public InstrumentTypeEnum InstrumentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EquityOptionAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EquityOptionAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EquityOptionAllOf" /> class.
        /// </summary>
        /// <param name="startDate">The start date of the instrument. This is normally synonymous with the trade-date. (required).</param>
        /// <param name="optionMaturityDate">The maturity date of the option. (required).</param>
        /// <param name="optionSettlementDate">The settlement date of the option. (required).</param>
        /// <param name="deliveryType">The available values are: Cash, Physical (required).</param>
        /// <param name="optionType">The available values are: None, Call, Put (required).</param>
        /// <param name="strike">The strike of the option. (required).</param>
        /// <param name="domCcy">The domestic currency of the instrument. (required).</param>
        /// <param name="underlyingIdentifier">The available values are: LusidInstrumentId, Isin, Sedol, Cusip, ClientInternal, Figi, RIC, QuotePermId, REDCode, BBGId, ICECode (required).</param>
        /// <param name="code">The identifying code for the equity underlying, e.g. &#39;IBM.N&#39;. (required).</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CashSettled, CdsIndex, Basket, FundingLeg, CrossCurrencySwap, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo (required).</param>
        public EquityOptionAllOf(DateTimeOffset startDate = default(DateTimeOffset), DateTimeOffset optionMaturityDate = default(DateTimeOffset), DateTimeOffset optionSettlementDate = default(DateTimeOffset), DeliveryTypeEnum deliveryType = default(DeliveryTypeEnum), OptionTypeEnum optionType = default(OptionTypeEnum), decimal strike = default(decimal), string domCcy = default(string), UnderlyingIdentifierEnum underlyingIdentifier = default(UnderlyingIdentifierEnum), string code = default(string), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum))
        {
            this.StartDate = startDate;
            this.OptionMaturityDate = optionMaturityDate;
            this.OptionSettlementDate = optionSettlementDate;
            this.DeliveryType = deliveryType;
            this.OptionType = optionType;
            this.Strike = strike;
            // to ensure "domCcy" is required (not null)
            this.DomCcy = domCcy ?? throw new ArgumentNullException("domCcy is a required property for EquityOptionAllOf and cannot be null");
            this.UnderlyingIdentifier = underlyingIdentifier;
            // to ensure "code" is required (not null)
            this.Code = code ?? throw new ArgumentNullException("code is a required property for EquityOptionAllOf and cannot be null");
            this.InstrumentType = instrumentType;
        }

        /// <summary>
        /// The start date of the instrument. This is normally synonymous with the trade-date.
        /// </summary>
        /// <value>The start date of the instrument. This is normally synonymous with the trade-date.</value>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// The maturity date of the option.
        /// </summary>
        /// <value>The maturity date of the option.</value>
        [DataMember(Name = "optionMaturityDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset OptionMaturityDate { get; set; }

        /// <summary>
        /// The settlement date of the option.
        /// </summary>
        /// <value>The settlement date of the option.</value>
        [DataMember(Name = "optionSettlementDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset OptionSettlementDate { get; set; }

        /// <summary>
        /// The strike of the option.
        /// </summary>
        /// <value>The strike of the option.</value>
        [DataMember(Name = "strike", IsRequired = true, EmitDefaultValue = true)]
        public decimal Strike { get; set; }

        /// <summary>
        /// The domestic currency of the instrument.
        /// </summary>
        /// <value>The domestic currency of the instrument.</value>
        [DataMember(Name = "domCcy", IsRequired = true, EmitDefaultValue = false)]
        public string DomCcy { get; set; }

        /// <summary>
        /// The identifying code for the equity underlying, e.g. &#39;IBM.N&#39;.
        /// </summary>
        /// <value>The identifying code for the equity underlying, e.g. &#39;IBM.N&#39;.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EquityOptionAllOf {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  OptionMaturityDate: ").Append(OptionMaturityDate).Append("\n");
            sb.Append("  OptionSettlementDate: ").Append(OptionSettlementDate).Append("\n");
            sb.Append("  DeliveryType: ").Append(DeliveryType).Append("\n");
            sb.Append("  OptionType: ").Append(OptionType).Append("\n");
            sb.Append("  Strike: ").Append(Strike).Append("\n");
            sb.Append("  DomCcy: ").Append(DomCcy).Append("\n");
            sb.Append("  UnderlyingIdentifier: ").Append(UnderlyingIdentifier).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  InstrumentType: ").Append(InstrumentType).Append("\n");
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
            return this.Equals(input as EquityOptionAllOf);
        }

        /// <summary>
        /// Returns true if EquityOptionAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of EquityOptionAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EquityOptionAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.OptionMaturityDate == input.OptionMaturityDate ||
                    (this.OptionMaturityDate != null &&
                    this.OptionMaturityDate.Equals(input.OptionMaturityDate))
                ) && 
                (
                    this.OptionSettlementDate == input.OptionSettlementDate ||
                    (this.OptionSettlementDate != null &&
                    this.OptionSettlementDate.Equals(input.OptionSettlementDate))
                ) && 
                (
                    this.DeliveryType == input.DeliveryType ||
                    this.DeliveryType.Equals(input.DeliveryType)
                ) && 
                (
                    this.OptionType == input.OptionType ||
                    this.OptionType.Equals(input.OptionType)
                ) && 
                (
                    this.Strike == input.Strike ||
                    this.Strike.Equals(input.Strike)
                ) && 
                (
                    this.DomCcy == input.DomCcy ||
                    (this.DomCcy != null &&
                    this.DomCcy.Equals(input.DomCcy))
                ) && 
                (
                    this.UnderlyingIdentifier == input.UnderlyingIdentifier ||
                    this.UnderlyingIdentifier.Equals(input.UnderlyingIdentifier)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.InstrumentType == input.InstrumentType ||
                    this.InstrumentType.Equals(input.InstrumentType)
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.OptionMaturityDate != null)
                    hashCode = hashCode * 59 + this.OptionMaturityDate.GetHashCode();
                if (this.OptionSettlementDate != null)
                    hashCode = hashCode * 59 + this.OptionSettlementDate.GetHashCode();
                hashCode = hashCode * 59 + this.DeliveryType.GetHashCode();
                hashCode = hashCode * 59 + this.OptionType.GetHashCode();
                hashCode = hashCode * 59 + this.Strike.GetHashCode();
                if (this.DomCcy != null)
                    hashCode = hashCode * 59 + this.DomCcy.GetHashCode();
                hashCode = hashCode * 59 + this.UnderlyingIdentifier.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                hashCode = hashCode * 59 + this.InstrumentType.GetHashCode();
                return hashCode;
            }
        }

    }
}
