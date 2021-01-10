using Microsoft.AspNetCore.Components;

namespace DBConnection1.Pages
{
    public class SongDetailsBase : ComponentBase
    {
        [Parameter]
        public string SongName { get; set; }
        [Parameter] 
        public string AlbumName { get; set; }
        [Parameter] 
        public string ArtistName { get; set; }
        [Parameter] 
        public string LinkYT { get; set; }
        [Parameter]
        public string LinkSP { get; set; }
        [Parameter] 
        public string Cover { get; set; }
    }
}
