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

    // Sales Totals by Amount
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.22.1.0")]
    public partial class SalesTotalsByAmount
    {
        public decimal? SaleAmount { get; set; } // SaleAmount
        public int OrderId { get; set; } // OrderID
        public string CompanyName { get; set; } // CompanyName (length: 40)
        public System.DateTime? ShippedDate { get; set; } // ShippedDate

        public SalesTotalsByAmount()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
