// File:    Cat.cs
// Author:  kostas
// Created: Πέμπτη, 1 Αυγούστου 2013 3:48:33 πμ
// Purpose: Definition of Class Cat

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
	/// Code         : Cat
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
	public partial class Cat : Mammal
	{
		#region Property Names
	
		// Declarations
		// ------------
	
		#endregion
	
		#region Data
	
		//
		// Declarative Data
		//
	
	
	
		#endregion
	
		#region Creation - Destruction
		
		#endregion
	}
}