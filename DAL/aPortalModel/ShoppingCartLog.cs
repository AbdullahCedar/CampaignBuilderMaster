using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class ShoppingCartLog
    {
        public int Id { get; set; }
        public string OpId { get; set; } = null!;
        public int ProductId { get; set; }
        public string ServiceItem { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Cost { get; set; } = null!;
        public int Quantity { get; set; }
        public int? ClientId { get; set; }
        public int? DebtorId { get; set; }
        public DateTime Datetime { get; set; }
        public int? SalesId { get; set; }
    }
}
