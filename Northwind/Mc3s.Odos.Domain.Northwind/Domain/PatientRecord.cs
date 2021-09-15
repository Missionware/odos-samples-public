// File:    PatientRecord.cs
// Author:  kostas
// Created: Πέμπτη, 1 Αυγούστου 2013 3:48:35 πμ
// Purpose: Definition of Class PatientRecord

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
	/// Code         : PatientRecord
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Birthdate
	/// Address
	/// Patient
	/// Gender
	/// Name
	///
	/// </summary>
	[PersistedClass]
	public partial class PatientRecord : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Birthdate = "Birthdate";
		public const string DEF_Address = "Address";
		public const string DEF_Patient = "Patient";
		public const string DEF_Gender = "Gender";
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
		/// Code         : Birthdate
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DateTime birthdate;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="birthdate")] 
		public DateTime Birthdate
		{
		   get
		   {
		      // Load
		      this.loadCheck("Birthdate");
		      
		      // Get
		      return this.birthdate;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Birthdate");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Birthdate", this.birthdate, value) != SetAction.NoChange)
		      {
		         // Backup
		         DateTime xVal = this.birthdate;
		         
		         try
		         {
		            // Set
		            this.birthdate = value;
		         
		            // Log & Raise
		   	      this.setModified("Birthdate");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.birthdate = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Address
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected PatientAddress address;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="address")] 
		public PatientAddress Address
		{
		   get
		   {
		      // Load
		      this.loadCheck("Address");
		      
		      // Get
		      return this.address;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Address");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Address", this.address, value) != SetAction.NoChange)
		      {
		         // Backup
		         PatientAddress xRef = this.address;
		         
		         try
		         {
		            // Set REFERENCE
		            this.address = value;
		         
		            // Log & Raise
		   	      this.setModified("Address");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.address = xRef;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Patient
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Patient patient;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="patient",_ReverseRef="patientRecords")] 
		public Patient Patient
		{
		   get
		   {
		      // Load
		      this.loadCheck("Patient");
		      
		      // Get
		      return this.patient;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Patient");
		      
		      // Check Modification Action
		      SetAction action = this.modifyCheck("Patient", this.patient, value);
		
		      // Check
		      if (action == SetAction.NoChange) return;
		
		      // Init
		      Patient newV = (Patient)value;
		      Patient oldV = this.patient;
		         
		      // Act
		      if (action == SetAction.Assign)
		      {
		         // 'newV' is not null --- else it would be a NoChange
		         
		         
		         try
		         {
		            // Insertion of REFERENCE
		            this.patient = newV;
		            newV.Patientrecords.Add(this);
		            
		            // Log & Raise
			         this.setModified("Patient");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.patient = null;
		            newV.Patientrecords.Remove(this);
		                     
		            // Rethrow
		            throw ex;
		         }
		      }
		      else if (action == SetAction.Nullify)
		      {
		         try
		         {
		            // Deletion of REFERENCE
		            this.patient = null;
		            oldV.Patientrecords.Remove(this);
		            
		            // Log & Raise
			         this.setModified("Patient");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.patient = oldV;
		            oldV.Patientrecords.Add(this);
		                    
		            // Rethrow
		            throw ex;
		         }
		      }
		      else if (action == SetAction.Replace)
		      {
		         // 'newV' & 'oldV' are not null --- else it would be an Insertion, a Nullify or a NoChange
		         
		         
		         try
		         {
		            // Update of REFERENCE
		            oldV.Patientrecords.Remove(this);
		            this.patient = newV;
		            newV.Patientrecords.Add(this);
		            
		            // Log & Raise
			         this.setModified("Patient");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            newV.Patientrecords.Remove(this);
		            this.patient = oldV;
		            oldV.Patientrecords.Add(this);
		                     
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Gender
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Gender gender;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="gender")] 
		public Gender Gender
		{
		   get
		   {
		      // Load
		      this.loadCheck("Gender");
		      
		      // Get
		      return this.gender;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Gender");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Gender", this.gender, value) != SetAction.NoChange)
		      {
		         // Backup
		         Gender xRef = this.gender;
		         
		         try
		         {
		            // Set REFERENCE
		            this.gender = value;
		         
		            // Log & Raise
		   	      this.setModified("Gender");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.gender = xRef;
		            
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
		protected PatientName name;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="name")] 
		public PatientName Name
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
		         PatientName xRef = this.name;
		         
		         try
		         {
		            // Set REFERENCE
		            this.name = value;
		         
		            // Log & Raise
		   	      this.setModified("Name");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.name = xRef;
		            
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