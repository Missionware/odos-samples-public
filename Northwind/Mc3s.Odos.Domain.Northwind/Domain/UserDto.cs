// File:    UserDto.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:40:08 πμ
// Purpose: Definition of Class UserDto

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
	/// Code         : UserDto
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Name
	/// Invalidloginattempts
	/// Rolename
	/// Userdto2
	///
	/// </summary>
	[PersistedClass]
	public partial class UserDto : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Name = "Name";
		public const string DEF_Invalidloginattempts = "Invalidloginattempts";
		public const string DEF_Rolename = "Rolename";
		public const string DEF_Userdto2 = "Userdto2";
	
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
		protected int id;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="id",_IDOrder=1,_AutoValue=AutoValue.Identity)] 
		public int Id
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
		         int xVal = this.id;
		         
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
		/// Code         : Rolename
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string roleName;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="roleName")] 
		public string Rolename
		{
		   get
		   {
		      // Load
		      this.loadCheck("Rolename");
		      
		      // Get
		      return this.roleName;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Rolename");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Rolename", this.roleName, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.roleName;
		         
		         try
		         {
		            // Set
		            this.roleName = value;
		         
		            // Log & Raise
		   	      this.setModified("Rolename");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.roleName = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Userdto2
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected UserDto2 userDto2;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="userDto2")] 
		public UserDto2 Userdto2
		{
		   get
		   {
		      // Load
		      this.loadCheck("Userdto2");
		      
		      // Get
		      return this.userDto2;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Userdto2");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Userdto2", this.userDto2, value) != SetAction.NoChange)
		      {
		         // Backup
		         UserDto2 xRef = this.userDto2;
		         
		         try
		         {
		            // Set REFERENCE
		            this.userDto2 = value;
		         
		            // Log & Raise
		   	      this.setModified("Userdto2");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.userDto2 = xRef;
		            
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