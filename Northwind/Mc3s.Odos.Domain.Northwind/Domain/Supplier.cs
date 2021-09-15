// File:    Supplier.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:18:31 πμ
// Purpose: Definition of Class Supplier

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
	/// Code         : Supplier
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Supplierid
	/// Companyname
	/// Contactname
	/// Contacttitle
	/// Homepage
	/// Products
	/// Address
	///
	/// </summary>
	[PersistedClass]
	public partial class Supplier : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Supplierid = "Supplierid";
		public const string DEF_Companyname = "Companyname";
		public const string DEF_Contactname = "Contactname";
		public const string DEF_Contacttitle = "Contacttitle";
		public const string DEF_Homepage = "Homepage";
		public const string DEF_Products = "Products";
		public const string DEF_Address = "Address";
	
		#endregion
	
		#region Data
	
		//
		// Declarative Data
		//
	
		/// <summary>
		///
		/// Code         : Supplierid
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected long supplierId;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="supplierId",_IDOrder=1)] 
		public long Supplierid
		{
		   get
		   {
		      // Load
		      this.loadCheck("Supplierid");
		      
		      // Get
		      return this.supplierId;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Supplierid");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Supplierid", this.supplierId, value) != SetAction.NoChange)
		      {
		         // Backup
		         long xVal = this.supplierId;
		         
		         try
		         {
		            // Set
		            this.supplierId = value;
		         
		            // Log & Raise
		   	      this.setModified("Supplierid");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.supplierId = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Companyname
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string companyName;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="companyName")] 
		public string Companyname
		{
		   get
		   {
		      // Load
		      this.loadCheck("Companyname");
		      
		      // Get
		      return this.companyName;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Companyname");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Companyname", this.companyName, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.companyName;
		         
		         try
		         {
		            // Set
		            this.companyName = value;
		         
		            // Log & Raise
		   	      this.setModified("Companyname");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.companyName = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Contactname
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string contactName;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="contactName")] 
		public string Contactname
		{
		   get
		   {
		      // Load
		      this.loadCheck("Contactname");
		      
		      // Get
		      return this.contactName;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Contactname");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Contactname", this.contactName, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.contactName;
		         
		         try
		         {
		            // Set
		            this.contactName = value;
		         
		            // Log & Raise
		   	      this.setModified("Contactname");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.contactName = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Contacttitle
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string contactTitle;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="contactTitle")] 
		public string Contacttitle
		{
		   get
		   {
		      // Load
		      this.loadCheck("Contacttitle");
		      
		      // Get
		      return this.contactTitle;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Contacttitle");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Contacttitle", this.contactTitle, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.contactTitle;
		         
		         try
		         {
		            // Set
		            this.contactTitle = value;
		         
		            // Log & Raise
		   	      this.setModified("Contacttitle");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.contactTitle = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Homepage
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string homePage;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="homePage")] 
		public string Homepage
		{
		   get
		   {
		      // Load
		      this.loadCheck("Homepage");
		      
		      // Get
		      return this.homePage;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Homepage");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Homepage", this.homePage, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.homePage;
		         
		         try
		         {
		            // Set
		            this.homePage = value;
		         
		            // Log & Raise
		   	      this.setModified("Homepage");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.homePage = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Products
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DataItemRefList<Product> products = null;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="products",_ReverseRef="supplier")] 
		public DataItemRefList<Product> Products
		{
		   get
		   {
		      // Load
		      loadCheck("Products");
		      
		      // Get
		      return products;
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
		protected Address address;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="address")] 
		public Address Address
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
		         Address xRef = this.address;
		         
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
	
		#endregion
	
		#region Creation - Destruction
	
		#endregion
	}
}