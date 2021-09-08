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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Lusid.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFeesAndCommissionsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] Get the Fees and Commissions that may be applicable to a transaction.
        /// </summary>
        /// <remarks>
        /// Additionally, matching can be based on the instrument&#39;s properties, its portfolio properties, and any additional property keys present in the data file.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentIdentifierType">Optional. The unique identifier type to use, eg &#39;Figi&#39; or &#39;LusidInstrumentId&#39;. (optional)</param>
        /// <param name="instrumentIdentifier">Optional. The Instrument Identifier to get properties for. (optional)</param>
        /// <param name="portfolioScope">Optional. The scope of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="portfolioCode">Optional. The code of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="additionalSearchKeys">Any other property keys or fields and their corresponding values that should be matched for fees. Eg. \&quot;Instrument/default/Name&#x3D;exampleValue\&quot; or \&quot;AdditionalKey2&#x3D;Value2\&quot;.              The list of fields available is as follows : \&quot;RuleName\&quot;, \&quot;Country\&quot;, \&quot;FeeType\&quot;, \&quot;FeeRate\&quot;, \&quot;MinFee\&quot;, \&quot;MaxFee\&quot;, \&quot;PropertyKey\&quot;,               \&quot;TransactionType\&quot;, \&quot;Counterparty\&quot;, \&quot;SettlementCurrency\&quot;, \&quot;TransactionCurrency\&quot;, \&quot;ExecutionBroker\&quot;,               \&quot;Custodian\&quot;, \&quot;Exchange\&quot; (optional)</param>
        /// <returns>ResourceListOfFeeCalculationDetails</returns>
        ResourceListOfFeeCalculationDetails GetApplicableFees(string instrumentIdentifierType = default(string), string instrumentIdentifier = default(string), string portfolioScope = default(string), string portfolioCode = default(string), List<string> additionalSearchKeys = default(List<string>));

        /// <summary>
        /// [EXPERIMENTAL] Get the Fees and Commissions that may be applicable to a transaction.
        /// </summary>
        /// <remarks>
        /// Additionally, matching can be based on the instrument&#39;s properties, its portfolio properties, and any additional property keys present in the data file.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentIdentifierType">Optional. The unique identifier type to use, eg &#39;Figi&#39; or &#39;LusidInstrumentId&#39;. (optional)</param>
        /// <param name="instrumentIdentifier">Optional. The Instrument Identifier to get properties for. (optional)</param>
        /// <param name="portfolioScope">Optional. The scope of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="portfolioCode">Optional. The code of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="additionalSearchKeys">Any other property keys or fields and their corresponding values that should be matched for fees. Eg. \&quot;Instrument/default/Name&#x3D;exampleValue\&quot; or \&quot;AdditionalKey2&#x3D;Value2\&quot;.              The list of fields available is as follows : \&quot;RuleName\&quot;, \&quot;Country\&quot;, \&quot;FeeType\&quot;, \&quot;FeeRate\&quot;, \&quot;MinFee\&quot;, \&quot;MaxFee\&quot;, \&quot;PropertyKey\&quot;,               \&quot;TransactionType\&quot;, \&quot;Counterparty\&quot;, \&quot;SettlementCurrency\&quot;, \&quot;TransactionCurrency\&quot;, \&quot;ExecutionBroker\&quot;,               \&quot;Custodian\&quot;, \&quot;Exchange\&quot; (optional)</param>
        /// <returns>ApiResponse of ResourceListOfFeeCalculationDetails</returns>
        ApiResponse<ResourceListOfFeeCalculationDetails> GetApplicableFeesWithHttpInfo(string instrumentIdentifierType = default(string), string instrumentIdentifier = default(string), string portfolioScope = default(string), string portfolioCode = default(string), List<string> additionalSearchKeys = default(List<string>));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFeesAndCommissionsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] Get the Fees and Commissions that may be applicable to a transaction.
        /// </summary>
        /// <remarks>
        /// Additionally, matching can be based on the instrument&#39;s properties, its portfolio properties, and any additional property keys present in the data file.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentIdentifierType">Optional. The unique identifier type to use, eg &#39;Figi&#39; or &#39;LusidInstrumentId&#39;. (optional)</param>
        /// <param name="instrumentIdentifier">Optional. The Instrument Identifier to get properties for. (optional)</param>
        /// <param name="portfolioScope">Optional. The scope of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="portfolioCode">Optional. The code of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="additionalSearchKeys">Any other property keys or fields and their corresponding values that should be matched for fees. Eg. \&quot;Instrument/default/Name&#x3D;exampleValue\&quot; or \&quot;AdditionalKey2&#x3D;Value2\&quot;.              The list of fields available is as follows : \&quot;RuleName\&quot;, \&quot;Country\&quot;, \&quot;FeeType\&quot;, \&quot;FeeRate\&quot;, \&quot;MinFee\&quot;, \&quot;MaxFee\&quot;, \&quot;PropertyKey\&quot;,               \&quot;TransactionType\&quot;, \&quot;Counterparty\&quot;, \&quot;SettlementCurrency\&quot;, \&quot;TransactionCurrency\&quot;, \&quot;ExecutionBroker\&quot;,               \&quot;Custodian\&quot;, \&quot;Exchange\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfFeeCalculationDetails</returns>
        System.Threading.Tasks.Task<ResourceListOfFeeCalculationDetails> GetApplicableFeesAsync(string instrumentIdentifierType = default(string), string instrumentIdentifier = default(string), string portfolioScope = default(string), string portfolioCode = default(string), List<string> additionalSearchKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EXPERIMENTAL] Get the Fees and Commissions that may be applicable to a transaction.
        /// </summary>
        /// <remarks>
        /// Additionally, matching can be based on the instrument&#39;s properties, its portfolio properties, and any additional property keys present in the data file.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentIdentifierType">Optional. The unique identifier type to use, eg &#39;Figi&#39; or &#39;LusidInstrumentId&#39;. (optional)</param>
        /// <param name="instrumentIdentifier">Optional. The Instrument Identifier to get properties for. (optional)</param>
        /// <param name="portfolioScope">Optional. The scope of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="portfolioCode">Optional. The code of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="additionalSearchKeys">Any other property keys or fields and their corresponding values that should be matched for fees. Eg. \&quot;Instrument/default/Name&#x3D;exampleValue\&quot; or \&quot;AdditionalKey2&#x3D;Value2\&quot;.              The list of fields available is as follows : \&quot;RuleName\&quot;, \&quot;Country\&quot;, \&quot;FeeType\&quot;, \&quot;FeeRate\&quot;, \&quot;MinFee\&quot;, \&quot;MaxFee\&quot;, \&quot;PropertyKey\&quot;,               \&quot;TransactionType\&quot;, \&quot;Counterparty\&quot;, \&quot;SettlementCurrency\&quot;, \&quot;TransactionCurrency\&quot;, \&quot;ExecutionBroker\&quot;,               \&quot;Custodian\&quot;, \&quot;Exchange\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfFeeCalculationDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfFeeCalculationDetails>> GetApplicableFeesWithHttpInfoAsync(string instrumentIdentifierType = default(string), string instrumentIdentifier = default(string), string portfolioScope = default(string), string portfolioCode = default(string), List<string> additionalSearchKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFeesAndCommissionsApi : IFeesAndCommissionsApiSync, IFeesAndCommissionsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FeesAndCommissionsApi : IFeesAndCommissionsApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FeesAndCommissionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FeesAndCommissionsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeesAndCommissionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FeesAndCommissionsApi(String basePath)
        {
            this.Configuration = Lusid.Sdk.Client.Configuration.MergeConfigurations(
                Lusid.Sdk.Client.GlobalConfiguration.Instance,
                new Lusid.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeesAndCommissionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FeesAndCommissionsApi(Lusid.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Lusid.Sdk.Client.Configuration.MergeConfigurations(
                Lusid.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Lusid.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeesAndCommissionsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public FeesAndCommissionsApi(Lusid.Sdk.Client.ISynchronousClient client, Lusid.Sdk.Client.IAsynchronousClient asyncClient, Lusid.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Lusid.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Lusid.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Lusid.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Lusid.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// [EXPERIMENTAL] Get the Fees and Commissions that may be applicable to a transaction. Additionally, matching can be based on the instrument&#39;s properties, its portfolio properties, and any additional property keys present in the data file.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentIdentifierType">Optional. The unique identifier type to use, eg &#39;Figi&#39; or &#39;LusidInstrumentId&#39;. (optional)</param>
        /// <param name="instrumentIdentifier">Optional. The Instrument Identifier to get properties for. (optional)</param>
        /// <param name="portfolioScope">Optional. The scope of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="portfolioCode">Optional. The code of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="additionalSearchKeys">Any other property keys or fields and their corresponding values that should be matched for fees. Eg. \&quot;Instrument/default/Name&#x3D;exampleValue\&quot; or \&quot;AdditionalKey2&#x3D;Value2\&quot;.              The list of fields available is as follows : \&quot;RuleName\&quot;, \&quot;Country\&quot;, \&quot;FeeType\&quot;, \&quot;FeeRate\&quot;, \&quot;MinFee\&quot;, \&quot;MaxFee\&quot;, \&quot;PropertyKey\&quot;,               \&quot;TransactionType\&quot;, \&quot;Counterparty\&quot;, \&quot;SettlementCurrency\&quot;, \&quot;TransactionCurrency\&quot;, \&quot;ExecutionBroker\&quot;,               \&quot;Custodian\&quot;, \&quot;Exchange\&quot; (optional)</param>
        /// <returns>ResourceListOfFeeCalculationDetails</returns>
        public ResourceListOfFeeCalculationDetails GetApplicableFees(string instrumentIdentifierType = default(string), string instrumentIdentifier = default(string), string portfolioScope = default(string), string portfolioCode = default(string), List<string> additionalSearchKeys = default(List<string>))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfFeeCalculationDetails> localVarResponse = GetApplicableFeesWithHttpInfo(instrumentIdentifierType, instrumentIdentifier, portfolioScope, portfolioCode, additionalSearchKeys);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] Get the Fees and Commissions that may be applicable to a transaction. Additionally, matching can be based on the instrument&#39;s properties, its portfolio properties, and any additional property keys present in the data file.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentIdentifierType">Optional. The unique identifier type to use, eg &#39;Figi&#39; or &#39;LusidInstrumentId&#39;. (optional)</param>
        /// <param name="instrumentIdentifier">Optional. The Instrument Identifier to get properties for. (optional)</param>
        /// <param name="portfolioScope">Optional. The scope of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="portfolioCode">Optional. The code of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="additionalSearchKeys">Any other property keys or fields and their corresponding values that should be matched for fees. Eg. \&quot;Instrument/default/Name&#x3D;exampleValue\&quot; or \&quot;AdditionalKey2&#x3D;Value2\&quot;.              The list of fields available is as follows : \&quot;RuleName\&quot;, \&quot;Country\&quot;, \&quot;FeeType\&quot;, \&quot;FeeRate\&quot;, \&quot;MinFee\&quot;, \&quot;MaxFee\&quot;, \&quot;PropertyKey\&quot;,               \&quot;TransactionType\&quot;, \&quot;Counterparty\&quot;, \&quot;SettlementCurrency\&quot;, \&quot;TransactionCurrency\&quot;, \&quot;ExecutionBroker\&quot;,               \&quot;Custodian\&quot;, \&quot;Exchange\&quot; (optional)</param>
        /// <returns>ApiResponse of ResourceListOfFeeCalculationDetails</returns>
        public Lusid.Sdk.Client.ApiResponse<ResourceListOfFeeCalculationDetails> GetApplicableFeesWithHttpInfo(string instrumentIdentifierType = default(string), string instrumentIdentifier = default(string), string portfolioScope = default(string), string portfolioCode = default(string), List<string> additionalSearchKeys = default(List<string>))
        {
            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (instrumentIdentifierType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "instrumentIdentifierType", instrumentIdentifierType));
            }
            if (instrumentIdentifier != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "instrumentIdentifier", instrumentIdentifier));
            }
            if (portfolioScope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "portfolioScope", portfolioScope));
            }
            if (portfolioCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "portfolioCode", portfolioCode));
            }
            if (additionalSearchKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "additionalSearchKeys", additionalSearchKeys));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.3463");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfFeeCalculationDetails>("/api/feesandcommissions", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApplicableFees", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EXPERIMENTAL] Get the Fees and Commissions that may be applicable to a transaction. Additionally, matching can be based on the instrument&#39;s properties, its portfolio properties, and any additional property keys present in the data file.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentIdentifierType">Optional. The unique identifier type to use, eg &#39;Figi&#39; or &#39;LusidInstrumentId&#39;. (optional)</param>
        /// <param name="instrumentIdentifier">Optional. The Instrument Identifier to get properties for. (optional)</param>
        /// <param name="portfolioScope">Optional. The scope of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="portfolioCode">Optional. The code of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="additionalSearchKeys">Any other property keys or fields and their corresponding values that should be matched for fees. Eg. \&quot;Instrument/default/Name&#x3D;exampleValue\&quot; or \&quot;AdditionalKey2&#x3D;Value2\&quot;.              The list of fields available is as follows : \&quot;RuleName\&quot;, \&quot;Country\&quot;, \&quot;FeeType\&quot;, \&quot;FeeRate\&quot;, \&quot;MinFee\&quot;, \&quot;MaxFee\&quot;, \&quot;PropertyKey\&quot;,               \&quot;TransactionType\&quot;, \&quot;Counterparty\&quot;, \&quot;SettlementCurrency\&quot;, \&quot;TransactionCurrency\&quot;, \&quot;ExecutionBroker\&quot;,               \&quot;Custodian\&quot;, \&quot;Exchange\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfFeeCalculationDetails</returns>
        public async System.Threading.Tasks.Task<ResourceListOfFeeCalculationDetails> GetApplicableFeesAsync(string instrumentIdentifierType = default(string), string instrumentIdentifier = default(string), string portfolioScope = default(string), string portfolioCode = default(string), List<string> additionalSearchKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Lusid.Sdk.Client.ApiResponse<ResourceListOfFeeCalculationDetails> localVarResponse = await GetApplicableFeesWithHttpInfoAsync(instrumentIdentifierType, instrumentIdentifier, portfolioScope, portfolioCode, additionalSearchKeys, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] Get the Fees and Commissions that may be applicable to a transaction. Additionally, matching can be based on the instrument&#39;s properties, its portfolio properties, and any additional property keys present in the data file.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="instrumentIdentifierType">Optional. The unique identifier type to use, eg &#39;Figi&#39; or &#39;LusidInstrumentId&#39;. (optional)</param>
        /// <param name="instrumentIdentifier">Optional. The Instrument Identifier to get properties for. (optional)</param>
        /// <param name="portfolioScope">Optional. The scope of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="portfolioCode">Optional. The code of the portfolio to fetch additional properties from. (optional)</param>
        /// <param name="additionalSearchKeys">Any other property keys or fields and their corresponding values that should be matched for fees. Eg. \&quot;Instrument/default/Name&#x3D;exampleValue\&quot; or \&quot;AdditionalKey2&#x3D;Value2\&quot;.              The list of fields available is as follows : \&quot;RuleName\&quot;, \&quot;Country\&quot;, \&quot;FeeType\&quot;, \&quot;FeeRate\&quot;, \&quot;MinFee\&quot;, \&quot;MaxFee\&quot;, \&quot;PropertyKey\&quot;,               \&quot;TransactionType\&quot;, \&quot;Counterparty\&quot;, \&quot;SettlementCurrency\&quot;, \&quot;TransactionCurrency\&quot;, \&quot;ExecutionBroker\&quot;,               \&quot;Custodian\&quot;, \&quot;Exchange\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfFeeCalculationDetails)</returns>
        public async System.Threading.Tasks.Task<Lusid.Sdk.Client.ApiResponse<ResourceListOfFeeCalculationDetails>> GetApplicableFeesWithHttpInfoAsync(string instrumentIdentifierType = default(string), string instrumentIdentifier = default(string), string portfolioScope = default(string), string portfolioCode = default(string), List<string> additionalSearchKeys = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Lusid.Sdk.Client.RequestOptions localVarRequestOptions = new Lusid.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Lusid.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Lusid.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (instrumentIdentifierType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "instrumentIdentifierType", instrumentIdentifierType));
            }
            if (instrumentIdentifier != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "instrumentIdentifier", instrumentIdentifier));
            }
            if (portfolioScope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "portfolioScope", portfolioScope));
            }
            if (portfolioCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("", "portfolioCode", portfolioCode));
            }
            if (additionalSearchKeys != null)
            {
                localVarRequestOptions.QueryParameters.Add(Lusid.Sdk.Client.ClientUtils.ParameterToMultiMap("multi", "additionalSearchKeys", additionalSearchKeys));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.11.3463");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfFeeCalculationDetails>("/api/feesandcommissions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApplicableFees", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}