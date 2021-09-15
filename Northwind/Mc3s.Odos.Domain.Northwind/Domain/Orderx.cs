// File:    Orderx.cs
// Author:  kostas
// Created: Πέμπτη, 1 Αυγούστου 2013 3:48:31 πμ
// Purpose: Definition of Class Orderx

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
	/// Code         : Orderx
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Orderid
	/// Orderlines
	/// Employee
	/// Customer
	/// Orderdate
	/// Requireddate
	/// Shippingdate
	/// Freight
	/// Shippedto
	/// Shippingaddress
	/// Shipper
	///
	/// </summary>
	[PersistedClass]
	public partial class Orderx : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Orderid = "Orderid";
		public const string DEF_Orderlines = "Orderlines";
		public const string DEF_Employee = "Employee";
		public const string DEF_Customer = "Customer";
		public const string DEF_Orderdate = "Orderdate";
		public const string DEF_Requireddate = "Requireddate";
		public const string DEF_Shippingdate = "Shippingdate";
		public const string DEF_Freight = "Freight";
		public const string DEF_Shippedto = "Shippedto";
		public const string DEF_Shippingaddress = "Shippingaddress";
		public const string DEF_Shipper = "Shipper";
	
		#endregion
	
		#region Data
	
		//
		// Declarative Data
		//
	
		/// <summary>
		///
		/// Code         : Orderid
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected long orderId;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="orderId",_IDOrder=1)] 
		public long Orderid
		{
		   get
		   {
		      // Load
		      this.loadCheck("Orderid");
		      
		      // Get
		      return this.orderId;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Orderid");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Orderid", this.orderId, value) != SetAction.NoChange)
		      {
		         // Backup
		         long xVal = this.orderId;
		         
		         try
		         {
		            // Set
		            this.orderId = value;
		         
		            // Log & Raise
		   	      this.setModified("Orderid");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.orderId = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Orderlines
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DataItemRefList<OrderLine> orderLines = null;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="orderLines",_ReverseRef="order")] 
		public DataItemRefList<OrderLine> Orderlines
		{
		   get
		   {
		      // Load
		      loadCheck("Orderlines");
		      
		      // Get
		      return orderLines;
		   }
		}
		/// <summary>
		///
		/// Code         : Employee
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Employee employee;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="employee",_ReverseRef="orders")] 
		public Employee Employee
		{
		   get
		   {
		      // Load
		      this.loadCheck("Employee");
		      
		      // Get
		      return this.employee;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Employee");
		      
		      // Check Modification Action
		      SetAction action = this.modifyCheck("Employee", this.employee, value);
		
		      // Check
		      if (action == SetAction.NoChange) return;
		
		      // Init
		      Employee newV = (Employee)value;
		      Employee oldV = this.employee;
		         
		      // Act
		      if (action == SetAction.Assign)
		      {
		         // 'newV' is not null --- else it would be a NoChange
		         
		         
		         try
		         {
		            // Insertion of REFERENCE
		            this.employee = newV;
		            newV.Orders.Add(this);
		            
		            // Log & Raise
			         this.setModified("Employee");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.employee = null;
		            newV.Orders.Remove(this);
		                     
		            // Rethrow
		            throw ex;
		         }
		      }
		      else if (action == SetAction.Nullify)
		      {
		         try
		         {
		            // Deletion of REFERENCE
		            this.employee = null;
		            oldV.Orders.Remove(this);
		            
		            // Log & Raise
			         this.setModified("Employee");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.employee = oldV;
		            oldV.Orders.Add(this);
		                    
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
		            oldV.Orders.Remove(this);
		            this.employee = newV;
		            newV.Orders.Add(this);
		            
		            // Log & Raise
			         this.setModified("Employee");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            newV.Orders.Remove(this);
		            this.employee = oldV;
		            oldV.Orders.Add(this);
		                     
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Customer
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Customer customer;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="customer",_ReverseRef="orders")] 
		public Customer Customer
		{
		   get
		   {
		      // Load
		      this.loadCheck("Customer");
		      
		      // Get
		      return this.customer;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Customer");
		      
		      // Check Modification Action
		      SetAction action = this.modifyCheck("Customer", this.customer, value);
		
		      // Check
		      if (action == SetAction.NoChange) return;
		
		      // Init
		      Customer newV = (Customer)value;
		      Customer oldV = this.customer;
		         
		      // Act
		      if (action == SetAction.Assign)
		      {
		         // 'newV' is not null --- else it would be a NoChange
		         
		         
		         try
		         {
		            // Insertion of REFERENCE
		            this.customer = newV;
		            newV.Orders.Add(this);
		            
		            // Log & Raise
			         this.setModified("Customer");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.customer = null;
		            newV.Orders.Remove(this);
		                     
		            // Rethrow
		            throw ex;
		         }
		      }
		      else if (action == SetAction.Nullify)
		      {
		         try
		         {
		            // Deletion of REFERENCE
		            this.customer = null;
		            oldV.Orders.Remove(this);
		            
		            // Log & Raise
			         this.setModified("Customer");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.customer = oldV;
		            oldV.Orders.Add(this);
		                    
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
		            oldV.Orders.Remove(this);
		            this.customer = newV;
		            newV.Orders.Add(this);
		            
		            // Log & Raise
			         this.setModified("Customer");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            newV.Orders.Remove(this);
		            this.customer = oldV;
		            oldV.Orders.Add(this);
		                     
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Orderdate
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DateTime orderDate;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="orderDate")] 
		public DateTime Orderdate
		{
		   get
		   {
		      // Load
		      this.loadCheck("Orderdate");
		      
		      // Get
		      return this.orderDate;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Orderdate");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Orderdate", this.orderDate, value) != SetAction.NoChange)
		      {
		         // Backup
		         DateTime xVal = this.orderDate;
		         
		         try
		         {
		            // Set
		            this.orderDate = value;
		         
		            // Log & Raise
		   	      this.setModified("Orderdate");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.orderDate = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Requireddate
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DateTime requiredDate;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="requiredDate")] 
		public DateTime Requireddate
		{
		   get
		   {
		      // Load
		      this.loadCheck("Requireddate");
		      
		      // Get
		      return this.requiredDate;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Requireddate");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Requireddate", this.requiredDate, value) != SetAction.NoChange)
		      {
		         // Backup
		         DateTime xVal = this.requiredDate;
		         
		         try
		         {
		            // Set
		            this.requiredDate = value;
		         
		            // Log & Raise
		   	      this.setModified("Requireddate");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.requiredDate = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Shippingdate
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DateTime shippingDate;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="shippingDate")] 
		public DateTime Shippingdate
		{
		   get
		   {
		      // Load
		      this.loadCheck("Shippingdate");
		      
		      // Get
		      return this.shippingDate;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Shippingdate");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Shippingdate", this.shippingDate, value) != SetAction.NoChange)
		      {
		         // Backup
		         DateTime xVal = this.shippingDate;
		         
		         try
		         {
		            // Set
		            this.shippingDate = value;
		         
		            // Log & Raise
		   	      this.setModified("Shippingdate");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.shippingDate = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Freight
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected double freight;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="freight")] 
		public double Freight
		{
		   get
		   {
		      // Load
		      this.loadCheck("Freight");
		      
		      // Get
		      return this.freight;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Freight");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Freight", this.freight, value) != SetAction.NoChange)
		      {
		         // Backup
		         double xVal = this.freight;
		         
		         try
		         {
		            // Set
		            this.freight = value;
		         
		            // Log & Raise
		   	      this.setModified("Freight");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.freight = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Shippedto
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string shippedTo;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="shippedTo")] 
		public string Shippedto
		{
		   get
		   {
		      // Load
		      this.loadCheck("Shippedto");
		      
		      // Get
		      return this.shippedTo;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Shippedto");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Shippedto", this.shippedTo, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.shippedTo;
		         
		         try
		         {
		            // Set
		            this.shippedTo = value;
		         
		            // Log & Raise
		   	      this.setModified("Shippedto");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.shippedTo = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Shippingaddress
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Address shippingAddress;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="shippingAddress")] 
		public Address Shippingaddress
		{
		   get
		   {
		      // Load
		      this.loadCheck("Shippingaddress");
		      
		      // Get
		      return this.shippingAddress;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Shippingaddress");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Shippingaddress", this.shippingAddress, value) != SetAction.NoChange)
		      {
		         // Backup
		         Address xRef = this.shippingAddress;
		         
		         try
		         {
		            // Set REFERENCE
		            this.shippingAddress = value;
		         
		            // Log & Raise
		   	      this.setModified("Shippingaddress");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.shippingAddress = xRef;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Shipper
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Shipper shipper;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="shipper",_ReverseRef="orders")] 
		public Shipper Shipper
		{
		   get
		   {
		      // Load
		      this.loadCheck("Shipper");
		      
		      // Get
		      return this.shipper;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Shipper");
		      
		      // Check Modification Action
		      SetAction action = this.modifyCheck("Shipper", this.shipper, value);
		
		      // Check
		      if (action == SetAction.NoChange) return;
		
		      // Init
		      Shipper newV = (Shipper)value;
		      Shipper oldV = this.shipper;
		         
		      // Act
		      if (action == SetAction.Assign)
		      {
		         // 'newV' is not null --- else it would be a NoChange
		         
		         
		         try
		         {
		            // Insertion of REFERENCE
		            this.shipper = newV;
		            newV.Orders.Add(this);
		            
		            // Log & Raise
			         this.setModified("Shipper");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.shipper = null;
		            newV.Orders.Remove(this);
		                     
		            // Rethrow
		            throw ex;
		         }
		      }
		      else if (action == SetAction.Nullify)
		      {
		         try
		         {
		            // Deletion of REFERENCE
		            this.shipper = null;
		            oldV.Orders.Remove(this);
		            
		            // Log & Raise
			         this.setModified("Shipper");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.shipper = oldV;
		            oldV.Orders.Add(this);
		                    
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
		            oldV.Orders.Remove(this);
		            this.shipper = newV;
		            newV.Orders.Add(this);
		            
		            // Log & Raise
			         this.setModified("Shipper");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            newV.Orders.Remove(this);
		            this.shipper = oldV;
		            oldV.Orders.Add(this);
		                     
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