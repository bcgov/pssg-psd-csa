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
    /// Microsoft.Dynamics.CRM.sdkmessageprocessingstepsecureconfig
    /// </summary>
    public partial class MicrosoftDynamicsCRMsdkmessageprocessingstepsecureconfig
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsdkmessageprocessingstepsecureconfig class.
        /// </summary>
        public MicrosoftDynamicsCRMsdkmessageprocessingstepsecureconfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsdkmessageprocessingstepsecureconfig class.
        /// </summary>
        public MicrosoftDynamicsCRMsdkmessageprocessingstepsecureconfig(string secureconfig = default(string), System.Guid? _createdbyValue = default(System.Guid?), int? customizationlevel = default(int?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.Guid? _modifiedbyValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? sdkmessageprocessingstepsecureconfigidunique = default(System.Guid?), System.Guid? _organizationidValue = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.Guid? sdkmessageprocessingstepsecureconfigid = default(System.Guid?), IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> sdkmessageprocessingstepsecureconfigidSdkmessageprocessingstep = default(IList<MicrosoftDynamicsCRMsdkmessageprocessingstep>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Secureconfig = secureconfig;
            this._createdbyValue = _createdbyValue;
            Customizationlevel = customizationlevel;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            Sdkmessageprocessingstepsecureconfigidunique = sdkmessageprocessingstepsecureconfigidunique;
            this._organizationidValue = _organizationidValue;
            Modifiedon = modifiedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Sdkmessageprocessingstepsecureconfigid = sdkmessageprocessingstepsecureconfigid;
            SdkmessageprocessingstepsecureconfigidSdkmessageprocessingstep = sdkmessageprocessingstepsecureconfigidSdkmessageprocessingstep;
            Organizationid = organizationid;
            Createdby = createdby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdonbehalfby = createdonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "secureconfig")]
        public string Secureconfig { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customizationlevel")]
        public int? Customizationlevel { get; set; }

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
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepsecureconfigidunique")]
        public System.Guid? Sdkmessageprocessingstepsecureconfigidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepsecureconfigid")]
        public System.Guid? Sdkmessageprocessingstepsecureconfigid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
        public IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> SdkmessageprocessingstepsecureconfigidSdkmessageprocessingstep { get; set; }

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
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

    }
}
