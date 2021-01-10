using DBConnection1.Data;
using DBConnection1.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DBConnection1.Pages
{
    public class SonglistBase : ComponentBase
    {
        [Inject]
        public AppDataContext AppDataContext { get; set; }
        protected List<Song> songlist;

        protected override void OnInitialized()
        {
            songlist = AppDataContext.Song.ToList();
        }
    }
}

