using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrincipiosSOLID.Models
{
    public class JugadorModel
    {
        public int JugadorId { get; set; }

        public string Nombre { get; set; }

        public int? EquipoId { get; set; }
    }
}
