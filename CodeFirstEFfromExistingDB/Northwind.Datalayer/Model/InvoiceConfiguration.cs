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

    // Invoices
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class InvoiceConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Invoice>
    {
        public InvoiceConfiguration()
            : this("dbo")
        {
        }

        public InvoiceConfiguration(string schema)
        {
            ToTable("Invoices", schema);
            HasKey(x => new { x.CustomerName, x.Salesperson, x.OrderId, x.ShipperName, x.ProductId, x.ProductName, x.UnitPrice, x.Quantity, x.Discount });

            Property(x => x.ShipName).HasColumnName(@"ShipName").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.ShipAddress).HasColumnName(@"ShipAddress").IsOptional().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.ShipCity).HasColumnName(@"ShipCity").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.ShipRegion).HasColumnName(@"ShipRegion").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.ShipPostalCode).HasColumnName(@"ShipPostalCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.ShipCountry).HasColumnName(@"ShipCountry").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.CustomerId).HasColumnName(@"CustomerID").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(5);
            Property(x => x.CustomerName).HasColumnName(@"CustomerName").IsRequired().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Address).HasColumnName(@"Address").IsOptional().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.City).HasColumnName(@"City").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.Region).HasColumnName(@"Region").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.PostalCode).HasColumnName(@"PostalCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Country).HasColumnName(@"Country").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.Salesperson).HasColumnName(@"Salesperson").IsRequired().HasColumnType("nvarchar").HasMaxLength(31);
            Property(x => x.OrderId).HasColumnName(@"OrderID").IsRequired().HasColumnType("int");
            Property(x => x.OrderDate).HasColumnName(@"OrderDate").IsOptional().HasColumnType("datetime");
            Property(x => x.RequiredDate).HasColumnName(@"RequiredDate").IsOptional().HasColumnType("datetime");
            Property(x => x.ShippedDate).HasColumnName(@"ShippedDate").IsOptional().HasColumnType("datetime");
            Property(x => x.ShipperName).HasColumnName(@"ShipperName").IsRequired().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.ProductId).HasColumnName(@"ProductID").IsRequired().HasColumnType("int");
            Property(x => x.ProductName).HasColumnName(@"ProductName").IsRequired().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice").IsRequired().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.Quantity).HasColumnName(@"Quantity").IsRequired().HasColumnType("smallint");
            Property(x => x.Discount).HasColumnName(@"Discount").IsRequired().HasColumnType("real");
            Property(x => x.ExtendedPrice).HasColumnName(@"ExtendedPrice").IsOptional().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.Freight).HasColumnName(@"Freight").IsOptional().HasColumnType("money").HasPrecision(19,4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
