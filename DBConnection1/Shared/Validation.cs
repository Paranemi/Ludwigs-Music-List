using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerSide.Shared
{
    public class Validation
    {

        //User
        [Required(ErrorMessage = "user name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "security answer is required")]
        public string SecurityAnswer { get; set; }

        //Song
        [Required(ErrorMessage = "song name is required")]
        public string SongName { get; set; }

        [Required(ErrorMessage = "spotify link is required")]
        public string LinkSptfy { get; set; }

        [Required(ErrorMessage = "youtube link is required")]
        public string LinkYT { get; set; }

        //Person
        [Required(ErrorMessage = "first name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "birth date is required")]
        public string Born { get; set; }

        [Required(ErrorMessage = "field is required")]
        public string From { get; set; }

        //Artist
        [Required(ErrorMessage = "artist name is required")]
        public string ArtistName { get; set; }

        [Required(ErrorMessage = "artist image is empty")]
        public string ArtistImageUrl { get; set; }

        [Required(ErrorMessage = "field founding date is empty")]
        public string Founded { get; set; }

        //Album
        [Required(ErrorMessage = "album name is required")]
        public string AlbumName { get; set; }

        [Required(ErrorMessage = "album image is required")]
        public string AlbumImageUrl { get; set; }

        [Required(ErrorMessage = "realease date is required")]
        public string ReleaseDate { get; set; }
    }
}
