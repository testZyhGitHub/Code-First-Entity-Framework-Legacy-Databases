// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.61
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace Northwind.DataAccessLayer
{
    using Northwind.DataAccessLayer.Model.Context;
    using Northwind.DataAccessLayer.Model.Interfaces;

    // Products by Category
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class ProductsByCategoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductsByCategory>
    {
        public ProductsByCategoryConfiguration()
            : this("dbo")
        {
        }

        public ProductsByCategoryConfiguration(string schema)
        {
            ToTable("Products by Category", schema);
            HasKey(x => new { x.CategoryName, x.ProductName, x.Discontinued });

            Property(x => x.CategoryName).HasColumnName(@"CategoryName").IsRequired().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.ProductName).HasColumnName(@"ProductName").IsRequired().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.QuantityPerUnit).HasColumnName(@"QuantityPerUnit").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.UnitsInStock).HasColumnName(@"UnitsInStock").IsOptional().HasColumnType("smallint");
            Property(x => x.Discontinued).HasColumnName(@"Discontinued").IsRequired().HasColumnType("bit");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>