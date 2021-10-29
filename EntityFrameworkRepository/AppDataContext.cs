using EntityFrameworkRepository.EFModels;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace EntityFrameworkRepository
{
    public class AppDataContext : DbContext
    {
        public AppDataContext([NotNull] DbContextOptions options) : base(options) { }

        public virtual DbSet<AlbumEntityModel> Album { get; set; }
        public virtual DbSet<ArtistEntityModel> Artist { get; set; }
        public virtual DbSet<LikedAlbumEntityModel> LikedAlbum { get; set; }
        public virtual DbSet<LikedSongEntityModel> LikedSong { get; set; }
        public virtual DbSet<PersonEntityModel> Person { get; set; }
        public virtual DbSet<SongEntityModel> Song { get; set; }
        public virtual DbSet<UserEntityModel> User { get; set; }
    }

}
