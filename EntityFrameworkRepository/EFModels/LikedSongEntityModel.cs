using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkRepository.EFModels
{
    [Table("LikedSong")]
    public class LikedSongEntityModel
    {
        [Key]
        public Guid LikedSongId { get; set; }
        public virtual Guid SongId { get; set; }
        public virtual SongEntityModel Songs { get; set; }
        public virtual Guid UserId { get; set; }
        public virtual UserEntityModel User { get; set; }

    }
}