using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkRepository.EFModels
{
    [Table("Persons")]
    public class PersonEntityModel
    {
        [Key]
        public Guid PersonId { get; set; }
        public int From { get; set; }
        public int To { get; set; }

        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(20)]
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Born { get; set; }
        public DateTime Died { get; set; }


        public virtual Guid ArtistId { get; set; }
        public virtual ArtistEntityModel Artist { get; set; }
    }
}
