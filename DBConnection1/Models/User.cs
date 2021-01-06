using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBConnection1.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        [MaxLength(40)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(40)]
        public string Password { get; set; }

        public virtual ICollection<LikedSong> LikedSongs { get; set; }
        public virtual ICollection<LikedAlbum> LikedAlbums { get; set; }
    }
}
