using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkRepository.EFModels
{
    [Table("Albums")]
    public class AlbumEntityModel
    {
        [Key]
        public Guid AlbumId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string ImageUrl { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}
