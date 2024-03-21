using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Shared.Modelos
{
    public class Distrito
    {
        public int Id { get; set; }

        [Display(Name = "Distrito")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener un máximo de {1} carácteres")]
        public string Nombre { get; set; } = null!;

        public Canton? Canton { get; set; }

        public int CantonId { get; set; }
    }
}
