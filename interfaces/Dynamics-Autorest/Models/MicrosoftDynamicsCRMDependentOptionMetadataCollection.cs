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
    /// DependentOptionMetadataCollection
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.DependentOptionMetadataCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMDependentOptionMetadataCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDependentOptionMetadataCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMDependentOptionMetadataCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDependentOptionMetadataCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMDependentOptionMetadataCollection(IList<object> optionList = default(IList<object>))
        {
            OptionList = optionList;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OptionList")]
        public IList<object> OptionList { get; set; }

    }
}
