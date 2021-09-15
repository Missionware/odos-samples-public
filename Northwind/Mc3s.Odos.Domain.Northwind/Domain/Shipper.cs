// File:    Shipper.cs
// Author:  kostas
// Created: Πέμπτη, 1 Αυγούστου 2013 3:48:32 πμ
// Purpose: Definition of Class Shipper

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
	/// Code         : Shipper
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Shipperid
	/// Companyname
	/// Phonenumber
	/// Reference
	/// Orders
	///
	/// </summary>
	[PersistedClass]
	public partial class Shipper : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Shipperid = "Shipperid";
		public const string DEF_Companyname = "Companyname";
		public const string DEF_Phonenumber = "Phonenumber";
		public const string DEF_Reference = "Reference";
		public const string DEF_Orders = "Orders";
	
		#endregion
	
		#region Data
	
		//
		// Declarative Data
		//
	
		/// <summary>
		///
		/// Code         : Shipperid
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected long shipperId;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="shipperId",_IDOrder=1)] 
		public long Shipperid
		{
		   get
		   {
		      // Load
		      this.loadCheck("Shipperid");
		      
		      // Get
		      return this.shipperId;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Shipperid");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Shipperid", this.shipperId, value) != SetAction.NoChange)
		      {
		         // Backup
		         long xVal = this.shipperId;
		         
		         try
		         {
		            // Set
		            this.shipperId = value;
		         
		            // Log & Raise
		   	      this.setModified("Shipperid");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.shipperId = xVal;
		            
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
		/// Code         : Reference
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string reference;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="reference")] 
		public string Reference
		{
		   get
		   {
		      // Load
		      this.loadCheck("Reference");
		      
		      // Get
		      return this.reference;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Reference");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Reference", this.reference, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.reference;
		         
		         try
		         {
		            // Set
		            this.reference = value;
		         
		            // Log & Raise
		   	      this.setModified("Reference");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.reference = xVal;
		            
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
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="orders",_ReverseRef="shipper")] 
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