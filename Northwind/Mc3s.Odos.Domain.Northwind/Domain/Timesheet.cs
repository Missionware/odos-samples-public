// File:    Timesheet.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:32:33 πμ
// Purpose: Definition of Class Timesheet

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
	/// Code         : Timesheet
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Submitteddate
	/// Submitted
	/// Users
	/// Entries
	///
	/// </summary>
	[PersistedClass]
	public partial class Timesheet : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Submitteddate = "Submitteddate";
		public const string DEF_Submitted = "Submitted";
		public const string DEF_Users = "Users";
		public const string DEF_Entries = "Entries";
	
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
		/// Code         : Submitteddate
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DateTime submittedDate;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="submittedDate")] 
		public DateTime Submitteddate
		{
		   get
		   {
		      // Load
		      this.loadCheck("Submitteddate");
		      
		      // Get
		      return this.submittedDate;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Submitteddate");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Submitteddate", this.submittedDate, value) != SetAction.NoChange)
		      {
		         // Backup
		         DateTime xVal = this.submittedDate;
		         
		         try
		         {
		            // Set
		            this.submittedDate = value;
		         
		            // Log & Raise
		   	      this.setModified("Submitteddate");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.submittedDate = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Submitted
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected bool submitted;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="submitted")] 
		public bool Submitted
		{
		   get
		   {
		      // Load
		      this.loadCheck("Submitted");
		      
		      // Get
		      return this.submitted;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Submitted");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Submitted", this.submitted, value) != SetAction.NoChange)
		      {
		         // Backup
		         bool xVal = this.submitted;
		         
		         try
		         {
		            // Set
		            this.submitted = value;
		         
		            // Log & Raise
		   	      this.setModified("Submitted");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.submitted = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Users
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DataItemRefList<Userx> users = null;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="users")] 
		public DataItemRefList<Userx> Users
		{
		   get
		   {
		      // Load
		      loadCheck("Users");
		      
		      // Get
		      return users;
		   }
		}
		/// <summary>
		///
		/// Code         : Entries
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DataItemRefList<TimesheetEntry> entries = null;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="entries")] 
		public DataItemRefList<TimesheetEntry> Entries
		{
		   get
		   {
		      // Load
		      loadCheck("Entries");
		      
		      // Get
		      return entries;
		   }
		}
	
		#endregion
	
		#region Creation - Destruction
		
		#endregion
	}
}