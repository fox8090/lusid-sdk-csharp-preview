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
    /// A request to create or update a Placement.
    /// </summary>
    [DataContract(Name = "PlacementRequest")]
    public partial class PlacementRequest : IEquatable<PlacementRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlacementRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlacementRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlacementRequest" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="blockIds">IDs of Blocks associated with this placement. (required).</param>
        /// <param name="properties">Client-defined properties associated with this order..</param>
        /// <param name="instrumentIdentifiers">The instrument ordered. (required).</param>
        /// <param name="quantity">The quantity of given instrument ordered. (required).</param>
        /// <param name="state">The state of this placement (typically a FIX state; Open, Filled, etc). (required).</param>
        /// <param name="side">The side (Buy, Sell, ...) of this placement. (required).</param>
        /// <param name="timeInForce">The time in force applicable to this placement (GTC, FOK, Day, etc) (required).</param>
        /// <param name="type">The type of this placement (Market, Limit, etc). (required).</param>
        /// <param name="createdDate">The active date of this placement. (required).</param>
        /// <param name="limitPrice">limitPrice.</param>
        /// <param name="stopPrice">stopPrice.</param>
        /// <param name="counterparty">The market entity this placement is placed with. (required).</param>
        public PlacementRequest(ResourceId id = default(ResourceId), List<ResourceId> blockIds = default(List<ResourceId>), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), decimal quantity = default(decimal), string state = default(string), string side = default(string), string timeInForce = default(string), string type = default(string), DateTimeOffset createdDate = default(DateTimeOffset), CurrencyAndAmount limitPrice = default(CurrencyAndAmount), CurrencyAndAmount stopPrice = default(CurrencyAndAmount), string counterparty = default(string))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for PlacementRequest and cannot be null");
            // to ensure "blockIds" is required (not null)
            this.BlockIds = blockIds ?? throw new ArgumentNullException("blockIds is a required property for PlacementRequest and cannot be null");
            // to ensure "instrumentIdentifiers" is required (not null)
            this.InstrumentIdentifiers = instrumentIdentifiers ?? throw new ArgumentNullException("instrumentIdentifiers is a required property for PlacementRequest and cannot be null");
            this.Quantity = quantity;
            // to ensure "state" is required (not null)
            this.State = state ?? throw new ArgumentNullException("state is a required property for PlacementRequest and cannot be null");
            // to ensure "side" is required (not null)
            this.Side = side ?? throw new ArgumentNullException("side is a required property for PlacementRequest and cannot be null");
            // to ensure "timeInForce" is required (not null)
            this.TimeInForce = timeInForce ?? throw new ArgumentNullException("timeInForce is a required property for PlacementRequest and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PlacementRequest and cannot be null");
            this.CreatedDate = createdDate;
            // to ensure "counterparty" is required (not null)
            this.Counterparty = counterparty ?? throw new ArgumentNullException("counterparty is a required property for PlacementRequest and cannot be null");
            this.Properties = properties;
            this.LimitPrice = limitPrice;
            this.StopPrice = stopPrice;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// IDs of Blocks associated with this placement.
        /// </summary>
        /// <value>IDs of Blocks associated with this placement.</value>
        [DataMember(Name = "blockIds", IsRequired = true, EmitDefaultValue = false)]
        public List<ResourceId> BlockIds { get; set; }

        /// <summary>
        /// Client-defined properties associated with this order.
        /// </summary>
        /// <value>Client-defined properties associated with this order.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// The instrument ordered.
        /// </summary>
        /// <value>The instrument ordered.</value>
        [DataMember(Name = "instrumentIdentifiers", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// The quantity of given instrument ordered.
        /// </summary>
        /// <value>The quantity of given instrument ordered.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The state of this placement (typically a FIX state; Open, Filled, etc).
        /// </summary>
        /// <value>The state of this placement (typically a FIX state; Open, Filled, etc).</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// The side (Buy, Sell, ...) of this placement.
        /// </summary>
        /// <value>The side (Buy, Sell, ...) of this placement.</value>
        [DataMember(Name = "side", IsRequired = true, EmitDefaultValue = false)]
        public string Side { get; set; }

        /// <summary>
        /// The time in force applicable to this placement (GTC, FOK, Day, etc)
        /// </summary>
        /// <value>The time in force applicable to this placement (GTC, FOK, Day, etc)</value>
        [DataMember(Name = "timeInForce", IsRequired = true, EmitDefaultValue = false)]
        public string TimeInForce { get; set; }

        /// <summary>
        /// The type of this placement (Market, Limit, etc).
        /// </summary>
        /// <value>The type of this placement (Market, Limit, etc).</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The active date of this placement.
        /// </summary>
        /// <value>The active date of this placement.</value>
        [DataMember(Name = "createdDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets LimitPrice
        /// </summary>
        [DataMember(Name = "limitPrice", EmitDefaultValue = false)]
        public CurrencyAndAmount LimitPrice { get; set; }

        /// <summary>
        /// Gets or Sets StopPrice
        /// </summary>
        [DataMember(Name = "stopPrice", EmitDefaultValue = false)]
        public CurrencyAndAmount StopPrice { get; set; }

        /// <summary>
        /// The market entity this placement is placed with.
        /// </summary>
        /// <value>The market entity this placement is placed with.</value>
        [DataMember(Name = "counterparty", IsRequired = true, EmitDefaultValue = false)]
        public string Counterparty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlacementRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BlockIds: ").Append(BlockIds).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  LimitPrice: ").Append(LimitPrice).Append("\n");
            sb.Append("  StopPrice: ").Append(StopPrice).Append("\n");
            sb.Append("  Counterparty: ").Append(Counterparty).Append("\n");
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
            return this.Equals(input as PlacementRequest);
        }

        /// <summary>
        /// Returns true if PlacementRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PlacementRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlacementRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.BlockIds == input.BlockIds ||
                    this.BlockIds != null &&
                    input.BlockIds != null &&
                    this.BlockIds.SequenceEqual(input.BlockIds)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.TimeInForce == input.TimeInForce ||
                    (this.TimeInForce != null &&
                    this.TimeInForce.Equals(input.TimeInForce))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.LimitPrice == input.LimitPrice ||
                    (this.LimitPrice != null &&
                    this.LimitPrice.Equals(input.LimitPrice))
                ) && 
                (
                    this.StopPrice == input.StopPrice ||
                    (this.StopPrice != null &&
                    this.StopPrice.Equals(input.StopPrice))
                ) && 
                (
                    this.Counterparty == input.Counterparty ||
                    (this.Counterparty != null &&
                    this.Counterparty.Equals(input.Counterparty))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.BlockIds != null)
                    hashCode = hashCode * 59 + this.BlockIds.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.InstrumentIdentifiers != null)
                    hashCode = hashCode * 59 + this.InstrumentIdentifiers.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.TimeInForce != null)
                    hashCode = hashCode * 59 + this.TimeInForce.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.LimitPrice != null)
                    hashCode = hashCode * 59 + this.LimitPrice.GetHashCode();
                if (this.StopPrice != null)
                    hashCode = hashCode * 59 + this.StopPrice.GetHashCode();
                if (this.Counterparty != null)
                    hashCode = hashCode * 59 + this.Counterparty.GetHashCode();
                return hashCode;
            }
        }

    }
}
