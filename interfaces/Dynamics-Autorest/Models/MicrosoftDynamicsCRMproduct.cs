// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Pssg.Csa.Interfaces.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.product
    /// </summary>
    public partial class MicrosoftDynamicsCRMproduct
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMproduct
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMproduct()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMproduct
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMproduct(decimal? standardcost = default(decimal?), string hierarchypath = default(string), System.Guid? _createdbyexternalpartyValue = default(System.Guid?), System.Guid? _defaultuomscheduleidValue = default(System.Guid?), int? productstructure = default(int?), decimal? currentcostBase = default(decimal?), decimal? standardcostBase = default(decimal?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string versionnumber = default(string), System.Guid? _defaultuomidValue = default(System.Guid?), int? dmtimportstate = default(int?), System.DateTime? validtodate = default(System.DateTime?), decimal? currentcost = default(decimal?), int? timezoneruleversionnumber = default(int?), decimal? price = default(decimal?), int? quantitydecimal = default(int?), int? importsequencenumber = default(int?), System.Guid? _subjectidValue = default(System.Guid?), System.Guid? _transactioncurrencyidValue = default(System.Guid?), string suppliername = default(string), System.DateTime? validfromdate = default(System.DateTime?), int? statuscode = default(int?), int? statecode = default(int?), string traversedpath = default(string), string productnumber = default(string), System.Guid? _organizationidValue = default(System.Guid?), string description = default(string), System.Guid? _modifiedbyexternalpartyValue = default(System.Guid?), System.Guid? _createdbyValue = default(System.Guid?), decimal? exchangerate = default(decimal?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.Guid? stageid = default(System.Guid?), System.Guid? _parentproductidValue = default(System.Guid?), System.Guid? _pricelevelidValue = default(System.Guid?), string producturl = default(string), string size = default(string), string vendorname = default(string), int? producttypecode = default(int?), decimal? stockweight = default(decimal?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string name = default(string), System.Guid? processid = default(System.Guid?), bool? iskit = default(bool?), decimal? priceBase = default(decimal?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.Guid? entityimageid = default(System.Guid?), bool? isstockitem = default(bool?), string vendorid = default(string), string vendorpartnumber = default(string), System.Guid? productid = default(System.Guid?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), byte[] entityimage = default(byte[]), string entityimageUrl = default(string), System.Guid? _modifiedbyValue = default(System.Guid?), long? entityimageTimestamp = default(long?), int? utcconversiontimezonecode = default(int?), decimal? quantityonhand = default(decimal?), decimal? stockvolume = default(decimal?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> productSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> productSharepointDocumentLocation = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMasyncoperation> productAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> productMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> productProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> productBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> productPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMconnection> productConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> productConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMannotation> productAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMpricelevel pricelevelid = default(MicrosoftDynamicsCRMpricelevel), IList<MicrosoftDynamicsCRMdynamicproperty> productDynamicProperty = default(IList<MicrosoftDynamicsCRMdynamicproperty>), IList<MicrosoftDynamicsCRMdynamicpropertyassociation> productDynamicPropertyAssociation = default(IList<MicrosoftDynamicsCRMdynamicpropertyassociation>), MicrosoftDynamicsCRMproduct parentproductid = default(MicrosoftDynamicsCRMproduct), IList<MicrosoftDynamicsCRMproduct> productParentProduct = default(IList<MicrosoftDynamicsCRMproduct>), IList<MicrosoftDynamicsCRMproductassociation> productProductAssociationAssocProd = default(IList<MicrosoftDynamicsCRMproductassociation>), IList<MicrosoftDynamicsCRMproductassociation> productProductAssociationProd = default(IList<MicrosoftDynamicsCRMproductassociation>), IList<MicrosoftDynamicsCRMproductsubstitute> productProductSubstituteSubstitutedproductid = default(IList<MicrosoftDynamicsCRMproductsubstitute>), IList<MicrosoftDynamicsCRMproductsubstitute> productProductSubstituteProductid = default(IList<MicrosoftDynamicsCRMproductsubstitute>), IList<MicrosoftDynamicsCRMproductpricelevel> productPriceLevels = default(IList<MicrosoftDynamicsCRMproductpricelevel>), MicrosoftDynamicsCRMsubject subjectid = default(MicrosoftDynamicsCRMsubject), MicrosoftDynamicsCRMuom defaultuomid = default(MicrosoftDynamicsCRMuom), MicrosoftDynamicsCRMuomschedule defaultuomscheduleid = default(MicrosoftDynamicsCRMuomschedule), IList<MicrosoftDynamicsCRMcampaign> campaignproductAssociation = default(IList<MicrosoftDynamicsCRMcampaign>), IList<MicrosoftDynamicsCRMcontractdetail> productContractLineItems = default(IList<MicrosoftDynamicsCRMcontractdetail>), IList<MicrosoftDynamicsCRMincident> productIncidents = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMentitlement> productEntitlementAssociation = default(IList<MicrosoftDynamicsCRMentitlement>), IList<MicrosoftDynamicsCRMentitlementtemplate> productEntitlementtemplateAssociation = default(IList<MicrosoftDynamicsCRMentitlementtemplate>), IList<MicrosoftDynamicsCRMlead> leadproductAssociation = default(IList<MicrosoftDynamicsCRMlead>), IList<MicrosoftDynamicsCRMopportunityproduct> opportunityProducts = default(IList<MicrosoftDynamicsCRMopportunityproduct>), IList<MicrosoftDynamicsCRMinvoicedetail> productInvoiceDetails = default(IList<MicrosoftDynamicsCRMinvoicedetail>), IList<MicrosoftDynamicsCRMsalesorderdetail> productOrderDetails = default(IList<MicrosoftDynamicsCRMsalesorderdetail>), IList<MicrosoftDynamicsCRMquotedetail> productQuoteDetails = default(IList<MicrosoftDynamicsCRMquotedetail>), IList<MicrosoftDynamicsCRMsalesliterature> productsalesliteratureAssociation = default(IList<MicrosoftDynamicsCRMsalesliterature>), IList<MicrosoftDynamicsCRMcompetitor> competitorproductAssociation = default(IList<MicrosoftDynamicsCRMcompetitor>))
        {
            Standardcost = standardcost;
            Hierarchypath = hierarchypath;
            this._createdbyexternalpartyValue = _createdbyexternalpartyValue;
            this._defaultuomscheduleidValue = _defaultuomscheduleidValue;
            Productstructure = productstructure;
            CurrentcostBase = currentcostBase;
            StandardcostBase = standardcostBase;
            Modifiedon = modifiedon;
            Versionnumber = versionnumber;
            this._defaultuomidValue = _defaultuomidValue;
            Dmtimportstate = dmtimportstate;
            Validtodate = validtodate;
            Currentcost = currentcost;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Price = price;
            Quantitydecimal = quantitydecimal;
            Importsequencenumber = importsequencenumber;
            this._subjectidValue = _subjectidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Suppliername = suppliername;
            Validfromdate = validfromdate;
            Statuscode = statuscode;
            Statecode = statecode;
            Traversedpath = traversedpath;
            Productnumber = productnumber;
            this._organizationidValue = _organizationidValue;
            Description = description;
            this._modifiedbyexternalpartyValue = _modifiedbyexternalpartyValue;
            this._createdbyValue = _createdbyValue;
            Exchangerate = exchangerate;
            Overriddencreatedon = overriddencreatedon;
            Stageid = stageid;
            this._parentproductidValue = _parentproductidValue;
            this._pricelevelidValue = _pricelevelidValue;
            Producturl = producturl;
            Size = size;
            Vendorname = vendorname;
            Producttypecode = producttypecode;
            Stockweight = stockweight;
            Createdon = createdon;
            Name = name;
            Processid = processid;
            Iskit = iskit;
            PriceBase = priceBase;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Entityimageid = entityimageid;
            Isstockitem = isstockitem;
            Vendorid = vendorid;
            Vendorpartnumber = vendorpartnumber;
            Productid = productid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Entityimage = entityimage;
            EntityimageUrl = entityimageUrl;
            this._modifiedbyValue = _modifiedbyValue;
            EntityimageTimestamp = entityimageTimestamp;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Quantityonhand = quantityonhand;
            Stockvolume = stockvolume;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            ProductSyncErrors = productSyncErrors;
            ProductSharepointDocumentLocation = productSharepointDocumentLocation;
            ProductAsyncOperations = productAsyncOperations;
            ProductMailboxTrackingFolders = productMailboxTrackingFolders;
            ProductProcessSessions = productProcessSessions;
            ProductBulkDeleteFailures = productBulkDeleteFailures;
            ProductPrincipalobjectattributeaccess = productPrincipalobjectattributeaccess;
            StageidProcessstage = stageidProcessstage;
            Transactioncurrencyid = transactioncurrencyid;
            ProductConnections1 = productConnections1;
            ProductConnections2 = productConnections2;
            ProductAnnotation = productAnnotation;
            Pricelevelid = pricelevelid;
            ProductDynamicProperty = productDynamicProperty;
            ProductDynamicPropertyAssociation = productDynamicPropertyAssociation;
            Parentproductid = parentproductid;
            ProductParentProduct = productParentProduct;
            ProductProductAssociationAssocProd = productProductAssociationAssocProd;
            ProductProductAssociationProd = productProductAssociationProd;
            ProductProductSubstituteSubstitutedproductid = productProductSubstituteSubstitutedproductid;
            ProductProductSubstituteProductid = productProductSubstituteProductid;
            ProductPriceLevels = productPriceLevels;
            Subjectid = subjectid;
            Defaultuomid = defaultuomid;
            Defaultuomscheduleid = defaultuomscheduleid;
            CampaignproductAssociation = campaignproductAssociation;
            ProductContractLineItems = productContractLineItems;
            ProductIncidents = productIncidents;
            ProductEntitlementAssociation = productEntitlementAssociation;
            ProductEntitlementtemplateAssociation = productEntitlementtemplateAssociation;
            LeadproductAssociation = leadproductAssociation;
            OpportunityProducts = opportunityProducts;
            ProductInvoiceDetails = productInvoiceDetails;
            ProductOrderDetails = productOrderDetails;
            ProductQuoteDetails = productQuoteDetails;
            ProductsalesliteratureAssociation = productsalesliteratureAssociation;
            CompetitorproductAssociation = competitorproductAssociation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "standardcost")]
        public decimal? Standardcost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hierarchypath")]
        public string Hierarchypath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdbyexternalparty_value")]
        public System.Guid? _createdbyexternalpartyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_defaultuomscheduleid_value")]
        public System.Guid? _defaultuomscheduleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productstructure")]
        public int? Productstructure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currentcost_base")]
        public decimal? CurrentcostBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "standardcost_base")]
        public decimal? StandardcostBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_defaultuomid_value")]
        public System.Guid? _defaultuomidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dmtimportstate")]
        public int? Dmtimportstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "validtodate")]
        public System.DateTime? Validtodate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currentcost")]
        public decimal? Currentcost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantitydecimal")]
        public int? Quantitydecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_subjectid_value")]
        public System.Guid? _subjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public System.Guid? _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "suppliername")]
        public string Suppliername { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "validfromdate")]
        public System.DateTime? Validfromdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productnumber")]
        public string Productnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedbyexternalparty_value")]
        public System.Guid? _modifiedbyexternalpartyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public System.Guid? Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentproductid_value")]
        public System.Guid? _parentproductidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_pricelevelid_value")]
        public System.Guid? _pricelevelidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "producturl")]
        public string Producturl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendorname")]
        public string Vendorname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "producttypecode")]
        public int? Producttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stockweight")]
        public decimal? Stockweight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public System.Guid? Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iskit")]
        public bool? Iskit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price_base")]
        public decimal? PriceBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public System.Guid? Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isstockitem")]
        public bool? Isstockitem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendorid")]
        public string Vendorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendorpartnumber")]
        public string Vendorpartnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public System.Guid? Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "entityimage")]
        public byte[] Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public long? EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantityonhand")]
        public decimal? Quantityonhand { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stockvolume")]
        public decimal? Stockvolume { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ProductSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_SharepointDocumentLocation")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> ProductSharepointDocumentLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ProductAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ProductMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> ProductProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ProductBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ProductPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> ProductConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> ProductConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> ProductAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevelid")]
        public MicrosoftDynamicsCRMpricelevel Pricelevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_DynamicProperty")]
        public IList<MicrosoftDynamicsCRMdynamicproperty> ProductDynamicProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_DynamicPropertyAssociation")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyassociation> ProductDynamicPropertyAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentproductid")]
        public MicrosoftDynamicsCRMproduct Parentproductid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_parent_product")]
        public IList<MicrosoftDynamicsCRMproduct> ProductParentProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_ProductAssociation_AssocProd")]
        public IList<MicrosoftDynamicsCRMproductassociation> ProductProductAssociationAssocProd { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product_ProductAssociation_Prod")]
        public IList<MicrosoftDynamicsCRMproductassociation> ProductProductAssociationProd { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_ProductSubstitute_substitutedproductid")]
        public IList<MicrosoftDynamicsCRMproductsubstitute> ProductProductSubstituteSubstitutedproductid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_ProductSubstitute_productid")]
        public IList<MicrosoftDynamicsCRMproductsubstitute> ProductProductSubstituteProductid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_price_levels")]
        public IList<MicrosoftDynamicsCRMproductpricelevel> ProductPriceLevels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subjectid")]
        public MicrosoftDynamicsCRMsubject Subjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultuomid")]
        public MicrosoftDynamicsCRMuom Defaultuomid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultuomscheduleid")]
        public MicrosoftDynamicsCRMuomschedule Defaultuomscheduleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignproduct_association")]
        public IList<MicrosoftDynamicsCRMcampaign> CampaignproductAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_contract_line_items")]
        public IList<MicrosoftDynamicsCRMcontractdetail> ProductContractLineItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_incidents")]
        public IList<MicrosoftDynamicsCRMincident> ProductIncidents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_entitlement_association")]
        public IList<MicrosoftDynamicsCRMentitlement> ProductEntitlementAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_entitlementtemplate_association")]
        public IList<MicrosoftDynamicsCRMentitlementtemplate> ProductEntitlementtemplateAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "leadproduct_association")]
        public IList<MicrosoftDynamicsCRMlead> LeadproductAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunity_products")]
        public IList<MicrosoftDynamicsCRMopportunityproduct> OpportunityProducts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_invoice_details")]
        public IList<MicrosoftDynamicsCRMinvoicedetail> ProductInvoiceDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_order_details")]
        public IList<MicrosoftDynamicsCRMsalesorderdetail> ProductOrderDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_quote_details")]
        public IList<MicrosoftDynamicsCRMquotedetail> ProductQuoteDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productsalesliterature_association")]
        public IList<MicrosoftDynamicsCRMsalesliterature> ProductsalesliteratureAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorproduct_association")]
        public IList<MicrosoftDynamicsCRMcompetitor> CompetitorproductAssociation { get; set; }

    }
}
