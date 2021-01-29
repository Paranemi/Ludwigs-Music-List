using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Contracts
{
    public interface ILikedSongDomainModel
    {
        Guid LikedSongId { get; set; }
        Guid SongId { get; set; }
        ISongDomainModel Songs { get; set; }
        Guid UserId { get; set; }
        IUserDomainModel User { get; set; }
    }
}
