using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBConnection1.Models
{
    [Table("LikedSong")]
    public class LikedSong
    {
        [Key]
        public Guid LikedSongId { get; set; }

        public virtual Guid UserId { get; set; }
        public virtual User User { get; set; }

        public virtual Guid SongId { get; set; }
        public virtual Song Songs { get; set; }
    }
}
