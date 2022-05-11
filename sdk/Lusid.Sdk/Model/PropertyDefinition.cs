/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) |   # Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-10\">-10</a>|Server Configuration Error|  | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"102\">102</a>|Version Not Found|  | | <a name=\"103\">103</a>|Api Rate Limit Violation|  | | <a name=\"104\">104</a>|Instrument Not Found|  | | <a name=\"105\">105</a>|Property Not Found|  | | <a name=\"106\">106</a>|Portfolio Recursion Depth|  | | <a name=\"108\">108</a>|Group Not Found|  | | <a name=\"109\">109</a>|Portfolio Not Found|  | | <a name=\"110\">110</a>|Property Schema Not Found|  | | <a name=\"111\">111</a>|Portfolio Ancestry Not Found|  | | <a name=\"112\">112</a>|Portfolio With Id Already Exists|  | | <a name=\"113\">113</a>|Orphaned Portfolio|  | | <a name=\"119\">119</a>|Missing Base Claims|  | | <a name=\"121\">121</a>|Property Not Defined|  | | <a name=\"122\">122</a>|Cannot Delete System Property|  | | <a name=\"123\">123</a>|Cannot Modify Immutable Property Field|  | | <a name=\"124\">124</a>|Property Already Exists|  | | <a name=\"125\">125</a>|Invalid Property Life Time|  | | <a name=\"126\">126</a>|Property Constraint Style Excludes Properties|  | | <a name=\"127\">127</a>|Cannot Modify Default Data Type|  | | <a name=\"128\">128</a>|Group Already Exists|  | | <a name=\"129\">129</a>|No Such Data Type|  | | <a name=\"130\">130</a>|Undefined Value For Data Type|  | | <a name=\"131\">131</a>|Unsupported Value Type Defined On Data Type|  | | <a name=\"132\">132</a>|Validation Error|  | | <a name=\"133\">133</a>|Loop Detected In Group Hierarchy|  | | <a name=\"134\">134</a>|Undefined Acceptable Values|  | | <a name=\"135\">135</a>|Sub Group Already Exists|  | | <a name=\"138\">138</a>|Price Source Not Found|  | | <a name=\"139\">139</a>|Analytic Store Not Found|  | | <a name=\"141\">141</a>|Analytic Store Already Exists|  | | <a name=\"143\">143</a>|Client Instrument Already Exists|  | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"147\">147</a>|Results Not Found|  | | <a name=\"148\">148</a>|Order Field Not In Result Set|  | | <a name=\"149\">149</a>|Operation Failed|  | | <a name=\"150\">150</a>|Elastic Search Error|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"153\">153</a>|Command Processing Failure|  | | <a name=\"154\">154</a>|Entity State Construction Failure|  | | <a name=\"155\">155</a>|Entity Timeline Does Not Exist|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"158\">158</a>|Event Publish Unknown|  | | <a name=\"159\">159</a>|Event Query Failure|  | | <a name=\"160\">160</a>|Blob Did Not Exist|  | | <a name=\"162\">162</a>|Sub System Request Failure|  | | <a name=\"163\">163</a>|Sub System Configuration Failure|  | | <a name=\"165\">165</a>|Failed To Delete|  | | <a name=\"166\">166</a>|Upsert Client Instrument Failure|  | | <a name=\"167\">167</a>|Illegal As At Interval|  | | <a name=\"168\">168</a>|Illegal Bitemporal Query|  | | <a name=\"169\">169</a>|Invalid Alternate Id|  | | <a name=\"170\">170</a>|Cannot Add Source Portfolio Property Explicitly|  | | <a name=\"171\">171</a>|Entity Already Exists In Group|  | | <a name=\"173\">173</a>|Entity With Id Already Exists|  | | <a name=\"174\">174</a>|Derived Portfolio Details Do Not Exist|  | | <a name=\"175\">175</a>|Entity Not In Group|  | | <a name=\"176\">176</a>|Portfolio With Name Already Exists|  | | <a name=\"177\">177</a>|Invalid Transactions|  | | <a name=\"178\">178</a>|Reference Portfolio Not Found|  | | <a name=\"179\">179</a>|Duplicate Id|  | | <a name=\"180\">180</a>|Command Retrieval Failure|  | | <a name=\"181\">181</a>|Data Filter Application Failure|  | | <a name=\"182\">182</a>|Search Failed|  | | <a name=\"183\">183</a>|Movements Engine Configuration Key Failure|  | | <a name=\"184\">184</a>|Fx Rate Source Not Found|  | | <a name=\"185\">185</a>|Accrual Source Not Found|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"188\">188</a>|Invalid Request Headers|  | | <a name=\"189\">189</a>|Price Not Found|  | | <a name=\"190\">190</a>|Invalid Sub Holding Keys Provided|  | | <a name=\"191\">191</a>|Duplicate Sub Holding Keys Provided|  | | <a name=\"192\">192</a>|Cut Definition Not Found|  | | <a name=\"193\">193</a>|Cut Definition Invalid|  | | <a name=\"194\">194</a>|Time Variant Property Deletion Date Unspecified|  | | <a name=\"195\">195</a>|Perpetual Property Deletion Date Specified|  | | <a name=\"196\">196</a>|Time Variant Property Upsert Date Unspecified|  | | <a name=\"197\">197</a>|Perpetual Property Upsert Date Specified|  | | <a name=\"200\">200</a>|Invalid Unit For Data Type|  | | <a name=\"201\">201</a>|Invalid Type For Data Type|  | | <a name=\"202\">202</a>|Invalid Value For Data Type|  | | <a name=\"203\">203</a>|Unit Not Defined For Data Type|  | | <a name=\"204\">204</a>|Units Not Supported On Data Type|  | | <a name=\"205\">205</a>|Cannot Specify Units On Data Type|  | | <a name=\"206\">206</a>|Unit Schema Inconsistent With Data Type|  | | <a name=\"207\">207</a>|Unit Definition Not Specified|  | | <a name=\"208\">208</a>|Duplicate Unit Definitions Specified|  | | <a name=\"209\">209</a>|Invalid Units Definition|  | | <a name=\"210\">210</a>|Invalid Instrument Identifier Unit|  | | <a name=\"211\">211</a>|Holdings Adjustment Does Not Exist|  | | <a name=\"212\">212</a>|Could Not Build Excel Url|  | | <a name=\"213\">213</a>|Could Not Get Excel Version|  | | <a name=\"214\">214</a>|Instrument By Code Not Found|  | | <a name=\"215\">215</a>|Entity Schema Does Not Exist|  | | <a name=\"216\">216</a>|Feature Not Supported On Portfolio Type|  | | <a name=\"217\">217</a>|Quote Not Found|  | | <a name=\"218\">218</a>|Invalid Quote Identifier|  | | <a name=\"219\">219</a>|Invalid Metric For Data Type|  | | <a name=\"220\">220</a>|Invalid Instrument Definition|  | | <a name=\"221\">221</a>|Instrument Upsert Failure|  | | <a name=\"222\">222</a>|Reference Portfolio Request Not Supported|  | | <a name=\"223\">223</a>|Transaction Portfolio Request Not Supported|  | | <a name=\"224\">224</a>|Invalid Property Value Assignment|  | | <a name=\"230\">230</a>|Transaction Type Not Found|  | | <a name=\"231\">231</a>|Transaction Type Duplication|  | | <a name=\"232\">232</a>|Portfolio Does Not Exist At Given Date|  | | <a name=\"233\">233</a>|Query Parser Failure|  | | <a name=\"234\">234</a>|Duplicate Constituent|  | | <a name=\"235\">235</a>|Unresolved Instrument Constituent|  | | <a name=\"236\">236</a>|Unresolved Instrument In Transition|  | | <a name=\"237\">237</a>|Missing Side Definitions|  | | <a name=\"299\">299</a>|Invalid Recipe|  | | <a name=\"300\">300</a>|Missing Recipe|  | | <a name=\"301\">301</a>|Dependencies|  | | <a name=\"304\">304</a>|Portfolio Preprocess Failure|  | | <a name=\"310\">310</a>|Valuation Engine Failure|  | | <a name=\"311\">311</a>|Task Factory Failure|  | | <a name=\"312\">312</a>|Task Evaluation Failure|  | | <a name=\"313\">313</a>|Task Generation Failure|  | | <a name=\"314\">314</a>|Engine Configuration Failure|  | | <a name=\"315\">315</a>|Model Specification Failure|  | | <a name=\"320\">320</a>|Market Data Key Failure|  | | <a name=\"321\">321</a>|Market Resolver Failure|  | | <a name=\"322\">322</a>|Market Data Failure|  | | <a name=\"330\">330</a>|Curve Failure|  | | <a name=\"331\">331</a>|Volatility Surface Failure|  | | <a name=\"332\">332</a>|Volatility Cube Failure|  | | <a name=\"350\">350</a>|Instrument Failure|  | | <a name=\"351\">351</a>|Cash Flows Failure|  | | <a name=\"352\">352</a>|Reference Data Failure|  | | <a name=\"360\">360</a>|Aggregation Failure|  | | <a name=\"361\">361</a>|Aggregation Measure Failure|  | | <a name=\"370\">370</a>|Result Retrieval Failure|  | | <a name=\"371\">371</a>|Result Processing Failure|  | | <a name=\"372\">372</a>|Vendor Result Processing Failure|  | | <a name=\"373\">373</a>|Vendor Result Mapping Failure|  | | <a name=\"374\">374</a>|Vendor Library Unauthorised|  | | <a name=\"375\">375</a>|Vendor Connectivity Error|  | | <a name=\"376\">376</a>|Vendor Interface Error|  | | <a name=\"377\">377</a>|Vendor Pricing Failure|  | | <a name=\"378\">378</a>|Vendor Translation Failure|  | | <a name=\"379\">379</a>|Vendor Key Mapping Failure|  | | <a name=\"380\">380</a>|Vendor Reflection Failure|  | | <a name=\"381\">381</a>|Vendor Process Failure|  | | <a name=\"382\">382</a>|Vendor System Failure|  | | <a name=\"390\">390</a>|Attempt To Upsert Duplicate Quotes|  | | <a name=\"391\">391</a>|Corporate Action Source Does Not Exist|  | | <a name=\"392\">392</a>|Corporate Action Source Already Exists|  | | <a name=\"393\">393</a>|Instrument Identifier Already In Use|  | | <a name=\"394\">394</a>|Properties Not Found|  | | <a name=\"395\">395</a>|Batch Operation Aborted|  | | <a name=\"400\">400</a>|Invalid Iso4217 Currency Code|  | | <a name=\"401\">401</a>|Cannot Assign Instrument Identifier To Currency|  | | <a name=\"402\">402</a>|Cannot Assign Currency Identifier To Non Currency|  | | <a name=\"403\">403</a>|Currency Instrument Cannot Be Deleted|  | | <a name=\"404\">404</a>|Currency Instrument Cannot Have Economic Definition|  | | <a name=\"405\">405</a>|Currency Instrument Cannot Have Lookthrough Portfolio|  | | <a name=\"406\">406</a>|Cannot Create Currency Instrument With Multiple Identifiers|  | | <a name=\"407\">407</a>|Specified Currency Is Undefined|  | | <a name=\"410\">410</a>|Index Does Not Exist|  | | <a name=\"411\">411</a>|Sort Field Does Not Exist|  | | <a name=\"413\">413</a>|Negative Pagination Parameters|  | | <a name=\"414\">414</a>|Invalid Search Syntax|  | | <a name=\"415\">415</a>|Filter Execution Timeout|  | | <a name=\"420\">420</a>|Side Definition Inconsistent|  | | <a name=\"450\">450</a>|Invalid Quote Access Metadata Rule|  | | <a name=\"451\">451</a>|Access Metadata Not Found|  | | <a name=\"452\">452</a>|Invalid Access Metadata Identifier|  | | <a name=\"460\">460</a>|Standard Resource Not Found|  | | <a name=\"461\">461</a>|Standard Resource Conflict|  | | <a name=\"462\">462</a>|Calendar Not Found|  | | <a name=\"463\">463</a>|Date In A Calendar Not Found|  | | <a name=\"464\">464</a>|Invalid Date Source Data|  | | <a name=\"465\">465</a>|Invalid Timezone|  | | <a name=\"601\">601</a>|Person Identifier Already In Use|  | | <a name=\"602\">602</a>|Person Not Found|  | | <a name=\"603\">603</a>|Cannot Set Identifier|  | | <a name=\"617\">617</a>|Invalid Recipe Specification In Request|  | | <a name=\"618\">618</a>|Inline Recipe Deserialisation Failure|  | | <a name=\"619\">619</a>|Identifier Types Not Set For Entity|  | | <a name=\"620\">620</a>|Cannot Delete All Client Defined Identifiers|  | | <a name=\"650\">650</a>|The Order requested was not found.|  | | <a name=\"654\">654</a>|The Allocation requested was not found.|  | | <a name=\"655\">655</a>|Cannot build the fx forward target with the given holdings.|  | | <a name=\"656\">656</a>|Group does not contain expected entities.|  | | <a name=\"665\">665</a>|Destination directory not found|  | | <a name=\"667\">667</a>|Relation definition already exists|  | | <a name=\"672\">672</a>|Could not retrieve file contents|  | | <a name=\"673\">673</a>|Missing entitlements for entities in Group|  | | <a name=\"674\">674</a>|Next Best Action not found|  | | <a name=\"676\">676</a>|Relation definition not defined|  | | <a name=\"677\">677</a>|Invalid entity identifier for relation|  | | <a name=\"681\">681</a>|Sorting by specified field not supported|One or more of the provided fields to order by were either invalid or not supported. | | <a name=\"682\">682</a>|Too many fields to sort by|The number of fields to sort the data by exceeds the number allowed by the endpoint | | <a name=\"684\">684</a>|Sequence Not Found|  | | <a name=\"685\">685</a>|Sequence Already Exists|  | | <a name=\"686\">686</a>|Non-cycling sequence has been exhausted|  | | <a name=\"687\">687</a>|Legal Entity Identifier Already In Use|  | | <a name=\"688\">688</a>|Legal Entity Not Found|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"690\">690</a>|Property Type Is Not Supported|  | | <a name=\"691\">691</a>|Multiple Tax-lots For Currency Type Is Not Supported|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"693\">693</a>|Entity type is not supported for Relationship|  | | <a name=\"694\">694</a>|Relationship Validation Failure|  | | <a name=\"695\">695</a>|Relationship Not Found|  | | <a name=\"697\">697</a>|Derived Property Formula No Longer Valid|  | | <a name=\"698\">698</a>|Story is not available|  | | <a name=\"703\">703</a>|Corporate Action Does Not Exist|  | | <a name=\"720\">720</a>|The provided sort and filter combination is not valid|  | | <a name=\"721\">721</a>|A2B generation failed|  | | <a name=\"722\">722</a>|Aggregated Return Calculation Failure|  | | <a name=\"723\">723</a>|Custom Entity Definition Identifier Already In Use|  | | <a name=\"724\">724</a>|Custom Entity Definition Not Found|  | | <a name=\"725\">725</a>|The Placement requested was not found.|  | | <a name=\"726\">726</a>|The Execution requested was not found.|  | | <a name=\"727\">727</a>|The Block requested was not found.|  | | <a name=\"728\">728</a>|The Participation requested was not found.|  | | <a name=\"729\">729</a>|The Package requested was not found.|  | | <a name=\"730\">730</a>|The OrderInstruction requested was not found.|  | | <a name=\"732\">732</a>|Custom Entity not found.|  | | <a name=\"733\">733</a>|Custom Entity Identifier already in use.|  | | <a name=\"735\">735</a>|Calculation Failed.|  | | <a name=\"736\">736</a>|An expected key on HttpResponse is missing.|  | | <a name=\"737\">737</a>|A required fee detail is missing.|  | | <a name=\"738\">738</a>|Zero rows were returned from Luminesce|  | | <a name=\"739\">739</a>|Provided Weekend Mask was invalid|  | | <a name=\"742\">742</a>|Custom Entity fields do not match the definition|  | | <a name=\"746\">746</a>|The provided sequence is not valid.|  | | <a name=\"751\">751</a>|The type of the Custom Entity is different than the type provided in the definition.|  | | <a name=\"752\">752</a>|Luminesce process returned an error.|  | | <a name=\"753\">753</a>|File name or content incompatible with operation.|  | | <a name=\"755\">755</a>|Schema of response from Drive is not as expected.|  | | <a name=\"757\">757</a>|Schema of response from Luminesce is not as expected.|  | | <a name=\"758\">758</a>|Luminesce timed out.|  | | <a name=\"763\">763</a>|Invalid Lusid Entity Identifier Unit|  | | <a name=\"768\">768</a>|Fee rule not found.|  | | <a name=\"769\">769</a>|Cannot update the base currency of a portfolio with transactions loaded|  | | <a name=\"771\">771</a>|Transaction configuration source not found|  | | <a name=\"774\">774</a>|Compliance rule not found.|  | | <a name=\"775\">775</a>|Fund accounting document cannot be processed.|  | | <a name=\"778\">778</a>|Unable to look up FX rate from trade ccy to portfolio ccy for some of the trades.|  | | <a name=\"782\">782</a>|The Property definition dataType is not matching the derivation formula dataType|  | | <a name=\"783\">783</a>|The Property definition domain is not supported for derived properties|  | | <a name=\"788\">788</a>|Compliance run not found failure.|  | 
 *
 * The version of the OpenAPI document: 0.11.4327
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
    /// A list of property definitions.
    /// </summary>
    [DataContract(Name = "PropertyDefinition")]
    public partial class PropertyDefinition : IEquatable<PropertyDefinition>
    {
        /// <summary>
        /// The type of values that can be associated with this property. This is defined by the property&#39;s data type. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel
        /// </summary>
        /// <value>The type of values that can be associated with this property. This is defined by the property&#39;s data type. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueTypeEnum
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
            /// Enum Map for value: Map
            /// </summary>
            [EnumMember(Value = "Map")]
            Map = 6,

            /// <summary>
            /// Enum List for value: List
            /// </summary>
            [EnumMember(Value = "List")]
            List = 7,

            /// <summary>
            /// Enum PropertyArray for value: PropertyArray
            /// </summary>
            [EnumMember(Value = "PropertyArray")]
            PropertyArray = 8,

            /// <summary>
            /// Enum Percentage for value: Percentage
            /// </summary>
            [EnumMember(Value = "Percentage")]
            Percentage = 9,

            /// <summary>
            /// Enum Code for value: Code
            /// </summary>
            [EnumMember(Value = "Code")]
            Code = 10,

            /// <summary>
            /// Enum Id for value: Id
            /// </summary>
            [EnumMember(Value = "Id")]
            Id = 11,

            /// <summary>
            /// Enum Uri for value: Uri
            /// </summary>
            [EnumMember(Value = "Uri")]
            Uri = 12,

            /// <summary>
            /// Enum CurrencyAndAmount for value: CurrencyAndAmount
            /// </summary>
            [EnumMember(Value = "CurrencyAndAmount")]
            CurrencyAndAmount = 13,

            /// <summary>
            /// Enum TradePrice for value: TradePrice
            /// </summary>
            [EnumMember(Value = "TradePrice")]
            TradePrice = 14,

            /// <summary>
            /// Enum Currency for value: Currency
            /// </summary>
            [EnumMember(Value = "Currency")]
            Currency = 15,

            /// <summary>
            /// Enum MetricValue for value: MetricValue
            /// </summary>
            [EnumMember(Value = "MetricValue")]
            MetricValue = 16,

            /// <summary>
            /// Enum ResourceId for value: ResourceId
            /// </summary>
            [EnumMember(Value = "ResourceId")]
            ResourceId = 17,

            /// <summary>
            /// Enum ResultValue for value: ResultValue
            /// </summary>
            [EnumMember(Value = "ResultValue")]
            ResultValue = 18,

            /// <summary>
            /// Enum CutLocalTime for value: CutLocalTime
            /// </summary>
            [EnumMember(Value = "CutLocalTime")]
            CutLocalTime = 19,

            /// <summary>
            /// Enum DateOrCutLabel for value: DateOrCutLabel
            /// </summary>
            [EnumMember(Value = "DateOrCutLabel")]
            DateOrCutLabel = 20

        }


        /// <summary>
        /// The type of values that can be associated with this property. This is defined by the property&#39;s data type. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel
        /// </summary>
        /// <value>The type of values that can be associated with this property. This is defined by the property&#39;s data type. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel</value>
        [DataMember(Name = "valueType", EmitDefaultValue = false)]
        public ValueTypeEnum? ValueType { get; set; }
        /// <summary>
        /// The type of the property. The available values are: Label, Metric, Information
        /// </summary>
        /// <value>The type of the property. The available values are: Label, Metric, Information</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Label for value: Label
            /// </summary>
            [EnumMember(Value = "Label")]
            Label = 1,

            /// <summary>
            /// Enum Metric for value: Metric
            /// </summary>
            [EnumMember(Value = "Metric")]
            Metric = 2,

            /// <summary>
            /// Enum Information for value: Information
            /// </summary>
            [EnumMember(Value = "Information")]
            Information = 3

        }


        /// <summary>
        /// The type of the property. The available values are: Label, Metric, Information
        /// </summary>
        /// <value>The type of the property. The available values are: Label, Metric, Information</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The units that can be associated with the property&#39;s values. This is defined by the property&#39;s data type. The available values are: NoUnits, Basic, Iso4217Currency
        /// </summary>
        /// <value>The units that can be associated with the property&#39;s values. This is defined by the property&#39;s data type. The available values are: NoUnits, Basic, Iso4217Currency</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitSchemaEnum
        {
            /// <summary>
            /// Enum NoUnits for value: NoUnits
            /// </summary>
            [EnumMember(Value = "NoUnits")]
            NoUnits = 1,

            /// <summary>
            /// Enum Basic for value: Basic
            /// </summary>
            [EnumMember(Value = "Basic")]
            Basic = 2,

            /// <summary>
            /// Enum Iso4217Currency for value: Iso4217Currency
            /// </summary>
            [EnumMember(Value = "Iso4217Currency")]
            Iso4217Currency = 3

        }


        /// <summary>
        /// The units that can be associated with the property&#39;s values. This is defined by the property&#39;s data type. The available values are: NoUnits, Basic, Iso4217Currency
        /// </summary>
        /// <value>The units that can be associated with the property&#39;s values. This is defined by the property&#39;s data type. The available values are: NoUnits, Basic, Iso4217Currency</value>
        [DataMember(Name = "unitSchema", EmitDefaultValue = false)]
        public UnitSchemaEnum? UnitSchema { get; set; }
        /// <summary>
        /// The domain that the property exists in. The available values are: NotDefined, Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, CutLabelDefinition, Analytic, PortfolioGroup, Person, AccessMetadata, Order, UnitResult, MarketData, ConfigurationRecipe, Allocation, Calendar, LegalEntity, Placement, Execution, Block, Participation, Package, OrderInstruction, NextBestAction, CustomEntity
        /// </summary>
        /// <value>The domain that the property exists in. The available values are: NotDefined, Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, CutLabelDefinition, Analytic, PortfolioGroup, Person, AccessMetadata, Order, UnitResult, MarketData, ConfigurationRecipe, Allocation, Calendar, LegalEntity, Placement, Execution, Block, Participation, Package, OrderInstruction, NextBestAction, CustomEntity</value>
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
            /// Enum NextBestAction for value: NextBestAction
            /// </summary>
            [EnumMember(Value = "NextBestAction")]
            NextBestAction = 26,

            /// <summary>
            /// Enum CustomEntity for value: CustomEntity
            /// </summary>
            [EnumMember(Value = "CustomEntity")]
            CustomEntity = 27

        }


        /// <summary>
        /// The domain that the property exists in. The available values are: NotDefined, Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, CutLabelDefinition, Analytic, PortfolioGroup, Person, AccessMetadata, Order, UnitResult, MarketData, ConfigurationRecipe, Allocation, Calendar, LegalEntity, Placement, Execution, Block, Participation, Package, OrderInstruction, NextBestAction, CustomEntity
        /// </summary>
        /// <value>The domain that the property exists in. The available values are: NotDefined, Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, CutLabelDefinition, Analytic, PortfolioGroup, Person, AccessMetadata, Order, UnitResult, MarketData, ConfigurationRecipe, Allocation, Calendar, LegalEntity, Placement, Execution, Block, Participation, Package, OrderInstruction, NextBestAction, CustomEntity</value>
        [DataMember(Name = "domain", EmitDefaultValue = false)]
        public DomainEnum? Domain { get; set; }
        /// <summary>
        /// Describes how the property&#39;s values can change over time. The available values are: Perpetual, TimeVariant
        /// </summary>
        /// <value>Describes how the property&#39;s values can change over time. The available values are: Perpetual, TimeVariant</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LifeTimeEnum
        {
            /// <summary>
            /// Enum Perpetual for value: Perpetual
            /// </summary>
            [EnumMember(Value = "Perpetual")]
            Perpetual = 1,

            /// <summary>
            /// Enum TimeVariant for value: TimeVariant
            /// </summary>
            [EnumMember(Value = "TimeVariant")]
            TimeVariant = 2

        }


        /// <summary>
        /// Describes how the property&#39;s values can change over time. The available values are: Perpetual, TimeVariant
        /// </summary>
        /// <value>Describes how the property&#39;s values can change over time. The available values are: Perpetual, TimeVariant</value>
        [DataMember(Name = "lifeTime", EmitDefaultValue = false)]
        public LifeTimeEnum? LifeTime { get; set; }
        /// <summary>
        /// The definition type (DerivedDefinition or Definition). The available values are: ValueProperty, DerivedDefinition
        /// </summary>
        /// <value>The definition type (DerivedDefinition or Definition). The available values are: ValueProperty, DerivedDefinition</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PropertyDefinitionTypeEnum
        {
            /// <summary>
            /// Enum ValueProperty for value: ValueProperty
            /// </summary>
            [EnumMember(Value = "ValueProperty")]
            ValueProperty = 1,

            /// <summary>
            /// Enum DerivedDefinition for value: DerivedDefinition
            /// </summary>
            [EnumMember(Value = "DerivedDefinition")]
            DerivedDefinition = 2

        }


        /// <summary>
        /// The definition type (DerivedDefinition or Definition). The available values are: ValueProperty, DerivedDefinition
        /// </summary>
        /// <value>The definition type (DerivedDefinition or Definition). The available values are: ValueProperty, DerivedDefinition</value>
        [DataMember(Name = "propertyDefinitionType", EmitDefaultValue = false)]
        public PropertyDefinitionTypeEnum? PropertyDefinitionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyDefinition" /> class.
        /// </summary>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="key">The property key which uniquely identifies the property. The format for the property key is {domain}/{scope}/{code}, e.g. &#39;Portfolio/Manager/Id&#39;..</param>
        /// <param name="valueType">The type of values that can be associated with this property. This is defined by the property&#39;s data type. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel.</param>
        /// <param name="displayName">The display name of the property..</param>
        /// <param name="dataTypeId">dataTypeId.</param>
        /// <param name="type">The type of the property. The available values are: Label, Metric, Information.</param>
        /// <param name="unitSchema">The units that can be associated with the property&#39;s values. This is defined by the property&#39;s data type. The available values are: NoUnits, Basic, Iso4217Currency.</param>
        /// <param name="domain">The domain that the property exists in. The available values are: NotDefined, Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, CutLabelDefinition, Analytic, PortfolioGroup, Person, AccessMetadata, Order, UnitResult, MarketData, ConfigurationRecipe, Allocation, Calendar, LegalEntity, Placement, Execution, Block, Participation, Package, OrderInstruction, NextBestAction, CustomEntity.</param>
        /// <param name="valueRequired">This field is not implemented and should be disregarded..</param>
        /// <param name="lifeTime">Describes how the property&#39;s values can change over time. The available values are: Perpetual, TimeVariant.</param>
        /// <param name="constraintStyle">Describes the uniqueness and cardinality of the property for entity objects under the property domain specified in Key..</param>
        /// <param name="propertyDefinitionType">The definition type (DerivedDefinition or Definition). The available values are: ValueProperty, DerivedDefinition.</param>
        /// <param name="propertyDescription">A brief description of what a property of this property definition contains..</param>
        /// <param name="derivationFormula">The rule that defines how data is composed for a derived property..</param>
        /// <param name="links">Collection of links..</param>
        public PropertyDefinition(string href = default(string), string key = default(string), ValueTypeEnum? valueType = default(ValueTypeEnum?), string displayName = default(string), ResourceId dataTypeId = default(ResourceId), TypeEnum? type = default(TypeEnum?), UnitSchemaEnum? unitSchema = default(UnitSchemaEnum?), DomainEnum? domain = default(DomainEnum?), bool valueRequired = default(bool), LifeTimeEnum? lifeTime = default(LifeTimeEnum?), string constraintStyle = default(string), PropertyDefinitionTypeEnum? propertyDefinitionType = default(PropertyDefinitionTypeEnum?), string propertyDescription = default(string), string derivationFormula = default(string), List<Link> links = default(List<Link>))
        {
            this.Href = href;
            this.Key = key;
            this.ValueType = valueType;
            this.DisplayName = displayName;
            this.DataTypeId = dataTypeId;
            this.Type = type;
            this.UnitSchema = unitSchema;
            this.Domain = domain;
            this.ValueRequired = valueRequired;
            this.LifeTime = lifeTime;
            this.ConstraintStyle = constraintStyle;
            this.PropertyDefinitionType = propertyDefinitionType;
            this.PropertyDescription = propertyDescription;
            this.DerivationFormula = derivationFormula;
            this.Links = links;
        }

        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// The property key which uniquely identifies the property. The format for the property key is {domain}/{scope}/{code}, e.g. &#39;Portfolio/Manager/Id&#39;.
        /// </summary>
        /// <value>The property key which uniquely identifies the property. The format for the property key is {domain}/{scope}/{code}, e.g. &#39;Portfolio/Manager/Id&#39;.</value>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The display name of the property.
        /// </summary>
        /// <value>The display name of the property.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets DataTypeId
        /// </summary>
        [DataMember(Name = "dataTypeId", EmitDefaultValue = false)]
        public ResourceId DataTypeId { get; set; }

        /// <summary>
        /// The scope that the property exists in.
        /// </summary>
        /// <value>The scope that the property exists in.</value>
        [DataMember(Name = "scope", EmitDefaultValue = true)]
        public string Scope { get; private set; }

        /// <summary>
        /// Returns false as Scope should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeScope()
        {
            return false;
        }

        /// <summary>
        /// The code of the property. Together with the domain and scope this uniquely identifies the property.
        /// </summary>
        /// <value>The code of the property. Together with the domain and scope this uniquely identifies the property.</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; private set; }

        /// <summary>
        /// Returns false as Code should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCode()
        {
            return false;
        }

        /// <summary>
        /// This field is not implemented and should be disregarded.
        /// </summary>
        /// <value>This field is not implemented and should be disregarded.</value>
        [DataMember(Name = "valueRequired", EmitDefaultValue = true)]
        public bool ValueRequired { get; set; }

        /// <summary>
        /// Describes the uniqueness and cardinality of the property for entity objects under the property domain specified in Key.
        /// </summary>
        /// <value>Describes the uniqueness and cardinality of the property for entity objects under the property domain specified in Key.</value>
        [DataMember(Name = "constraintStyle", EmitDefaultValue = true)]
        public string ConstraintStyle { get; set; }

        /// <summary>
        /// A brief description of what a property of this property definition contains.
        /// </summary>
        /// <value>A brief description of what a property of this property definition contains.</value>
        [DataMember(Name = "propertyDescription", EmitDefaultValue = true)]
        public string PropertyDescription { get; set; }

        /// <summary>
        /// The rule that defines how data is composed for a derived property.
        /// </summary>
        /// <value>The rule that defines how data is composed for a derived property.</value>
        [DataMember(Name = "derivationFormula", EmitDefaultValue = true)]
        public string DerivationFormula { get; set; }

        /// <summary>
        /// Collection of links.
        /// </summary>
        /// <value>Collection of links.</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyDefinition {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DataTypeId: ").Append(DataTypeId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UnitSchema: ").Append(UnitSchema).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ValueRequired: ").Append(ValueRequired).Append("\n");
            sb.Append("  LifeTime: ").Append(LifeTime).Append("\n");
            sb.Append("  ConstraintStyle: ").Append(ConstraintStyle).Append("\n");
            sb.Append("  PropertyDefinitionType: ").Append(PropertyDefinitionType).Append("\n");
            sb.Append("  PropertyDescription: ").Append(PropertyDescription).Append("\n");
            sb.Append("  DerivationFormula: ").Append(DerivationFormula).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as PropertyDefinition);
        }

        /// <summary>
        /// Returns true if PropertyDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    this.ValueType.Equals(input.ValueType)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.UnitSchema == input.UnitSchema ||
                    this.UnitSchema.Equals(input.UnitSchema)
                ) && 
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
                    this.ValueRequired == input.ValueRequired ||
                    this.ValueRequired.Equals(input.ValueRequired)
                ) && 
                (
                    this.LifeTime == input.LifeTime ||
                    this.LifeTime.Equals(input.LifeTime)
                ) && 
                (
                    this.ConstraintStyle == input.ConstraintStyle ||
                    (this.ConstraintStyle != null &&
                    this.ConstraintStyle.Equals(input.ConstraintStyle))
                ) && 
                (
                    this.PropertyDefinitionType == input.PropertyDefinitionType ||
                    this.PropertyDefinitionType.Equals(input.PropertyDefinitionType)
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
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DataTypeId != null)
                    hashCode = hashCode * 59 + this.DataTypeId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.UnitSchema.GetHashCode();
                hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                hashCode = hashCode * 59 + this.ValueRequired.GetHashCode();
                hashCode = hashCode * 59 + this.LifeTime.GetHashCode();
                if (this.ConstraintStyle != null)
                    hashCode = hashCode * 59 + this.ConstraintStyle.GetHashCode();
                hashCode = hashCode * 59 + this.PropertyDefinitionType.GetHashCode();
                if (this.PropertyDescription != null)
                    hashCode = hashCode * 59 + this.PropertyDescription.GetHashCode();
                if (this.DerivationFormula != null)
                    hashCode = hashCode * 59 + this.DerivationFormula.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
