// File:    Animal.cs
// Author:  kostas
// Created: Πέμπτη, 1 Αυγούστου 2013 3:48:27 πμ
// Purpose: Definition of Class Animal

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
	/// Code         : Animal
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Description
	/// Bodyweight
	/// Serialnumber
	/// Children
	/// Mother
	/// Father
	///
	/// </summary>
	[PersistedClass]
	public abstract partial class Animal : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Description = "Description";
		public const string DEF_Bodyweight = "Bodyweight";
		public const string DEF_Serialnumber = "Serialnumber";
		public const string DEF_Children = "Children";
		public const string DEF_Mother = "Mother";
		public const string DEF_Father = "Father";
	
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
		/// Code         : Bodyweight
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected double bodyWeight;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="bodyWeight")] 
		public double Bodyweight
		{
		   get
		   {
		      // Load
		      this.loadCheck("Bodyweight");
		      
		      // Get
		      return this.bodyWeight;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Bodyweight");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Bodyweight", this.bodyWeight, value) != SetAction.NoChange)
		      {
		         // Backup
		         double xVal = this.bodyWeight;
		         
		         try
		         {
		            // Set
		            this.bodyWeight = value;
		         
		            // Log & Raise
		   	      this.setModified("Bodyweight");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.bodyWeight = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Serialnumber
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string serialNumber;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="serialNumber")] 
		public string Serialnumber
		{
		   get
		   {
		      // Load
		      this.loadCheck("Serialnumber");
		      
		      // Get
		      return this.serialNumber;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Serialnumber");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Serialnumber", this.serialNumber, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.serialNumber;
		         
		         try
		         {
		            // Set
		            this.serialNumber = value;
		         
		            // Log & Raise
		   	      this.setModified("Serialnumber");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.serialNumber = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Children
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DataItemRefList<Animal> children = null;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="children")] 
		public DataItemRefList<Animal> Children
		{
		   get
		   {
		      // Load
		      loadCheck("Children");
		      
		      // Get
		      return children;
		   }
		}
		/// <summary>
		///
		/// Code         : Mother
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Animal mother;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="mother")] 
		public Animal Mother
		{
		   get
		   {
		      // Load
		      this.loadCheck("Mother");
		      
		      // Get
		      return this.mother;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Mother");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Mother", this.mother, value) != SetAction.NoChange)
		      {
		         // Backup
		         Animal xRef = this.mother;
		         
		         try
		         {
		            // Set REFERENCE
		            this.mother = value;
		         
		            // Log & Raise
		   	      this.setModified("Mother");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.mother = xRef;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Father
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Animal father;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="father")] 
		public Animal Father
		{
		   get
		   {
		      // Load
		      this.loadCheck("Father");
		      
		      // Get
		      return this.father;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Father");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Father", this.father, value) != SetAction.NoChange)
		      {
		         // Backup
		         Animal xRef = this.father;
		         
		         try
		         {
		            // Set REFERENCE
		            this.father = value;
		         
		            // Log & Raise
		   	      this.setModified("Father");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.father = xRef;
		            
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