using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Dependency_Inversion_principle.Ejemplo_malo
{
    public class SopaIngredientes
    {
        List<string> Ingredientes = new List<string>(){"Papa","Arroz", "Papa criolla","Zanahoria", "Alberja"};


        public List<string> IngredientesSopa()
        {
            return Ingredientes;
        }
    }
}
