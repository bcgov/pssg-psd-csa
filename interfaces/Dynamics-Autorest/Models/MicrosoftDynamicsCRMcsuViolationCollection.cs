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
    /// Collection of csu_violation
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.csu_violationCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMcsuViolationCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuViolationCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuViolationCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuViolationCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuViolationCollection(IList<MicrosoftDynamicsCRMcsuViolation> value = default(IList<MicrosoftDynamicsCRMcsuViolation>))
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
        public IList<MicrosoftDynamicsCRMcsuViolation> Value { get; set; }

    }
}
