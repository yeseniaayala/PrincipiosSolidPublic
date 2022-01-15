using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_PrincipioAbiertoCerrado
{
    public class EnumTipoAnimal
    {
        public List<string> Value { get; set; }
        

        private EnumTipoAnimal(List<string> value)
        {
            Value = value;
        }

        public static EnumTipoAnimal TipoAnimal { get { return new EnumTipoAnimal(new List<string>() { "Carnivoros", "Herbivoros", "Omnivoros" }); } }


    }
}
