// File:    PatientAddress.cs
// Author:  kostas
// Created: Πέμπτη, 1 Αυγούστου 2013 3:48:34 πμ
// Purpose: Definition of Class PatientAddress

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
	/// Code         : PatientAddress
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// State
	/// Addressline1
	/// Addressline2
	/// City
	/// Zipcode
	///
	/// </summary>
	[PersistedClass]
	public partial class PatientAddress : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_State = "State";
		public const string DEF_Addressline1 = "Addressline1";
		public const string DEF_Addressline2 = "Addressline2";
		public const string DEF_City = "City";
		public const string DEF_Zipcode = "Zipcode";
	
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
		/// Code         : State
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected State state;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="state")] 
		public State State
		{
		   get
		   {
		      // Load
		      this.loadCheck("State");
		      
		      // Get
		      return this.state;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("State");
		      
		      // Check Modification Action
		      if (this.modifyCheck("State", this.state, value) != SetAction.NoChange)
		      {
		         // Backup
		         State xRef = this.state;
		         
		         try
		         {
		            // Set REFERENCE
		            this.state = value;
		         
		            // Log & Raise
		   	      this.setModified("State");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.state = xRef;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Addressline1
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string addressLine1;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="addressLine1")] 
		public string Addressline1
		{
		   get
		   {
		      // Load
		      this.loadCheck("Addressline1");
		      
		      // Get
		      return this.addressLine1;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Addressline1");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Addressline1", this.addressLine1, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.addressLine1;
		         
		         try
		         {
		            // Set
		            this.addressLine1 = value;
		         
		            // Log & Raise
		   	      this.setModified("Addressline1");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.addressLine1 = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Addressline2
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string addressLine2;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="addressLine2")] 
		public string Addressline2
		{
		   get
		   {
		      // Load
		      this.loadCheck("Addressline2");
		      
		      // Get
		      return this.addressLine2;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Addressline2");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Addressline2", this.addressLine2, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.addressLine2;
		         
		         try
		         {
		            // Set
		            this.addressLine2 = value;
		         
		            // Log & Raise
		   	      this.setModified("Addressline2");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.addressLine2 = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : City
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string city;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="city")] 
		public string City
		{
		   get
		   {
		      // Load
		      this.loadCheck("City");
		      
		      // Get
		      return this.city;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("City");
		      
		      // Check Modification Action
		      if (this.modifyCheck("City", this.city, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.city;
		         
		         try
		         {
		            // Set
		            this.city = value;
		         
		            // Log & Raise
		   	      this.setModified("City");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.city = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Zipcode
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string zipCode;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="zipCode")] 
		public string Zipcode
		{
		   get
		   {
		      // Load
		      this.loadCheck("Zipcode");
		      
		      // Get
		      return this.zipCode;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Zipcode");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Zipcode", this.zipCode, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.zipCode;
		         
		         try
		         {
		            // Set
		            this.zipCode = value;
		         
		            // Log & Raise
		   	      this.setModified("Zipcode");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.zipCode = xVal;
		            
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