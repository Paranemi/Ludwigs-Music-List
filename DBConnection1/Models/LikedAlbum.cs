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
        public Guid LikedAlbumId { get; set; }

        public virtual Guid UserId { get; set; }
        public virtual User User { get; set; }

        public virtual Guid AlbumId { get; set; }
        public virtual Album Album { get; set; }
    }
}
