using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBConnection1.Models
{
    [Table("Artists")]
    public class Artist
    {
        [Key]
        public Guid ArtistId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string ArtistImageUrl { get; set; }    
        public DateTime Founded { get; set; }


        public virtual ICollection<Person> Persons { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
