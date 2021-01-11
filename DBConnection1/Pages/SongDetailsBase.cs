using DBConnection1.Data;
using DBConnection1.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DBConnection1.Pages
{
    public class SongDetailsBase : ComponentBase
    {
        [Parameter]
        public string SongName { get; set; }
        [Parameter] 
        public string AlbumName { get; set; }
        [Parameter] 
        public string ArtistName { get; set; }
        [Parameter] 
        public string LinkYT { get; set; }
        [Parameter]
        public string LinkSP { get; set; }
        [Parameter] 
        public string Cover { get; set; }

        [Inject]
        protected AppDataContext Db { get; set; }
        protected List<Song> songlist;

        protected override void OnInitialized()
        {
            songlist = Db.Song.Where(b => b.Name.Contains(SongName)&& b.Album.Name.Contains(AlbumName)).ToList();
            SetElements();
        }

        protected void SetElements()
        {
            foreach (var songDetails in songlist)
            {
                ArtistName = songDetails.Artist.Name;
                LinkYT = songDetails.LinkYT;
                LinkSP = songDetails.LinkSptfy;
                Cover = songDetails.Album.ImageUrl;
            }
        }
    }
}
