using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WeFirstCoreProject.Model;

namespace WeFirstCoreProject.Model
{
   public abstract class EntityBaseConfiguration<T>:IEntityTypeConfiguration<T> where T:EntityBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(x => x.CreateTime).IsRequired();
            builder.Property(x => x.UpdateTime).IsRequired();
            builder.Property(x => x.CreateUser).IsRequired();
            builder.Property(x => x.UpdateUser).IsRequired();
            builder.Property(x => x.LastAction).IsRequired();

            ConfiguraDerived(builder);
        }
        public abstract void ConfiguraDerived(EntityTypeBuilder<T> b);
    }
}
