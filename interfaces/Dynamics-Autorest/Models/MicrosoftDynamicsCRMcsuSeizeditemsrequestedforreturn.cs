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
    /// Microsoft.Dynamics.CRM.csu_seizeditemsrequestedforreturn
    /// </summary>
    public partial class MicrosoftDynamicsCRMcsuSeizeditemsrequestedforreturn
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuSeizeditemsrequestedforreturn class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuSeizeditemsrequestedforreturn()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuSeizeditemsrequestedforreturn class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuSeizeditemsrequestedforreturn(System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string csuItemnumber = default(string), System.Guid? _modifiedbyValue = default(System.Guid?), int? statuscode = default(int?), int? importsequencenumber = default(int?), System.DateTimeOffset? csuDirectorsdecisiondate = default(System.DateTimeOffset?), System.Guid? _csuReferencedseizureValue = default(System.Guid?), int? csuCompensate = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.Guid? _owneridValue = default(System.Guid?), int? csuIspartialrequest = default(int?), string versionnumber = default(string), decimal? csuEquivalencyamountingramsseizure = default(decimal?), string csuName = default(string), decimal? csuAmountingrams = default(decimal?), int? csuItemtype = default(int?), decimal? csuCompensationdeterminedBase = default(decimal?), System.Guid? _csuAssociatedseizeditemsidValue = default(System.Guid?), System.Guid? _owninguserValue = default(System.Guid?), decimal? csuEquivalencyamountingramsreturncalculated = default(decimal?), int? csuDirectorsdecision = default(int?), int? statecode = default(int?), System.DateTimeOffset? csuApplicationduedate = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), decimal? csuEquivalencyamountingrams = default(decimal?), System.Guid? _owningteamValue = default(System.Guid?), string csuItemdescription = default(string), System.Guid? csuSeizeditemsrequestedforreturnid = default(System.Guid?), System.Guid? _transactioncurrencyidValue = default(System.Guid?), System.Guid? _createdbyValue = default(System.Guid?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.Guid? _owningbusinessunitValue = default(System.Guid?), decimal? exchangerate = default(decimal?), decimal? csuAmountingramsseizure = default(decimal?), int? csuNumberofitems = default(int?), decimal? csuNumberofitemsseizure = default(decimal?), System.Guid? _csuCaseidValue = default(System.Guid?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), int? csuReturn = default(int?), decimal? csuCompensationdetermined = default(decimal?), decimal? csuEquivalencyamountingramscalculated = default(decimal?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> csuSeizeditemsrequestedforreturnSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> csuSeizeditemsrequestedforreturnDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> csuSeizeditemsrequestedforreturnDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> csuSeizeditemsrequestedforreturnAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> csuSeizeditemsrequestedforreturnMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> csuSeizeditemsrequestedforreturnProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> csuSeizeditemsrequestedforreturnBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> csuSeizeditemsrequestedforreturnPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMcsuSeizuredetails csuReferencedSeizure = default(MicrosoftDynamicsCRMcsuSeizuredetails), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMcsuApplicationforreturnofseizedcannabis csuAssociatedSeizedItemsId = default(MicrosoftDynamicsCRMcsuApplicationforreturnofseizedcannabis), MicrosoftDynamicsCRMincident csuCaseId = default(MicrosoftDynamicsCRMincident))
        {
            Modifiedon = modifiedon;
            CsuItemnumber = csuItemnumber;
            this._modifiedbyValue = _modifiedbyValue;
            Statuscode = statuscode;
            Importsequencenumber = importsequencenumber;
            CsuDirectorsdecisiondate = csuDirectorsdecisiondate;
            this._csuReferencedseizureValue = _csuReferencedseizureValue;
            CsuCompensate = csuCompensate;
            Createdon = createdon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            CsuIspartialrequest = csuIspartialrequest;
            Versionnumber = versionnumber;
            CsuEquivalencyamountingramsseizure = csuEquivalencyamountingramsseizure;
            CsuName = csuName;
            CsuAmountingrams = csuAmountingrams;
            CsuItemtype = csuItemtype;
            CsuCompensationdeterminedBase = csuCompensationdeterminedBase;
            this._csuAssociatedseizeditemsidValue = _csuAssociatedseizeditemsidValue;
            this._owninguserValue = _owninguserValue;
            CsuEquivalencyamountingramsreturncalculated = csuEquivalencyamountingramsreturncalculated;
            CsuDirectorsdecision = csuDirectorsdecision;
            Statecode = statecode;
            CsuApplicationduedate = csuApplicationduedate;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            CsuEquivalencyamountingrams = csuEquivalencyamountingrams;
            this._owningteamValue = _owningteamValue;
            CsuItemdescription = csuItemdescription;
            CsuSeizeditemsrequestedforreturnid = csuSeizeditemsrequestedforreturnid;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Exchangerate = exchangerate;
            CsuAmountingramsseizure = csuAmountingramsseizure;
            CsuNumberofitems = csuNumberofitems;
            CsuNumberofitemsseizure = csuNumberofitemsseizure;
            this._csuCaseidValue = _csuCaseidValue;
            Overriddencreatedon = overriddencreatedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            CsuReturn = csuReturn;
            CsuCompensationdetermined = csuCompensationdetermined;
            CsuEquivalencyamountingramscalculated = csuEquivalencyamountingramscalculated;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            CsuSeizeditemsrequestedforreturnSyncErrors = csuSeizeditemsrequestedforreturnSyncErrors;
            CsuSeizeditemsrequestedforreturnDuplicateMatchingRecord = csuSeizeditemsrequestedforreturnDuplicateMatchingRecord;
            CsuSeizeditemsrequestedforreturnDuplicateBaseRecord = csuSeizeditemsrequestedforreturnDuplicateBaseRecord;
            CsuSeizeditemsrequestedforreturnAsyncOperations = csuSeizeditemsrequestedforreturnAsyncOperations;
            CsuSeizeditemsrequestedforreturnMailboxTrackingFolders = csuSeizeditemsrequestedforreturnMailboxTrackingFolders;
            CsuSeizeditemsrequestedforreturnProcessSession = csuSeizeditemsrequestedforreturnProcessSession;
            CsuSeizeditemsrequestedforreturnBulkDeleteFailures = csuSeizeditemsrequestedforreturnBulkDeleteFailures;
            CsuSeizeditemsrequestedforreturnPrincipalObjectAttributeAccesses = csuSeizeditemsrequestedforreturnPrincipalObjectAttributeAccesses;
            CsuReferencedSeizure = csuReferencedSeizure;
            Transactioncurrencyid = transactioncurrencyid;
            CsuAssociatedSeizedItemsId = csuAssociatedSeizedItemsId;
            CsuCaseId = csuCaseId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_itemnumber")]
        public string CsuItemnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_directorsdecisiondate")]
        public System.DateTimeOffset? CsuDirectorsdecisiondate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_csu_referencedseizure_value")]
        public System.Guid? _csuReferencedseizureValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_compensate")]
        public int? CsuCompensate { get; set; }

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
        [JsonProperty(PropertyName = "_ownerid_value")]
        public System.Guid? _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_ispartialrequest")]
        public int? CsuIspartialrequest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_equivalencyamountingramsseizure")]
        public decimal? CsuEquivalencyamountingramsseizure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_name")]
        public string CsuName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_amountingrams")]
        public decimal? CsuAmountingrams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_itemtype")]
        public int? CsuItemtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_compensationdetermined_base")]
        public decimal? CsuCompensationdeterminedBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_csu_associatedseizeditemsid_value")]
        public System.Guid? _csuAssociatedseizeditemsidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public System.Guid? _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_equivalencyamountingramsreturncalculated")]
        public decimal? CsuEquivalencyamountingramsreturncalculated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_directorsdecision")]
        public int? CsuDirectorsdecision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_applicationduedate")]
        public System.DateTimeOffset? CsuApplicationduedate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_equivalencyamountingrams")]
        public decimal? CsuEquivalencyamountingrams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public System.Guid? _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_itemdescription")]
        public string CsuItemdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_seizeditemsrequestedforreturnid")]
        public System.Guid? CsuSeizeditemsrequestedforreturnid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public System.Guid? _transactioncurrencyidValue { get; set; }

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
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public System.Guid? _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_amountingramsseizure")]
        public decimal? CsuAmountingramsseizure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_numberofitems")]
        public int? CsuNumberofitems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_numberofitemsseizure")]
        public decimal? CsuNumberofitemsseizure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_csu_caseid_value")]
        public System.Guid? _csuCaseidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_return")]
        public int? CsuReturn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_compensationdetermined")]
        public decimal? CsuCompensationdetermined { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_equivalencyamountingramscalculated")]
        public decimal? CsuEquivalencyamountingramscalculated { get; set; }

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
        [JsonProperty(PropertyName = "csu_seizeditemsrequestedforreturn_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CsuSeizeditemsrequestedforreturnSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_seizeditemsrequestedforreturn_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuSeizeditemsrequestedforreturnDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_seizeditemsrequestedforreturn_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuSeizeditemsrequestedforreturnDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_seizeditemsrequestedforreturn_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CsuSeizeditemsrequestedforreturnAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_seizeditemsrequestedforreturn_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CsuSeizeditemsrequestedforreturnMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_seizeditemsrequestedforreturn_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> CsuSeizeditemsrequestedforreturnProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_seizeditemsrequestedforreturn_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CsuSeizeditemsrequestedforreturnBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_seizeditemsrequestedforreturn_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CsuSeizeditemsrequestedforreturnPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_ReferencedSeizure")]
        public MicrosoftDynamicsCRMcsuSeizuredetails CsuReferencedSeizure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_AssociatedSeizedItemsId")]
        public MicrosoftDynamicsCRMcsuApplicationforreturnofseizedcannabis CsuAssociatedSeizedItemsId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_CaseId")]
        public MicrosoftDynamicsCRMincident CsuCaseId { get; set; }

    }
}
