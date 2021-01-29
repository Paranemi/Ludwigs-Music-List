using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Contracts
{
    public interface IArtistViewModel
    {
        Guid ArtistId { get; set; }
        string Name { get; set; }
        string ArtistImageUrl { get; set; }
        int Founded { get; set; }
    }
}
