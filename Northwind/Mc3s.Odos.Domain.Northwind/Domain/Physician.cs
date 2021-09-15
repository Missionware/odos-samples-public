// File:    Physician.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:07:50 πμ
// Purpose: Definition of Class Physician

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
	/// Code         : Physician
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Name
	///
	/// </summary>
	[PersistedClass]
	public partial class Physician : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Name = "Name";
	
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
	
		#endregion
	
		#region Creation - Destruction
	
		#endregion
	}
}