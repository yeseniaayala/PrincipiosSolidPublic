using DIP_Dependency_Inversion_principle.Ejemplo_bueno.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Dependency_Inversion_principle.Ejemplo_bueno
{
    public interface ISopaIngredientes
    {
        List<Ingredientes> SopaArrozIngredientes();

        List<Ingredientes> SopaAjiacoIngredientes();
    }
}
