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
    /// DependentOptionMetadata
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.DependentOptionMetadata
    /// </remarks>
    public partial class MicrosoftDynamicsCRMDependentOptionMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDependentOptionMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMDependentOptionMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDependentOptionMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMDependentOptionMetadata(string label = default(string), int? value = default(int?))
        {
            Label = label;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Label")]
        public string Label { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public int? Value { get; set; }

    }
}
