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
    /// A curve containing discount factors and dates to which they apply
    /// </summary>
    [DataContract(Name = "DiscountFactorCurveData")]
    [JsonConverter(typeof(JsonSubtypes), "MarketDataType")]
    public partial class DiscountFactorCurveData : ComplexMarketData, IEquatable<DiscountFactorCurveData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountFactorCurveData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DiscountFactorCurveData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountFactorCurveData" /> class.
        /// </summary>
        /// <param name="baseDate">BaseDate for the Curve (required).</param>
        /// <param name="dates">Dates for which the discount factors apply (required).</param>
        /// <param name="discountFactors">Discount factors to be applied to cashflow on the specified dates (required).</param>
        /// <param name="marketDataType">The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData (required) (default to &quot;DiscountFactorCurveData&quot;).</param>
        public DiscountFactorCurveData(DateTimeOffset baseDate = default(DateTimeOffset), List<DateTimeOffset> dates = default(List<DateTimeOffset>), List<decimal> discountFactors = default(List<decimal>), MarketDataTypeEnum marketDataType = default(MarketDataTypeEnum)) : base(marketDataType)
        {
            this.BaseDate = baseDate;
            // to ensure "dates" is required (not null)
            this.Dates = dates ?? throw new ArgumentNullException("dates is a required property for DiscountFactorCurveData and cannot be null");
            // to ensure "discountFactors" is required (not null)
            this.DiscountFactors = discountFactors ?? throw new ArgumentNullException("discountFactors is a required property for DiscountFactorCurveData and cannot be null");
        }

        /// <summary>
        /// BaseDate for the Curve
        /// </summary>
        /// <value>BaseDate for the Curve</value>
        [DataMember(Name = "baseDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset BaseDate { get; set; }

        /// <summary>
        /// Dates for which the discount factors apply
        /// </summary>
        /// <value>Dates for which the discount factors apply</value>
        [DataMember(Name = "dates", IsRequired = true, EmitDefaultValue = false)]
        public List<DateTimeOffset> Dates { get; set; }

        /// <summary>
        /// Discount factors to be applied to cashflow on the specified dates
        /// </summary>
        /// <value>Discount factors to be applied to cashflow on the specified dates</value>
        [DataMember(Name = "discountFactors", IsRequired = true, EmitDefaultValue = false)]
        public List<decimal> DiscountFactors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscountFactorCurveData {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BaseDate: ").Append(BaseDate).Append("\n");
            sb.Append("  Dates: ").Append(Dates).Append("\n");
            sb.Append("  DiscountFactors: ").Append(DiscountFactors).Append("\n");
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
            return this.Equals(input as DiscountFactorCurveData);
        }

        /// <summary>
        /// Returns true if DiscountFactorCurveData instances are equal
        /// </summary>
        /// <param name="input">Instance of DiscountFactorCurveData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscountFactorCurveData input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.BaseDate == input.BaseDate ||
                    (this.BaseDate != null &&
                    this.BaseDate.Equals(input.BaseDate))
                ) && base.Equals(input) && 
                (
                    this.Dates == input.Dates ||
                    this.Dates != null &&
                    input.Dates != null &&
                    this.Dates.SequenceEqual(input.Dates)
                ) && base.Equals(input) && 
                (
                    this.DiscountFactors == input.DiscountFactors ||
                    this.DiscountFactors != null &&
                    input.DiscountFactors != null &&
                    this.DiscountFactors.SequenceEqual(input.DiscountFactors)
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
                if (this.BaseDate != null)
                    hashCode = hashCode * 59 + this.BaseDate.GetHashCode();
                if (this.Dates != null)
                    hashCode = hashCode * 59 + this.Dates.GetHashCode();
                if (this.DiscountFactors != null)
                    hashCode = hashCode * 59 + this.DiscountFactors.GetHashCode();
                return hashCode;
            }
        }

    }
}
