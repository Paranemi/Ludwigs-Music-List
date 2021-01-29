using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using ViewModels.Contracts;

namespace BlazorServerSide.Pages
{
    public class LikedSongsBase : ComponentBase
    {
        public Guid UserId { get; set; }

        [Inject]
        protected GlobalVariables GlobalVariables { get; set; }

        protected List<ILikedSongViewModel> usersongs;

        [Parameter]
        public string ActiveUser { get; set; }

        protected override void OnInitialized()
        {
            ActiveUser = GlobalVariables.ActiveUser;
   //         usersongs = Db.LikedSong.Where(a => a.UserId == UserId).ToList();
        }

    }
}
