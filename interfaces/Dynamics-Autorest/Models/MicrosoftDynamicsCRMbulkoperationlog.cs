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
    /// Microsoft.Dynamics.CRM.bulkoperationlog
    /// </summary>
    public partial class MicrosoftDynamicsCRMbulkoperationlog
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbulkoperationlog class.
        /// </summary>
        public MicrosoftDynamicsCRMbulkoperationlog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbulkoperationlog class.
        /// </summary>
        public MicrosoftDynamicsCRMbulkoperationlog(System.Guid? _owneridValue = default(System.Guid?), string additionalinfo = default(string), System.Guid? _createdobjectidValue = default(System.Guid?), int? utcconversiontimezonecode = default(int?), System.Guid? _owninguserValue = default(System.Guid?), System.Guid? bulkoperationlogid = default(System.Guid?), int? errornumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.Guid? _owningbusinessunitValue = default(System.Guid?), System.Guid? _regardingobjectidValue = default(System.Guid?), System.Guid? _owningteamValue = default(System.Guid?), System.Guid? _bulkoperationidValue = default(System.Guid?), string versionnumber = default(string), string name = default(string), int? importsequencenumber = default(int?), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMsyncerror> bulkoperationlogSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> bulkOperationLogAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> bulkoperationlogMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bulkOperationLogBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> bulkoperationlogPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMaccount createdobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMaccount regardingobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMactivitypointer bulkoperationidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMactivitypointer createdobjectidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMbulkoperation bulkoperationid = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMcontact createdobjectidContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMcontact regardingobjectidContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMlead createdobjectidLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMlead regardingobjectidLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMopportunity createdobjectidOpportunity = default(MicrosoftDynamicsCRMopportunity))
        {
            this._owneridValue = _owneridValue;
            Additionalinfo = additionalinfo;
            this._createdobjectidValue = _createdobjectidValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._owninguserValue = _owninguserValue;
            Bulkoperationlogid = bulkoperationlogid;
            Errornumber = errornumber;
            Overriddencreatedon = overriddencreatedon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._regardingobjectidValue = _regardingobjectidValue;
            this._owningteamValue = _owningteamValue;
            this._bulkoperationidValue = _bulkoperationidValue;
            Versionnumber = versionnumber;
            Name = name;
            Importsequencenumber = importsequencenumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Owninguser = owninguser;
            Owningteam = owningteam;
            BulkoperationlogSyncErrors = bulkoperationlogSyncErrors;
            BulkOperationLogAsyncOperations = bulkOperationLogAsyncOperations;
            BulkoperationlogMailboxTrackingFolders = bulkoperationlogMailboxTrackingFolders;
            BulkOperationLogBulkDeleteFailures = bulkOperationLogBulkDeleteFailures;
            BulkoperationlogPrincipalObjectAttributeAccesses = bulkoperationlogPrincipalObjectAttributeAccesses;
            CreatedobjectidAccount = createdobjectidAccount;
            RegardingobjectidAccount = regardingobjectidAccount;
            BulkoperationidActivitypointer = bulkoperationidActivitypointer;
            CreatedobjectidActivitypointer = createdobjectidActivitypointer;
            Bulkoperationid = bulkoperationid;
            CreatedobjectidContact = createdobjectidContact;
            RegardingobjectidContact = regardingobjectidContact;
            CreatedobjectidLead = createdobjectidLead;
            RegardingobjectidLead = regardingobjectidLead;
            CreatedobjectidOpportunity = createdobjectidOpportunity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public System.Guid? _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additionalinfo")]
        public string Additionalinfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdobjectid_value")]
        public System.Guid? _createdobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public System.Guid? _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperationlogid")]
        public System.Guid? Bulkoperationlogid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errornumber")]
        public int? Errornumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public System.Guid? _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public System.Guid? _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public System.Guid? _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bulkoperationid_value")]
        public System.Guid? _bulkoperationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

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
        [JsonProperty(PropertyName = "bulkoperationlog_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BulkoperationlogSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperationLog_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BulkOperationLogAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperationlog_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> BulkoperationlogMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperationLog_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BulkOperationLogBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperationlog_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> BulkoperationlogPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdobjectid_account")]
        public MicrosoftDynamicsCRMaccount CreatedobjectidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperationid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer BulkoperationidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdobjectid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer CreatedobjectidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperationid")]
        public MicrosoftDynamicsCRMbulkoperation Bulkoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdobjectid_contact")]
        public MicrosoftDynamicsCRMcontact CreatedobjectidContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdobjectid_lead")]
        public MicrosoftDynamicsCRMlead CreatedobjectidLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdobjectid_opportunity")]
        public MicrosoftDynamicsCRMopportunity CreatedobjectidOpportunity { get; set; }

    }
}
