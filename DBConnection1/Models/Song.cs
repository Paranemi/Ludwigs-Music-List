﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBConnection1.Models
{
    [Table("Songs")]
    public class Song
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LinkSptfy { get; set; }
        public string LinkYT { get; set; }
    }
}