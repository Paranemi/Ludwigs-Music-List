using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViewModels.Contracts;

namespace ViewModels
{
    public class SongViewModel : ISongViewModel
    {
        public Guid SongId { get; set; }
        public string Name { get; set; }
        public string LinkSptfy { get; set; }
        public string LinkYT { get; set; }

        public virtual Guid AlbumId { get; set; }
        public virtual IAlbumViewModel Album { get; set; }

        public virtual Guid ArtistId { get; set; }
        public virtual IArtistViewModel Artist { get; set; }


    }
}
