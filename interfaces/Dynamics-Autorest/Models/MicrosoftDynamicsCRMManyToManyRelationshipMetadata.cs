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
    /// Microsoft.Dynamics.CRM.ManyToManyRelationshipMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMManyToManyRelationshipMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMManyToManyRelationshipMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMManyToManyRelationshipMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMManyToManyRelationshipMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMManyToManyRelationshipMetadata(string entity1AssociatedMenuConfiguration = default(string), string entity2AssociatedMenuConfiguration = default(string), string entity1LogicalName = default(string), string entity2LogicalName = default(string), string intersectEntityName = default(string), string entity1IntersectAttribute = default(string), string entity2IntersectAttribute = default(string), string entity1NavigationPropertyName = default(string), string entity2NavigationPropertyName = default(string))
        {
            Entity1AssociatedMenuConfiguration = entity1AssociatedMenuConfiguration;
            Entity2AssociatedMenuConfiguration = entity2AssociatedMenuConfiguration;
            Entity1LogicalName = entity1LogicalName;
            Entity2LogicalName = entity2LogicalName;
            IntersectEntityName = intersectEntityName;
            Entity1IntersectAttribute = entity1IntersectAttribute;
            Entity2IntersectAttribute = entity2IntersectAttribute;
            Entity1NavigationPropertyName = entity1NavigationPropertyName;
            Entity2NavigationPropertyName = entity2NavigationPropertyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity1AssociatedMenuConfiguration")]
        public string Entity1AssociatedMenuConfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity2AssociatedMenuConfiguration")]
        public string Entity2AssociatedMenuConfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity1LogicalName")]
        public string Entity1LogicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity2LogicalName")]
        public string Entity2LogicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IntersectEntityName")]
        public string IntersectEntityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity1IntersectAttribute")]
        public string Entity1IntersectAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity2IntersectAttribute")]
        public string Entity2IntersectAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity1NavigationPropertyName")]
        public string Entity1NavigationPropertyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity2NavigationPropertyName")]
        public string Entity2NavigationPropertyName { get; set; }

    }
}
