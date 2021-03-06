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
	/// ProductCategory type
	/// </summary>
	[PersistedClass]
	public partial class ProductCategory : DataItem
	{
		protected long categoryId;
		/// <summary>
		/// Category ID
		/// </summary>
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName=nameof(categoryId),_IDOrder=1)] 
		public long Categoryid { get => getter<long>(); set => setter(value); }
		
		protected string name;
		/// <summary>
		/// Category name
		/// </summary>
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName=nameof(name))] 
		public string Name { get => getter<string>(); set => setter(value); }

		protected string description;
		/// <summary>
		/// Category description
		/// </summary>
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName=nameof(description))] 
		public string Description { get => getter<string>(); set => setter(value); }

		protected DataItemRefList<Product> products = null;
		/// <summary>
		/// Category products
		/// </summary>
		[PersistedProperty(_DataSourceType=DataSourceType.Field,_DataSourceName=nameof(products),_ReverseRef=nameof(Product.Category))] 
		public DataItemRefList<Product> Products => getter<DataItemRefList<Product>>();
	}
}