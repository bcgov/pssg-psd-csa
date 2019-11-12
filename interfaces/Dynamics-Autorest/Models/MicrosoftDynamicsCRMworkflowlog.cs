// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Pssg.Csa.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.workflowlog
    /// </summary>
    public partial class MicrosoftDynamicsCRMworkflowlog
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMworkflowlog
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMworkflowlog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMworkflowlog
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMworkflowlog(System.Guid? _asyncoperationidValue = default(System.Guid?), string description = default(string), System.Guid? _regardingobjectidValue = default(System.Guid?), System.Guid? _owningbusinessunitValue = default(System.Guid?), int? status = default(int?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.Guid? _createdbyValue = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string stagename = default(string), System.Guid? _owneridValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string stepname = default(string), System.DateTimeOffset? startedon = default(System.DateTimeOffset?), string interactionactivityresult = default(string), System.Guid? _modifiedbyValue = default(System.Guid?), System.Guid? _owninguserValue = default(System.Guid?), int? duration = default(int?), string message = default(string), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), System.Guid? _childworkflowinstanceidValue = default(System.Guid?), System.Guid? workflowlogid = default(System.Guid?), int? errorcode = default(int?), string activityname = default(string), System.Guid? _owningteamValue = default(System.Guid?), MicrosoftDynamicsCRMphonetocaseprocess phoneToCaseProcessAsyncoperationid = default(MicrosoftDynamicsCRMphonetocaseprocess), MicrosoftDynamicsCRMleadtoopportunitysalesprocess leadToOpportunitySalesProcessAsyncoperationid = default(MicrosoftDynamicsCRMleadtoopportunitysalesprocess), MicrosoftDynamicsCRMopportunitysalesprocess opportunitySalesProcessAsyncoperationid = default(MicrosoftDynamicsCRMopportunitysalesprocess), MicrosoftDynamicsCRMprocesssession asyncoperationidProcesssession = default(MicrosoftDynamicsCRMprocesssession), MicrosoftDynamicsCRMprocesssession childworkflowinstanceidProcesssession = default(MicrosoftDynamicsCRMprocesssession), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMasyncoperation childworkflowinstanceidAsyncoperation = default(MicrosoftDynamicsCRMasyncoperation), MicrosoftDynamicsCRMexpiredprocess expiredProcessAsyncoperationid = default(MicrosoftDynamicsCRMexpiredprocess), MicrosoftDynamicsCRMtranslationprocess translationProcessAsyncoperationid = default(MicrosoftDynamicsCRMtranslationprocess), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMasyncoperation asyncoperationidAsyncoperation = default(MicrosoftDynamicsCRMasyncoperation), MicrosoftDynamicsCRMnewprocess newProcessAsyncoperationid = default(MicrosoftDynamicsCRMnewprocess), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._asyncoperationidValue = _asyncoperationidValue;
            Description = description;
            this._regardingobjectidValue = _regardingobjectidValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Status = status;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Modifiedon = modifiedon;
            Stagename = stagename;
            this._owneridValue = _owneridValue;
            Createdon = createdon;
            Stepname = stepname;
            Startedon = startedon;
            Interactionactivityresult = interactionactivityresult;
            this._modifiedbyValue = _modifiedbyValue;
            this._owninguserValue = _owninguserValue;
            Duration = duration;
            Message = message;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Completedon = completedon;
            this._childworkflowinstanceidValue = _childworkflowinstanceidValue;
            Workflowlogid = workflowlogid;
            Errorcode = errorcode;
            Activityname = activityname;
            this._owningteamValue = _owningteamValue;
            PhoneToCaseProcessAsyncoperationid = phoneToCaseProcessAsyncoperationid;
            LeadToOpportunitySalesProcessAsyncoperationid = leadToOpportunitySalesProcessAsyncoperationid;
            OpportunitySalesProcessAsyncoperationid = opportunitySalesProcessAsyncoperationid;
            AsyncoperationidProcesssession = asyncoperationidProcesssession;
            ChildworkflowinstanceidProcesssession = childworkflowinstanceidProcesssession;
            Owningteam = owningteam;
            Createdonbehalfby = createdonbehalfby;
            ChildworkflowinstanceidAsyncoperation = childworkflowinstanceidAsyncoperation;
            ExpiredProcessAsyncoperationid = expiredProcessAsyncoperationid;
            TranslationProcessAsyncoperationid = translationProcessAsyncoperationid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Modifiedby = modifiedby;
            Owningbusinessunit = owningbusinessunit;
            AsyncoperationidAsyncoperation = asyncoperationidAsyncoperation;
            NewProcessAsyncoperationid = newProcessAsyncoperationid;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_asyncoperationid_value")]
        public System.Guid? _asyncoperationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public System.Guid? _regardingobjectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public System.Guid? _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public int? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stagename")]
        public string Stagename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public System.Guid? _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stepname")]
        public string Stepname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startedon")]
        public System.DateTimeOffset? Startedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "interactionactivityresult")]
        public string Interactionactivityresult { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public System.Guid? _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_childworkflowinstanceid_value")]
        public System.Guid? _childworkflowinstanceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowlogid")]
        public System.Guid? Workflowlogid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorcode")]
        public int? Errorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityname")]
        public string Activityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public System.Guid? _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhoneToCaseProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMphonetocaseprocess PhoneToCaseProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LeadToOpportunitySalesProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMleadtoopportunitysalesprocess LeadToOpportunitySalesProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OpportunitySalesProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMopportunitysalesprocess OpportunitySalesProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asyncoperationid_processsession")]
        public MicrosoftDynamicsCRMprocesssession AsyncoperationidProcesssession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "childworkflowinstanceid_processsession")]
        public MicrosoftDynamicsCRMprocesssession ChildworkflowinstanceidProcesssession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "childworkflowinstanceid_asyncoperation")]
        public MicrosoftDynamicsCRMasyncoperation ChildworkflowinstanceidAsyncoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExpiredProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMexpiredprocess ExpiredProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TranslationProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMtranslationprocess TranslationProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asyncoperationid_asyncoperation")]
        public MicrosoftDynamicsCRMasyncoperation AsyncoperationidAsyncoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NewProcess_asyncoperationid")]
        public MicrosoftDynamicsCRMnewprocess NewProcessAsyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
