using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.DTOs
{
    public class PeliculaDTO
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public string Resumen { get; set; }
        public string Trailer { get; set; }
        public bool EnCines { get; set; }
        public DateTime FechaDeLanzamiento { get; set; }
        public string Poster { get; set; }
        public List<GeneroDTO> Generos { get; set; }
        public List<CineDTO> Cines { get; set; }
        public List<PeliculaActorDTO> Actores { get; set; }
    }
}
