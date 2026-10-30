using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class CartClientInfo
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string? Cname { get; set; }
        public string? Pname { get; set; }
        public string? Caddress { get; set; }
        public string? Cemail { get; set; }
        public string? DeName { get; set; }
        public string? DeAddress { get; set; }
        public string? DePhone { get; set; }
        public string? DeDob { get; set; }
        public string? DeSs { get; set; }
        public string? DeEmail { get; set; }
        public string? Cphone { get; set; }
    }
}
