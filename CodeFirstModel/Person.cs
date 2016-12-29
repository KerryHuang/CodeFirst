using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstModel
{
    [Table("Employee", Schema = "Company")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonId { get; set; }
        [MaxLength(8)]
        public string FirstName { get; set; }
        [MaxLength(8)]
        public string LastName { get; set; }
        [NotMapped]
        public string DisplayName { get; set; }
    }
}
