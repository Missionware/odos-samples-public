// File:    Product.cs
// Author:  kostas
// Created: Πέμπτη, 1 Αυγούστου 2013 3:48:33 πμ
// Purpose: Definition of Class Product

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
	/// Code         : Product
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Productid
	/// Unitprice
	/// Other
	/// Orderlines
	/// Category
	/// Name
	/// Unitsinstock
	/// Unitsonorder
	/// Reorderlevel
	/// Discontinued
	/// Shippingweight
	/// Quantityperunit
	/// Supplier
	///
	/// </summary>
	[PersistedClass]
	public partial class Product : Thing
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Orderlines = "Orderlines";
		public const string DEF_Category = "Category";
		public const string DEF_Name = "Name";
		public const string DEF_Unitsinstock = "Unitsinstock";
		public const string DEF_Unitsonorder = "Unitsonorder";
		public const string DEF_Reorderlevel = "Reorderlevel";
		public const string DEF_Discontinued = "Discontinued";
		public const string DEF_Shippingweight = "Shippingweight";
		public const string DEF_Quantityperunit = "Quantityperunit";
		public const string DEF_Supplier = "Supplier";
	
		#endregion
	
		#region Data
	
		//
		// Declarative Data
		//
	
		/// <summary>
		///
		/// Code         : Orderlines
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DataItemRefList<OrderLine> orderLines = null;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="orderLines",_ReverseRef="product")] 
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
		/// Code         : Category
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected ProductCategory category;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="category",_ReverseRef="products")] 
		public ProductCategory Category
		{
		   get
		   {
		      // Load
		      this.loadCheck("Category");
		      
		      // Get
		      return this.category;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Category");
		      
		      // Check Modification Action
		      SetAction action = this.modifyCheck("Category", this.category, value);
		
		      // Check
		      if (action == SetAction.NoChange) return;
		
		      // Init
		      ProductCategory newV = (ProductCategory)value;
		      ProductCategory oldV = this.category;
		         
		      // Act
		      if (action == SetAction.Assign)
		      {
		         // 'newV' is not null --- else it would be a NoChange
		         
		         
		         try
		         {
		            // Insertion of REFERENCE
		            this.category = newV;
		            newV.Products.Add(this);
		            
		            // Log & Raise
			         this.setModified("Category");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.category = null;
		            newV.Products.Remove(this);
		                     
		            // Rethrow
		            throw ex;
		         }
		      }
		      else if (action == SetAction.Nullify)
		      {
		         try
		         {
		            // Deletion of REFERENCE
		            this.category = null;
		            oldV.Products.Remove(this);
		            
		            // Log & Raise
			         this.setModified("Category");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.category = oldV;
		            oldV.Products.Add(this);
		                    
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
		            oldV.Products.Remove(this);
		            this.category = newV;
		            newV.Products.Add(this);
		            
		            // Log & Raise
			         this.setModified("Category");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            newV.Products.Remove(this);
		            this.category = oldV;
		            oldV.Products.Add(this);
		                     
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
		protected string name;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="name")] 
		public string Name
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
		         string xVal = this.name;
		         
		         try
		         {
		            // Set
		            this.name = value;
		         
		            // Log & Raise
		   	      this.setModified("Name");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.name = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Unitsinstock
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected int unitsInStock;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="unitsInStock")] 
		public int Unitsinstock
		{
		   get
		   {
		      // Load
		      this.loadCheck("Unitsinstock");
		      
		      // Get
		      return this.unitsInStock;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Unitsinstock");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Unitsinstock", this.unitsInStock, value) != SetAction.NoChange)
		      {
		         // Backup
		         int xVal = this.unitsInStock;
		         
		         try
		         {
		            // Set
		            this.unitsInStock = value;
		         
		            // Log & Raise
		   	      this.setModified("Unitsinstock");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.unitsInStock = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Unitsonorder
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected int unitsOnOrder;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="unitsOnOrder")] 
		public int Unitsonorder
		{
		   get
		   {
		      // Load
		      this.loadCheck("Unitsonorder");
		      
		      // Get
		      return this.unitsOnOrder;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Unitsonorder");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Unitsonorder", this.unitsOnOrder, value) != SetAction.NoChange)
		      {
		         // Backup
		         int xVal = this.unitsOnOrder;
		         
		         try
		         {
		            // Set
		            this.unitsOnOrder = value;
		         
		            // Log & Raise
		   	      this.setModified("Unitsonorder");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.unitsOnOrder = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Reorderlevel
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected int reorderLevel;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="reorderLevel")] 
		public int Reorderlevel
		{
		   get
		   {
		      // Load
		      this.loadCheck("Reorderlevel");
		      
		      // Get
		      return this.reorderLevel;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Reorderlevel");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Reorderlevel", this.reorderLevel, value) != SetAction.NoChange)
		      {
		         // Backup
		         int xVal = this.reorderLevel;
		         
		         try
		         {
		            // Set
		            this.reorderLevel = value;
		         
		            // Log & Raise
		   	      this.setModified("Reorderlevel");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.reorderLevel = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Discontinued
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected bool discontinued;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="discontinued")] 
		public bool Discontinued
		{
		   get
		   {
		      // Load
		      this.loadCheck("Discontinued");
		      
		      // Get
		      return this.discontinued;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Discontinued");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Discontinued", this.discontinued, value) != SetAction.NoChange)
		      {
		         // Backup
		         bool xVal = this.discontinued;
		         
		         try
		         {
		            // Set
		            this.discontinued = value;
		         
		            // Log & Raise
		   	      this.setModified("Discontinued");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.discontinued = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Shippingweight
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected double shippingWeight;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="shippingWeight")] 
		public double Shippingweight
		{
		   get
		   {
		      // Load
		      this.loadCheck("Shippingweight");
		      
		      // Get
		      return this.shippingWeight;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Shippingweight");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Shippingweight", this.shippingWeight, value) != SetAction.NoChange)
		      {
		         // Backup
		         double xVal = this.shippingWeight;
		         
		         try
		         {
		            // Set
		            this.shippingWeight = value;
		         
		            // Log & Raise
		   	      this.setModified("Shippingweight");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.shippingWeight = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Quantityperunit
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string quantityPerUnit;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="quantityPerUnit")] 
		public string Quantityperunit
		{
		   get
		   {
		      // Load
		      this.loadCheck("Quantityperunit");
		      
		      // Get
		      return this.quantityPerUnit;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Quantityperunit");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Quantityperunit", this.quantityPerUnit, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.quantityPerUnit;
		         
		         try
		         {
		            // Set
		            this.quantityPerUnit = value;
		         
		            // Log & Raise
		   	      this.setModified("Quantityperunit");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.quantityPerUnit = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Supplier
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Supplier supplier;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="supplier",_ReverseRef="products")] 
		public Supplier Supplier
		{
		   get
		   {
		      // Load
		      this.loadCheck("Supplier");
		      
		      // Get
		      return this.supplier;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Supplier");
		      
		      // Check Modification Action
		      SetAction action = this.modifyCheck("Supplier", this.supplier, value);
		
		      // Check
		      if (action == SetAction.NoChange) return;
		
		      // Init
		      Supplier newV = (Supplier)value;
		      Supplier oldV = this.supplier;
		         
		      // Act
		      if (action == SetAction.Assign)
		      {
		         // 'newV' is not null --- else it would be a NoChange
		         
		         
		         try
		         {
		            // Insertion of REFERENCE
		            this.supplier = newV;
		            newV.Products.Add(this);
		            
		            // Log & Raise
			         this.setModified("Supplier");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.supplier = null;
		            newV.Products.Remove(this);
		                     
		            // Rethrow
		            throw ex;
		         }
		      }
		      else if (action == SetAction.Nullify)
		      {
		         try
		         {
		            // Deletion of REFERENCE
		            this.supplier = null;
		            oldV.Products.Remove(this);
		            
		            // Log & Raise
			         this.setModified("Supplier");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.supplier = oldV;
		            oldV.Products.Add(this);
		                    
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
		            oldV.Products.Remove(this);
		            this.supplier = newV;
		            newV.Products.Add(this);
		            
		            // Log & Raise
			         this.setModified("Supplier");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            newV.Products.Remove(this);
		            this.supplier = oldV;
		            oldV.Products.Add(this);
		                     
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