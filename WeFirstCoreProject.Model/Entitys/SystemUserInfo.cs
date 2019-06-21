using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeFirstCoreProject.Model.Entitys
{
    public class SystemUserInfo:EntityBase
    {
        public int Id { get; set; }
        public string SystemAccount { get; set; }
        public string SystemPassword { get; set; }
        public string Name { get; set; }
        public int SystemLevel { get; set; }
    }
    public class SystemUserInfoConfiguration: EntityBaseConfiguration<SystemUserInfo>
    {
        public override void ConfiguraDerived(EntityTypeBuilder<SystemUserInfo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SystemAccount).IsRequired().HasMaxLength(50);
            builder.Property(x => x.SystemPassword).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.SystemLevel).IsRequired();
        }
    }
}
 