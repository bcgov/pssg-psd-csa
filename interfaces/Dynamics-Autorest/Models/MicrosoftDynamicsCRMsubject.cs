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
    /// Microsoft.Dynamics.CRM.subject
    /// </summary>
    public partial class MicrosoftDynamicsCRMsubject
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsubject
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsubject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsubject
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsubject(int? importsequencenumber = default(int?), string description = default(string), System.Guid? _createdbyexternalpartyValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _modifiedbyexternalpartyValue = default(System.Guid?), System.Guid? _parentsubjectValue = default(System.Guid?), System.Guid? _organizationidValue = default(System.Guid?), System.Guid? _modifiedbyValue = default(System.Guid?), string versionnumber = default(string), System.Guid? subjectid = default(System.Guid?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), string title = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? featuremask = default(int?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.Guid? _createdbyValue = default(System.Guid?), IList<MicrosoftDynamicsCRMproduct> subjectProducts = default(IList<MicrosoftDynamicsCRMproduct>), IList<MicrosoftDynamicsCRMincident> subjectIncidents = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMsalesliterature> subjectSalesLiterature = default(IList<MicrosoftDynamicsCRMsalesliterature>), IList<MicrosoftDynamicsCRMprocesssession> subjectProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsubject parentsubject = default(MicrosoftDynamicsCRMsubject), IList<MicrosoftDynamicsCRMsubject> subjectParentSubject = default(IList<MicrosoftDynamicsCRMsubject>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> subjectAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMsyncerror> subjectSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMkbarticle> subjectKbArticles = default(IList<MicrosoftDynamicsCRMkbarticle>), IList<MicrosoftDynamicsCRMknowledgearticle> subjectKnowledgearticles = default(IList<MicrosoftDynamicsCRMknowledgearticle>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMbulkdeletefailure> subjectBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>))
        {
            Importsequencenumber = importsequencenumber;
            Description = description;
            this._createdbyexternalpartyValue = _createdbyexternalpartyValue;
            Createdon = createdon;
            this._modifiedbyexternalpartyValue = _modifiedbyexternalpartyValue;
            this._parentsubjectValue = _parentsubjectValue;
            this._organizationidValue = _organizationidValue;
            this._modifiedbyValue = _modifiedbyValue;
            Versionnumber = versionnumber;
            Subjectid = subjectid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Title = title;
            Modifiedon = modifiedon;
            Featuremask = featuremask;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            this._createdbyValue = _createdbyValue;
            SubjectProducts = subjectProducts;
            SubjectIncidents = subjectIncidents;
            SubjectSalesLiterature = subjectSalesLiterature;
            SubjectProcessSessions = subjectProcessSessions;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Parentsubject = parentsubject;
            SubjectParentSubject = subjectParentSubject;
            Createdonbehalfby = createdonbehalfby;
            SubjectAsyncOperations = subjectAsyncOperations;
            SubjectSyncErrors = subjectSyncErrors;
            SubjectKbArticles = subjectKbArticles;
            SubjectKnowledgearticles = subjectKnowledgearticles;
            Organizationid = organizationid;
            SubjectBulkDeleteFailures = subjectBulkDeleteFailures;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdbyexternalparty_value")]
        public System.Guid? _createdbyexternalpartyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedbyexternalparty_value")]
        public System.Guid? _modifiedbyexternalpartyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentsubject_value")]
        public System.Guid? _parentsubjectValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subjectid")]
        public System.Guid? Subjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "featuremask")]
        public int? Featuremask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject_products")]
        public IList<MicrosoftDynamicsCRMproduct> SubjectProducts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject_incidents")]
        public IList<MicrosoftDynamicsCRMincident> SubjectIncidents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject_sales_literature")]
        public IList<MicrosoftDynamicsCRMsalesliterature> SubjectSalesLiterature { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Subject_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> SubjectProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

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
        [JsonProperty(PropertyName = "parentsubject")]
        public MicrosoftDynamicsCRMsubject Parentsubject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject_parent_subject")]
        public IList<MicrosoftDynamicsCRMsubject> SubjectParentSubject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Subject_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SubjectAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Subject_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SubjectSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject_kb_articles")]
        public IList<MicrosoftDynamicsCRMkbarticle> SubjectKbArticles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject_knowledgearticles")]
        public IList<MicrosoftDynamicsCRMknowledgearticle> SubjectKnowledgearticles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Subject_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SubjectBulkDeleteFailures { get; set; }

    }
}
