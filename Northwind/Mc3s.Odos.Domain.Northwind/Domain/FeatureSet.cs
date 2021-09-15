// File:    FeatureSet.cs
// Author:  kostas
// Created: Παρασκευή, 2 Αυγούστου 2013 2:40:09 πμ
// Purpose: Definition of Enum FeatureSet

using System;

namespace Mc3s.Odos.Domain.Northwind
{
	public enum FeatureSet
	{
	   hasThis = 1,
	   hasThat = 2,
	   hasMore = 4,
	   hasAll = 8
	}
}