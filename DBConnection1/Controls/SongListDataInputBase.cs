using DBConnection1.Data;
using DBConnection1.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBConnection1.Controls
{
    public class SongListDataInputBase : ComponentBase
    {
        protected string SongName { get; set; }
        protected string AlbumName { get; set; }
        protected string ArtistName { get; set; }
        protected string ReleaseDate { get; set; }
        protected string LinkYT { get; set; }
        protected string LinkSP { get; set; }
        protected string Cover { get; set; }

        [Inject]
        public AppDataContext Db { get; set; }

        [Parameter]
        public bool Visible { get; set; } = false;

        public void HideWindow()
        {
            Visible = false;
        }

        public void AddSong()
        {
            Visible = false;
            var album = new Album
            {
                Name = AlbumName,
                ImageUrl = Cover,
                ReleaseDate = DateTime.Parse(ReleaseDate),
            };
            Db.Album.Add(album);

            var artist = new Artist
            {
                Name = ArtistName,
                    
            };
            Db.Artist.Add(artist);

            var song = new Song
            {
                Name = SongName,
                LinkYT = LinkYT,
                LinkSptfy = LinkSP,
                Album = album,
                Artist = artist
            };
            Db.Song.Add(song);
            Db.SaveChanges();
        }


        protected void SongNameValueChanged(string Value)
        {
            SongName = Value;
        }
        protected void AlbumNameValueChanged(string Value)
        {
            AlbumName = Value;
        }
        protected void ArtistNameValueChanged(string Value)
        {
            ArtistName = Value;
        }
        protected void LinkYTValueChanged(string Value)
        {
            LinkYT = Value.Substring(Value.IndexOf('=') + 1);
        }
        protected void LinkSPValueChanged(string Value)
        {
            LinkSP = Value.Substring(Value.IndexOf("track/") + 6);
        }
        protected void CoverValueChanged(string Value)
        {
            Cover = Value;
        }
        protected void ReleaseDateValueChanged(string Value)
        {
            ReleaseDate = Value;
        }
    }
}
