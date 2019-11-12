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
    /// Microsoft.Dynamics.CRM.savedqueryvisualization
    /// </summary>
    public partial class MicrosoftDynamicsCRMsavedqueryvisualization
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsavedqueryvisualization class.
        /// </summary>
        public MicrosoftDynamicsCRMsavedqueryvisualization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsavedqueryvisualization class.
        /// </summary>
        public MicrosoftDynamicsCRMsavedqueryvisualization(string presentationdescription = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string canbedeleted = default(string), System.Guid? _createdbyValue = default(System.Guid?), int? type = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.Guid? _modifiedbyValue = default(System.Guid?), string primaryentitytypecode = default(string), string description = default(string), string introducedversion = default(string), int? componentstate = default(int?), string datadescription = default(string), int? charttype = default(int?), bool? ismanaged = default(bool?), System.Guid? _organizationidValue = default(System.Guid?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), string versionnumber = default(string), System.Guid? savedqueryvisualizationid = default(System.Guid?), System.Guid? _webresourceidValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string name = default(string), bool? isdefault = default(bool?), string iscustomizable = default(string), System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.Guid? savedqueryvisualizationidunique = default(System.Guid?), System.Guid? solutionid = default(System.Guid?), IList<MicrosoftDynamicsCRMsyncerror> savedQueryVisualizationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMwebresource webresourceid = default(MicrosoftDynamicsCRMwebresource), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Presentationdescription = presentationdescription;
            Overwritetime = overwritetime;
            Canbedeleted = canbedeleted;
            this._createdbyValue = _createdbyValue;
            Type = type;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            Primaryentitytypecode = primaryentitytypecode;
            Description = description;
            Introducedversion = introducedversion;
            Componentstate = componentstate;
            Datadescription = datadescription;
            Charttype = charttype;
            Ismanaged = ismanaged;
            this._organizationidValue = _organizationidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Versionnumber = versionnumber;
            Savedqueryvisualizationid = savedqueryvisualizationid;
            this._webresourceidValue = _webresourceidValue;
            Createdon = createdon;
            Name = name;
            Isdefault = isdefault;
            Iscustomizable = iscustomizable;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Savedqueryvisualizationidunique = savedqueryvisualizationidunique;
            Solutionid = solutionid;
            SavedQueryVisualizationSyncErrors = savedQueryVisualizationSyncErrors;
            Createdonbehalfby = createdonbehalfby;
            Organizationid = organizationid;
            Createdby = createdby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Webresourceid = webresourceid;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "presentationdescription")]
        public string Presentationdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canbedeleted")]
        public string Canbedeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryentitytypecode")]
        public string Primaryentitytypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datadescription")]
        public string Datadescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "charttype")]
        public int? Charttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "savedqueryvisualizationid")]
        public System.Guid? Savedqueryvisualizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_webresourceid_value")]
        public System.Guid? _webresourceidValue { get; set; }

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
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "savedqueryvisualizationidunique")]
        public System.Guid? Savedqueryvisualizationidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public System.Guid? Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SavedQueryVisualization_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SavedQueryVisualizationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webresourceid")]
        public MicrosoftDynamicsCRMwebresource Webresourceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}
