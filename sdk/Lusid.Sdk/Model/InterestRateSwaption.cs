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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// A swaption, an option to enter into an interest rate swap.
    /// </summary>
    [DataContract(Name = "InterestRateSwaption")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentType")]
    public partial class InterestRateSwaption : LusidInstrument, IEquatable<InterestRateSwaption>
    {
        /// <summary>
        /// The available values are: NotDefined, Pay, Receive
        /// </summary>
        /// <value>The available values are: NotDefined, Pay, Receive</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PayOrReceiveFixedEnum
        {
            /// <summary>
            /// Enum NotDefined for value: NotDefined
            /// </summary>
            [EnumMember(Value = "NotDefined")]
            NotDefined = 1,

            /// <summary>
            /// Enum Pay for value: Pay
            /// </summary>
            [EnumMember(Value = "Pay")]
            Pay = 2,

            /// <summary>
            /// Enum Receive for value: Receive
            /// </summary>
            [EnumMember(Value = "Receive")]
            Receive = 3

        }


        /// <summary>
        /// The available values are: NotDefined, Pay, Receive
        /// </summary>
        /// <value>The available values are: NotDefined, Pay, Receive</value>
        [DataMember(Name = "payOrReceiveFixed", IsRequired = true, EmitDefaultValue = false)]
        public PayOrReceiveFixedEnum PayOrReceiveFixed { get; set; }
        /// <summary>
        /// The available values are: Cash, Physical
        /// </summary>
        /// <value>The available values are: Cash, Physical</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryMethodEnum
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
        [DataMember(Name = "deliveryMethod", IsRequired = true, EmitDefaultValue = false)]
        public DeliveryMethodEnum DeliveryMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InterestRateSwaption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InterestRateSwaption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InterestRateSwaption" /> class.
        /// </summary>
        /// <param name="startDate">The start date of the instrument. This is normally synonymous with the trade-date. (required).</param>
        /// <param name="payOrReceiveFixed">The available values are: NotDefined, Pay, Receive (required).</param>
        /// <param name="deliveryMethod">The available values are: Cash, Physical (required).</param>
        /// <param name="swap">swap (required).</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CashSettled, CdsIndex, Basket, FundingLeg, CrossCurrencySwap, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo (required) (default to &quot;InterestRateSwaption&quot;).</param>
        public InterestRateSwaption(DateTimeOffset startDate = default(DateTimeOffset), PayOrReceiveFixedEnum payOrReceiveFixed = default(PayOrReceiveFixedEnum), DeliveryMethodEnum deliveryMethod = default(DeliveryMethodEnum), InterestRateSwap swap = default(InterestRateSwap), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum)) : base(instrumentType)
        {
            this.StartDate = startDate;
            this.PayOrReceiveFixed = payOrReceiveFixed;
            this.DeliveryMethod = deliveryMethod;
            // to ensure "swap" is required (not null)
            this.Swap = swap ?? throw new ArgumentNullException("swap is a required property for InterestRateSwaption and cannot be null");
        }

        /// <summary>
        /// The start date of the instrument. This is normally synonymous with the trade-date.
        /// </summary>
        /// <value>The start date of the instrument. This is normally synonymous with the trade-date.</value>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Swap
        /// </summary>
        [DataMember(Name = "swap", IsRequired = true, EmitDefaultValue = false)]
        public InterestRateSwap Swap { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InterestRateSwaption {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  PayOrReceiveFixed: ").Append(PayOrReceiveFixed).Append("\n");
            sb.Append("  DeliveryMethod: ").Append(DeliveryMethod).Append("\n");
            sb.Append("  Swap: ").Append(Swap).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as InterestRateSwaption);
        }

        /// <summary>
        /// Returns true if InterestRateSwaption instances are equal
        /// </summary>
        /// <param name="input">Instance of InterestRateSwaption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterestRateSwaption input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && base.Equals(input) && 
                (
                    this.PayOrReceiveFixed == input.PayOrReceiveFixed ||
                    this.PayOrReceiveFixed.Equals(input.PayOrReceiveFixed)
                ) && base.Equals(input) && 
                (
                    this.DeliveryMethod == input.DeliveryMethod ||
                    this.DeliveryMethod.Equals(input.DeliveryMethod)
                ) && base.Equals(input) && 
                (
                    this.Swap == input.Swap ||
                    (this.Swap != null &&
                    this.Swap.Equals(input.Swap))
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
                int hashCode = base.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                hashCode = hashCode * 59 + this.PayOrReceiveFixed.GetHashCode();
                hashCode = hashCode * 59 + this.DeliveryMethod.GetHashCode();
                if (this.Swap != null)
                    hashCode = hashCode * 59 + this.Swap.GetHashCode();
                return hashCode;
            }
        }

    }
}
