﻿using DBConnection1.Data;
using DBConnection1.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using Telerik.Blazor.Components;

namespace DBConnection1.Pages
{
    public class SonglistBase : ComponentBase
    {
        protected bool SongListInput { get; set; } = false;
        [Inject]
        public AppDataContext Db { get; set; }
        protected List<Song> songlist;

        protected override void OnInitialized()
        {
            songlist = Db.Song.ToList();
        }

    }
}

