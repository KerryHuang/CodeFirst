using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstModel
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual DetailedInfo DetailedInfo { get; set; }
        public virtual List<Person> Employees { get; set; }
    }
}
