﻿using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.DAL.Context
{
	public class MyPortfolioContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-RSDLUJ4;initial Catalog=MyPortfolioDb;integrated Security=true;");

		}

		public DbSet<About> Abouts { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Education> Educations { get; set; }
		public DbSet<Experience> Experiences { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<Skill> Skills { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<DownloadCV> DownloadCVs { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Admin> Admins { get; set; }
		public DbSet<Token> Tokens { get; set; }
		public DbSet<Mail> Mails { get; set; }

	}
}
