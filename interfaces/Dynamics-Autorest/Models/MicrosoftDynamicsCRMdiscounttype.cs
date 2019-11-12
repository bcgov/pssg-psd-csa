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
    /// Microsoft.Dynamics.CRM.discounttype
    /// </summary>
    public partial class MicrosoftDynamicsCRMdiscounttype
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMdiscounttype
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMdiscounttype()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMdiscounttype
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMdiscounttype(System.Guid? _createdonbehalfbyValue = default(System.Guid?), int? timezoneruleversionnumber = default(int?), System.Guid? discounttypeid = default(System.Guid?), string versionnumber = default(string), System.Guid? _modifiedbyValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _organizationidValue = default(System.Guid?), int? importsequencenumber = default(int?), bool? isamounttype = default(bool?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? statecode = default(int?), int? statuscode = default(int?), System.Guid? _transactioncurrencyidValue = default(System.Guid?), string description = default(string), System.Guid? _createdbyValue = default(System.Guid?), string name = default(string), int? utcconversiontimezonecode = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> discountTypeSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> discountTypeAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> discounttypeMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> discountTypeProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> discountTypeBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> discounttypePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMdiscount> discountTypeDiscounts = default(IList<MicrosoftDynamicsCRMdiscount>), IList<MicrosoftDynamicsCRMproductpricelevel> discountTypeProductPriceLevels = default(IList<MicrosoftDynamicsCRMproductpricelevel>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Discounttypeid = discounttypeid;
            Versionnumber = versionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            this._organizationidValue = _organizationidValue;
            Importsequencenumber = importsequencenumber;
            Isamounttype = isamounttype;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Modifiedon = modifiedon;
            Overriddencreatedon = overriddencreatedon;
            Statecode = statecode;
            Statuscode = statuscode;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Description = description;
            this._createdbyValue = _createdbyValue;
            Name = name;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            DiscountTypeSyncErrors = discountTypeSyncErrors;
            DiscountTypeAsyncOperations = discountTypeAsyncOperations;
            DiscounttypeMailboxTrackingFolders = discounttypeMailboxTrackingFolders;
            DiscountTypeProcessSessions = discountTypeProcessSessions;
            DiscountTypeBulkDeleteFailures = discountTypeBulkDeleteFailures;
            DiscounttypePrincipalObjectAttributeAccesses = discounttypePrincipalObjectAttributeAccesses;
            DiscountTypeDiscounts = discountTypeDiscounts;
            DiscountTypeProductPriceLevels = discountTypeProductPriceLevels;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discounttypeid")]
        public System.Guid? Discounttypeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isamounttype")]
        public bool? Isamounttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public System.Guid? _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

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
        [JsonProperty(PropertyName = "DiscountType_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> DiscountTypeSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DiscountType_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> DiscountTypeAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discounttype_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> DiscounttypeMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DiscountType_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> DiscountTypeProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DiscountType_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> DiscountTypeBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discounttype_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> DiscounttypePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discount_type_discounts")]
        public IList<MicrosoftDynamicsCRMdiscount> DiscountTypeDiscounts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discount_type_product_price_levels")]
        public IList<MicrosoftDynamicsCRMproductpricelevel> DiscountTypeProductPriceLevels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
