﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlienspaceBL
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese la categoria")]
        public string Pelicula { get; set; }
    }
}
