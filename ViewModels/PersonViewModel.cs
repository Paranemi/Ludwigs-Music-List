using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViewModels.Contracts;

namespace ViewModels
{
    public class PersonViewModel : IPersonViewModel
    {
        public Guid PersonId { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Born { get; set; }
        public DateTime Died { get; set; }


        public virtual Guid ArtistId { get; set; }
        public virtual IArtistViewModel Artist { get; set; }
    }
}
