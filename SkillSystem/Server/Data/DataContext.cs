﻿namespace SkillSystem.Server.Data
{
	public class DataContext:DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}
	}
}
