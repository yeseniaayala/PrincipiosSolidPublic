using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Liskov_Substitution_Principle.Animales
{
    public class Tigre : AnimalesGeneral
    {
        public void caracteristicas()
        {
            raza = "Vengala";
            comida = new string[2] { "Venado", "Kanguro" };
            tipoAnimal = "Vertebrado";

            dormir();
            cazar();
            comer();
            criar();
            jugar();           
            
        }
       
    }
}
