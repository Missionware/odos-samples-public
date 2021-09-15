// File:    Role.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:32:33 πμ
// Purpose: Definition of Class Role

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
	/// Code         : Role
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Name
	/// Isactive
	/// Parentrole
	/// Entity
	///
	/// </summary>
	[PersistedClass]
	public partial class Role : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Name = "Name";
		public const string DEF_Isactive = "Isactive";
		public const string DEF_Parentrole = "Parentrole";
		public const string DEF_Entity = "Entity";
	
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
		/// Code         : Isactive
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected bool isActive;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="isActive")] 
		public bool Isactive
		{
		   get
		   {
		      // Load
		      this.loadCheck("Isactive");
		      
		      // Get
		      return this.isActive;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Isactive");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Isactive", this.isActive, value) != SetAction.NoChange)
		      {
		         // Backup
		         bool xVal = this.isActive;
		         
		         try
		         {
		            // Set
		            this.isActive = value;
		         
		            // Log & Raise
		   	      this.setModified("Isactive");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.isActive = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Parentrole
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Role parentRole;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="parentRole")] 
		public Role Parentrole
		{
		   get
		   {
		      // Load
		      this.loadCheck("Parentrole");
		      
		      // Get
		      return this.parentRole;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Parentrole");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Parentrole", this.parentRole, value) != SetAction.NoChange)
		      {
		         // Backup
		         Role xRef = this.parentRole;
		         
		         try
		         {
		            // Set REFERENCE
		            this.parentRole = value;
		         
		            // Log & Raise
		   	      this.setModified("Parentrole");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.parentRole = xRef;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Entity
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected AnotherEntity entity;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="entity")] 
		public AnotherEntity Entity
		{
		   get
		   {
		      // Load
		      this.loadCheck("Entity");
		      
		      // Get
		      return this.entity;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Entity");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Entity", this.entity, value) != SetAction.NoChange)
		      {
		         // Backup
		         AnotherEntity xRef = this.entity;
		         
		         try
		         {
		            // Set REFERENCE
		            this.entity = value;
		         
		            // Log & Raise
		   	      this.setModified("Entity");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.entity = xRef;
		            
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