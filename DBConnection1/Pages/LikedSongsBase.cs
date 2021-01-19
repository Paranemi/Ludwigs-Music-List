using DBConnection1.Data;
using DBConnection1.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBConnection1.Pages
{
    public class LikedSongsBase : ComponentBase
    {
        public Guid UserId { get; set; }
        [Inject]
        protected AppDataContext Db { get; set; }
        [Inject]
        protected GlobalVariables GlobalVariables { get; set; }
        protected List<LikedSong> usersongs;
        protected List<User> usr;

        [Parameter]
        public string ActiveUser { get; set; }

        protected override void OnInitialized()
        {
            ActiveUser = GlobalVariables.ActiveUser;
            usr = Db.User.Where(e => e.UserName.Contains(ActiveUser)).ToList();
            foreach(var userdetails in usr)
            {
                UserId = userdetails.UserId;
            }
            usersongs = Db.LikedSong.Where(a => a.UserId == UserId).ToList();

        }

    
    
    }
}
