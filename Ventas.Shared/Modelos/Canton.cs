using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Shared.Modelos
{
    public class Canton
    {
        public int Id { get; set; }

        [Display(Name = "Cantón")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener un máximo de {1} carácteres")]
        public string Nombre { get; set; } = null!;

        public Provincia? Provincia { get; set; }

        public ICollection<Distrito>? Distritos { get; set; }

        [Display(Name = "Distritos")]
        public int NumeroDistritos => Distritos == null ? 0 : Distritos.Count();

        public int ProvinciaId { get; set; }
    }
}
