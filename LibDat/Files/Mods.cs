﻿using System;
using System.IO;

namespace LibDat.Files
{
	public class Mods : BaseDat
	{
		[StringIndex]
		public int Id { get; set; }
		public int Unknown0 { get; set; }
		// Generalized mod group
		//		group 45 = increased attack speed
		//		group 80 = local increased attack speed
		//public int Group { get; set; } // Removed as of latest patch
		public int Level { get; set; }
		public int Stat1Min { get; set; }
		public int Stat1Max { get; set; }
		public int Stat2Min { get; set; }
		public int Stat2Max { get; set; }
		public int Stat3Min { get; set; }
		public int Stat3Max { get; set; }
		public int Stat4Min { get; set; }
		public int Stat4Max { get; set; }
		public Int64 Stat1Group { get; set; }
		public Int64 Stat2Group { get; set; }
		public Int64 Stat3Group { get; set; }
		public Int64 Stat4Group { get; set; }
		// 1 - Item
		// 2 - Flask
		// 3 - Monster
		// 4 - Chest
		// 5 - Map
		public int Domain { get; set; }
		[UserStringIndex]
		public int Name { get; set; }
		// 1 - Prefix
		// 2 - Suffix
		// 3 - Cannot be generated
		public int GenerationType { get; set; }
		[StringIndex]
		public int CorrectGroup { get; set; }
		public int Unknown18 { get; set; }
		// possibly [StringIndex] ?
		public int Unknown19 { get; set; }
		public int Unknown20 { get; set; }
		public int Unknown21 { get; set; }
		public Int64 Unknown22 { get; set; }
		public int Unknown23 { get; set; }
		public int Unknown24 { get; set; }
		// possibly [StringIndex] if previous is 0?
		public int Unknown25 { get; set; }
		public Int64 Unknown26 { get; set; }
		public int Unknown27 { get; set; }
		public int Unknown28 { get; set; }

		public Mods(BinaryReader inStream)
		{
			Id = inStream.ReadInt32();
			Unknown0 = inStream.ReadInt32();
			Level = inStream.ReadInt32();
			Stat1Min = inStream.ReadInt32();
			Stat1Max = inStream.ReadInt32();
			Stat2Min = inStream.ReadInt32();
			Stat2Max = inStream.ReadInt32();
			Stat3Min = inStream.ReadInt32();
			Stat3Max = inStream.ReadInt32();
			Stat4Min = inStream.ReadInt32();
			Stat4Max = inStream.ReadInt32();
			Stat1Group = inStream.ReadInt64();
			Stat2Group = inStream.ReadInt64();
			Stat3Group = inStream.ReadInt64();
			Stat4Group = inStream.ReadInt64();
			Domain = inStream.ReadInt32();
			Name = inStream.ReadInt32();
			GenerationType = inStream.ReadInt32();
			CorrectGroup = inStream.ReadInt32();
			Unknown18 = inStream.ReadInt32();
			Unknown19 = inStream.ReadInt32();
			Unknown20 = inStream.ReadInt32();
			Unknown21 = inStream.ReadInt32();
			Unknown22 = inStream.ReadInt64();
			Unknown23 = inStream.ReadInt32();
			Unknown24 = inStream.ReadInt32();
			Unknown25 = inStream.ReadInt32();
			Unknown26 = inStream.ReadInt64();
			Unknown27 = inStream.ReadInt32();
			Unknown28 = inStream.ReadInt32();
		}

		public override void Save(BinaryWriter outStream)
		{
			outStream.Write(Id);
			outStream.Write(Unknown0);
			outStream.Write(Level);
			outStream.Write(Stat1Min);
			outStream.Write(Stat1Max);
			outStream.Write(Stat2Min);
			outStream.Write(Stat2Max);
			outStream.Write(Stat3Min);
			outStream.Write(Stat3Max);
			outStream.Write(Stat4Min);
			outStream.Write(Stat4Max);
			outStream.Write(Stat1Group);
			outStream.Write(Stat2Group);
			outStream.Write(Stat3Group);
			outStream.Write(Stat4Group);
			outStream.Write(Domain);
			outStream.Write(Name);
			outStream.Write(GenerationType);
			outStream.Write(CorrectGroup);
			outStream.Write(Unknown18);
			outStream.Write(Unknown19);
			outStream.Write(Unknown20);
			outStream.Write(Unknown21);
			outStream.Write(Unknown22);
			outStream.Write(Unknown23);
			outStream.Write(Unknown24);
			outStream.Write(Unknown25);
			outStream.Write(Unknown26);
			outStream.Write(Unknown27);
			outStream.Write(Unknown28);

		}

		public override int GetSize()
		{
			return 0x90;
		}
	}
}
