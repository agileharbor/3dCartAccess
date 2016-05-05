﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ThreeDCartAccess.V1.Models.Product
{
	[ Serializable() ]
	[ XmlRoot( ElementName = "GetProductDetailsResponse" ) ]
	public class ThreeDCartProducts
	{
		[ XmlElement( ElementName = "Product" ) ]
		public List< ThreeDCartProduct > Products{ get; set; }
	}
}