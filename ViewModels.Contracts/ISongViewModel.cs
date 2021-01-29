using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Contracts
{
    public interface ISongViewModel
    {
        Guid SongId { get; set; }
        string Name { get; set; }
        string LinkSptfy { get; set; }
        string LinkYT { get; set; }

        Guid AlbumId { get; set; }
        IAlbumViewModel Album { get; set; }

        Guid ArtistId { get; set; }
        IArtistViewModel Artist { get; set; }
    }
}
