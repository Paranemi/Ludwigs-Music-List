using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Contracts
{
    public interface IPersonViewModel
    {

        Guid PersonId { get; set; }
        int From { get; set; }
        int To { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string ImageUrl { get; set; }
        DateTime Born { get; set; }
        DateTime Died { get; set; }


        Guid ArtistId { get; set; }
        IArtistViewModel Artist { get; set; }
    }
}
