// File:    UserComponent.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:18:30 πμ
// Purpose: Definition of Class UserComponent

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
	/// Code         : UserComponent
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Property1
	/// Property2
	/// Othercomponent
	///
	/// </summary>
	[PersistedClass]
	public partial class UserComponent : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Property1 = "Property1";
		public const string DEF_Property2 = "Property2";
		public const string DEF_Othercomponent = "Othercomponent";
	
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
		/// Code         : Property1
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string property1;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="property1")] 
		public string Property1
		{
		   get
		   {
		      // Load
		      this.loadCheck("Property1");
		      
		      // Get
		      return this.property1;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Property1");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Property1", this.property1, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.property1;
		         
		         try
		         {
		            // Set
		            this.property1 = value;
		         
		            // Log & Raise
		   	      this.setModified("Property1");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.property1 = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Property2
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string property2;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="property2")] 
		public string Property2
		{
		   get
		   {
		      // Load
		      this.loadCheck("Property2");
		      
		      // Get
		      return this.property2;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Property2");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Property2", this.property2, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.property2;
		         
		         try
		         {
		            // Set
		            this.property2 = value;
		         
		            // Log & Raise
		   	      this.setModified("Property2");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.property2 = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Othercomponent
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected UserComponent2 otherComponent;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="otherComponent")] 
		public UserComponent2 Othercomponent
		{
		   get
		   {
		      // Load
		      this.loadCheck("Othercomponent");
		      
		      // Get
		      return this.otherComponent;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Othercomponent");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Othercomponent", this.otherComponent, value) != SetAction.NoChange)
		      {
		         // Backup
		         UserComponent2 xRef = this.otherComponent;
		         
		         try
		         {
		            // Set REFERENCE
		            this.otherComponent = value;
		         
		            // Log & Raise
		   	      this.setModified("Othercomponent");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.otherComponent = xRef;
		            
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