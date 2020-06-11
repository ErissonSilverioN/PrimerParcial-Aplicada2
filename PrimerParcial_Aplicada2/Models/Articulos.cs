using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial_Aplicada2.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }

        [Required(ErrorMessage ="Este Campo es Obligatorio")]
        public string Descripcion { get; set; }

        [Range(minimum:1,maximum:100,ErrorMessage ="El Maximo es 100")]
        public int Existencia { get; set; }
        public decimal Costo  { get; set; }
        public decimal ValorInventario { get; set; }

        public Articulos()
        {
            ArticuloId = 0;
            Descripcion = string.Empty;
            Existencia = 0;
            Costo = 0;
            ValorInventario = 0;
        }
    }
}
