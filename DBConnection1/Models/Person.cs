using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBConnection1.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public Guid PersonId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Born { get; set; }
        public DateTime Died { get; set; }


        public virtual Guid ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
