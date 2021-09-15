// File:    Address.cs
// Author:  kostas
// Created: Πέμπτη, 1 Αυγούστου 2013 3:48:28 πμ
// Purpose: Definition of Class Address

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
	/// Code         : Address
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Street
	/// City
	/// Region
	/// Postalcode
	/// Country
	/// Phonenumber
	/// Fax
	///
	/// </summary>
	[PersistedClass]
	public partial class Address : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Street = "Street";
		public const string DEF_City = "City";
		public const string DEF_Region = "Region";
		public const string DEF_Postalcode = "Postalcode";
		public const string DEF_Country = "Country";
		public const string DEF_Phonenumber = "Phonenumber";
		public const string DEF_Fax = "Fax";
	
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
		/// Code         : Street
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string street;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="street")] 
		public string Street
		{
		   get
		   {
		      // Load
		      this.loadCheck("Street");
		      
		      // Get
		      return this.street;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Street");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Street", this.street, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.street;
		         
		         try
		         {
		            // Set
		            this.street = value;
		         
		            // Log & Raise
		   	      this.setModified("Street");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.street = xVal;
		            
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
		/// Code         : Region
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string region;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="region")] 
		public string Region
		{
		   get
		   {
		      // Load
		      this.loadCheck("Region");
		      
		      // Get
		      return this.region;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Region");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Region", this.region, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.region;
		         
		         try
		         {
		            // Set
		            this.region = value;
		         
		            // Log & Raise
		   	      this.setModified("Region");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.region = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Postalcode
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string postalCode;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="postalCode")] 
		public string Postalcode
		{
		   get
		   {
		      // Load
		      this.loadCheck("Postalcode");
		      
		      // Get
		      return this.postalCode;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Postalcode");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Postalcode", this.postalCode, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.postalCode;
		         
		         try
		         {
		            // Set
		            this.postalCode = value;
		         
		            // Log & Raise
		   	      this.setModified("Postalcode");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.postalCode = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Country
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string country;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="country")] 
		public string Country
		{
		   get
		   {
		      // Load
		      this.loadCheck("Country");
		      
		      // Get
		      return this.country;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Country");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Country", this.country, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.country;
		         
		         try
		         {
		            // Set
		            this.country = value;
		         
		            // Log & Raise
		   	      this.setModified("Country");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.country = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Phonenumber
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string phoneNumber;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="phoneNumber")] 
		public string Phonenumber
		{
		   get
		   {
		      // Load
		      this.loadCheck("Phonenumber");
		      
		      // Get
		      return this.phoneNumber;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Phonenumber");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Phonenumber", this.phoneNumber, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.phoneNumber;
		         
		         try
		         {
		            // Set
		            this.phoneNumber = value;
		         
		            // Log & Raise
		   	      this.setModified("Phonenumber");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.phoneNumber = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Fax
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string fax;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="fax")] 
		public string Fax
		{
		   get
		   {
		      // Load
		      this.loadCheck("Fax");
		      
		      // Get
		      return this.fax;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Fax");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Fax", this.fax, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.fax;
		         
		         try
		         {
		            // Set
		            this.fax = value;
		         
		            // Log & Raise
		   	      this.setModified("Fax");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.fax = xVal;
		            
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