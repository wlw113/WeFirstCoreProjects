using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WeFirstCoreProject.Model.Entitys;

namespace WeFirstCoreProject.Model.Map
{
   public class FirstProjectContext:DbContext
    {
        public FirstProjectContext(DbContextOptions<FirstProjectContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SystemUserInfoConfiguration());
        }
        public DbSet<SystemUserInfo> SystemUserInfos { get; set; }
    }
}
