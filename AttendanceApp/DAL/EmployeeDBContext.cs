using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AttendanceApp.Models;

namespace AttendanceApp.DAL
{
	public class EmployeeDBContext:DbContext
	{
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EmployeeDBContext>(null);
            base.OnModelCreating(modelBuilder);
        }
        public EmployeeDBContext() : base("DefaultConnection")
		{
            this.Database.CreateIfNotExists();
		}

		public DbSet<Employee> Employee { get; set; }
		public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Member> Member { get; set; }


	}
}