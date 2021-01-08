using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBConnection1.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public Guid PersonId { get; set; }
        public int From { get; set; }
        public int To { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Born { get; set; }
        public DateTime Died { get; set; }


        public virtual Guid ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
