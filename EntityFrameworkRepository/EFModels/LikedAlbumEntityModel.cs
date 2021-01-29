using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkRepository.EFModels
{
    [Table("LikedAlbum")]
    public class LikedAlbumEntityModel
    {
        [Key]
        public Guid LikedAlbumId { get; set; }

        public virtual Guid UserId { get; set; }
        public virtual UserEntityModel User { get; set; }

        public virtual Guid AlbumId { get; set; }
        public virtual AlbumEntityModel Album { get; set; }
    }
}
