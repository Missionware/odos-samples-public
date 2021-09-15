// File:    Reptile.cs
// Author:  kostas
// Created: Πέμπτη, 1 Αυγούστου 2013 3:59:18 πμ
// Purpose: Definition of Class Reptile

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
	/// Code         : Reptile
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
	///
	/// </summary>
	[PersistedClass]
	public abstract partial class Reptile : Animal
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Bodytemperature = "Bodytemperature";
	
		#endregion
	
		#region Data
	
		//
		// Declarative Data
		//
	
		/// <summary>
		///
		/// Code         : Bodytemperature
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected double bodyTemperature;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="bodyTemperature")] 
		public double Bodytemperature
		{
		   get
		   {
		      // Load
		      this.loadCheck("Bodytemperature");
		      
		      // Get
		      return this.bodyTemperature;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Bodytemperature");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Bodytemperature", this.bodyTemperature, value) != SetAction.NoChange)
		      {
		         // Backup
		         double xVal = this.bodyTemperature;
		         
		         try
		         {
		            // Set
		            this.bodyTemperature = value;
		         
		            // Log & Raise
		   	      this.setModified("Bodytemperature");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.bodyTemperature = xVal;
		            
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