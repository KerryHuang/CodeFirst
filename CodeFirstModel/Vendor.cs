using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstModel
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }
        public string Name { get; set; }
    }
}
