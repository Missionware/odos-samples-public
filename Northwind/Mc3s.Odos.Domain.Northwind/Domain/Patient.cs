// File:    Patient.cs
// Author:  kostas
// Created: Πέμπτη, 1 Αυγούστου 2013 3:48:35 πμ
// Purpose: Definition of Class Patient

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
	/// Code         : Patient
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Active
	/// Patientrecords
	/// Physician
	///
	/// </summary>
	[PersistedClass]
	public partial class Patient : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Active = "Active";
		public const string DEF_Patientrecords = "Patientrecords";
		public const string DEF_Physician = "Physician";
	
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
		/// Code         : Active
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected bool active;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="active")] 
		public bool Active
		{
		   get
		   {
		      // Load
		      this.loadCheck("Active");
		      
		      // Get
		      return this.active;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Active");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Active", this.active, value) != SetAction.NoChange)
		      {
		         // Backup
		         bool xVal = this.active;
		         
		         try
		         {
		            // Set
		            this.active = value;
		         
		            // Log & Raise
		   	      this.setModified("Active");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.active = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Patientrecords
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DataItemRefList<PatientRecord> patientRecords = null;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="patientRecords",_ReverseRef="patient")] 
		public DataItemRefList<PatientRecord> Patientrecords
		{
		   get
		   {
		      // Load
		      loadCheck("Patientrecords");
		      
		      // Get
		      return patientRecords;
		   }
		}
		/// <summary>
		///
		/// Code         : Physician
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Physician physician;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="physician")] 
		public Physician Physician
		{
		   get
		   {
		      // Load
		      this.loadCheck("Physician");
		      
		      // Get
		      return this.physician;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Physician");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Physician", this.physician, value) != SetAction.NoChange)
		      {
		         // Backup
		         Physician xRef = this.physician;
		         
		         try
		         {
		            // Set REFERENCE
		            this.physician = value;
		         
		            // Log & Raise
		   	      this.setModified("Physician");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.physician = xRef;
		            
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