// File:    Employee.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:18:31 πμ
// Purpose: Definition of Class Employee

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
	/// Code         : Employee
	/// Label        : 
	/// Description  : 
	///
	/// Available Properties
	/// --------------------
	/// Employeeid
	/// Firstname
	/// Lastname
	/// Title
	/// Titleofcourtesy
	/// Birthdate
	/// Hiredate
	/// Extension
	/// Notes
	/// Address
	/// Subordinates
	/// Superior
	/// Territories
	/// Orders
	///
	/// </summary>
	[PersistedClass]
	public partial class Employee : DataItem
	{
		#region Property Names
	
		// Declarations
		// ------------
		public const string DEF_Employeeid = "Employeeid";
		public const string DEF_Firstname = "Firstname";
		public const string DEF_Lastname = "Lastname";
		public const string DEF_Title = "Title";
		public const string DEF_Titleofcourtesy = "Titleofcourtesy";
		public const string DEF_Birthdate = "Birthdate";
		public const string DEF_Hiredate = "Hiredate";
		public const string DEF_Extension = "Extension";
		public const string DEF_Notes = "Notes";
		public const string DEF_Address = "Address";
		public const string DEF_Subordinates = "Subordinates";
		public const string DEF_Superior = "Superior";
		public const string DEF_Territories = "Territories";
		public const string DEF_Orders = "Orders";
	
		#endregion
	
		#region Data
	
		//
		// Declarative Data
		//
	
		/// <summary>
		///
		/// Code         : Employeeid
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected long employeeId;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="employeeId",_IDOrder=1)] 
		public long Employeeid
		{
		   get
		   {
		      // Load
		      this.loadCheck("Employeeid");
		      
		      // Get
		      return this.employeeId;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Employeeid");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Employeeid", this.employeeId, value) != SetAction.NoChange)
		      {
		         // Backup
		         long xVal = this.employeeId;
		         
		         try
		         {
		            // Set
		            this.employeeId = value;
		         
		            // Log & Raise
		   	      this.setModified("Employeeid");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.employeeId = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Firstname
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string firstName;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="firstName")] 
		public string Firstname
		{
		   get
		   {
		      // Load
		      this.loadCheck("Firstname");
		      
		      // Get
		      return this.firstName;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Firstname");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Firstname", this.firstName, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.firstName;
		         
		         try
		         {
		            // Set
		            this.firstName = value;
		         
		            // Log & Raise
		   	      this.setModified("Firstname");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.firstName = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Lastname
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string lastName;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="lastName")] 
		public string Lastname
		{
		   get
		   {
		      // Load
		      this.loadCheck("Lastname");
		      
		      // Get
		      return this.lastName;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Lastname");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Lastname", this.lastName, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.lastName;
		         
		         try
		         {
		            // Set
		            this.lastName = value;
		         
		            // Log & Raise
		   	      this.setModified("Lastname");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.lastName = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Title
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string title;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="title")] 
		public string Title
		{
		   get
		   {
		      // Load
		      this.loadCheck("Title");
		      
		      // Get
		      return this.title;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Title");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Title", this.title, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.title;
		         
		         try
		         {
		            // Set
		            this.title = value;
		         
		            // Log & Raise
		   	      this.setModified("Title");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.title = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Titleofcourtesy
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string titleOfCourtesy;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="titleOfCourtesy")] 
		public string Titleofcourtesy
		{
		   get
		   {
		      // Load
		      this.loadCheck("Titleofcourtesy");
		      
		      // Get
		      return this.titleOfCourtesy;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Titleofcourtesy");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Titleofcourtesy", this.titleOfCourtesy, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.titleOfCourtesy;
		         
		         try
		         {
		            // Set
		            this.titleOfCourtesy = value;
		         
		            // Log & Raise
		   	      this.setModified("Titleofcourtesy");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.titleOfCourtesy = xVal;
		            
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
		/// <summary>
		///
		/// Code         : Hiredate
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DateTime hireDate;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="hireDate")] 
		public DateTime Hiredate
		{
		   get
		   {
		      // Load
		      this.loadCheck("Hiredate");
		      
		      // Get
		      return this.hireDate;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Hiredate");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Hiredate", this.hireDate, value) != SetAction.NoChange)
		      {
		         // Backup
		         DateTime xVal = this.hireDate;
		         
		         try
		         {
		            // Set
		            this.hireDate = value;
		         
		            // Log & Raise
		   	      this.setModified("Hiredate");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.hireDate = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Extension
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string extension;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="extension")] 
		public string Extension
		{
		   get
		   {
		      // Load
		      this.loadCheck("Extension");
		      
		      // Get
		      return this.extension;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Extension");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Extension", this.extension, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.extension;
		         
		         try
		         {
		            // Set
		            this.extension = value;
		         
		            // Log & Raise
		   	      this.setModified("Extension");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.extension = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Notes
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected string notes;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="notes")] 
		public string Notes
		{
		   get
		   {
		      // Load
		      this.loadCheck("Notes");
		      
		      // Get
		      return this.notes;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Notes");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Notes", this.notes, value) != SetAction.NoChange)
		      {
		         // Backup
		         string xVal = this.notes;
		         
		         try
		         {
		            // Set
		            this.notes = value;
		         
		            // Log & Raise
		   	      this.setModified("Notes");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.notes = xVal;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Address
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Address address;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="address")] 
		public Address Address
		{
		   get
		   {
		      // Load
		      this.loadCheck("Address");
		      
		      // Get
		      return this.address;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Address");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Address", this.address, value) != SetAction.NoChange)
		      {
		         // Backup
		         Address xRef = this.address;
		         
		         try
		         {
		            // Set REFERENCE
		            this.address = value;
		         
		            // Log & Raise
		   	      this.setModified("Address");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.address = xRef;
		            
		            // Rethrow
		            throw ex;
		         }
		      }
		   }
		}
		/// <summary>
		///
		/// Code         : Subordinates
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DataItemRefList<Employee> subordinates = null;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="subordinates")] 
		public DataItemRefList<Employee> Subordinates
		{
		   get
		   {
		      // Load
		      loadCheck("Subordinates");
		      
		      // Get
		      return subordinates;
		   }
		}
		/// <summary>
		///
		/// Code         : Superior
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected Employee superior;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="superior")] 
		public Employee Superior
		{
		   get
		   {
		      // Load
		      this.loadCheck("Superior");
		      
		      // Get
		      return this.superior;
		   }
		   set
		   {
		      // Load
		      this.loadCheck("Superior");
		      
		      // Check Modification Action
		      if (this.modifyCheck("Superior", this.superior, value) != SetAction.NoChange)
		      {
		         // Backup
		         Employee xRef = this.superior;
		         
		         try
		         {
		            // Set REFERENCE
		            this.superior = value;
		         
		            // Log & Raise
		   	      this.setModified("Superior");
		         }
		         catch (Exception ex)
		         {
		            // Restore
		            this.superior = xRef;
		            
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
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="territories")] 
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
		/// <summary>
		///
		/// Code         : Orders
		/// Label        : 
		/// Description  : 
		///
		///
		/// </summary>
		protected DataItemRefList<Orderx> orders = null;
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName="orders",_ReverseRef="employee")] 
		public DataItemRefList<Orderx> Orders
		{
		   get
		   {
		      // Load
		      loadCheck("Orders");
		      
		      // Get
		      return orders;
		   }
		}
	
		#endregion
	
		#region Creation - Destruction
		
		#endregion
	}
}