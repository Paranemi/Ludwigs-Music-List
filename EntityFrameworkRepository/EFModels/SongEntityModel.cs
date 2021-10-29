using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkRepository.EFModels
{
    [Table("Songs")]
    public class SongEntityModel
    {
        [Key]
        public Guid SongId { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string LinkSptfy { get; set; }
        [MaxLength(100)]
        public string LinkYT { get; set; }

        public virtual Guid AlbumId { get; set; }
        public virtual AlbumEntityModel Album { get; set; }

        public virtual Guid ArtistId { get; set; }
        public virtual ArtistEntityModel Artist { get; set; }
    }
}
