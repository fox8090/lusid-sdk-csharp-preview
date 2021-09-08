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
    /// Specification for the reconciliation request. Left and Right hand sides are constructed. Each consists of a valuation of a inline set of instruments  using an inline aggregation request. The results of this can then be compared to each other. The difference, which is effectively a risk based  difference allows comparison of the effects of changing a recipe, valuation date, or (though it may or may not make logical sense) a set of instruments.
    /// </summary>
    [DataContract(Name = "InlineValuationsReconciliationRequest")]
    public partial class InlineValuationsReconciliationRequest : IEquatable<InlineValuationsReconciliationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineValuationsReconciliationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineValuationsReconciliationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineValuationsReconciliationRequest" /> class.
        /// </summary>
        /// <param name="left">left (required).</param>
        /// <param name="right">right (required).</param>
        /// <param name="leftToRightMapping">The mapping from property keys requested by left aggregation to property keys on right hand side.</param>
        /// <param name="preserveKeys">List of keys to preserve (from rhs) in the diff. Used in conjunction with filtering/grouping.</param>
        public InlineValuationsReconciliationRequest(InlineValuationRequest left = default(InlineValuationRequest), InlineValuationRequest right = default(InlineValuationRequest), List<ReconciliationLeftRightAddressKeyPair> leftToRightMapping = default(List<ReconciliationLeftRightAddressKeyPair>), List<string> preserveKeys = default(List<string>))
        {
            // to ensure "left" is required (not null)
            this.Left = left ?? throw new ArgumentNullException("left is a required property for InlineValuationsReconciliationRequest and cannot be null");
            // to ensure "right" is required (not null)
            this.Right = right ?? throw new ArgumentNullException("right is a required property for InlineValuationsReconciliationRequest and cannot be null");
            this.LeftToRightMapping = leftToRightMapping;
            this.PreserveKeys = preserveKeys;
        }

        /// <summary>
        /// Gets or Sets Left
        /// </summary>
        [DataMember(Name = "left", IsRequired = true, EmitDefaultValue = false)]
        public InlineValuationRequest Left { get; set; }

        /// <summary>
        /// Gets or Sets Right
        /// </summary>
        [DataMember(Name = "right", IsRequired = true, EmitDefaultValue = false)]
        public InlineValuationRequest Right { get; set; }

        /// <summary>
        /// The mapping from property keys requested by left aggregation to property keys on right hand side
        /// </summary>
        /// <value>The mapping from property keys requested by left aggregation to property keys on right hand side</value>
        [DataMember(Name = "leftToRightMapping", EmitDefaultValue = true)]
        public List<ReconciliationLeftRightAddressKeyPair> LeftToRightMapping { get; set; }

        /// <summary>
        /// List of keys to preserve (from rhs) in the diff. Used in conjunction with filtering/grouping
        /// </summary>
        /// <value>List of keys to preserve (from rhs) in the diff. Used in conjunction with filtering/grouping</value>
        [DataMember(Name = "preserveKeys", EmitDefaultValue = true)]
        public List<string> PreserveKeys { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineValuationsReconciliationRequest {\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  LeftToRightMapping: ").Append(LeftToRightMapping).Append("\n");
            sb.Append("  PreserveKeys: ").Append(PreserveKeys).Append("\n");
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
            return this.Equals(input as InlineValuationsReconciliationRequest);
        }

        /// <summary>
        /// Returns true if InlineValuationsReconciliationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineValuationsReconciliationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineValuationsReconciliationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Left == input.Left ||
                    (this.Left != null &&
                    this.Left.Equals(input.Left))
                ) && 
                (
                    this.Right == input.Right ||
                    (this.Right != null &&
                    this.Right.Equals(input.Right))
                ) && 
                (
                    this.LeftToRightMapping == input.LeftToRightMapping ||
                    this.LeftToRightMapping != null &&
                    input.LeftToRightMapping != null &&
                    this.LeftToRightMapping.SequenceEqual(input.LeftToRightMapping)
                ) && 
                (
                    this.PreserveKeys == input.PreserveKeys ||
                    this.PreserveKeys != null &&
                    input.PreserveKeys != null &&
                    this.PreserveKeys.SequenceEqual(input.PreserveKeys)
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
                if (this.Left != null)
                    hashCode = hashCode * 59 + this.Left.GetHashCode();
                if (this.Right != null)
                    hashCode = hashCode * 59 + this.Right.GetHashCode();
                if (this.LeftToRightMapping != null)
                    hashCode = hashCode * 59 + this.LeftToRightMapping.GetHashCode();
                if (this.PreserveKeys != null)
                    hashCode = hashCode * 59 + this.PreserveKeys.GetHashCode();
                return hashCode;
            }
        }

    }
}
