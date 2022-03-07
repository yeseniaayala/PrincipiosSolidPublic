using DIP_Dependency_Inversion_principle.Ejemplo_bueno.Entities;
using System.Collections.Generic;

namespace DIP_Dependency_Inversion_principle.Ejemplo_bueno
{
    public class SopaIngredientes : ISopaIngredientes
    {
        private List<Ingredientes> ingredientes;
        public List<Ingredientes> SopaAjiacoIngredientes()
        {
            ingredientes = new List<Ingredientes>(){
                           new Ingredientes() {id = 1, Name = "Papa"},
                           new Ingredientes(){ id = 2, Name = "Arracacha" },
                           new Ingredientes(){ id = 3, Name = "Zanahoria" },
                           new Ingredientes(){ id = 4, Name = "Papa criolla" },
                           new Ingredientes(){ id = 5, Name = "Pollo" },
                           new Ingredientes(){ id = 6, Name = "Alberja"}
            };

            return ingredientes;
        }

        public List<Ingredientes> SopaArrozIngredientes()
        {
            ingredientes = new List<Ingredientes>(){
                           new Ingredientes() {id = 1, Name = "Papa"},
                           new Ingredientes(){ id = 2, Name = "Arroz" },
                           new Ingredientes(){ id = 3, Name = "Zanahoria" },
                           new Ingredientes(){ id = 4, Name = "Papa criolla" },
                           new Ingredientes(){ id = 5, Name = "Alberja" }
            };

            return ingredientes;
        }
    }
}
