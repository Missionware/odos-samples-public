// File:    PatientName.cs
// Author:  kostas
// Created: Πέμπτη, 1 Αυγούστου 2013 3:48:35 πμ
// Purpose: Definition of Class PatientName

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
	/// Code         : PatientName
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Firstname
	/// Lastname
	///
	/// </summary>
	[PersistedClass]
	public partial class PatientName : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Firstname = "Firstname";
		public const string DEF_Lastname = "Lastname";
	
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
		/// Code         : Firstname
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string firstName;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="firstName")] 
		public string Firstname
		{
		   get
		   {
		      // Load
		      this.loadCheck("Firstname");
		      
		      // Get
		      return this.firstName;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Firstname");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Firstname", this.firstName, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.firstName;
		         
		         try
		         {
		            // Set
		            this.firstName = value;
		         
		            // Log & Raise
		   	      this.setModified("Firstname");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.firstName = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Lastname
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string lastName;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="lastName")] 
		public string Lastname
		{
		   get
		   {
		      // Load
		      this.loadCheck("Lastname");
		      
		      // Get
		      return this.lastName;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Lastname");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Lastname", this.lastName, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.lastName;
		         
		         try
		         {
		            // Set
		            this.lastName = value;
		         
		            // Log & Raise
		   	      this.setModified("Lastname");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.lastName = xVal;
		            
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