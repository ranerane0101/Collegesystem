﻿using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using System;
namespace ContosoUniversity.Data
{
	public interface SchoolContext : DbContext
	{
		public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
		{

		}

		public DbSet<Course> Couses { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
		public DbSet<Student> Students { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Course>().ToTable("Course");
			modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
			modelBuilder.Entity<Student>().ToTable("Student");
		}
	}
}

