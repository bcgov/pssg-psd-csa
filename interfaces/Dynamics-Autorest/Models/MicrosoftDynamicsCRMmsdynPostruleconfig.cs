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
    /// Microsoft.Dynamics.CRM.msdyn_postruleconfig
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynPostruleconfig
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynPostruleconfig class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynPostruleconfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynPostruleconfig class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynPostruleconfig(string versionnumber = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? statuscode = default(int?), string msdynName = default(string), string msdynStepid = default(string), System.Guid? _modifiedbyValue = default(System.Guid?), string msdynFormatid = default(string), System.Guid? _organizationidValue = default(System.Guid?), bool? msdynPosttoyammer = default(bool?), System.Guid? msdynPostruleconfigid = default(System.Guid?), string msdynRulesource = default(string), System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), System.Guid? _msdynPostconfigidValue = default(System.Guid?), System.Guid? _createdbyValue = default(System.Guid?), int? importsequencenumber = default(int?), int? statecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string msdynRuleid = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> msdynPostruleconfigSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> msdynPostruleconfigAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynPostruleconfigMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynPostruleconfigProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynPostruleconfigBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynPostruleconfigPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMmsdynPostconfig msdynPostConfigId = default(MicrosoftDynamicsCRMmsdynPostconfig))
        {
            Versionnumber = versionnumber;
            Overriddencreatedon = overriddencreatedon;
            Statuscode = statuscode;
            MsdynName = msdynName;
            MsdynStepid = msdynStepid;
            this._modifiedbyValue = _modifiedbyValue;
            MsdynFormatid = msdynFormatid;
            this._organizationidValue = _organizationidValue;
            MsdynPosttoyammer = msdynPosttoyammer;
            MsdynPostruleconfigid = msdynPostruleconfigid;
            MsdynRulesource = msdynRulesource;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdon = createdon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._msdynPostconfigidValue = _msdynPostconfigidValue;
            this._createdbyValue = _createdbyValue;
            Importsequencenumber = importsequencenumber;
            Statecode = statecode;
            Modifiedon = modifiedon;
            MsdynRuleid = msdynRuleid;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            MsdynPostruleconfigSyncErrors = msdynPostruleconfigSyncErrors;
            MsdynPostruleconfigAsyncOperations = msdynPostruleconfigAsyncOperations;
            MsdynPostruleconfigMailboxTrackingFolders = msdynPostruleconfigMailboxTrackingFolders;
            MsdynPostruleconfigProcessSession = msdynPostruleconfigProcessSession;
            MsdynPostruleconfigBulkDeleteFailures = msdynPostruleconfigBulkDeleteFailures;
            MsdynPostruleconfigPrincipalObjectAttributeAccesses = msdynPostruleconfigPrincipalObjectAttributeAccesses;
            MsdynPostConfigId = msdynPostConfigId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

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
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_name")]
        public string MsdynName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_stepid")]
        public string MsdynStepid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_formatid")]
        public string MsdynFormatid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_posttoyammer")]
        public bool? MsdynPosttoyammer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postruleconfigid")]
        public System.Guid? MsdynPostruleconfigid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_rulesource")]
        public string MsdynRulesource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_msdyn_postconfigid_value")]
        public System.Guid? _msdynPostconfigidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_ruleid")]
        public string MsdynRuleid { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_postruleconfig_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynPostruleconfigSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postruleconfig_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynPostruleconfigAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postruleconfig_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynPostruleconfigMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postruleconfig_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynPostruleconfigProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postruleconfig_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynPostruleconfigBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_postruleconfig_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynPostruleconfigPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_PostConfigId")]
        public MicrosoftDynamicsCRMmsdynPostconfig MsdynPostConfigId { get; set; }

    }
}
