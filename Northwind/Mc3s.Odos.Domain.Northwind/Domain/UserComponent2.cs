// File:    UserComponent2.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:32:34 πμ
// Purpose: Definition of Class UserComponent2

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
	/// Code         : UserComponent2
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Otherproperty1
	///
	/// </summary>
	[PersistedClass]
	public partial class UserComponent2 : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Otherproperty1 = "Otherproperty1";
	
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
		/// Code         : Otherproperty1
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string otherProperty1;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="otherProperty1")] 
		public string Otherproperty1
		{
		   get
		   {
		      // Load
		      this.loadCheck("Otherproperty1");
		      
		      // Get
		      return this.otherProperty1;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Otherproperty1");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Otherproperty1", this.otherProperty1, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.otherProperty1;
		         
		         try
		         {
		            // Set
		            this.otherProperty1 = value;
		         
		            // Log & Raise
		   	      this.setModified("Otherproperty1");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.otherProperty1 = xVal;
		            
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