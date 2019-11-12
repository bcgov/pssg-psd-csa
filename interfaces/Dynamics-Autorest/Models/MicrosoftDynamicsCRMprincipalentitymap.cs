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
    /// Microsoft.Dynamics.CRM.principalentitymap
    /// </summary>
    public partial class MicrosoftDynamicsCRMprincipalentitymap
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMprincipalentitymap class.
        /// </summary>
        public MicrosoftDynamicsCRMprincipalentitymap()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMprincipalentitymap class.
        /// </summary>
        public MicrosoftDynamicsCRMprincipalentitymap(string objecttypecode = default(string), System.Guid? principalid = default(System.Guid?), System.Guid? principalentitymapid = default(System.Guid?), string versionnumber = default(string), MicrosoftDynamicsCRMprincipal principalidOwner = default(MicrosoftDynamicsCRMprincipal))
        {
            Objecttypecode = objecttypecode;
            Principalid = principalid;
            Principalentitymapid = principalentitymapid;
            Versionnumber = versionnumber;
            PrincipalidOwner = principalidOwner;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public string Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "principalid")]
        public System.Guid? Principalid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "principalentitymapid")]
        public System.Guid? Principalentitymapid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "principalid_owner")]
        public MicrosoftDynamicsCRMprincipal PrincipalidOwner { get; set; }

    }
}
