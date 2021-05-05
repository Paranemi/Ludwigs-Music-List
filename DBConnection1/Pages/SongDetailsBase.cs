using Microsoft.AspNetCore.Components;
using MusicListWorkflow.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorServerSide.Pages
{
    public class SongDetailsBase : ComponentBase
    {
        [Parameter]
        public string SongId { get; set; }
        public string SongName { get; set; }
        [Parameter]
        public string AlbumName { get; set; }
        public Guid ArtistId { get; set; }
        public string ArtistName { get; set; }
        public string LinkYT { get; set; }
        public string LinkSP { get; set; }
        public string Cover { get; set; }
        [Inject]
        public ISongWorkflow SongWorkflow { get; set; }
        [Inject]
        public IAlbumWorkflow AlbumWorkflow { get; set; }

        [Inject]
        public NavigationManager UriHelper { get; set; }


        protected override void OnInitialized()
        {
            var song = SongWorkflow.GetSongById(Guid.Parse(SongId)); 

            SongName = song.Name;
            AlbumName = song.Album.Name;
            ArtistId = song.Artist.ArtistId;
            ArtistName = song.Artist.Name;
            LinkYT = song.LinkYT;
            LinkSP = song.LinkSptfy;
            Cover = song.Album.ImageUrl;
        }

        protected void NavBackHandler()
        {
            UriHelper.NavigateTo("/songlist");
        }


    }
}
