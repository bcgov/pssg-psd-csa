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
    /// Microsoft.Dynamics.CRM.dynamicpropertyoptionsetitem
    /// </summary>
    public partial class MicrosoftDynamicsCRMdynamicpropertyoptionsetitem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicpropertyoptionsetitem class.
        /// </summary>
        public MicrosoftDynamicsCRMdynamicpropertyoptionsetitem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicpropertyoptionsetitem class.
        /// </summary>
        public MicrosoftDynamicsCRMdynamicpropertyoptionsetitem(string dynamicpropertyoptionname = default(string), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _createdbyValue = default(System.Guid?), System.Guid? dynamicpropertyoptionsetvalueid = default(System.Guid?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), decimal? exchangerate = default(decimal?), System.Guid? _modifiedbyValue = default(System.Guid?), System.Guid? _dynamicpropertyidValue = default(System.Guid?), string versionnumber = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string dynamicpropertyoptiondescription = default(string), int? dynamicpropertyoptionsetvaluesequencenumber = default(int?), int? importsequencenumber = default(int?), System.Guid? _transactioncurrencyidValue = default(System.Guid?), int? dmtimportstate = default(int?), int? dynamicpropertyoptionvalue = default(int?), int? utcconversiontimezonecode = default(int?), System.Guid? _organizationidValue = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> dynamicpropertyoptionsetitemSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> dynamicpropertyoptionsetitemAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> dynamicpropertyoptionsetitemMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> dynamicpropertyoptionsetitemBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> dynamicpropertyoptionsetitemPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMdynamicproperty> defaultValueOptionSetDynamicProperty = default(IList<MicrosoftDynamicsCRMdynamicproperty>), MicrosoftDynamicsCRMdynamicproperty dynamicpropertyid = default(MicrosoftDynamicsCRMdynamicproperty), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            Dynamicpropertyoptionname = dynamicpropertyoptionname;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdon = createdon;
            this._createdbyValue = _createdbyValue;
            Dynamicpropertyoptionsetvalueid = dynamicpropertyoptionsetvalueid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Exchangerate = exchangerate;
            this._modifiedbyValue = _modifiedbyValue;
            this._dynamicpropertyidValue = _dynamicpropertyidValue;
            Versionnumber = versionnumber;
            Overriddencreatedon = overriddencreatedon;
            Dynamicpropertyoptiondescription = dynamicpropertyoptiondescription;
            Dynamicpropertyoptionsetvaluesequencenumber = dynamicpropertyoptionsetvaluesequencenumber;
            Importsequencenumber = importsequencenumber;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Dmtimportstate = dmtimportstate;
            Dynamicpropertyoptionvalue = dynamicpropertyoptionvalue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._organizationidValue = _organizationidValue;
            Modifiedon = modifiedon;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            DynamicpropertyoptionsetitemSyncErrors = dynamicpropertyoptionsetitemSyncErrors;
            DynamicpropertyoptionsetitemAsyncOperations = dynamicpropertyoptionsetitemAsyncOperations;
            DynamicpropertyoptionsetitemMailboxTrackingFolders = dynamicpropertyoptionsetitemMailboxTrackingFolders;
            DynamicpropertyoptionsetitemBulkDeleteFailures = dynamicpropertyoptionsetitemBulkDeleteFailures;
            DynamicpropertyoptionsetitemPrincipalObjectAttributeAccesses = dynamicpropertyoptionsetitemPrincipalObjectAttributeAccesses;
            DefaultValueOptionSetDynamicProperty = defaultValueOptionSetDynamicProperty;
            Dynamicpropertyid = dynamicpropertyid;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptionname")]
        public string Dynamicpropertyoptionname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptionsetvalueid")]
        public System.Guid? Dynamicpropertyoptionsetvalueid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_dynamicpropertyid_value")]
        public System.Guid? _dynamicpropertyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptiondescription")]
        public string Dynamicpropertyoptiondescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptionsetvaluesequencenumber")]
        public int? Dynamicpropertyoptionsetvaluesequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public System.Guid? _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dmtimportstate")]
        public int? Dmtimportstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptionvalue")]
        public int? Dynamicpropertyoptionvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

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
        [JsonProperty(PropertyName = "dynamicpropertyoptionsetitem_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> DynamicpropertyoptionsetitemSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptionsetitem_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> DynamicpropertyoptionsetitemAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptionsetitem_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> DynamicpropertyoptionsetitemMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptionsetitem_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> DynamicpropertyoptionsetitemBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> DynamicpropertyoptionsetitemPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultValueOptionSet_DynamicProperty")]
        public IList<MicrosoftDynamicsCRMdynamicproperty> DefaultValueOptionSetDynamicProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyid")]
        public MicrosoftDynamicsCRMdynamicproperty Dynamicpropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
