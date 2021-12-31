﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.Entidades
{
    public class Actor
    {
        public int id { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string Nombre { get; set;}
        public string Biografia { get; set; }
        public string Foto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<PeliculasActores> PeliculasActores { get; set; }


    }
}
