using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViewModels.Contracts;

namespace ViewModels
{
    public class UserViewModel : IUserViewModel
    {
        public Guid UserId { get; set; }
        [Required(ErrorMessage = "user name is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "password is required")]
        public string Password { get; set; }
        public string SecurityAnswer { get; set; }

    }
}
