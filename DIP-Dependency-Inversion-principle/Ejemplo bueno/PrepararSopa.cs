using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP_Dependency_Inversion_principle.Ejemplo_bueno;
using DIP_Dependency_Inversion_principle.Ejemplo_bueno.Entities;

namespace DIP_Dependency_Inversion_principle.Ejemplo_bueno
{
    public class PrepararSopa: SopaIngredientes
    {
        public void PrepararAjiaco()
        {
            List<Ingredientes> ingredientes = SopaAjiacoIngredientes();

            //TODO preparar sopa Ajiaco
        }

        public void PrepararSopaArroz()
        {
            List<Ingredientes> ingredientes = SopaArrozIngredientes();

            //TODO preparar sopa de Arroz
        }
    }
}
