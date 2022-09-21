﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace maisumdenovo.Models
{
    public class Pessoa
    {
        [Required]
        public int id { get; set; }
        public string nome { get; set; }
    }
}
