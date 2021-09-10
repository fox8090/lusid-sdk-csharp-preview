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
    /// The details of the structured market data item to upsert into Lusid.
    /// </summary>
    [DataContract(Name = "UpsertStructuredMarketDataRequest")]
    public partial class UpsertStructuredMarketDataRequest : IEquatable<UpsertStructuredMarketDataRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertStructuredMarketDataRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertStructuredMarketDataRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertStructuredMarketDataRequest" /> class.
        /// </summary>
        /// <param name="marketDataId">marketDataId (required).</param>
        /// <param name="marketData">marketData (required).</param>
        public UpsertStructuredMarketDataRequest(StructuredMarketDataId marketDataId = default(StructuredMarketDataId), StructuredMarketData marketData = default(StructuredMarketData))
        {
            // to ensure "marketDataId" is required (not null)
            this.MarketDataId = marketDataId ?? throw new ArgumentNullException("marketDataId is a required property for UpsertStructuredMarketDataRequest and cannot be null");
            // to ensure "marketData" is required (not null)
            this.MarketData = marketData ?? throw new ArgumentNullException("marketData is a required property for UpsertStructuredMarketDataRequest and cannot be null");
        }

        /// <summary>
        /// Gets or Sets MarketDataId
        /// </summary>
        [DataMember(Name = "marketDataId", IsRequired = true, EmitDefaultValue = false)]
        public StructuredMarketDataId MarketDataId { get; set; }

        /// <summary>
        /// Gets or Sets MarketData
        /// </summary>
        [DataMember(Name = "marketData", IsRequired = true, EmitDefaultValue = false)]
        public StructuredMarketData MarketData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpsertStructuredMarketDataRequest {\n");
            sb.Append("  MarketDataId: ").Append(MarketDataId).Append("\n");
            sb.Append("  MarketData: ").Append(MarketData).Append("\n");
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
            return this.Equals(input as UpsertStructuredMarketDataRequest);
        }

        /// <summary>
        /// Returns true if UpsertStructuredMarketDataRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertStructuredMarketDataRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertStructuredMarketDataRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MarketDataId == input.MarketDataId ||
                    (this.MarketDataId != null &&
                    this.MarketDataId.Equals(input.MarketDataId))
                ) && 
                (
                    this.MarketData == input.MarketData ||
                    (this.MarketData != null &&
                    this.MarketData.Equals(input.MarketData))
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
                if (this.MarketDataId != null)
                    hashCode = hashCode * 59 + this.MarketDataId.GetHashCode();
                if (this.MarketData != null)
                    hashCode = hashCode * 59 + this.MarketData.GetHashCode();
                return hashCode;
            }
        }

    }
}
