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
    /// Microsoft.Dynamics.CRM.csu_complaintseizure
    /// </summary>
    public partial class MicrosoftDynamicsCRMcsuComplaintseizure
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuComplaintseizure class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuComplaintseizure()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuComplaintseizure class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuComplaintseizure(decimal? csuNumberofitems = default(decimal?), int? csuItemtype = default(int?), int? importsequencenumber = default(int?), System.Guid? _createdbyValue = default(System.Guid?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), int? csuSeizuretype = default(int?), System.Guid? _owningbusinessunitValue = default(System.Guid?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.Guid? _modifiedbyValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _owningteamValue = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.Guid? _owninguserValue = default(System.Guid?), System.Guid? _csuPrimarycomplaintidValue = default(System.Guid?), string csuName = default(string), System.Guid? _owneridValue = default(System.Guid?), int? statecode = default(int?), int? timezoneruleversionnumber = default(int?), System.Guid? csuComplaintseizureid = default(System.Guid?), decimal? csuEquivalencyamountingrams = default(decimal?), int? utcconversiontimezonecode = default(int?), decimal? csuAmountingrams = default(decimal?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), int? statuscode = default(int?), string versionnumber = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> csuComplaintseizureSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> csuComplaintseizureDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> csuComplaintseizureDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> csuComplaintseizureAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> csuComplaintseizureMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> csuComplaintseizureProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> csuComplaintseizureBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> csuComplaintseizurePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMcsuComplaints csuPrimaryComplaintId = default(MicrosoftDynamicsCRMcsuComplaints))
        {
            CsuNumberofitems = csuNumberofitems;
            CsuItemtype = csuItemtype;
            Importsequencenumber = importsequencenumber;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            CsuSeizuretype = csuSeizuretype;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            this._owningteamValue = _owningteamValue;
            Modifiedon = modifiedon;
            this._owninguserValue = _owninguserValue;
            this._csuPrimarycomplaintidValue = _csuPrimarycomplaintidValue;
            CsuName = csuName;
            this._owneridValue = _owneridValue;
            Statecode = statecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            CsuComplaintseizureid = csuComplaintseizureid;
            CsuEquivalencyamountingrams = csuEquivalencyamountingrams;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            CsuAmountingrams = csuAmountingrams;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Statuscode = statuscode;
            Versionnumber = versionnumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            CsuComplaintseizureSyncErrors = csuComplaintseizureSyncErrors;
            CsuComplaintseizureDuplicateMatchingRecord = csuComplaintseizureDuplicateMatchingRecord;
            CsuComplaintseizureDuplicateBaseRecord = csuComplaintseizureDuplicateBaseRecord;
            CsuComplaintseizureAsyncOperations = csuComplaintseizureAsyncOperations;
            CsuComplaintseizureMailboxTrackingFolders = csuComplaintseizureMailboxTrackingFolders;
            CsuComplaintseizureProcessSession = csuComplaintseizureProcessSession;
            CsuComplaintseizureBulkDeleteFailures = csuComplaintseizureBulkDeleteFailures;
            CsuComplaintseizurePrincipalObjectAttributeAccesses = csuComplaintseizurePrincipalObjectAttributeAccesses;
            CsuPrimaryComplaintId = csuPrimaryComplaintId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_numberofitems")]
        public decimal? CsuNumberofitems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_itemtype")]
        public int? CsuItemtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_seizuretype")]
        public int? CsuSeizuretype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public System.Guid? _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "_owningteam_value")]
        public System.Guid? _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public System.Guid? _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_csu_primarycomplaintid_value")]
        public System.Guid? _csuPrimarycomplaintidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_name")]
        public string CsuName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public System.Guid? _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_complaintseizureid")]
        public System.Guid? CsuComplaintseizureid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_equivalencyamountingrams")]
        public decimal? CsuEquivalencyamountingrams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_amountingrams")]
        public decimal? CsuAmountingrams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

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
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_complaintseizure_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CsuComplaintseizureSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_complaintseizure_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuComplaintseizureDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_complaintseizure_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuComplaintseizureDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_complaintseizure_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CsuComplaintseizureAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_complaintseizure_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CsuComplaintseizureMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_complaintseizure_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> CsuComplaintseizureProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_complaintseizure_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CsuComplaintseizureBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_complaintseizure_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CsuComplaintseizurePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_PrimaryComplaintId")]
        public MicrosoftDynamicsCRMcsuComplaints CsuPrimaryComplaintId { get; set; }

    }
}
