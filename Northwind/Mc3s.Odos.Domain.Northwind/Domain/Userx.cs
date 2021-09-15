// File:    Userx.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:32:33 πμ
// Purpose: Definition of Class Userx

using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Mc3s.Odos.Library;

namespace Mc3s.Odos.Domain.Northwind
{
	/// <summary>
	/// 
	/// Code         : Userx
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Name
	/// Invalidloginattempts
	/// Registeredat
	/// Lastlogindate
	/// Enum1
	/// Enum2
	/// Role
	/// Component
	/// Features
	///
	/// </summary>
	[PersistedClass]
	public partial class Userx : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Name = "Name";
		public const string DEF_Invalidloginattempts = "Invalidloginattempts";
		public const string DEF_Registeredat = "Registeredat";
		public const string DEF_Lastlogindate = "Lastlogindate";
		public const string DEF_Enum1 = "Enum1";
		public const string DEF_Enum2 = "Enum2";
		public const string DEF_Role = "Role";
		public const string DEF_Component = "Component";
		public const string DEF_Features = "Features";
	
		#endregion
	
		#region Data
	
		//
		// Declarative Data
		//
	
		/// <summary>
		///
		/// Code         : Id
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected long id;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="id",_IDOrder=1,_AutoValue=AutoValue.Identity)] 
		public long Id
		{
		   get
		   {
		      // Load
		      this.loadCheck("Id");
		      
		      // Get
		      return this.id;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Id");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Id", this.id, value) != SetAction.NoChange)
		      {
		         // Backup
		         long xVal = this.id;
		         
		         try
		         {
		            // Set
		            this.id = value;
		         
		            // Log & Raise
		   	      this.setModified("Id");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.id = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Name
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string name;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="name")] 
		public string Name
		{
		   get
		   {
		      // Load
		      this.loadCheck("Name");
		      
		      // Get
		      return this.name;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Name");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Name", this.name, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.name;
		         
		         try
		         {
		            // Set
		            this.name = value;
		         
		            // Log & Raise
		   	      this.setModified("Name");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.name = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Invalidloginattempts
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected int invalidLoginAttempts;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="invalidLoginAttempts")] 
		public int Invalidloginattempts
		{
		   get
		   {
		      // Load
		      this.loadCheck("Invalidloginattempts");
		      
		      // Get
		      return this.invalidLoginAttempts;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Invalidloginattempts");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Invalidloginattempts", this.invalidLoginAttempts, value) != SetAction.NoChange)
		      {
		         // Backup
		         int xVal = this.invalidLoginAttempts;
		         
		         try
		         {
		            // Set
		            this.invalidLoginAttempts = value;
		         
		            // Log & Raise
		   	      this.setModified("Invalidloginattempts");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.invalidLoginAttempts = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Registeredat
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DateTime registeredAt;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="registeredAt")] 
		public DateTime Registeredat
		{
		   get
		   {
		      // Load
		      this.loadCheck("Registeredat");
		      
		      // Get
		      return this.registeredAt;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Registeredat");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Registeredat", this.registeredAt, value) != SetAction.NoChange)
		      {
		         // Backup
		         DateTime xVal = this.registeredAt;
		         
		         try
		         {
		            // Set
		            this.registeredAt = value;
		         
		            // Log & Raise
		   	      this.setModified("Registeredat");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.registeredAt = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Lastlogindate
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DateTime lastLoginDate;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="lastLoginDate")] 
		public DateTime Lastlogindate
		{
		   get
		   {
		      // Load
		      this.loadCheck("Lastlogindate");
		      
		      // Get
		      return this.lastLoginDate;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Lastlogindate");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Lastlogindate", this.lastLoginDate, value) != SetAction.NoChange)
		      {
		         // Backup
		         DateTime xVal = this.lastLoginDate;
		         
		         try
		         {
		            // Set
		            this.lastLoginDate = value;
		         
		            // Log & Raise
		   	      this.setModified("Lastlogindate");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.lastLoginDate = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Enum1
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected EnumStoredAsString enum1;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="enum1")] 
		public EnumStoredAsString Enum1
		{
		   get
		   {
		      // Load
		      this.loadCheck("Enum1");
		      
		      // Get
		      return this.enum1;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Enum1");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Enum1", this.enum1, value) != SetAction.NoChange)
		      {
		         // Backup
		         EnumStoredAsString xRef = this.enum1;
		         
		         try
		         {
		            // Set REFERENCE
		            this.enum1 = value;
		         
		            // Log & Raise
		   	      this.setModified("Enum1");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.enum1 = xRef;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Enum2
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected EnumStoredAsInt32 enum2;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="enum2")] 
		public EnumStoredAsInt32 Enum2
		{
		   get
		   {
		      // Load
		      this.loadCheck("Enum2");
		      
		      // Get
		      return this.enum2;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Enum2");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Enum2", this.enum2, value) != SetAction.NoChange)
		      {
		         // Backup
		         EnumStoredAsInt32 xRef = this.enum2;
		         
		         try
		         {
		            // Set REFERENCE
		            this.enum2 = value;
		         
		            // Log & Raise
		   	      this.setModified("Enum2");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.enum2 = xRef;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Role
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Role role;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="role")] 
		public Role Role
		{
		   get
		   {
		      // Load
		      this.loadCheck("Role");
		      
		      // Get
		      return this.role;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Role");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Role", this.role, value) != SetAction.NoChange)
		      {
		         // Backup
		         Role xRef = this.role;
		         
		         try
		         {
		            // Set REFERENCE
		            this.role = value;
		         
		            // Log & Raise
		   	      this.setModified("Role");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.role = xRef;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Component
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected UserComponent component;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="component")] 
		public UserComponent Component
		{
		   get
		   {
		      // Load
		      this.loadCheck("Component");
		      
		      // Get
		      return this.component;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Component");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Component", this.component, value) != SetAction.NoChange)
		      {
		         // Backup
		         UserComponent xRef = this.component;
		         
		         try
		         {
		            // Set REFERENCE
		            this.component = value;
		         
		            // Log & Raise
		   	      this.setModified("Component");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.component = xRef;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Features
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected FeatureSet features;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="features")] 
		public FeatureSet Features
		{
		   get
		   {
		      // Load
		      this.loadCheck("Features");
		      
		      // Get
		      return this.features;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Features");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Features", this.features, value) != SetAction.NoChange)
		      {
		         // Backup
		         FeatureSet xRef = this.features;
		         
		         try
		         {
		            // Set REFERENCE
		            this.features = value;
		         
		            // Log & Raise
		   	      this.setModified("Features");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.features = xRef;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
	
		#endregion
	
		#region Creation - Destruction
		
		#endregion
	}
}