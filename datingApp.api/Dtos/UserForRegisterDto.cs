﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace datingApp.api.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(16, MinimumLength =8 ,ErrorMessage ="You mast specify password between 8 and 16 characters.")]
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }
    }

}
