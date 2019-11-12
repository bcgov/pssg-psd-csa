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
    /// Microsoft.Dynamics.CRM.competitorproduct
    /// </summary>
    public partial class MicrosoftDynamicsCRMcompetitorproduct
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcompetitorproduct class.
        /// </summary>
        public MicrosoftDynamicsCRMcompetitorproduct()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcompetitorproduct class.
        /// </summary>
        public MicrosoftDynamicsCRMcompetitorproduct(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string name = default(string), string versionnumber = default(string), System.Guid? productid = default(System.Guid?), System.Guid? competitorid = default(System.Guid?), int? utcconversiontimezonecode = default(int?), int? importsequencenumber = default(int?), int? timezoneruleversionnumber = default(int?), System.Guid? competitorproductid = default(System.Guid?), IList<MicrosoftDynamicsCRMasyncoperation> competitorproductAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> competitorproductMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> competitorproductBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> competitorproductPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Overriddencreatedon = overriddencreatedon;
            Name = name;
            Versionnumber = versionnumber;
            Productid = productid;
            Competitorid = competitorid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Importsequencenumber = importsequencenumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Competitorproductid = competitorproductid;
            CompetitorproductAsyncOperations = competitorproductAsyncOperations;
            CompetitorproductMailboxTrackingFolders = competitorproductMailboxTrackingFolders;
            CompetitorproductBulkDeleteFailures = competitorproductBulkDeleteFailures;
            CompetitorproductPrincipalObjectAttributeAccesses = competitorproductPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public System.Guid? Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorid")]
        public System.Guid? Competitorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorproductid")]
        public System.Guid? Competitorproductid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorproduct_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CompetitorproductAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorproduct_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CompetitorproductMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorproduct_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CompetitorproductBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorproduct_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CompetitorproductPrincipalObjectAttributeAccesses { get; set; }

    }
}
