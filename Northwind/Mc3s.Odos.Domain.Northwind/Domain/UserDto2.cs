// File:    UserDto2.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:40:52 πμ
// Purpose: Definition of Class UserDto2

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
	/// Code         : UserDto2
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Registeredat
	/// Id
	/// Enum1
	///
	/// </summary>
	[PersistedClass]
	public partial class UserDto2 : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Registeredat = "Registeredat";
		public const string DEF_Id = "Id";
		public const string DEF_Enum1 = "Enum1";
	
		#endregion
	
		#region Data
	
		//
		// Declarative Data
		//
	
		/// <summary>
		///
		/// Code         : Registeredat
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DateTime registeredAt;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="registeredAt",_AutoValue=AutoValue.Identity)] 
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
		/// Code         : Id
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected int id;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="id",_IDOrder=1)] 
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
		/// Code         : Enum1
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected EnumStoredAsInt32 enum1;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="enum1")] 
		public EnumStoredAsInt32 Enum1
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
		         EnumStoredAsInt32 xRef = this.enum1;
		         
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
	
		#endregion
	
		#region Creation - Destruction
		
		#endregion
	}
}