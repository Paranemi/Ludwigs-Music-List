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
        public ISongWorkflow SongWorkflow { get; set; }
        [Inject]
        public IAlbumWorkflow AlbumWorkflow { get; set; }

        //   protected List<Song> songlist;


        protected override void OnInitialized()
        {
            var song = SongWorkflow.GetSongByName(SongName); 
    //        var album = AlbumWorkflow.GetAlbumByName(AlbumName);

            SongName = song.Name;
            AlbumName = song.Album.Name;
            ArtistName = song.Artist.Name;
            LinkYT = song.LinkYT;
            LinkSP = song.LinkSptfy;
            Cover = song.Album.ImageUrl;

           // SetElements();
        }

        //protected void SetElements()
        //{
        //    foreach (var songDetails in songlist)
        //    {
        //        ArtistName = songDetails.Artist.Name;
        //        LinkYT = songDetails.LinkYT;
        //        LinkSP = songDetails.LinkSptfy;
        //        Cover = songDetails.Album.ImageUrl;
        //    }
        //}
    }
}
