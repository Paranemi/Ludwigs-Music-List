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
        public bool isSelected { get; set; } = true;
        [Parameter]
        public string ActiveUser { get; set; } = "Ludwig";
        public Guid UserId { get; set; }
        [Inject]
        protected AppDataContext Db { get; set; }
        protected List<LikedSong> usersongs;
        protected List<Song> songlist;
        protected List<User> usr;

        protected override void OnInitialized()
        {
            usr = Db.User.Where(e => e.UserName.Contains(ActiveUser)).ToList();
            foreach(var userdetails in usr)
            {
                UserId = userdetails.UserId;
            }
            usersongs = Db.LikedSong.Where(a => a.UserId == UserId).ToList();


            int bla;
        }

    
    
    }
}
