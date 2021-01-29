using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Contracts
{
    public interface ILikedSongViewModel
    {
        Guid LikedSongId { get; set; }
        Guid SongId { get; set; }
        ISongViewModel Songs { get; set; }
        Guid UserId { get; set; }
        IUserViewModel User { get; set; }
    }
}
