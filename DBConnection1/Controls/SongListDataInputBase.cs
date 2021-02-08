using Microsoft.AspNetCore.Components;
using MusicListWorkflow.Contracts;
using System;
using System.Collections.Generic;
using ViewModels;
using ViewModels.Contracts;

namespace BlazorServerSide.Controls
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
        protected bool AddArtistDetails { get; set; } = false;

        [Parameter]
        public bool Visible { get; set; } = false;

        protected List<IAlbumViewModel> albumList;
        protected List<IArtistViewModel> artistList;

        [Inject]
        public NavigationManager UriHelper { get; set; }
        [Inject]
        public IArtistWorkflow ArtistWorkflow { get; set; }
        [Inject]
        public IAlbumWorkflow AlbumWorkflow { get; set; }
        [Inject]
        public ISongWorkflow SongWorkflow { get; set; }

        public void HideWindow()
        {
            Visible = false;

            SongName = string.Empty;
            AlbumName = string.Empty;
            ArtistName = string.Empty;
            ReleaseDate = string.Empty;
            LinkYT = string.Empty;
            LinkSP = string.Empty;
            Cover = string.Empty;
        }     

        protected override void OnInitialized()
        {
            albumList = AlbumWorkflow.GetAllAlbums();
            artistList = ArtistWorkflow.GetAllArtists();
        }

        protected void CheckBoxChangeHandler(bool checkBoxValue)
        {
            if (checkBoxValue)
            {
                AddArtistDetails = true;
            }
        }

        protected void AlbumDropdownOnChangeHandler(object theUserInput)
        {
            try
            {
                var existingAlbum = AlbumWorkflow.GetAlbumByName(theUserInput as string);
                Cover = existingAlbum.ImageUrl;
                ReleaseDate = existingAlbum.ReleaseDate.ToString();
            }
            catch (Exception)
            {

            }
        }

        public void AddSong()
        {

            Visible = false;
            var albumExist = AlbumWorkflow.GetAlbumByName(AlbumName);
            if (albumExist == null)
            {
                var album = new AlbumViewModel
                {
                    Name = AlbumName,
                    ImageUrl = Cover,
                    ReleaseDate = DateTime.Parse(ReleaseDate)
                };
                AlbumWorkflow.CreateAlbum(album);
            }


            var artistExist = ArtistWorkflow.GetArtistByName(ArtistName);
            if (artistExist == null)
            {
                var artist = new ArtistViewModel()
                {
                    Name = ArtistName,
                }; 
                ArtistWorkflow.CreateArtist(artist);
            }

            var song = new SongViewModel()
            {
                Name = SongName,
                LinkYT = LinkYT,
                LinkSptfy = LinkSP,
                Album = AlbumWorkflow.GetAlbumByName(AlbumName),
                Artist = ArtistWorkflow.GetArtistByName(ArtistName)
            };
            SongWorkflow.CreateSong(song, AlbumWorkflow.GetAlbumIdByName(AlbumName), ArtistWorkflow.GetArtistIdByName(ArtistName));

            UriHelper.NavigateTo("/songlist", true);
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
            LinkYT = Value.Substring(Value.IndexOf("www.youtube.com/watch?v=") + 24);
        }
        protected void LinkSPValueChanged(string Value)
        {
            LinkSP = Value.Substring(Value.IndexOf("track/") + 6);
        }
        protected void ClickHandler(string Value)
        {
            Cover = Value;
        }
        protected void ReleaseDateValueChanged(string Value)
        {
            ReleaseDate = Value;
        }
    }
}
