using DBConnection1.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace DBConnection1.Data
{
    public class AppDataContext : DbContext
    {

        public AppDataContext([NotNull] DbContextOptions options) : base(options) { }

        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<LikedAlbum> LikedAlbum { get; set; }
        public virtual DbSet<LikedSong> LikedSong { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Song> Song { get; set; }
        public virtual DbSet<User> User { get; set; }

    /*    public void addtest()
        {
            var context = new AppDataContext();
            var album = new Album
            {
                Id = Guid.NewGuid()
                , ImageUrl = "../Image/endgame.jpg"
                , Name = "The Joy of Motion"
                , ReleaseDate = new DateTime(2014,3,24)
            };
            context.Add(album);
            context.SaveChanges();
            
        }*/
      
    }

}
