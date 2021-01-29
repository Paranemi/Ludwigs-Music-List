﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Contracts
{
    public interface IArtistDomainModel
    {
        Guid ArtistId { get; set; }
        string Name { get; set; }
        string ArtistImageUrl { get; set; }
        int Founded { get; set; }

    }
}
