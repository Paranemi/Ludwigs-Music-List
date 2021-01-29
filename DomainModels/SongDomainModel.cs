using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels
{
    public class SongDomainModel : ISongDomainModel
    {
        public Guid SongId { get; set; }
        public string Name { get; set; }
        public string LinkSptfy { get; set; }
        public string LinkYT { get; set; }

        public virtual Guid AlbumId { get; set; }
        public virtual IAlbumDomainModel Album { get; set; }

        public virtual Guid ArtistId { get; set; }
        public virtual IArtistDomainModel Artist { get; set; }


    }
}
