using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicfyAPI.Models.DTO
{
    public class AlbumDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public int Year { get; set; }
        public string Imagen { get; set; }
    }
}
