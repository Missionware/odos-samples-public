// File:    AnotherEntity.cs
// Author:  kostas
// Created: Πέμπτη, 1 Αυγούστου 2013 3:48:29 πμ
// Purpose: Definition of Class AnotherEntity

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
	/// Code         : AnotherEntity
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Id
	/// Output
	/// Input
	///
	/// </summary>
	[PersistedClass]
	public partial class AnotherEntity : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Id = "Id";
		public const string DEF_Output = "Output";
		public const string DEF_Input = "Input";
	
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
		/// Code         : Output
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string output;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="output")] 
		public string Output
		{
		   get
		   {
		      // Load
		      this.loadCheck("Output");
		      
		      // Get
		      return this.output;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Output");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Output", this.output, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.output;
		         
		         try
		         {
		            // Set
		            this.output = value;
		         
		            // Log & Raise
		   	      this.setModified("Output");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.output = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Input
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string input;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="input")] 
		public string Input
		{
		   get
		   {
		      // Load
		      this.loadCheck("Input");
		      
		      // Get
		      return this.input;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Input");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Input", this.input, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.input;
		         
		         try
		         {
		            // Set
		            this.input = value;
		         
		            // Log & Raise
		   	      this.setModified("Input");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.input = xVal;
		            
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