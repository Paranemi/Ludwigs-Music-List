using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Contracts
{
    public interface ILikedAlbumViewModel
    {
        Guid LikedAlbumId { get; set; }

        Guid UserId { get; set; }
        IUserViewModel User { get; set; }

        Guid AlbumId { get; set; }
        IAlbumViewModel Album { get; set; }
    }
}
