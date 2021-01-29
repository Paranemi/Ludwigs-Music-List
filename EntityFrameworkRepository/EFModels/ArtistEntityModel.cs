using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkRepository.EFModels
{
    [Table("Artists")]
    public class ArtistEntityModel
    {
        [Key]
        public Guid ArtistId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string ArtistImageUrl { get; set; }
        public int Founded { get; set; }

    }
}
