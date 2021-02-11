using Microsoft.AspNetCore.Components;
using MusicListWorkflow.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using ViewModels;
using ViewModels.Contracts;

namespace BlazorServerSide.Pages
{
    public class SonglistBase : ComponentBase
    {
        protected bool edit { get; set; } = false;
        public Guid SongIdToEdit { get; set; }

        protected bool IsLikedbyUser { get; set; }

        protected List<ISongViewModel> songlist;
        protected List<ILikedSongViewModel> userSongs;

        [Inject]
        public NavigationManager UriHelper { get; set; }
        [Inject]
        public GlobalVariables globalVariables { get; set; }
        [Inject]
        public ISongWorkflow SongWorkflow { get; set; }
        [Inject]
        public ILikedSongWorkflow LikedSongWorkflow { get; set; }
        [Inject]
        public IUserWorkflow UserWorkflow { get; set; }

        protected override void OnInitialized()
        {
            songlist = SongWorkflow.GetAllSongs();
            var user = UserWorkflow.GetUserByName(globalVariables.ActiveUser);
            userSongs = LikedSongWorkflow.GetLikedSongsByUserId(user.UserId);
        }

        protected void ChangeHandler(bool value, Guid songId)
        {
            if (value)
            {          

                var likedSong = new LikedSongViewModel()
                {
                    User = UserWorkflow.GetUserByName(globalVariables.ActiveUser),
                    Song = SongWorkflow.GetSongById(songId)
                };
                LikedSongWorkflow.CreateLikedSong(likedSong);
                UriHelper.NavigateTo(UriHelper.Uri, true);
            }
        }
    }
}

