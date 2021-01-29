using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Contracts
{
    public interface IAlbumViewModel
    {
        Guid AlbumId { get; set; }
        string Name { get; set; }
        string ImageUrl { get; set; }
        DateTime ReleaseDate { get; set; }
    }
}
