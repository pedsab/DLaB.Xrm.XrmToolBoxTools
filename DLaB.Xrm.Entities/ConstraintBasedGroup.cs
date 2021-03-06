//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLaB.Xrm.Entities
{
	
	/// <summary>
	/// Group or collection of people, equipment, and/or facilities that can be scheduled.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("constraintbasedgroup")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public partial class ConstraintBasedGroup : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string BusinessUnitId = "businessunitid";
			public const string ConstraintBasedGroupId = "constraintbasedgroupid";
			public const string Id = "constraintbasedgroupid";
			public const string Constraints = "constraints";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string GroupTypeCode = "grouptypecode";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string VersionNumber = "versionnumber";
			public const string business_unit_constraint_based_groups = "business_unit_constraint_based_groups";
			public const string constraintbasedgroup_systemuser = "constraintbasedgroup_systemuser";
			public const string lk_constraintbasedgroup_createdby = "lk_constraintbasedgroup_createdby";
			public const string lk_constraintbasedgroup_createdonbehalfby = "lk_constraintbasedgroup_createdonbehalfby";
			public const string lk_constraintbasedgroup_modifiedby = "lk_constraintbasedgroup_modifiedby";
			public const string lk_constraintbasedgroup_modifiedonbehalfby = "lk_constraintbasedgroup_modifiedonbehalfby";
			public const string organization_constraint_based_groups = "organization_constraint_based_groups";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ConstraintBasedGroup() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "constraintbasedgroup";
		
		public const int EntityTypeCode = 4007;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Shows the business unit that the record owner belongs to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BusinessUnitId");
				this.SetAttributeValue("businessunitid", value);
				this.OnPropertyChanged("BusinessUnitId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the resource group.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("constraintbasedgroupid")]
		public System.Nullable<System.Guid> ConstraintBasedGroupId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("constraintbasedgroupid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConstraintBasedGroupId");
				this.SetAttributeValue("constraintbasedgroupid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ConstraintBasedGroupId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("constraintbasedgroupid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.ConstraintBasedGroupId = value;
			}
		}
		
		/// <summary>
		/// Shows the constraints defined for the users, equipment, teams, and other resource groups included as resources for the group, stored in XML format.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("constraints")]
		public string Constraints
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("constraints");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Constraints");
				this.SetAttributeValue("constraints", value);
				this.OnPropertyChanged("Constraints");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the resource group.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedBy");
				this.SetAttributeValue("createdby", value);
				this.OnPropertyChanged("CreatedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the resource group was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOn");
				this.SetAttributeValue("createdon", value);
				this.OnPropertyChanged("CreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the constraintbasedgroup.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Type additional information to describe the resource group, such as the intended use or associated resource types.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Shows whether the resource group is static, dynamic or hidden. Hidden groups are for system use only and are not viewable in Microsoft Dynamics CRM.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("grouptypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue GroupTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("grouptypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("GroupTypeCode");
				this.SetAttributeValue("grouptypecode", value);
				this.OnPropertyChanged("GroupTypeCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the resource group.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedBy");
				this.SetAttributeValue("modifiedby", value);
				this.OnPropertyChanged("ModifiedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the resource group was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOn");
				this.SetAttributeValue("modifiedon", value);
				this.OnPropertyChanged("ModifiedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the constraintbasedgroup.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Type a title or name that describes the resource group.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated with the resource group.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N constraint_based_group_resource_specs
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraint_based_group_resource_specs")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.ResourceSpec> constraint_based_group_resource_specs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.ResourceSpec>("constraint_based_group_resource_specs", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("constraint_based_group_resource_specs");
				this.SetRelatedEntities<DLaB.Xrm.Entities.ResourceSpec>("constraint_based_group_resource_specs", null, value);
				this.OnPropertyChanged("constraint_based_group_resource_specs");
			}
		}
		
		/// <summary>
		/// 1:N ConstraintBasedGroup_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConstraintBasedGroup_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.AsyncOperation> ConstraintBasedGroup_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("ConstraintBasedGroup_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConstraintBasedGroup_AsyncOperations");
				this.SetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("ConstraintBasedGroup_AsyncOperations", null, value);
				this.OnPropertyChanged("ConstraintBasedGroup_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N ConstraintBasedGroup_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConstraintBasedGroup_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.BulkDeleteFailure> ConstraintBasedGroup_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("ConstraintBasedGroup_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConstraintBasedGroup_BulkDeleteFailures");
				this.SetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("ConstraintBasedGroup_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("ConstraintBasedGroup_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N constraintbasedgroup_connections1
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraintbasedgroup_connections1")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.Connection> constraintbasedgroup_connections1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.Connection>("constraintbasedgroup_connections1", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("constraintbasedgroup_connections1");
				this.SetRelatedEntities<DLaB.Xrm.Entities.Connection>("constraintbasedgroup_connections1", null, value);
				this.OnPropertyChanged("constraintbasedgroup_connections1");
			}
		}
		
		/// <summary>
		/// 1:N constraintbasedgroup_connections2
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraintbasedgroup_connections2")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.Connection> constraintbasedgroup_connections2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.Connection>("constraintbasedgroup_connections2", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("constraintbasedgroup_connections2");
				this.SetRelatedEntities<DLaB.Xrm.Entities.Connection>("constraintbasedgroup_connections2", null, value);
				this.OnPropertyChanged("constraintbasedgroup_connections2");
			}
		}
		
		/// <summary>
		/// 1:N ConstraintBasedGroup_ProcessSessions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConstraintBasedGroup_ProcessSessions")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.ProcessSession> ConstraintBasedGroup_ProcessSessions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.ProcessSession>("ConstraintBasedGroup_ProcessSessions", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConstraintBasedGroup_ProcessSessions");
				this.SetRelatedEntities<DLaB.Xrm.Entities.ProcessSession>("ConstraintBasedGroup_ProcessSessions", null, value);
				this.OnPropertyChanged("ConstraintBasedGroup_ProcessSessions");
			}
		}
		
		/// <summary>
		/// 1:N constraintbasedgroup_resource_groups
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraintbasedgroup_resource_groups")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.ResourceGroup> constraintbasedgroup_resource_groups
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.ResourceGroup>("constraintbasedgroup_resource_groups", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("constraintbasedgroup_resource_groups");
				this.SetRelatedEntities<DLaB.Xrm.Entities.ResourceGroup>("constraintbasedgroup_resource_groups", null, value);
				this.OnPropertyChanged("constraintbasedgroup_resource_groups");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_constraintbasedgroup
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_constraintbasedgroup")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.UserEntityInstanceData> userentityinstancedata_constraintbasedgroup
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_constraintbasedgroup", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_constraintbasedgroup");
				this.SetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_constraintbasedgroup", null, value);
				this.OnPropertyChanged("userentityinstancedata_constraintbasedgroup");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_constraint_based_groups
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_constraint_based_groups")]
		public DLaB.Xrm.Entities.BusinessUnit business_unit_constraint_based_groups
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.BusinessUnit>("business_unit_constraint_based_groups", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("business_unit_constraint_based_groups");
				this.SetRelatedEntity<DLaB.Xrm.Entities.BusinessUnit>("business_unit_constraint_based_groups", null, value);
				this.OnPropertyChanged("business_unit_constraint_based_groups");
			}
		}
		
		/// <summary>
		/// N:1 constraintbasedgroup_systemuser
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraintbasedgroup_systemuser")]
		public DLaB.Xrm.Entities.SystemUser constraintbasedgroup_systemuser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("constraintbasedgroup_systemuser", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("constraintbasedgroup_systemuser");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("constraintbasedgroup_systemuser", null, value);
				this.OnPropertyChanged("constraintbasedgroup_systemuser");
			}
		}
		
		/// <summary>
		/// N:1 lk_constraintbasedgroup_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_createdby")]
		public DLaB.Xrm.Entities.SystemUser lk_constraintbasedgroup_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_constraintbasedgroup_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_constraintbasedgroup_createdby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_constraintbasedgroup_createdby", null, value);
				this.OnPropertyChanged("lk_constraintbasedgroup_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_constraintbasedgroup_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_createdonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_constraintbasedgroup_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_constraintbasedgroup_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_constraintbasedgroup_createdonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_constraintbasedgroup_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_constraintbasedgroup_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_constraintbasedgroup_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_modifiedby")]
		public DLaB.Xrm.Entities.SystemUser lk_constraintbasedgroup_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_constraintbasedgroup_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_constraintbasedgroup_modifiedby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_constraintbasedgroup_modifiedby", null, value);
				this.OnPropertyChanged("lk_constraintbasedgroup_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_constraintbasedgroup_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_modifiedonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_constraintbasedgroup_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_constraintbasedgroup_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_constraintbasedgroup_modifiedonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_constraintbasedgroup_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_constraintbasedgroup_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_constraint_based_groups
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_constraint_based_groups")]
		public DLaB.Xrm.Entities.Organization organization_constraint_based_groups
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Organization>("organization_constraint_based_groups", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ConstraintBasedGroup(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["constraintbasedgroupid"] = base.Id;
                        break;
                    case "constraintbasedgroupid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("grouptypecode")]
		public virtual ConstraintBasedGroup_GroupTypeCode? GroupTypeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ConstraintBasedGroup_GroupTypeCode?)(EntityOptionSetEnum.GetEnum(this, "grouptypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				GroupTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}