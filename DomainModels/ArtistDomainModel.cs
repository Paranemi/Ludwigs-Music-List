using DomainModels.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels
{
    public class ArtistDomainModel : IArtistDomainModel
    {
        public Guid ArtistId { get; set; }
        public string Name { get; set; }
        public string ArtistImageUrl { get; set; }
        public int Founded { get; set; }

    }
}
