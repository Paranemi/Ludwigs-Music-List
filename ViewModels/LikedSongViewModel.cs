using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViewModels.Contracts;

namespace ViewModels
{
    public class LikedSongViewModel : ILikedSongViewModel
    {
        public Guid LikedSongId { get; set; }
        public virtual Guid SongId { get; set; }
        public virtual ISongViewModel Song { get; set; }
        public virtual Guid UserId { get; set; }
        public virtual IUserViewModel User { get; set; }
      
    }
}