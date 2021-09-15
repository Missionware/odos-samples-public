// File:    Thing.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:40:08 πμ
// Purpose: Definition of Class Thing

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
	/// Code         : Thing
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Productid
	/// Unitprice
	/// Other
	///
	/// </summary>
	[PersistedClass]
	public partial class Thing : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Productid = "Productid";
		public const string DEF_Unitprice = "Unitprice";
		public const string DEF_Other = "Other";
	
		#endregion
	
		#region Data
	
		//
		// Declarative Data
		//
	
		/// <summary>
		///
		/// Code         : Productid
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected long productId;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="productId",_IDOrder=1)] 
		public long Productid
		{
		   get
		   {
		      // Load
		      this.loadCheck("Productid");
		      
		      // Get
		      return this.productId;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Productid");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Productid", this.productId, value) != SetAction.NoChange)
		      {
		         // Backup
		         long xVal = this.productId;
		         
		         try
		         {
		            // Set
		            this.productId = value;
		         
		            // Log & Raise
		   	      this.setModified("Productid");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.productId = xVal;
		            
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
		/// Code         : Other
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected double other;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="other")] 
		public double Other
		{
		   get
		   {
		      // Load
		      this.loadCheck("Other");
		      
		      // Get
		      return this.other;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Other");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Other", this.other, value) != SetAction.NoChange)
		      {
		         // Backup
		         double xVal = this.other;
		         
		         try
		         {
		            // Set
		            this.other = value;
		         
		            // Log & Raise
		   	      this.setModified("Other");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.other = xVal;
		            
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