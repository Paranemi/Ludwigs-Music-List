using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBConnection1.Models
{
    [Table("Songs")]
    public class Song
    {
        [Key]
        public Guid SongId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string LinkSptfy { get; set; }
        [MaxLength(100)]
        public string LinkYT { get; set; }

        public virtual Guid AlbumId { get; set; }
        public virtual Album Album { get; set; }

        public virtual Guid ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

        public virtual ICollection<LikedSong> LikedSongs { get; set; }

        //public List<Album> Albums { get; set; } = new List<Album>();
    }
}
