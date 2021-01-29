using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViewModels.Contracts;

namespace ViewModels
{
    public class LikedAlbumViewModel : ILikedAlbumViewModel
    {
        public Guid LikedAlbumId { get; set; }

        public virtual Guid UserId { get; set; }
        public virtual IUserViewModel User { get; set; }

        public virtual Guid AlbumId { get; set; }
        public virtual IAlbumViewModel Album { get; set; }
    }
}
