using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBConnection1.Models
{
    [Table("LikedAlbum")]
    public class LikedAlbum
    {
        [Key]
        public Guid Id { get; set; }
    }
}
