// File:    Mammal.cs
// Author:  kostas
// Created: Πέμπτη, 1 Αυγούστου 2013 3:48:30 πμ
// Purpose: Definition of Class Mammal

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
	/// Code         : Mammal
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
	/// Bodytemperature
	/// Pregnant
	/// Birthdate
	///
	/// </summary>
	[PersistedClass]
	public abstract partial class Mammal : Reptile
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Pregnant = "Pregnant";
		public const string DEF_Birthdate = "Birthdate";
	
		#endregion
	
		#region Data
	
		//
		// Declarative Data
		//
	
		/// <summary>
		///
		/// Code         : Pregnant
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected bool pregnant;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="pregnant")] 
		public bool Pregnant
		{
		   get
		   {
		      // Load
		      this.loadCheck("Pregnant");
		      
		      // Get
		      return this.pregnant;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Pregnant");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Pregnant", this.pregnant, value) != SetAction.NoChange)
		      {
		         // Backup
		         bool xVal = this.pregnant;
		         
		         try
		         {
		            // Set
		            this.pregnant = value;
		         
		            // Log & Raise
		   	      this.setModified("Pregnant");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.pregnant = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Birthdate
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DateTime birthDate;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="birthDate")] 
		public DateTime Birthdate
		{
		   get
		   {
		      // Load
		      this.loadCheck("Birthdate");
		      
		      // Get
		      return this.birthDate;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Birthdate");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Birthdate", this.birthDate, value) != SetAction.NoChange)
		      {
		         // Backup
		         DateTime xVal = this.birthDate;
		         
		         try
		         {
		            // Set
		            this.birthDate = value;
		         
		            // Log & Raise
		   	      this.setModified("Birthdate");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.birthDate = xVal;
		            
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