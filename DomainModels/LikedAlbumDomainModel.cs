using DomainModels.Contracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels
{
    public class LikedAlbumDomainModel : ILikedAlbumDomainModel
    {
        public Guid LikedAlbumId { get; set; }

        public virtual Guid UserId { get; set; }
        public virtual IUserDomainModel User { get; set; }

        public virtual Guid AlbumId { get; set; }
        public virtual IAlbumDomainModel Album { get; set; }
    }
}
