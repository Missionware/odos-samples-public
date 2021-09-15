// File:    TimesheetEntry.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:32:33 πμ
// Purpose: Definition of Class TimesheetEntry

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
	/// Code         : TimesheetEntry
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Entrydate
	/// Numberofhours
	/// Comments
	///
	/// </summary>
	[PersistedClass]
	public partial class TimesheetEntry : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Entrydate = "Entrydate";
		public const string DEF_Numberofhours = "Numberofhours";
		public const string DEF_Comments = "Comments";
	
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
		/// Code         : Entrydate
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DateTime entryDate;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="entryDate")] 
		public DateTime Entrydate
		{
		   get
		   {
		      // Load
		      this.loadCheck("Entrydate");
		      
		      // Get
		      return this.entryDate;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Entrydate");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Entrydate", this.entryDate, value) != SetAction.NoChange)
		      {
		         // Backup
		         DateTime xVal = this.entryDate;
		         
		         try
		         {
		            // Set
		            this.entryDate = value;
		         
		            // Log & Raise
		   	      this.setModified("Entrydate");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.entryDate = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Numberofhours
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected int numberOfHours;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="numberOfHours")] 
		public int Numberofhours
		{
		   get
		   {
		      // Load
		      this.loadCheck("Numberofhours");
		      
		      // Get
		      return this.numberOfHours;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Numberofhours");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Numberofhours", this.numberOfHours, value) != SetAction.NoChange)
		      {
		         // Backup
		         int xVal = this.numberOfHours;
		         
		         try
		         {
		            // Set
		            this.numberOfHours = value;
		         
		            // Log & Raise
		   	      this.setModified("Numberofhours");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.numberOfHours = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Comments
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string comments;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="comments")] 
		public string Comments
		{
		   get
		   {
		      // Load
		      this.loadCheck("Comments");
		      
		      // Get
		      return this.comments;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Comments");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Comments", this.comments, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.comments;
		         
		         try
		         {
		            // Set
		            this.comments = value;
		         
		            // Log & Raise
		   	      this.setModified("Comments");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.comments = xVal;
		            
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