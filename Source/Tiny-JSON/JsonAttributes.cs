﻿/*
	This file is part of Tiny-JSON /L
		© 2023 LisiasT : http://lisias.net <support@lisias.net>
		© 2015-2018 Robert Gering : https://github.com/gering

	Tiny-JSON /L is licensed as follows:
		* MIT (Expat) : https://opensource.org/license/mit/

	Tiny-JSON /L is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

*/
using System;
namespace Tiny {

	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
	public class JsonPropertyAttribute : Attribute {
		public string Name { get; private set; }

		public JsonPropertyAttribute(string name) {
			Name = name;
		}
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
	public class MatchSnakeCaseAttribute : Attribute {
	}
}
