// File:    Territory.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:18:30 πμ
// Purpose: Definition of Class Territory

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
	/// Code         : Territory
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Description
	/// Region
	///
	/// </summary>
	[PersistedClass]
	public partial class Territory : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Description = "Description";
		public const string DEF_Region = "Region";
	
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
		/// Code         : Region
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Region region;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="region",_ReverseRef="territories")] 
		public Region Region
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
		      SetAction action = this.modifyCheck("Region", region, value);
		
		      // Check
		      if (action == SetAction.NoChange) return;
		      
		      // Init
		      Region newV = (Region)value;
		      Region oldV = this.region;
		         
		      // Act
		      if (action == SetAction.Assign)
		      {
		         // 'newV' is not null --- else it would be a NoChange
		         
		         
		         try
		         {
		            // Insertion of REFERENCE
		            this.region = newV;
		            newV.Territories.Add(this);
		            
		            // Log & Raise
			         this.setModified("Region");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.region = null;
		            newV.Territories.Remove(this);
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		      else if (action == SetAction.Nullify)
		      {
		         try
		         {
		            // Deletion of REFERENCE
		            this.region = null;
		            oldV.Territories.Remove(this);
		            
		            // Log & Raise
			         this.setModified("Region");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.region = oldV;
		            oldV.Territories.Add(this);
		            
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
		            oldV.Territories.Remove(this);
		            this.region = newV;
		            newV.Territories.Add(this);
		            
		            // Log & Raise
			         this.setModified("Region");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            newV.Territories.Remove(this);
		            this.region = oldV;
		            oldV.Territories.Add(this);
		            
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