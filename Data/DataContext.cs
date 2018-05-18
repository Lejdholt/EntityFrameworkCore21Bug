using System;
using System.Linq;
using System.Linq.Expressions;
using GDB.Vinn.DataWarehouse.DataSets.ComplexTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data
{
    public class DataContext:DbContext
    {
        public DbSet<Data1> Data1s { get; set; }
        public DbSet<Data2> Data2s { get; set; }
        public DbSet<Data3> Data3s { get; set; }
        

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            foreach (var pb in builder.Model
                .GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal))
                .Select(p => builder.Entity(p.DeclaringEntityType.ClrType).Property(p.Name)))
            {

                pb.HasColumnType("decimal(32,12)");
            }
            foreach (var pb in builder.Model
                .GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal?))
                .Select(p => builder.Entity(p.DeclaringEntityType.ClrType).Property(p.Name)))
            {
                pb.HasColumnType("decimal(32,12)");
            }
            foreach (var pb in builder.Model
                .GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(string))
                .Select(p => builder.Entity(p.DeclaringEntityType.ClrType).Property(p.Name)))
            {
                pb.HasMaxLength(256);
            }

            foreach (var pb in builder.Model
                .GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(DateTime))
                .Select(p => builder.Entity(p.DeclaringEntityType.ClrType).Property(p.Name)))
            {
                pb.HasColumnType("datetime2");
            }


            builder.ApplyConfiguration(new Data1Config());
            builder.ApplyConfiguration(new Data2Config());
            builder.ApplyConfiguration(new Data3Config());

            base.OnModelCreating(builder);
        }
    }

    public class Data1Config : IEntityTypeConfiguration<Data1>
    {
        public void Configure(EntityTypeBuilder<Data1> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.EntityId).IsRequired();
            builder.SetupReferenceValues();
        }
    }

    public class Data2Config : IEntityTypeConfiguration<Data2>
    {
        public void Configure(EntityTypeBuilder<Data2> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.EntityId).IsRequired();
            builder.SetupReferenceValues();
        }
    }
    public class Data3Config : IEntityTypeConfiguration<Data3>
    {
        public void Configure(EntityTypeBuilder<Data3> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.EntityId).IsRequired();
            builder.SetupReferenceValues();
        }
    }

    public static class EntityTypeBuilderExtensions
    {
        public static void SetupReferenceValues<T>(this EntityTypeBuilder<T> builder) where T : class
        {
            foreach (var property in builder.Metadata.ClrType.GetProperties())
            {
                Console.WriteLine(property.PropertyType + " " + property.Name);
                if (property.PropertyType == typeof(ReferenceValueString))
                {
                    builder.OwnsReferenceValueString(property.Name);
                }

                else if (property.PropertyType == typeof(ReferenceValueDecimal))
                {
                    builder.OwnsReferenceValueDecimal(property.Name);
                }

                else if (property.PropertyType == typeof(ReferenceValueDateTime))
                {
                    builder.OwnsReferenceValueDateTime(property.Name);
                }

                else if (property.PropertyType == typeof(ReferenceValueInteger))
                {
                    builder.OwnsReferenceValueInteger(property.Name);
                }

                else if (property.PropertyType == typeof(ReferenceValueDouble))
                {
                    builder.OwnsReferenceValueDouble(property.Name);
                }
                else if (property.PropertyType == typeof(ReferenceValueDouble))
                {
                    builder.OwnsReferenceValueDouble(property.Name);
                }
                else if (property.PropertyType == typeof(ReferenceValueBool))
                {
                    builder.OwnsReferenceValueBool(property.Name);
                }
            }
        }

        public static EntityTypeBuilder<TEntity> OwnsReferenceValueString<TEntity>(this EntityTypeBuilder<TEntity> builder, string propertyName, int maxLength = 256) where TEntity : class

        {
            var ownsInstitutionCode = builder.OwnsOne(typeof(ReferenceValueString), propertyName);

            ownsInstitutionCode.Property("Value").HasColumnName(propertyName).HasMaxLength(maxLength);
            ownsInstitutionCode.Property("Source").HasColumnName(propertyName + "_Source").HasMaxLength(64);

            return builder;
        }
 

        public static EntityTypeBuilder<TEntity> OwnsReferenceValueDecimal<TEntity>(this EntityTypeBuilder<TEntity> builder, string propertyName) where TEntity : class

        {
            var ownsInstitutionCode = builder.OwnsOne(typeof(ReferenceValueDecimal), propertyName);

            ownsInstitutionCode.Property("Value").HasColumnName(propertyName).HasColumnType("decimal(32,12)");
            ownsInstitutionCode.Property("Source").HasColumnName(propertyName + "_Source").HasMaxLength(64);

            return builder;
        }


        public static EntityTypeBuilder<TEntity> OwnsReferenceValueDateTime<TEntity>(this EntityTypeBuilder<TEntity> builder, string propertyName) where TEntity : class

        {
            var ownsInstitutionCode = builder.OwnsOne(typeof(ReferenceValueDateTime), propertyName);

            ownsInstitutionCode.Property("Value").HasColumnName(propertyName).HasColumnType("datetime2");
            ownsInstitutionCode.Property("Source").HasColumnName(propertyName + "_Source").HasMaxLength(64);

            return builder;
        }

        public static EntityTypeBuilder<TEntity> OwnsReferenceValueDouble<TEntity>(this EntityTypeBuilder<TEntity> builder, string propertyName) where TEntity : class

        {
            var ownsInstitutionCode = builder.OwnsOne(typeof(ReferenceValueDouble), propertyName);

            ownsInstitutionCode.Property("Value").HasColumnName(propertyName);
            ownsInstitutionCode.Property("Source").HasColumnName(propertyName + "_Source").HasMaxLength(64);

            return builder;
        }

        public static EntityTypeBuilder<TEntity> OwnsReferenceValueInteger<TEntity>(this EntityTypeBuilder<TEntity> builder, string propertyName) where TEntity : class

        {
            var ownsInstitutionCode = builder.OwnsOne(typeof(ReferenceValueInteger), propertyName);

            ownsInstitutionCode.Property("Value").HasColumnName(propertyName);
            ownsInstitutionCode.Property("Source").HasColumnName(propertyName + "_Source").HasMaxLength(64);

            return builder;
        }


        public static EntityTypeBuilder<TEntity> OwnsReferenceValueBool<TEntity>(this EntityTypeBuilder<TEntity> builder, string propertyName) where TEntity : class

        {
            var ownsInstitutionCode = builder.OwnsOne(typeof(ReferenceValueBool), propertyName);

            ownsInstitutionCode.Property("Value").HasColumnName(propertyName);
            ownsInstitutionCode.Property("Source").HasColumnName(propertyName + "_Source").HasMaxLength(64);

            return builder;
        }
    }
}
