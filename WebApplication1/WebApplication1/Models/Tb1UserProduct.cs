using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Tb1UserProduct
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int? CatId { get; set; }
        public string ProductImage { get; set; }
        public int? ProductMrp { get; set; }
        public int? ProductDiscount { get; set; }
        public int? ProductFinal { get; set; }
        public int? ProductQuantity { get; set; }
    }
}
