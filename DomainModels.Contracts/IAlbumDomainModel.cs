using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Contracts
{
   public interface IAlbumDomainModel
    {
        Guid AlbumId { get; set; }
        string Name { get; set; }
        string ImageUrl { get; set; }
        DateTime ReleaseDate { get; set; }

    }
}
