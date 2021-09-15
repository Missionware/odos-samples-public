// File:    State.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:07:50 πμ
// Purpose: Definition of Class State

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
	/// Code         : State
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Abbreviation
	/// Fullname
	///
	/// </summary>
	[PersistedClass]
	public partial class State : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Abbreviation = "Abbreviation";
		public const string DEF_Fullname = "Fullname";
	
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
		/// Code         : Abbreviation
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string abbreviation;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="abbreviation")] 
		public string Abbreviation
		{
		   get
		   {
		      // Load
		      this.loadCheck("Abbreviation");
		      
		      // Get
		      return this.abbreviation;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Abbreviation");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Abbreviation", this.abbreviation, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.abbreviation;
		         
		         try
		         {
		            // Set
		            this.abbreviation = value;
		         
		            // Log & Raise
		   	      this.setModified("Abbreviation");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.abbreviation = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Fullname
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string fullName;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="fullName")] 
		public string Fullname
		{
		   get
		   {
		      // Load
		      this.loadCheck("Fullname");
		      
		      // Get
		      return this.fullName;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Fullname");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Fullname", this.fullName, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.fullName;
		         
		         try
		         {
		            // Set
		            this.fullName = value;
		         
		            // Log & Raise
		   	      this.setModified("Fullname");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.fullName = xVal;
		            
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