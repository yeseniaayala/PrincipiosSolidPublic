using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Liskov_Substitution_Principle.Animales
{
    public class Delfin : AnimalesNoDuermen
    {
        public void caracteristicas()
        {
            raza = "Rosado";
            comida = new string[2] { "", "" };
            tipoAnimal = "Vertebrado";

            cazar();
            comer();
            criar();
            jugar();
        }
    }
}
