// File:    ProductCategory.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:18:31 πμ
// Purpose: Definition of Class ProductCategory

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
	/// Code         : ProductCategory
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Categoryid
	/// Name
	/// Description
	/// Products
	///
	/// </summary>
	[PersistedClass]
	public partial class ProductCategory : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Categoryid = "Categoryid";
		public const string DEF_Name = "Name";
		public const string DEF_Description = "Description";
		public const string DEF_Products = "Products";
	
		#endregion
	
		#region Data
	
		//
		// Declarative Data
		//
	
		/// <summary>
		///
		/// Code         : Categoryid
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected long categoryId;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="categoryId",_IDOrder=1)] 
		public long Categoryid
		{
		   get
		   {
		      // Load
		      this.loadCheck("Categoryid");
		      
		      // Get
		      return this.categoryId;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Categoryid");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Categoryid", this.categoryId, value) != SetAction.NoChange)
		      {
		         // Backup
		         long xVal = this.categoryId;
		         
		         try
		         {
		            // Set
		            this.categoryId = value;
		         
		            // Log & Raise
		   	      this.setModified("Categoryid");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.categoryId = xVal;
		            
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
		/// Code         : Description
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string description;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="description")] 
		public string Description
		{
		   get
		   {
		      // Load
		      this.loadCheck("Description");
		      
		      // Get
		      return this.description;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Description");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Description", this.description, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.description;
		         
		         try
		         {
		            // Set
		            this.description = value;
		         
		            // Log & Raise
		   	      this.setModified("Description");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.description = xVal;
		            
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
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="products",_ReverseRef="category")] 
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
	
		#endregion
	
		#region Creation - Destruction
	
		#endregion
	}
}