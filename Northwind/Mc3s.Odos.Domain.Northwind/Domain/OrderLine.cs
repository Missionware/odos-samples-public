// File:    OrderLine.cs
// Author:  kostas
// Created: Πέμπτη, 1 Αυγούστου 2013 3:48:33 πμ
// Purpose: Definition of Class OrderLine

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
	/// Code         : OrderLine
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Unitprice
	/// Quantity
	/// Discount
	/// Order
	/// Product
	///
	/// </summary>
	[PersistedClass]
	public partial class OrderLine : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Unitprice = "Unitprice";
		public const string DEF_Quantity = "Quantity";
		public const string DEF_Discount = "Discount";
		public const string DEF_Order = "Order";
		public const string DEF_Product = "Product";
	
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
		/// Code         : Unitprice
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected double unitPrice;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="unitPrice")] 
		public double Unitprice
		{
		   get
		   {
		      // Load
		      this.loadCheck("Unitprice");
		      
		      // Get
		      return this.unitPrice;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Unitprice");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Unitprice", this.unitPrice, value) != SetAction.NoChange)
		      {
		         // Backup
		         double xVal = this.unitPrice;
		         
		         try
		         {
		            // Set
		            this.unitPrice = value;
		         
		            // Log & Raise
		   	      this.setModified("Unitprice");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.unitPrice = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Quantity
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected int quantity;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="quantity")] 
		public int Quantity
		{
		   get
		   {
		      // Load
		      this.loadCheck("Quantity");
		      
		      // Get
		      return this.quantity;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Quantity");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Quantity", this.quantity, value) != SetAction.NoChange)
		      {
		         // Backup
		         int xVal = this.quantity;
		         
		         try
		         {
		            // Set
		            this.quantity = value;
		         
		            // Log & Raise
		   	      this.setModified("Quantity");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.quantity = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Discount
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected double discount;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="discount")] 
		public double Discount
		{
		   get
		   {
		      // Load
		      this.loadCheck("Discount");
		      
		      // Get
		      return this.discount;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Discount");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Discount", this.discount, value) != SetAction.NoChange)
		      {
		         // Backup
		         double xVal = this.discount;
		         
		         try
		         {
		            // Set
		            this.discount = value;
		         
		            // Log & Raise
		   	      this.setModified("Discount");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.discount = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Order
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Orderx order;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="order",_ReverseRef="orderLines")] 
		public Orderx Order
		{
		   get
		   {
		      // Load
		      this.loadCheck("Order");
		      
		      // Get
		      return this.order;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Order");
		      
		      // Check Modification Action
		      SetAction action = this.modifyCheck("Order", this.order, value);
		
		      // Check
		      if (action == SetAction.NoChange) return;
		
		      // Init
		      Orderx newV = (Orderx)value;
		      Orderx oldV = this.order;
		         
		      // Act
		      if (action == SetAction.Assign)
		      {
		         // 'newV' is not null --- else it would be a NoChange
		         
		         
		         try
		         {
		            // Insertion of REFERENCE
		            this.order = newV;
		            newV.Orderlines.Add(this);
		            
		            // Log & Raise
			         this.setModified("Order");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.order = null;
		            newV.Orderlines.Remove(this);
		                     
		            // Rethrow
		            throw ex;
		         }
		      }
		      else if (action == SetAction.Nullify)
		      {
		         try
		         {
		            // Deletion of REFERENCE
		            this.order = null;
		            oldV.Orderlines.Remove(this);
		            
		            // Log & Raise
			         this.setModified("Order");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.order = oldV;
		            oldV.Orderlines.Add(this);
		                    
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
		            oldV.Orderlines.Remove(this);
		            this.order = newV;
		            newV.Orderlines.Add(this);
		            
		            // Log & Raise
			         this.setModified("Order");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            newV.Orderlines.Remove(this);
		            this.order = oldV;
		            oldV.Orderlines.Add(this);
		                     
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Product
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Product product;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="product",_ReverseRef="orderLines")] 
		public Product Product
		{
		   get
		   {
		      // Load
		      this.loadCheck("Product");
		      
		      // Get
		      return this.product;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Product");
		      
		      // Check Modification Action
		      SetAction action = this.modifyCheck("Product", product, value);
		
		      // Check
		      if (action == SetAction.NoChange) return;
		      
		      // Init
		      Product newV = (Product)value;
		      Product oldV = this.product;
		         
		      // Act
		      if (action == SetAction.Assign)
		      {
		         // 'newV' is not null --- else it would be a NoChange
		         
		         
		         try
		         {
		            // Insertion of REFERENCE
		            this.product = newV;
		            newV.Orderlines.Add(this);
		            
		            // Log & Raise
			         this.setModified("Product");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.product = null;
		            newV.Orderlines.Remove(this);
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		      else if (action == SetAction.Nullify)
		      {
		         try
		         {
		            // Deletion of REFERENCE
		            this.product = null;
		            oldV.Orderlines.Remove(this);
		            
		            // Log & Raise
			         this.setModified("Product");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.product = oldV;
		            oldV.Orderlines.Add(this);
		            
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
		            oldV.Orderlines.Remove(this);
		            this.product = newV;
		            newV.Orderlines.Add(this);
		            
		            // Log & Raise
			         this.setModified("Product");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            newV.Orderlines.Remove(this);
		            this.product = oldV;
		            oldV.Orderlines.Add(this);
		            
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