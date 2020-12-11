using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBConnection1.Models
{
    [Table("LikedSong")]
    public class LikedSong
    {
        [Key]
        public Guid Id { get; set; }

    }
}
