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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// Market Data required to build a volatility cube for swaption pricing,  represented by a list of instruments and corresponding market quotes
    /// </summary>
    [DataContract(Name = "IrVolCubeData")]
    [JsonConverter(typeof(JsonSubtypes), "MarketDataType")]
    public partial class IrVolCubeData : ComplexMarketData, IEquatable<IrVolCubeData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IrVolCubeData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IrVolCubeData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IrVolCubeData" /> class.
        /// </summary>
        /// <param name="baseDate">Base date of the cube - this is the start date of the swaptions on the cube. (required).</param>
        /// <param name="instruments">Retrieve the set of instruments that define the cube. (required).</param>
        /// <param name="quotes">Access the set of quotes that define the cube. (required).</param>
        /// <param name="marketDataType">The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData (required) (default to &quot;IrVolCubeData&quot;).</param>
        public IrVolCubeData(DateTimeOffset baseDate = default(DateTimeOffset), List<LusidInstrument> instruments = default(List<LusidInstrument>), List<MarketQuote> quotes = default(List<MarketQuote>), MarketDataTypeEnum marketDataType = default(MarketDataTypeEnum)) : base(marketDataType)
        {
            this.BaseDate = baseDate;
            // to ensure "instruments" is required (not null)
            this.Instruments = instruments ?? throw new ArgumentNullException("instruments is a required property for IrVolCubeData and cannot be null");
            // to ensure "quotes" is required (not null)
            this.Quotes = quotes ?? throw new ArgumentNullException("quotes is a required property for IrVolCubeData and cannot be null");
        }

        /// <summary>
        /// Base date of the cube - this is the start date of the swaptions on the cube.
        /// </summary>
        /// <value>Base date of the cube - this is the start date of the swaptions on the cube.</value>
        [DataMember(Name = "baseDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset BaseDate { get; set; }

        /// <summary>
        /// Retrieve the set of instruments that define the cube.
        /// </summary>
        /// <value>Retrieve the set of instruments that define the cube.</value>
        [DataMember(Name = "instruments", IsRequired = true, EmitDefaultValue = false)]
        public List<LusidInstrument> Instruments { get; set; }

        /// <summary>
        /// Access the set of quotes that define the cube.
        /// </summary>
        /// <value>Access the set of quotes that define the cube.</value>
        [DataMember(Name = "quotes", IsRequired = true, EmitDefaultValue = false)]
        public List<MarketQuote> Quotes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IrVolCubeData {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BaseDate: ").Append(BaseDate).Append("\n");
            sb.Append("  Instruments: ").Append(Instruments).Append("\n");
            sb.Append("  Quotes: ").Append(Quotes).Append("\n");
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
            return this.Equals(input as IrVolCubeData);
        }

        /// <summary>
        /// Returns true if IrVolCubeData instances are equal
        /// </summary>
        /// <param name="input">Instance of IrVolCubeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IrVolCubeData input)
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
                    this.Instruments == input.Instruments ||
                    this.Instruments != null &&
                    input.Instruments != null &&
                    this.Instruments.SequenceEqual(input.Instruments)
                ) && base.Equals(input) && 
                (
                    this.Quotes == input.Quotes ||
                    this.Quotes != null &&
                    input.Quotes != null &&
                    this.Quotes.SequenceEqual(input.Quotes)
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
                if (this.Instruments != null)
                    hashCode = hashCode * 59 + this.Instruments.GetHashCode();
                if (this.Quotes != null)
                    hashCode = hashCode * 59 + this.Quotes.GetHashCode();
                return hashCode;
            }
        }

    }
}
