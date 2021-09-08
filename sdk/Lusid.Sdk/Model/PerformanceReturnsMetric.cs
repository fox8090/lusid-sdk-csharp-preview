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
    /// The request used in the AggregatedReturns.
    /// </summary>
    [DataContract(Name = "PerformanceReturnsMetric")]
    public partial class PerformanceReturnsMetric : IEquatable<PerformanceReturnsMetric>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceReturnsMetric" /> class.
        /// </summary>
        /// <param name="window">The given metric for the calculation i.e. 1Y, 1D..</param>
        /// <param name="allowPartial">Bool if the metric is allowed partial results. Deafult to false..</param>
        /// <param name="annualised">Bool if the metric is annualized. Default to false..</param>
        public PerformanceReturnsMetric(string window = default(string), bool allowPartial = default(bool), bool annualised = default(bool))
        {
            this.Window = window;
            this.AllowPartial = allowPartial;
            this.Annualised = annualised;
        }

        /// <summary>
        /// The type of the metric. Default to Return
        /// </summary>
        /// <value>The type of the metric. Default to Return</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; private set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }

        /// <summary>
        /// The given metric for the calculation i.e. 1Y, 1D.
        /// </summary>
        /// <value>The given metric for the calculation i.e. 1Y, 1D.</value>
        [DataMember(Name = "window", EmitDefaultValue = true)]
        public string Window { get; set; }

        /// <summary>
        /// Bool if the metric is allowed partial results. Deafult to false.
        /// </summary>
        /// <value>Bool if the metric is allowed partial results. Deafult to false.</value>
        [DataMember(Name = "allowPartial", EmitDefaultValue = true)]
        public bool AllowPartial { get; set; }

        /// <summary>
        /// Bool if the metric is annualized. Default to false.
        /// </summary>
        /// <value>Bool if the metric is annualized. Default to false.</value>
        [DataMember(Name = "annualised", EmitDefaultValue = true)]
        public bool Annualised { get; set; }

        /// <summary>
        /// Bool if the metric should consider the fees when is calculated. Default to false.
        /// </summary>
        /// <value>Bool if the metric should consider the fees when is calculated. Default to false.</value>
        [DataMember(Name = "withFee", EmitDefaultValue = true)]
        public bool WithFee { get; private set; }

        /// <summary>
        /// Returns false as WithFee should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWithFee()
        {
            return false;
        }

        /// <summary>
        /// The alias for the metric.
        /// </summary>
        /// <value>The alias for the metric.</value>
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; private set; }

        /// <summary>
        /// Returns false as Alias should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAlias()
        {
            return false;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PerformanceReturnsMetric {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Window: ").Append(Window).Append("\n");
            sb.Append("  AllowPartial: ").Append(AllowPartial).Append("\n");
            sb.Append("  Annualised: ").Append(Annualised).Append("\n");
            sb.Append("  WithFee: ").Append(WithFee).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
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
            return this.Equals(input as PerformanceReturnsMetric);
        }

        /// <summary>
        /// Returns true if PerformanceReturnsMetric instances are equal
        /// </summary>
        /// <param name="input">Instance of PerformanceReturnsMetric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformanceReturnsMetric input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Window == input.Window ||
                    (this.Window != null &&
                    this.Window.Equals(input.Window))
                ) && 
                (
                    this.AllowPartial == input.AllowPartial ||
                    this.AllowPartial.Equals(input.AllowPartial)
                ) && 
                (
                    this.Annualised == input.Annualised ||
                    this.Annualised.Equals(input.Annualised)
                ) && 
                (
                    this.WithFee == input.WithFee ||
                    this.WithFee.Equals(input.WithFee)
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Window != null)
                    hashCode = hashCode * 59 + this.Window.GetHashCode();
                hashCode = hashCode * 59 + this.AllowPartial.GetHashCode();
                hashCode = hashCode * 59 + this.Annualised.GetHashCode();
                hashCode = hashCode * 59 + this.WithFee.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                return hashCode;
            }
        }

    }
}
