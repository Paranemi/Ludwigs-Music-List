using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkRepository.EFModels
{
    [Table("Users")]
    public class UserEntityModel
    {
        [Key]
        public Guid UserId { get; set; }

        [MaxLength(15)]
        [Required(ErrorMessage = "user name is required")]
        public string UserName { get; set; }

        [MaxLength(40)]
        [Required(ErrorMessage = "password is required")]
        public string Password { get; set; }

        [MaxLength(40)]
        public string SecurityAnswer { get; set; }

    }
}
