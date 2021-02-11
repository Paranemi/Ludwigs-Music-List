using Microsoft.AspNetCore.Components;
using MusicListWorkflow.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using ViewModels.Contracts;

namespace BlazorServerSide.Pages
{
    public class LikedSongsBase : ComponentBase
    {
        public Guid UserId { get; set; }

        protected bool IsLikedbyUser { get; set; } = true;

        [Inject]
        public NavigationManager UriHelper { get; set; }
        [Inject]
        protected GlobalVariables GlobalVariables { get; set; }
        [Inject]
        public ILikedSongWorkflow LikedSongWorkflow { get; set; }
        [Inject]
        public IUserWorkflow UserWorkflow { get; set; }

        protected List<ILikedSongViewModel> userSongs;

        [Parameter]
        public string ActiveUser { get; set; }

        protected override void OnInitialized()
        {
            ActiveUser = GlobalVariables.ActiveUser;
            // usersongs = Db.LikedSong.Where(a => a.UserId == UserId).ToList();
            
            var user = UserWorkflow.GetUserByName(ActiveUser);
            UserId = user.UserId;
            userSongs = LikedSongWorkflow.GetLikedSongsByUserId(UserId);
        }

        protected void ChangeHandler(bool value, Guid songId)
        {
            if (!value)
            {
                LikedSongWorkflow.DeleteLikedSongBySongId(songId);
                UriHelper.NavigateTo(UriHelper.Uri, true);
            }
        }
    }
}
