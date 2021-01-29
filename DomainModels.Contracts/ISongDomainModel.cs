using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Contracts
{
    public interface ISongDomainModel
    {
        Guid SongId { get; set; }
        string Name { get; set; }
        string LinkSptfy { get; set; }
        string LinkYT { get; set; }
        IAlbumDomainModel Album { get; set; }
        Guid AlbumId { get; set; }
        Guid ArtistId { get; set; }
        IArtistDomainModel Artist { get; set; }
    }
}
