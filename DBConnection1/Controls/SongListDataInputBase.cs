using BlazorServerSide.Shared;
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
        [Parameter]
        public Guid SongId { get; set; }
        //protected string AlbumName { get; set; }
        //protected string ArtistName { get; set; }
        //protected string ReleaseDate { get; set; }
        //protected string LinkYT { get; set; }
        //protected string LinkSP { get; set; }
        //protected string Cover { get; set; }
        protected bool AddArtistDetails { get; set; } = false;

        [Parameter]
        public bool Visible { get; set; } = false;

        protected List<IAlbumViewModel> albumList;
        protected List<IArtistViewModel> artistList;

        protected Validation Song { get; set; } = new Validation();

        [Inject]
        public NavigationManager UriHelper { get; set; }
        [Inject]
        public IArtistWorkflow ArtistWorkflow { get; set; }
        [Inject]
        public IAlbumWorkflow AlbumWorkflow { get; set; }
        [Inject]
        public ISongWorkflow SongWorkflow { get; set; }


        protected override void OnInitialized()
        {

            albumList = AlbumWorkflow.GetAllAlbums();
            artistList = ArtistWorkflow.GetAllArtists();

            if(SongId != Guid.Empty)
            {
                var songToEdit = SongWorkflow.GetSongById(SongId);

                Song.SongName = songToEdit.Name;
                Song.AlbumName = songToEdit.Album.Name;
                Song.ArtistName = songToEdit.Artist.Name;
                Song.ReleaseDate = songToEdit.Album.ReleaseDate.ToShortDateString();
                Song.LinkYT = songToEdit.LinkYT;
                Song.LinkSptfy = songToEdit.LinkSptfy;
                Song.AlbumImageUrl = songToEdit.Album.ImageUrl;
            }
            
        }

        public void HideWindow()
        {
            Visible = false;

            Song.SongName = string.Empty;
            Song.AlbumName = string.Empty;
            Song.ArtistName = string.Empty;
            Song.ReleaseDate = string.Empty;
            Song.LinkYT = string.Empty;
            Song.LinkSptfy = string.Empty;
            Song.AlbumImageUrl = string.Empty;
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
                if(existingAlbum != null)
                {
                    Song.AlbumImageUrl = existingAlbum.ImageUrl;
                    Song.ReleaseDate = existingAlbum.ReleaseDate.ToShortDateString();
                    
                }
                
            }
            catch (Exception)
            {

            }
        }

        protected void AddSong()
        {
            if (!string.IsNullOrEmpty(Song.SongName) && !string.IsNullOrEmpty(Song.AlbumName) && !string.IsNullOrEmpty(Song.ArtistName) 
                && !string.IsNullOrEmpty(Song.AlbumImageUrl) && !string.IsNullOrEmpty(Song.ReleaseDate) && !string.IsNullOrEmpty(Song.LinkYT)
                 && !string.IsNullOrEmpty(Song.LinkSptfy))
            {
                Visible = false;
                var albumExist = AlbumWorkflow.GetAlbumByName(Song.AlbumName);
                if (albumExist == null)
                {
                    var album = new AlbumViewModel
                    {
                        Name = Song.AlbumName,
                        ImageUrl = Song.AlbumImageUrl,
                        ReleaseDate = DateTime.Parse(Song.ReleaseDate)
                    };
                    AlbumWorkflow.CreateAlbum(album);
                }


                var artistExist = ArtistWorkflow.GetArtistByName(Song.ArtistName);
                if (artistExist == null)
                {
                    var artist = new ArtistViewModel()
                    {
                        Name = Song.ArtistName,
                    }; 
                    ArtistWorkflow.CreateArtist(artist);
                }

                var song = new SongViewModel()
                {
                    Name = Song.SongName,
                    LinkYT = Song.LinkYT.Substring(Song.LinkYT.IndexOf("www.youtube.com/watch?v=") + 24),
                    LinkSptfy = Song.LinkSptfy.Substring(Song.LinkSptfy.IndexOf("track/") + 6),
                    Album = AlbumWorkflow.GetAlbumByName(Song.AlbumName),
                    Artist = ArtistWorkflow.GetArtistByName(Song.ArtistName)
                };
                SongWorkflow.CreateSong(song, AlbumWorkflow.GetAlbumIdByName(Song.AlbumName), ArtistWorkflow.GetArtistIdByName(Song.ArtistName));

                UriHelper.NavigateTo("/songlist", true);
            }      
        }

        protected void UpdateSong()
        {
            if (!string.IsNullOrEmpty(Song.SongName) && !string.IsNullOrEmpty(Song.AlbumName) && !string.IsNullOrEmpty(Song.ArtistName)
                && !string.IsNullOrEmpty(Song.AlbumImageUrl) && !string.IsNullOrEmpty(Song.ReleaseDate) && !string.IsNullOrEmpty(Song.LinkYT)
                 && !string.IsNullOrEmpty(Song.LinkSptfy))
            {
                Visible = false;
                var albumExist = AlbumWorkflow.GetAlbumByName(Song.AlbumName);
                if (albumExist == null)
                {
                    var album = new AlbumViewModel
                    {
                        Name = Song.AlbumName,
                        ImageUrl = Song.AlbumImageUrl,
                        ReleaseDate = DateTime.Parse(Song.ReleaseDate)
                    };
                    AlbumWorkflow.CreateAlbum(album);
                }


                var artistExist = ArtistWorkflow.GetArtistByName(Song.ArtistName);
                if (artistExist == null)
                {
                    var artist = new ArtistViewModel()
                    {
                        Name = Song.ArtistName,
                    };
                    ArtistWorkflow.CreateArtist(artist);
                }

                var song = new SongViewModel()
                {
                    SongId = SongId,
                    Name = Song.SongName,
                    LinkYT = Song.LinkYT,
                    LinkSptfy = Song.LinkSptfy,
                    Album = AlbumWorkflow.GetAlbumByName(Song.AlbumName),
                    AlbumId = AlbumWorkflow.GetAlbumIdByName(Song.AlbumName),
                    Artist = ArtistWorkflow.GetArtistByName(Song.ArtistName),
                    ArtistId = ArtistWorkflow.GetArtistIdByName(Song.ArtistName)
                    
                };
                SongWorkflow.UpdateSong(song);

                UriHelper.NavigateTo("/songlist", true);
            }
        }

        protected void SongNameValueChanged(string Value)
        {
            Song.SongName = Value;
        }
        protected void AlbumNameValueChanged(string Value)
        {
            Song.AlbumName = Value;
        }
        protected void ArtistNameValueChanged(string Value)
        {
            Song.ArtistName = Value;
        }
        protected void LinkYTValueChanged(string Value)
        {
            Song.LinkYT = Value;
        }
        protected void LinkSPValueChanged(string Value)
        {
            Song.LinkSptfy = Value;
        }
        protected void ClickHandler(string Value)
        {
            Song.AlbumImageUrl = Value;
        }
        protected void ReleaseDateValueChanged(string Value)
        {
            Song.ReleaseDate = Value;
        }
    }
}
