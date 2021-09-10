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
    /// CreateDerivedPropertyDefinitionRequest
    /// </summary>
    [DataContract(Name = "CreateDerivedPropertyDefinitionRequest")]
    public partial class CreateDerivedPropertyDefinitionRequest : IEquatable<CreateDerivedPropertyDefinitionRequest>
    {
        /// <summary>
        /// The domain that the property exists in. The available values are: NotDefined, Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, CutLabelDefinition, Analytic, PortfolioGroup, Person, AccessMetadata, Order, UnitResult, MarketData, ConfigurationRecipe, Allocation, Calendar, LegalEntity, Placement, Execution, Block, Participation, Package, OrderInstruction, CustomEntity
        /// </summary>
        /// <value>The domain that the property exists in. The available values are: NotDefined, Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, CutLabelDefinition, Analytic, PortfolioGroup, Person, AccessMetadata, Order, UnitResult, MarketData, ConfigurationRecipe, Allocation, Calendar, LegalEntity, Placement, Execution, Block, Participation, Package, OrderInstruction, CustomEntity</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DomainEnum
        {
            /// <summary>
            /// Enum NotDefined for value: NotDefined
            /// </summary>
            [EnumMember(Value = "NotDefined")]
            NotDefined = 1,

            /// <summary>
            /// Enum Transaction for value: Transaction
            /// </summary>
            [EnumMember(Value = "Transaction")]
            Transaction = 2,

            /// <summary>
            /// Enum Portfolio for value: Portfolio
            /// </summary>
            [EnumMember(Value = "Portfolio")]
            Portfolio = 3,

            /// <summary>
            /// Enum Holding for value: Holding
            /// </summary>
            [EnumMember(Value = "Holding")]
            Holding = 4,

            /// <summary>
            /// Enum ReferenceHolding for value: ReferenceHolding
            /// </summary>
            [EnumMember(Value = "ReferenceHolding")]
            ReferenceHolding = 5,

            /// <summary>
            /// Enum TransactionConfiguration for value: TransactionConfiguration
            /// </summary>
            [EnumMember(Value = "TransactionConfiguration")]
            TransactionConfiguration = 6,

            /// <summary>
            /// Enum Instrument for value: Instrument
            /// </summary>
            [EnumMember(Value = "Instrument")]
            Instrument = 7,

            /// <summary>
            /// Enum CutLabelDefinition for value: CutLabelDefinition
            /// </summary>
            [EnumMember(Value = "CutLabelDefinition")]
            CutLabelDefinition = 8,

            /// <summary>
            /// Enum Analytic for value: Analytic
            /// </summary>
            [EnumMember(Value = "Analytic")]
            Analytic = 9,

            /// <summary>
            /// Enum PortfolioGroup for value: PortfolioGroup
            /// </summary>
            [EnumMember(Value = "PortfolioGroup")]
            PortfolioGroup = 10,

            /// <summary>
            /// Enum Person for value: Person
            /// </summary>
            [EnumMember(Value = "Person")]
            Person = 11,

            /// <summary>
            /// Enum AccessMetadata for value: AccessMetadata
            /// </summary>
            [EnumMember(Value = "AccessMetadata")]
            AccessMetadata = 12,

            /// <summary>
            /// Enum Order for value: Order
            /// </summary>
            [EnumMember(Value = "Order")]
            Order = 13,

            /// <summary>
            /// Enum UnitResult for value: UnitResult
            /// </summary>
            [EnumMember(Value = "UnitResult")]
            UnitResult = 14,

            /// <summary>
            /// Enum MarketData for value: MarketData
            /// </summary>
            [EnumMember(Value = "MarketData")]
            MarketData = 15,

            /// <summary>
            /// Enum ConfigurationRecipe for value: ConfigurationRecipe
            /// </summary>
            [EnumMember(Value = "ConfigurationRecipe")]
            ConfigurationRecipe = 16,

            /// <summary>
            /// Enum Allocation for value: Allocation
            /// </summary>
            [EnumMember(Value = "Allocation")]
            Allocation = 17,

            /// <summary>
            /// Enum Calendar for value: Calendar
            /// </summary>
            [EnumMember(Value = "Calendar")]
            Calendar = 18,

            /// <summary>
            /// Enum LegalEntity for value: LegalEntity
            /// </summary>
            [EnumMember(Value = "LegalEntity")]
            LegalEntity = 19,

            /// <summary>
            /// Enum Placement for value: Placement
            /// </summary>
            [EnumMember(Value = "Placement")]
            Placement = 20,

            /// <summary>
            /// Enum Execution for value: Execution
            /// </summary>
            [EnumMember(Value = "Execution")]
            Execution = 21,

            /// <summary>
            /// Enum Block for value: Block
            /// </summary>
            [EnumMember(Value = "Block")]
            Block = 22,

            /// <summary>
            /// Enum Participation for value: Participation
            /// </summary>
            [EnumMember(Value = "Participation")]
            Participation = 23,

            /// <summary>
            /// Enum Package for value: Package
            /// </summary>
            [EnumMember(Value = "Package")]
            Package = 24,

            /// <summary>
            /// Enum OrderInstruction for value: OrderInstruction
            /// </summary>
            [EnumMember(Value = "OrderInstruction")]
            OrderInstruction = 25,

            /// <summary>
            /// Enum CustomEntity for value: CustomEntity
            /// </summary>
            [EnumMember(Value = "CustomEntity")]
            CustomEntity = 26

        }


        /// <summary>
        /// The domain that the property exists in. The available values are: NotDefined, Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, CutLabelDefinition, Analytic, PortfolioGroup, Person, AccessMetadata, Order, UnitResult, MarketData, ConfigurationRecipe, Allocation, Calendar, LegalEntity, Placement, Execution, Block, Participation, Package, OrderInstruction, CustomEntity
        /// </summary>
        /// <value>The domain that the property exists in. The available values are: NotDefined, Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, CutLabelDefinition, Analytic, PortfolioGroup, Person, AccessMetadata, Order, UnitResult, MarketData, ConfigurationRecipe, Allocation, Calendar, LegalEntity, Placement, Execution, Block, Participation, Package, OrderInstruction, CustomEntity</value>
        [DataMember(Name = "domain", IsRequired = true, EmitDefaultValue = false)]
        public DomainEnum Domain { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDerivedPropertyDefinitionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDerivedPropertyDefinitionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDerivedPropertyDefinitionRequest" /> class.
        /// </summary>
        /// <param name="domain">The domain that the property exists in. The available values are: NotDefined, Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, CutLabelDefinition, Analytic, PortfolioGroup, Person, AccessMetadata, Order, UnitResult, MarketData, ConfigurationRecipe, Allocation, Calendar, LegalEntity, Placement, Execution, Block, Participation, Package, OrderInstruction, CustomEntity (required).</param>
        /// <param name="scope">The scope that the property exists in. (required).</param>
        /// <param name="code">The code of the property. Together with the domain and scope this uniquely identifies the property. (required).</param>
        /// <param name="displayName">The display name of the property. (required).</param>
        /// <param name="dataTypeId">dataTypeId (required).</param>
        /// <param name="propertyDescription">Describes the property.</param>
        /// <param name="derivationFormula">The rule that defines how data is composed for a derived property..</param>
        public CreateDerivedPropertyDefinitionRequest(DomainEnum domain = default(DomainEnum), string scope = default(string), string code = default(string), string displayName = default(string), ResourceId dataTypeId = default(ResourceId), string propertyDescription = default(string), string derivationFormula = default(string))
        {
            this.Domain = domain;
            // to ensure "scope" is required (not null)
            this.Scope = scope ?? throw new ArgumentNullException("scope is a required property for CreateDerivedPropertyDefinitionRequest and cannot be null");
            // to ensure "code" is required (not null)
            this.Code = code ?? throw new ArgumentNullException("code is a required property for CreateDerivedPropertyDefinitionRequest and cannot be null");
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for CreateDerivedPropertyDefinitionRequest and cannot be null");
            // to ensure "dataTypeId" is required (not null)
            this.DataTypeId = dataTypeId ?? throw new ArgumentNullException("dataTypeId is a required property for CreateDerivedPropertyDefinitionRequest and cannot be null");
            this.PropertyDescription = propertyDescription;
            this.DerivationFormula = derivationFormula;
        }

        /// <summary>
        /// The scope that the property exists in.
        /// </summary>
        /// <value>The scope that the property exists in.</value>
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = false)]
        public string Scope { get; set; }

        /// <summary>
        /// The code of the property. Together with the domain and scope this uniquely identifies the property.
        /// </summary>
        /// <value>The code of the property. Together with the domain and scope this uniquely identifies the property.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// The display name of the property.
        /// </summary>
        /// <value>The display name of the property.</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets DataTypeId
        /// </summary>
        [DataMember(Name = "dataTypeId", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId DataTypeId { get; set; }

        /// <summary>
        /// Describes the property
        /// </summary>
        /// <value>Describes the property</value>
        [DataMember(Name = "propertyDescription", EmitDefaultValue = true)]
        public string PropertyDescription { get; set; }

        /// <summary>
        /// The rule that defines how data is composed for a derived property.
        /// </summary>
        /// <value>The rule that defines how data is composed for a derived property.</value>
        [DataMember(Name = "derivationFormula", EmitDefaultValue = true)]
        public string DerivationFormula { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDerivedPropertyDefinitionRequest {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DataTypeId: ").Append(DataTypeId).Append("\n");
            sb.Append("  PropertyDescription: ").Append(PropertyDescription).Append("\n");
            sb.Append("  DerivationFormula: ").Append(DerivationFormula).Append("\n");
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
            return this.Equals(input as CreateDerivedPropertyDefinitionRequest);
        }

        /// <summary>
        /// Returns true if CreateDerivedPropertyDefinitionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDerivedPropertyDefinitionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDerivedPropertyDefinitionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    this.Domain.Equals(input.Domain)
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.DataTypeId == input.DataTypeId ||
                    (this.DataTypeId != null &&
                    this.DataTypeId.Equals(input.DataTypeId))
                ) && 
                (
                    this.PropertyDescription == input.PropertyDescription ||
                    (this.PropertyDescription != null &&
                    this.PropertyDescription.Equals(input.PropertyDescription))
                ) && 
                (
                    this.DerivationFormula == input.DerivationFormula ||
                    (this.DerivationFormula != null &&
                    this.DerivationFormula.Equals(input.DerivationFormula))
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
                hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DataTypeId != null)
                    hashCode = hashCode * 59 + this.DataTypeId.GetHashCode();
                if (this.PropertyDescription != null)
                    hashCode = hashCode * 59 + this.PropertyDescription.GetHashCode();
                if (this.DerivationFormula != null)
                    hashCode = hashCode * 59 + this.DerivationFormula.GetHashCode();
                return hashCode;
            }
        }

    }
}
