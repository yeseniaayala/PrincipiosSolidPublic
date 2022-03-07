using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Dependency_Inversion_principle.Ejemplo_malo
{
    //clase de alto nivel
    public class PrepararSopa
    {
        public void PrepararSopaArroz()
        {
            SopaIngredientes sopaIngredientes = new SopaIngredientes();
            List<string> ingredientes = sopaIngredientes.IngredientesSopa();

            //TODO preparar sopa arroz
        }

        public void PrepararSopaAjiaco()
        {
            SopaIngredientes sopaIngredientes = new SopaIngredientes();//Estos ingredientes son solo para sopa de arroz
            List<string> ingredientes = sopaIngredientes.IngredientesSopa();

            //TODO preparar sopa de Ajiaco
        }
    }
}
