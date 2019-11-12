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
    /// Microsoft.Dynamics.CRM.ownermapping
    /// </summary>
    public partial class MicrosoftDynamicsCRMownermapping
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMownermapping
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMownermapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMownermapping
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMownermapping(System.Guid? solutionid = default(System.Guid?), System.Guid? ownermappingid = default(System.Guid?), string targetuservalueforsourcecrmuserlink = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statuscode = default(int?), System.Guid? _targetsystemuseridValue = default(System.Guid?), string introducedversion = default(string), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), int? processcode = default(int?), System.Guid? ownermappingidunique = default(System.Guid?), bool? ismanaged = default(bool?), string targetsystemuserdomainname = default(string), System.Guid? _importmapidValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _createdbyValue = default(System.Guid?), System.Guid? _modifiedbyValue = default(System.Guid?), string sourceuservalueforsourcecrmuserlink = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string sourcesystemusername = default(string), System.Guid? _createdonbehalfbyValue = default(System.Guid?), int? statecode = default(int?), int? componentstate = default(int?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser targetsystemuserid = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMimportmap importmapid = default(MicrosoftDynamicsCRMimportmap))
        {
            Solutionid = solutionid;
            Ownermappingid = ownermappingid;
            Targetuservalueforsourcecrmuserlink = targetuservalueforsourcecrmuserlink;
            Modifiedon = modifiedon;
            Statuscode = statuscode;
            this._targetsystemuseridValue = _targetsystemuseridValue;
            Introducedversion = introducedversion;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Processcode = processcode;
            Ownermappingidunique = ownermappingidunique;
            Ismanaged = ismanaged;
            Targetsystemuserdomainname = targetsystemuserdomainname;
            this._importmapidValue = _importmapidValue;
            Createdon = createdon;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Sourceuservalueforsourcecrmuserlink = sourceuservalueforsourcecrmuserlink;
            Overwritetime = overwritetime;
            Sourcesystemusername = sourcesystemusername;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statecode = statecode;
            Componentstate = componentstate;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Createdby = createdby;
            Targetsystemuserid = targetsystemuserid;
            Importmapid = importmapid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public System.Guid? Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownermappingid")]
        public System.Guid? Ownermappingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetuservalueforsourcecrmuserlink")]
        public string Targetuservalueforsourcecrmuserlink { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_targetsystemuserid_value")]
        public System.Guid? _targetsystemuseridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processcode")]
        public int? Processcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownermappingidunique")]
        public System.Guid? Ownermappingidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetsystemuserdomainname")]
        public string Targetsystemuserdomainname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_importmapid_value")]
        public System.Guid? _importmapidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceuservalueforsourcecrmuserlink")]
        public string Sourceuservalueforsourcecrmuserlink { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourcesystemusername")]
        public string Sourcesystemusername { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

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
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetsystemuserid")]
        public MicrosoftDynamicsCRMsystemuser Targetsystemuserid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importmapid")]
        public MicrosoftDynamicsCRMimportmap Importmapid { get; set; }

    }
}
