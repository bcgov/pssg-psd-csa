// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Pssg.Csa.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.contractdetail
    /// </summary>
    public partial class MicrosoftDynamicsCRMcontractdetail
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcontractdetail class.
        /// </summary>
        public MicrosoftDynamicsCRMcontractdetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcontractdetail class.
        /// </summary>
        public MicrosoftDynamicsCRMcontractdetail(System.Guid? _owninguserValue = default(System.Guid?), System.Guid? _transactioncurrencyidValue = default(System.Guid?), System.DateTimeOffset? expireson = default(System.DateTimeOffset?), System.Guid? _uomscheduleidValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _productidValue = default(System.Guid?), decimal? rate = default(decimal?), int? statuscode = default(int?), int? allotmentsoverage = default(int?), int? allotmentsused = default(int?), int? lineitemorder = default(int?), int? allotmentsremaining = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), int? servicecontractunitscode = default(int?), System.Guid? _uomidValue = default(System.Guid?), int? timezoneruleversionnumber = default(int?), decimal? netBase = default(decimal?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.Guid? _owningbusinessunitValue = default(System.Guid?), int? importsequencenumber = default(int?), System.Guid? _owningteamValue = default(System.Guid?), string title = default(string), string effectivitycalendar = default(string), int? contractstatecode = default(int?), System.Guid? _serviceaddressValue = default(System.Guid?), decimal? price = default(decimal?), int? initialquantity = default(int?), int? statecode = default(int?), int? totalallotments = default(int?), decimal? net = default(decimal?), System.Guid? _owneridValue = default(System.Guid?), decimal? rateBase = default(decimal?), decimal? exchangerate = default(decimal?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.Guid? _contractidValue = default(System.Guid?), System.Guid? _createdbyValue = default(System.Guid?), decimal? discountpercentage = default(decimal?), System.Guid? _accountidValue = default(System.Guid?), System.Guid? contractdetailid = default(System.Guid?), System.Guid? _contactidValue = default(System.Guid?), decimal? discount = default(decimal?), decimal? priceBase = default(decimal?), System.DateTimeOffset? activeon = default(System.DateTimeOffset?), System.Guid? _customeridValue = default(System.Guid?), System.Guid? _modifiedbyValue = default(System.Guid?), decimal? discountBase = default(decimal?), string versionnumber = default(string), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), string productserialnumber = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMsyncerror> contractDetailSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> contractDetailAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> contractdetailMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> contractDetailProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> contractDetailBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> contractdetailPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMannotation> contractDetailAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMaccount customeridAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact customeridContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMcontract contractid = default(MicrosoftDynamicsCRMcontract), IList<MicrosoftDynamicsCRMincident> contractDetailCases = default(IList<MicrosoftDynamicsCRMincident>), MicrosoftDynamicsCRMcustomeraddress serviceaddress = default(MicrosoftDynamicsCRMcustomeraddress), MicrosoftDynamicsCRMproduct productid = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMuom uomid = default(MicrosoftDynamicsCRMuom), MicrosoftDynamicsCRMuomschedule uomscheduleid = default(MicrosoftDynamicsCRMuomschedule))
        {
            this._owninguserValue = _owninguserValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Expireson = expireson;
            this._uomscheduleidValue = _uomscheduleidValue;
            Createdon = createdon;
            this._productidValue = _productidValue;
            Rate = rate;
            Statuscode = statuscode;
            Allotmentsoverage = allotmentsoverage;
            Allotmentsused = allotmentsused;
            Lineitemorder = lineitemorder;
            Allotmentsremaining = allotmentsremaining;
            Overriddencreatedon = overriddencreatedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Servicecontractunitscode = servicecontractunitscode;
            this._uomidValue = _uomidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            NetBase = netBase;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Importsequencenumber = importsequencenumber;
            this._owningteamValue = _owningteamValue;
            Title = title;
            Effectivitycalendar = effectivitycalendar;
            Contractstatecode = contractstatecode;
            this._serviceaddressValue = _serviceaddressValue;
            Price = price;
            Initialquantity = initialquantity;
            Statecode = statecode;
            Totalallotments = totalallotments;
            Net = net;
            this._owneridValue = _owneridValue;
            RateBase = rateBase;
            Exchangerate = exchangerate;
            Modifiedon = modifiedon;
            this._contractidValue = _contractidValue;
            this._createdbyValue = _createdbyValue;
            Discountpercentage = discountpercentage;
            this._accountidValue = _accountidValue;
            Contractdetailid = contractdetailid;
            this._contactidValue = _contactidValue;
            Discount = discount;
            PriceBase = priceBase;
            Activeon = activeon;
            this._customeridValue = _customeridValue;
            this._modifiedbyValue = _modifiedbyValue;
            DiscountBase = discountBase;
            Versionnumber = versionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Productserialnumber = productserialnumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            ContractDetailSyncErrors = contractDetailSyncErrors;
            ContractDetailAsyncOperations = contractDetailAsyncOperations;
            ContractdetailMailboxTrackingFolders = contractdetailMailboxTrackingFolders;
            ContractDetailProcessSessions = contractDetailProcessSessions;
            ContractDetailBulkDeleteFailures = contractDetailBulkDeleteFailures;
            ContractdetailPrincipalobjectattributeaccess = contractdetailPrincipalobjectattributeaccess;
            Transactioncurrencyid = transactioncurrencyid;
            ContractDetailAnnotation = contractDetailAnnotation;
            CustomeridAccount = customeridAccount;
            CustomeridContact = customeridContact;
            Contractid = contractid;
            ContractDetailCases = contractDetailCases;
            Serviceaddress = serviceaddress;
            Productid = productid;
            Uomid = uomid;
            Uomscheduleid = uomscheduleid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public System.Guid? _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public System.Guid? _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expireson")]
        public System.DateTimeOffset? Expireson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomscheduleid_value")]
        public System.Guid? _uomscheduleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_productid_value")]
        public System.Guid? _productidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public decimal? Rate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allotmentsoverage")]
        public int? Allotmentsoverage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allotmentsused")]
        public int? Allotmentsused { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lineitemorder")]
        public int? Lineitemorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allotmentsremaining")]
        public int? Allotmentsremaining { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicecontractunitscode")]
        public int? Servicecontractunitscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_uomid_value")]
        public System.Guid? _uomidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "net_base")]
        public decimal? NetBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public System.Guid? _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public System.Guid? _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectivitycalendar")]
        public string Effectivitycalendar { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractstatecode")]
        public int? Contractstatecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_serviceaddress_value")]
        public System.Guid? _serviceaddressValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "initialquantity")]
        public int? Initialquantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalallotments")]
        public int? Totalallotments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "net")]
        public decimal? Net { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public System.Guid? _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rate_base")]
        public decimal? RateBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contractid_value")]
        public System.Guid? _contractidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountpercentage")]
        public decimal? Discountpercentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public System.Guid? _accountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractdetailid")]
        public System.Guid? Contractdetailid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public System.Guid? _contactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discount")]
        public decimal? Discount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_base")]
        public decimal? PriceBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activeon")]
        public System.DateTimeOffset? Activeon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_customerid_value")]
        public System.Guid? _customeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discount_base")]
        public decimal? DiscountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productserialnumber")]
        public string Productserialnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContractDetail_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ContractDetailSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContractDetail_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ContractDetailAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractdetail_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ContractdetailMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContractDetail_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> ContractDetailProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContractDetail_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ContractDetailBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractdetail_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ContractdetailPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContractDetail_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> ContractDetailAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_account")]
        public MicrosoftDynamicsCRMaccount CustomeridAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_contact")]
        public MicrosoftDynamicsCRMcontact CustomeridContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractid")]
        public MicrosoftDynamicsCRMcontract Contractid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contract_detail_cases")]
        public IList<MicrosoftDynamicsCRMincident> ContractDetailCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceaddress")]
        public MicrosoftDynamicsCRMcustomeraddress Serviceaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public MicrosoftDynamicsCRMproduct Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public MicrosoftDynamicsCRMuom Uomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomscheduleid")]
        public MicrosoftDynamicsCRMuomschedule Uomscheduleid { get; set; }

    }
}
