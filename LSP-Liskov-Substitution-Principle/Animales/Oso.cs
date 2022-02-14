using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Liskov_Substitution_Principle.Animales
{
    public class Oso : AnimalesHibernan
    {
        public void caracteristicas()
        {
            raza = "Polar";
            comida = new string[2] { "Focas", "Pescados" };
            tipoAnimal = "Vertebrado";

            dormir();
            hibernar();
            cazar();
            comer();
            criar();
            jugar();
        }
    }
}
