using Microsoft.AspNetCore.Components;
using MusicListWorkflow.Contracts;
using System;
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

        protected void CheckBoxChangeHandler(bool checkBoxValue)
        {
            if (checkBoxValue)
            {
                AddArtistDetails = true;
            }
        }

        public void AddSong()
        {

            Visible = false;


            //var album = new AlbumViewModel()
            //{
            //    Name = AlbumName,
            //    ImageUrl = Cover,
            //    ReleaseDate = DateTime.Parse(ReleaseDate),
            //};
            //AlbumWorkflow.CreateAlbum(album);

            //var artist = new ArtistViewModel()
            //{
            //    Name = ArtistName,

            //};

            //if (!AddArtistDetails)
            //{
            //    ArtistWorkflow.CreateArtist(artist);
            //}

            //var song = new SongViewModel()
            //{
            //    Name = SongName,
            //    LinkYT = LinkYT,
            //    LinkSptfy = LinkSP,
            //    Album = AlbumWorkflow.GetAlbumByName(AlbumName),
            //    Artist = ArtistWorkflow.GetArtistByName(ArtistName)
            //};
            //SongWorkflow.CreateSong(song, album, artist);
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
