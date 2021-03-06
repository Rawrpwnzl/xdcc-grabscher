// 
//  Files.cs
// 
//  Author:
//       Lars Formella <ich@larsformella.de>
// 
//  Copyright (c) 2012 Lars Formella
// 
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
//  

using System;
using System.Collections.Generic;
using System.Linq;

namespace XG.Core
{
	[Serializable]
	public class Files : AObjects
	{
		public new IEnumerable<File> All
		{
			get { return base.All.Cast<File>(); }
		}

		public File File(string tmpPath)
		{
			try
			{
				return All.First(file => file.TmpPath == tmpPath);
			}
			catch (Exception)
			{
				return null;
			}
		}

		public void Add(File aFile)
		{
			base.Add(aFile);
		}

		public void Add(string aName, Int64 aSize)
		{
			var tFile = new File(aName, aSize);
			if (File(tFile.TmpPath) == null)
			{
				Add(tFile);
			}
		}

		public void Remove(File aFile)
		{
			base.Remove(aFile);
		}
	}
}
