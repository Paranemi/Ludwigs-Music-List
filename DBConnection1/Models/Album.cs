using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBConnection1.Models
{
    [Table("Albums")]
    public class Album
    {
        [Key]
        public Guid AlbumId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string ImageUrl { get; set; }
        public DateTime ReleaseDate { get; set; }


        public virtual ICollection<Song> Songs { get; set; }
        public virtual ICollection<LikedAlbum> LikedAlbums { get; set; }
    }
}
