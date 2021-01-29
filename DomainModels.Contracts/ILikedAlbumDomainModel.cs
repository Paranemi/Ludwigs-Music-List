using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Contracts
{
    public interface ILikedAlbumDomainModel
    {
        Guid LikedAlbumId { get; set; }

        Guid UserId { get; set; }

        IUserDomainModel User { get; set; }

        Guid AlbumId { get; set; }

        IAlbumDomainModel Album { get; set; }
    }
}
