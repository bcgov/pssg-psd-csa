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
    /// Microsoft.Dynamics.CRM.customcontroldefaultconfig
    /// </summary>
    public partial class MicrosoftDynamicsCRMcustomcontroldefaultconfig
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcustomcontroldefaultconfig class.
        /// </summary>
        public MicrosoftDynamicsCRMcustomcontroldefaultconfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcustomcontroldefaultconfig class.
        /// </summary>
        public MicrosoftDynamicsCRMcustomcontroldefaultconfig(string primaryentitytypecode = default(string), string controldescriptionjson = default(string), System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), int? componentstate = default(int?), bool? ismanaged = default(bool?), string eventsxml = default(string), System.Guid? customcontroldefaultconfigid = default(System.Guid?), System.Guid? solutionid = default(System.Guid?), System.Guid? _createdbyValue = default(System.Guid?), string introducedversion = default(string), System.Guid? _organizationidValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? customcontroldefaultconfigidunique = default(System.Guid?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string versionnumber = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string controldescriptionxml = default(string), System.Guid? _modifiedbyValue = default(System.Guid?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Primaryentitytypecode = primaryentitytypecode;
            Controldescriptionjson = controldescriptionjson;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Componentstate = componentstate;
            Ismanaged = ismanaged;
            Eventsxml = eventsxml;
            Customcontroldefaultconfigid = customcontroldefaultconfigid;
            Solutionid = solutionid;
            this._createdbyValue = _createdbyValue;
            Introducedversion = introducedversion;
            this._organizationidValue = _organizationidValue;
            Createdon = createdon;
            Customcontroldefaultconfigidunique = customcontroldefaultconfigidunique;
            Overwritetime = overwritetime;
            Versionnumber = versionnumber;
            Modifiedon = modifiedon;
            Controldescriptionxml = controldescriptionxml;
            this._modifiedbyValue = _modifiedbyValue;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Createdby = createdby;
            Organizationid = organizationid;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryentitytypecode")]
        public string Primaryentitytypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "controldescriptionjson")]
        public string Controldescriptionjson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "eventsxml")]
        public string Eventsxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customcontroldefaultconfigid")]
        public System.Guid? Customcontroldefaultconfigid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public System.Guid? Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customcontroldefaultconfigidunique")]
        public System.Guid? Customcontroldefaultconfigidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

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
        [JsonProperty(PropertyName = "controldescriptionxml")]
        public string Controldescriptionxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

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
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
