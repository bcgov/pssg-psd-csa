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
    /// Microsoft.Dynamics.CRM.role
    /// </summary>
    public partial class MicrosoftDynamicsCRMrole
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMrole class.
        /// </summary>
        public MicrosoftDynamicsCRMrole()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMrole class.
        /// </summary>
        public MicrosoftDynamicsCRMrole(int? importsequencenumber = default(int?), int? componentstate = default(int?), System.Guid? solutionid = default(System.Guid?), System.Guid? _roletemplateidValue = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.Guid? _modifiedbyValue = default(System.Guid?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.Guid? organizationid = default(System.Guid?), string name = default(string), string canbedeleted = default(string), System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.Guid? _createdbyValue = default(System.Guid?), System.Guid? _businessunitidValue = default(System.Guid?), System.Guid? roleid = default(System.Guid?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), bool? ismanaged = default(bool?), string iscustomizable = default(string), System.Guid? _parentrootroleidValue = default(System.Guid?), System.Guid? roleidunique = default(System.Guid?), System.Guid? _parentroleidValue = default(System.Guid?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string versionnumber = default(string), IList<MicrosoftDynamicsCRMsystemuser> systemuserrolesAssociation = default(IList<MicrosoftDynamicsCRMsystemuser>), IList<MicrosoftDynamicsCRMprivilege> roleprivilegesAssociation = default(IList<MicrosoftDynamicsCRMprivilege>), IList<MicrosoftDynamicsCRMappmodule> appmodulerolesAssociation = default(IList<MicrosoftDynamicsCRMappmodule>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMrole parentroleid = default(MicrosoftDynamicsCRMrole), IList<MicrosoftDynamicsCRMrole> roleParentRole = default(IList<MicrosoftDynamicsCRMrole>), MicrosoftDynamicsCRMbusinessunit businessunitid = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMroletemplate roletemplateid = default(MicrosoftDynamicsCRMroletemplate), IList<MicrosoftDynamicsCRMasyncoperation> roleAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> roleBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMorganization organizationidOrganization = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMteam> teamrolesAssociation = default(IList<MicrosoftDynamicsCRMteam>), MicrosoftDynamicsCRMrole parentrootroleid = default(MicrosoftDynamicsCRMrole), IList<MicrosoftDynamicsCRMrole> roleParentRootRole = default(IList<MicrosoftDynamicsCRMrole>), IList<MicrosoftDynamicsCRMsyncerror> roleSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>))
        {
            Importsequencenumber = importsequencenumber;
            Componentstate = componentstate;
            Solutionid = solutionid;
            this._roletemplateidValue = _roletemplateidValue;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Organizationid = organizationid;
            Name = name;
            Canbedeleted = canbedeleted;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            this._businessunitidValue = _businessunitidValue;
            Roleid = roleid;
            Overwritetime = overwritetime;
            Ismanaged = ismanaged;
            Iscustomizable = iscustomizable;
            this._parentrootroleidValue = _parentrootroleidValue;
            Roleidunique = roleidunique;
            this._parentroleidValue = _parentroleidValue;
            Overriddencreatedon = overriddencreatedon;
            Createdon = createdon;
            Versionnumber = versionnumber;
            SystemuserrolesAssociation = systemuserrolesAssociation;
            RoleprivilegesAssociation = roleprivilegesAssociation;
            AppmodulerolesAssociation = appmodulerolesAssociation;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Parentroleid = parentroleid;
            RoleParentRole = roleParentRole;
            Businessunitid = businessunitid;
            Roletemplateid = roletemplateid;
            RoleAsyncOperations = roleAsyncOperations;
            RoleBulkDeleteFailures = roleBulkDeleteFailures;
            OrganizationidOrganization = organizationidOrganization;
            Createdby = createdby;
            TeamrolesAssociation = teamrolesAssociation;
            Parentrootroleid = parentrootroleid;
            RoleParentRootRole = roleParentRootRole;
            RoleSyncErrors = roleSyncErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public System.Guid? Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_roletemplateid_value")]
        public System.Guid? _roletemplateidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public System.Guid? Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canbedeleted")]
        public string Canbedeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public System.Guid? _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleid")]
        public System.Guid? Roleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentrootroleid_value")]
        public System.Guid? _parentrootroleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleidunique")]
        public System.Guid? Roleidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentroleid_value")]
        public System.Guid? _parentroleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemuserroles_association")]
        public IList<MicrosoftDynamicsCRMsystemuser> SystemuserrolesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleprivileges_association")]
        public IList<MicrosoftDynamicsCRMprivilege> RoleprivilegesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmoduleroles_association")]
        public IList<MicrosoftDynamicsCRMappmodule> AppmodulerolesAssociation { get; set; }

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
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentroleid")]
        public MicrosoftDynamicsCRMrole Parentroleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "role_parent_role")]
        public IList<MicrosoftDynamicsCRMrole> RoleParentRole { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid")]
        public MicrosoftDynamicsCRMbusinessunit Businessunitid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roletemplateid")]
        public MicrosoftDynamicsCRMroletemplate Roletemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> RoleAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> RoleBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid_organization")]
        public MicrosoftDynamicsCRMorganization OrganizationidOrganization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teamroles_association")]
        public IList<MicrosoftDynamicsCRMteam> TeamrolesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentrootroleid")]
        public MicrosoftDynamicsCRMrole Parentrootroleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "role_parent_root_role")]
        public IList<MicrosoftDynamicsCRMrole> RoleParentRootRole { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> RoleSyncErrors { get; set; }

    }
}
