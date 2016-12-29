using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstModel
{
    public class DetailedInfo
    {
        [Key]
        public int CompanyId { get; set; }
        public string Address { get; set; }
        public DateTime DateFounded { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateCreated { get; set; }
        // Constructor
        public DetailedInfo()
        {
            this.DateCreated = DateTime.Now;
        }
    }
}
