﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace _1911065522_PhungXuanDoan_BigSchool.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
            public DbSet<Course> Courses { get; set; }
            public DbSet<Category> Categories { get; set; }
            public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            
            return new ApplicationDbContext();
    }
}
}