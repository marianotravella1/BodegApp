﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class CredentialsDto
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        [MinLength(8)]
        public string? Password { get; set; }
    }
}
