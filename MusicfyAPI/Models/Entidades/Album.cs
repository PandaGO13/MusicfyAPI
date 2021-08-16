using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicfyAPI.Models.Entidades
{
    public class Album
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength:50, ErrorMessage = "El campo {0} debe tener como máximo 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength:50, ErrorMessage = "El campo {0} debe tener como máximo 50 caracteres")]
        public string Artista { get; set; }

        [Display(Name="Año")]
        [Range(2010, 2021, ErrorMessage = "El campo {0} debe tener un valor entre 2010 y 2021")]
        public int Year { get; set; }

        public string Imagen { get; set; }
        
        public bool isDeleted { get; set; }
    }
}
