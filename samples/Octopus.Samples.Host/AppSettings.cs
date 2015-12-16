﻿using System;

namespace GV.AspNet.Configuration.Contrib.Octopus.Samples.Host
{
	public class AppSettings
	{
		public DatabaseSettings Database { get; set; }
		public OctopusSettings Octopus { get; set; }

		public override string ToString() => $"Database: {Database}; Octopus: {Octopus}";
	}
}