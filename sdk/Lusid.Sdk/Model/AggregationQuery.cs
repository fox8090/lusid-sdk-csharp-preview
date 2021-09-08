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
    /// AggregationQuery
    /// </summary>
    [DataContract(Name = "AggregationQuery")]
    public partial class AggregationQuery : IEquatable<AggregationQuery>
    {
        /// <summary>
        /// The available values are: String, Int, Decimal, DateTime, Boolean, ResultValue, Array, Map, Json
        /// </summary>
        /// <value>The available values are: String, Int, Decimal, DateTime, Boolean, ResultValue, Array, Map, Json</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum String for value: String
            /// </summary>
            [EnumMember(Value = "String")]
            String = 1,

            /// <summary>
            /// Enum Int for value: Int
            /// </summary>
            [EnumMember(Value = "Int")]
            Int = 2,

            /// <summary>
            /// Enum Decimal for value: Decimal
            /// </summary>
            [EnumMember(Value = "Decimal")]
            Decimal = 3,

            /// <summary>
            /// Enum DateTime for value: DateTime
            /// </summary>
            [EnumMember(Value = "DateTime")]
            DateTime = 4,

            /// <summary>
            /// Enum Boolean for value: Boolean
            /// </summary>
            [EnumMember(Value = "Boolean")]
            Boolean = 5,

            /// <summary>
            /// Enum ResultValue for value: ResultValue
            /// </summary>
            [EnumMember(Value = "ResultValue")]
            ResultValue = 6,

            /// <summary>
            /// Enum Array for value: Array
            /// </summary>
            [EnumMember(Value = "Array")]
            Array = 7,

            /// <summary>
            /// Enum Map for value: Map
            /// </summary>
            [EnumMember(Value = "Map")]
            Map = 8,

            /// <summary>
            /// Enum Json for value: Json
            /// </summary>
            [EnumMember(Value = "Json")]
            Json = 9

        }


        /// <summary>
        /// The available values are: String, Int, Decimal, DateTime, Boolean, ResultValue, Array, Map, Json
        /// </summary>
        /// <value>The available values are: String, Int, Decimal, DateTime, Boolean, ResultValue, Array, Map, Json</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AggregationQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationQuery" /> class.
        /// </summary>
        /// <param name="addressKey">The address that is the query to be made into the system. e.g. a Valuation/Pv or Instrument/MaturityDate (required).</param>
        /// <param name="description">What does the information that is being queried by the address mean. What is the address for. (required).</param>
        /// <param name="displayName">The suggested name that the user would wish to put on to the returned information for visualisation in preference to the address. (required).</param>
        /// <param name="type">The available values are: String, Int, Decimal, DateTime, Boolean, ResultValue, Array, Map, Json (required).</param>
        /// <param name="scalesWithHoldingQuantity">Is the data scaled when it is for, e.g. a holding in an instrument. A key example would be the difference between price and pv. The present value  of an instrument would scale with the quantity held. The price would be that for a hypothetical unit of that instrument, typically associated with the  contract size. (required).</param>
        /// <param name="supportedOperations">When performing an aggregation operation, what column type operations can be performed on the data. For example, it makes sense to sum decimals but  not strings. Either can be counted. With more complex types, e.g. ResultValues, operations may be linked to a semantic meaning such as the currency  of the result. In such cases the operations may be supported but context specific. For example, it makes sense to sum PVs in a single currency but not  when the currency is different. In such cases, an error would result (it being assumed that no fx rates for currency conversion were implicit in the context). (required).</param>
        /// <param name="lifeCycleStatus">Within an API where an item can be accessed through an address or property, there is an associated status that determines  whether the item is stable or likely to change. This status is one of [Experimental, Beta, EAP, Prod,  Deprecated]. If the item is  deprecated it will be removed on or after the associated DateTime RemovalDate field. That field will not otherwise be set. (required).</param>
        /// <param name="removalDate">If the life cycle status is set to deprecated then this will be populated with the date on or after which removal of the address query will happen (required).</param>
        public AggregationQuery(string addressKey = default(string), string description = default(string), string displayName = default(string), TypeEnum type = default(TypeEnum), bool scalesWithHoldingQuantity = default(bool), string supportedOperations = default(string), string lifeCycleStatus = default(string), DateTimeOffset removalDate = default(DateTimeOffset))
        {
            // to ensure "addressKey" is required (not null)
            this.AddressKey = addressKey ?? throw new ArgumentNullException("addressKey is a required property for AggregationQuery and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for AggregationQuery and cannot be null");
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for AggregationQuery and cannot be null");
            this.Type = type;
            this.ScalesWithHoldingQuantity = scalesWithHoldingQuantity;
            // to ensure "supportedOperations" is required (not null)
            this.SupportedOperations = supportedOperations ?? throw new ArgumentNullException("supportedOperations is a required property for AggregationQuery and cannot be null");
            // to ensure "lifeCycleStatus" is required (not null)
            this.LifeCycleStatus = lifeCycleStatus ?? throw new ArgumentNullException("lifeCycleStatus is a required property for AggregationQuery and cannot be null");
            this.RemovalDate = removalDate;
        }

        /// <summary>
        /// The address that is the query to be made into the system. e.g. a Valuation/Pv or Instrument/MaturityDate
        /// </summary>
        /// <value>The address that is the query to be made into the system. e.g. a Valuation/Pv or Instrument/MaturityDate</value>
        [DataMember(Name = "addressKey", IsRequired = true, EmitDefaultValue = false)]
        public string AddressKey { get; set; }

        /// <summary>
        /// What does the information that is being queried by the address mean. What is the address for.
        /// </summary>
        /// <value>What does the information that is being queried by the address mean. What is the address for.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The suggested name that the user would wish to put on to the returned information for visualisation in preference to the address.
        /// </summary>
        /// <value>The suggested name that the user would wish to put on to the returned information for visualisation in preference to the address.</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Is the data scaled when it is for, e.g. a holding in an instrument. A key example would be the difference between price and pv. The present value  of an instrument would scale with the quantity held. The price would be that for a hypothetical unit of that instrument, typically associated with the  contract size.
        /// </summary>
        /// <value>Is the data scaled when it is for, e.g. a holding in an instrument. A key example would be the difference between price and pv. The present value  of an instrument would scale with the quantity held. The price would be that for a hypothetical unit of that instrument, typically associated with the  contract size.</value>
        [DataMember(Name = "scalesWithHoldingQuantity", IsRequired = true, EmitDefaultValue = true)]
        public bool ScalesWithHoldingQuantity { get; set; }

        /// <summary>
        /// When performing an aggregation operation, what column type operations can be performed on the data. For example, it makes sense to sum decimals but  not strings. Either can be counted. With more complex types, e.g. ResultValues, operations may be linked to a semantic meaning such as the currency  of the result. In such cases the operations may be supported but context specific. For example, it makes sense to sum PVs in a single currency but not  when the currency is different. In such cases, an error would result (it being assumed that no fx rates for currency conversion were implicit in the context).
        /// </summary>
        /// <value>When performing an aggregation operation, what column type operations can be performed on the data. For example, it makes sense to sum decimals but  not strings. Either can be counted. With more complex types, e.g. ResultValues, operations may be linked to a semantic meaning such as the currency  of the result. In such cases the operations may be supported but context specific. For example, it makes sense to sum PVs in a single currency but not  when the currency is different. In such cases, an error would result (it being assumed that no fx rates for currency conversion were implicit in the context).</value>
        [DataMember(Name = "supportedOperations", IsRequired = true, EmitDefaultValue = false)]
        public string SupportedOperations { get; set; }

        /// <summary>
        /// Within an API where an item can be accessed through an address or property, there is an associated status that determines  whether the item is stable or likely to change. This status is one of [Experimental, Beta, EAP, Prod,  Deprecated]. If the item is  deprecated it will be removed on or after the associated DateTime RemovalDate field. That field will not otherwise be set.
        /// </summary>
        /// <value>Within an API where an item can be accessed through an address or property, there is an associated status that determines  whether the item is stable or likely to change. This status is one of [Experimental, Beta, EAP, Prod,  Deprecated]. If the item is  deprecated it will be removed on or after the associated DateTime RemovalDate field. That field will not otherwise be set.</value>
        [DataMember(Name = "lifeCycleStatus", IsRequired = true, EmitDefaultValue = false)]
        public string LifeCycleStatus { get; set; }

        /// <summary>
        /// If the life cycle status is set to deprecated then this will be populated with the date on or after which removal of the address query will happen
        /// </summary>
        /// <value>If the life cycle status is set to deprecated then this will be populated with the date on or after which removal of the address query will happen</value>
        [DataMember(Name = "removalDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset RemovalDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregationQuery {\n");
            sb.Append("  AddressKey: ").Append(AddressKey).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ScalesWithHoldingQuantity: ").Append(ScalesWithHoldingQuantity).Append("\n");
            sb.Append("  SupportedOperations: ").Append(SupportedOperations).Append("\n");
            sb.Append("  LifeCycleStatus: ").Append(LifeCycleStatus).Append("\n");
            sb.Append("  RemovalDate: ").Append(RemovalDate).Append("\n");
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
            return this.Equals(input as AggregationQuery);
        }

        /// <summary>
        /// Returns true if AggregationQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of AggregationQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregationQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressKey == input.AddressKey ||
                    (this.AddressKey != null &&
                    this.AddressKey.Equals(input.AddressKey))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.ScalesWithHoldingQuantity == input.ScalesWithHoldingQuantity ||
                    this.ScalesWithHoldingQuantity.Equals(input.ScalesWithHoldingQuantity)
                ) && 
                (
                    this.SupportedOperations == input.SupportedOperations ||
                    (this.SupportedOperations != null &&
                    this.SupportedOperations.Equals(input.SupportedOperations))
                ) && 
                (
                    this.LifeCycleStatus == input.LifeCycleStatus ||
                    (this.LifeCycleStatus != null &&
                    this.LifeCycleStatus.Equals(input.LifeCycleStatus))
                ) && 
                (
                    this.RemovalDate == input.RemovalDate ||
                    (this.RemovalDate != null &&
                    this.RemovalDate.Equals(input.RemovalDate))
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
                if (this.AddressKey != null)
                    hashCode = hashCode * 59 + this.AddressKey.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.ScalesWithHoldingQuantity.GetHashCode();
                if (this.SupportedOperations != null)
                    hashCode = hashCode * 59 + this.SupportedOperations.GetHashCode();
                if (this.LifeCycleStatus != null)
                    hashCode = hashCode * 59 + this.LifeCycleStatus.GetHashCode();
                if (this.RemovalDate != null)
                    hashCode = hashCode * 59 + this.RemovalDate.GetHashCode();
                return hashCode;
            }
        }

    }
}
