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
    /// Microsoft.Dynamics.CRM.translationprocess
    /// </summary>
    public partial class MicrosoftDynamicsCRMtranslationprocess
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMtranslationprocess class.
        /// </summary>
        public MicrosoftDynamicsCRMtranslationprocess()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMtranslationprocess class.
        /// </summary>
        public MicrosoftDynamicsCRMtranslationprocess(int? duration = default(int?), string traversedpath = default(string), System.Guid? _knowledgearticleidValue = default(System.Guid?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), int? importsequencenumber = default(int?), System.Guid? _activestageidValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string name = default(string), System.Guid? _processidValue = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statecode = default(int?), System.Guid? businessprocessflowinstanceid = default(System.Guid?), int? statuscode = default(int?), System.DateTimeOffset? activestagestartedon = default(System.DateTimeOffset?), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), System.Guid? _createdbyValue = default(System.Guid?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), string versionnumber = default(string), System.Guid? _transactioncurrencyidValue = default(System.Guid?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), decimal? exchangerate = default(decimal?), System.Guid? _modifiedbyValue = default(System.Guid?), System.Guid? _organizationidValue = default(System.Guid?), IList<MicrosoftDynamicsCRMsyncerror> translationProcessSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMknowledgearticle knowledgearticleid = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMworkflowlog> workflowlogsTranslationprocess = default(IList<MicrosoftDynamicsCRMworkflowlog>), MicrosoftDynamicsCRMworkflow processid = default(MicrosoftDynamicsCRMworkflow), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMprocesssession> translationProcessProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMprocessstage activestageid = default(MicrosoftDynamicsCRMprocessstage))
        {
            Duration = duration;
            Traversedpath = traversedpath;
            this._knowledgearticleidValue = _knowledgearticleidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Importsequencenumber = importsequencenumber;
            this._activestageidValue = _activestageidValue;
            Createdon = createdon;
            Name = name;
            this._processidValue = _processidValue;
            Modifiedon = modifiedon;
            Statecode = statecode;
            Businessprocessflowinstanceid = businessprocessflowinstanceid;
            Statuscode = statuscode;
            Activestagestartedon = activestagestartedon;
            Completedon = completedon;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Versionnumber = versionnumber;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Overriddencreatedon = overriddencreatedon;
            Exchangerate = exchangerate;
            this._modifiedbyValue = _modifiedbyValue;
            this._organizationidValue = _organizationidValue;
            TranslationProcessSyncErrors = translationProcessSyncErrors;
            Knowledgearticleid = knowledgearticleid;
            Modifiedbyname = modifiedbyname;
            WorkflowlogsTranslationprocess = workflowlogsTranslationprocess;
            Processid = processid;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Organizationid = organizationid;
            TranslationProcessProcessSessions = translationProcessProcessSessions;
            Transactioncurrencyid = transactioncurrencyid;
            Activestageid = activestageid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_knowledgearticleid_value")]
        public System.Guid? _knowledgearticleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_activestageid_value")]
        public System.Guid? _activestageidValue { get; set; }

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
        [JsonProperty(PropertyName = "_processid_value")]
        public System.Guid? _processidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessprocessflowinstanceid")]
        public System.Guid? Businessprocessflowinstanceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestagestartedon")]
        public System.DateTimeOffset? Activestagestartedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

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
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public System.Guid? _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TranslationProcess_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> TranslationProcessSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleid")]
        public MicrosoftDynamicsCRMknowledgearticle Knowledgearticleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowlogs_translationprocess")]
        public IList<MicrosoftDynamicsCRMworkflowlog> WorkflowlogsTranslationprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public MicrosoftDynamicsCRMworkflow Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TranslationProcess_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> TranslationProcessProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestageid")]
        public MicrosoftDynamicsCRMprocessstage Activestageid { get; set; }

    }
}
