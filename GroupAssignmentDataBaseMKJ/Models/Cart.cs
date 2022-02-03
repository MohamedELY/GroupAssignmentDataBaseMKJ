using System;
using System.Collections.Generic;

#nullable disable

namespace GroupAssignmentDataBaseMKJ.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public string CustemerId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual Product Product { get; set; }
    }
}
