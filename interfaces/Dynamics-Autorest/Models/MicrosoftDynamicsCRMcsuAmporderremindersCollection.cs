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
    /// Collection of csu_amporderreminders
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.csu_amporderremindersCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMcsuAmporderremindersCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuAmporderremindersCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuAmporderremindersCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuAmporderremindersCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuAmporderremindersCollection(IList<MicrosoftDynamicsCRMcsuAmporderreminders> value = default(IList<MicrosoftDynamicsCRMcsuAmporderreminders>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMcsuAmporderreminders> Value { get; set; }

    }
}
