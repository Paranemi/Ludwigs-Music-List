using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViewModels.Contracts;

namespace ViewModels
{
    public class ArtistViewModel : IArtistViewModel
    {
        public Guid ArtistId { get; set; }
        public string Name { get; set; }
        public string ArtistImageUrl { get; set; }
        public int Founded { get; set; }

    }
}
