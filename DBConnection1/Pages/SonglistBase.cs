using Microsoft.AspNetCore.Components;
using MusicListWorkflow.Contracts;
using System.Collections.Generic;
using System.Linq;
using ViewModels;
using ViewModels.Contracts;

namespace BlazorServerSide.Pages
{
    public class SonglistBase : ComponentBase
    {
        protected bool SongListInput { get; set; } = false;

        protected List<ISongViewModel> songlist;

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
        }

        protected string bindingvalue;
        protected void ChangeHandler(bool value, string songName)
        {
            if (value)
            {          

                var likedSong = new LikedSongViewModel()
                {
                    User = UserWorkflow.GetUserByName(globalVariables.ActiveUser),
                    Song = SongWorkflow.GetSongByName(songName)
                };
                LikedSongWorkflow.CreateLikedSong(likedSong);

                bindingvalue = songName;
            }
            else
            {
                bindingvalue = "";
            }

        }
    }
}

