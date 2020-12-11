using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBConnection1.Models
{
    [Table("Artists")]
    public class Artist
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Founded { get; set; }
    }
}
