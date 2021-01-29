using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels
{
    public class LikedSongDomainModel : ILikedSongDomainModel
    {
        public Guid LikedSongId { get; set; }
        public virtual Guid SongId { get; set; }
        public virtual ISongDomainModel Song { get; set; }
        public virtual Guid UserId { get; set; }
        public virtual IUserDomainModel User { get; set; }

    }
}