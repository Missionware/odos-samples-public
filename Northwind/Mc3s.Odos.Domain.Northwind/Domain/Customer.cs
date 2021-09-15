// File:    Customer.cs
// Author:  kostas
// Created: Πέμπτη, 1 Αυγούστου 2013 3:48:29 πμ
// Purpose: Definition of Class Customer

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
	/// Code         : Customer
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Companyname
	/// Contactname
	/// Contacttitle
	/// Address
	/// Customerid
	/// Orders
	///
	/// </summary>
	[PersistedClass]
	public partial class Customer : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Companyname = "Companyname";
		public const string DEF_Contactname = "Contactname";
		public const string DEF_Contacttitle = "Contacttitle";
		public const string DEF_Address = "Address";
		public const string DEF_Customerid = "Customerid";
		public const string DEF_Orders = "Orders";
	
		#endregion
	
		#region Data
	
		//
		// Declarative Data
		//
	
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
		/// <summary>
		///
		/// Code         : Customerid
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string customerId;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="customerId",_IDOrder=1)] 
		public string Customerid
		{
		   get
		   {
		      // Load
		      this.loadCheck("Customerid");
		      
		      // Get
		      return this.customerId;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Customerid");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Customerid", this.customerId, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.customerId;
		         
		         try
		         {
		            // Set
		            this.customerId = value;
		         
		            // Log & Raise
		   	      this.setModified("Customerid");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.customerId = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Orders
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DataItemRefList<Orderx> orders = null;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="orders",_ReverseRef="customer")] 
		public DataItemRefList<Orderx> Orders
		{
		   get
		   {
		      // Load
		      loadCheck("Orders");
		      
		      // Get
		      return orders;
		   }
		}
	
		#endregion
	
		#region Creation - Destruction
		
		#endregion
	}
}