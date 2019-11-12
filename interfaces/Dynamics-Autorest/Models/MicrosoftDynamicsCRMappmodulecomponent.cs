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
    /// Microsoft.Dynamics.CRM.appmodulecomponent
    /// </summary>
    public partial class MicrosoftDynamicsCRMappmodulecomponent
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMappmodulecomponent class.
        /// </summary>
        public MicrosoftDynamicsCRMappmodulecomponent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMappmodulecomponent class.
        /// </summary>
        public MicrosoftDynamicsCRMappmodulecomponent(System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), System.Guid? appmodulecomponentidunique = default(System.Guid?), int? rootcomponentbehavior = default(int?), string introducedversion = default(string), System.Guid? rootappmodulecomponentid = default(System.Guid?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), int? timezoneruleversionnumber = default(int?), bool? isdefault = default(bool?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string versionnumber = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), decimal? exchangerate = default(decimal?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.Guid? _modifiedbyValue = default(System.Guid?), System.Guid? objectid = default(System.Guid?), int? componenttype = default(int?), System.Guid? _createdbyValue = default(System.Guid?), System.Guid? appmodulecomponentid = default(System.Guid?), System.Guid? _appmoduleiduniqueValue = default(System.Guid?), bool? ismetadata = default(bool?), MicrosoftDynamicsCRMsystemuser appmodulecomponentModifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser appmodulecomponentCreatedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMappmodule appmoduleid = default(MicrosoftDynamicsCRMappmodule))
        {
            Overwritetime = overwritetime;
            Appmodulecomponentidunique = appmodulecomponentidunique;
            Rootcomponentbehavior = rootcomponentbehavior;
            Introducedversion = introducedversion;
            Rootappmodulecomponentid = rootappmodulecomponentid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Isdefault = isdefault;
            Createdon = createdon;
            Versionnumber = versionnumber;
            Modifiedon = modifiedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Exchangerate = exchangerate;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Objectid = objectid;
            Componenttype = componenttype;
            this._createdbyValue = _createdbyValue;
            Appmodulecomponentid = appmodulecomponentid;
            this._appmoduleiduniqueValue = _appmoduleiduniqueValue;
            Ismetadata = ismetadata;
            AppmodulecomponentModifiedby = appmodulecomponentModifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdonbehalfby = createdonbehalfby;
            AppmodulecomponentCreatedby = appmodulecomponentCreatedby;
            Appmoduleid = appmoduleid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmodulecomponentidunique")]
        public System.Guid? Appmodulecomponentidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rootcomponentbehavior")]
        public int? Rootcomponentbehavior { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rootappmodulecomponentid")]
        public System.Guid? Rootappmodulecomponentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid")]
        public System.Guid? Objectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componenttype")]
        public int? Componenttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmodulecomponentid")]
        public System.Guid? Appmodulecomponentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_appmoduleidunique_value")]
        public System.Guid? _appmoduleiduniqueValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismetadata")]
        public bool? Ismetadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmodulecomponent_modifiedby")]
        public MicrosoftDynamicsCRMsystemuser AppmodulecomponentModifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmodulecomponent_createdby")]
        public MicrosoftDynamicsCRMsystemuser AppmodulecomponentCreatedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmoduleid")]
        public MicrosoftDynamicsCRMappmodule Appmoduleid { get; set; }

    }
}
