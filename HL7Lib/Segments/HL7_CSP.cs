/***************************************************************
* Copyright (C) 2011 Jeremy Reagan, All Rights Reserved.
* I may be reached via email at: jeremy.reagan@live.com
* 
* This program is free software; you can redistribute it and/or
* modify it under the terms of the GNU General Public License
* as published by the Free Software Foundation; under version 2
* of the License.
* 
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
****************************************************************/

using System;
using System.Collections.Generic;
using HL7Lib.Base;

namespace HL7Lib.Segments
{
	/// <summary>
/// CSP Class: Constructs an HL7 CSP Segment Object
/// </summary>
public class CSP
	{
		public string Name {get; set;}
		public string Description {get; set;}
		public List<Field> Fields {get; set;}

		public CSP()
		{
			Name = "CSP";
			Description = "Clinical Study Phase";
			List<Field> fs = new List<Field>();
			fs.Add(Field.SegName());
			fs.Add(CSP1());
			fs.Add(CSP2());
			fs.Add(CSP3());
			fs.Add(CSP4());
			Fields = fs;
		}
		private Field CSP1()
		{
			Field f = new Field("Study Phase Identifier");
			List<Component> c = new List<Component>();
			c.Add(new Component("Identifier", "CSP-1.1"));
			c.Add(new Component("", "CSP-1.2"));
			c.Add(new Component("Name of Coding System", "CSP-1.3"));
			c.Add(new Component("Alternate Identifier", "CSP-1.4"));
			c.Add(new Component("Alternate Text", "CSP-1.5"));
			c.Add(new Component("Name of Alternate Coding System", "CSP-1.6"));
			f.Components = c;
			return f;
		}
		private Field CSP2()
		{
			Field f = new Field("Date/time Study Phase Began");
			List<Component> c = new List<Component>();
			c.Add(new Component("Time", "CSP-2.1"));
			c.Add(new Component("Degree of Precision", "CSP-2.2"));
			f.Components = c;
			return f;
		}
		private Field CSP3()
		{
			Field f = new Field("Date/time Study Phase Ended");
			List<Component> c = new List<Component>();
			c.Add(new Component("Time", "CSP-3.1"));
			c.Add(new Component("Degree of Precision", "CSP-3.2"));
			f.Components = c;
			return f;
		}
		private Field CSP4()
		{
			Field f = new Field("Study Phase Evaluability");
			List<Component> c = new List<Component>();
			c.Add(new Component("Identifier", "CSP-4.1"));
			c.Add(new Component("", "CSP-4.2"));
			c.Add(new Component("Name of Coding System", "CSP-4.3"));
			c.Add(new Component("Alternate Identifier", "CSP-4.4"));
			c.Add(new Component("Alternate Text", "CSP-4.5"));
			c.Add(new Component("Name of Alternate Coding System", "CSP-4.6"));
			f.Components = c;
			return f;
		}
	}
}
