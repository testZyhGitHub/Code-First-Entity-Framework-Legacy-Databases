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

    // Products Above Average Price
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class ProductsAboveAveragePriceConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductsAboveAveragePrice>
    {
        public ProductsAboveAveragePriceConfiguration()
            : this("dbo")
        {
        }

        public ProductsAboveAveragePriceConfiguration(string schema)
        {
            ToTable("Products Above Average Price", schema);
            HasKey(x => x.ProductName);

            Property(x => x.ProductName).HasColumnName(@"ProductName").IsRequired().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice").IsOptional().HasColumnType("money").HasPrecision(19,4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
