// File:    Region.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:18:30 πμ
// Purpose: Definition of Class Region

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
	/// Code         : Region
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Description
	/// Territories
	///
	/// </summary>
	[PersistedClass]
	public partial class Region : Entity
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Description = "Description";
		public const string DEF_Territories = "Territories";
	
		#endregion
	
		#region Data
	
		//
		// Declarative Data
		//
	
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
		/// Code         : Territories
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DataItemRefList<Territory> territories = null;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="territories",_ReverseRef="region")] 
		public DataItemRefList<Territory> Territories
		{
		   get
		   {
		      // Load
		      loadCheck("Territories");
		      
		      // Get
		      return territories;
		   }
		}
	
		#endregion
	
		#region Creation - Destruction
	
		#endregion
	}
}