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
        public string UserName { get; set; }

        [MaxLength(40)]
        public string Password { get; set; }

        [MaxLength(40)]
        public string SecurityAnswer { get; set; }

    }
}
