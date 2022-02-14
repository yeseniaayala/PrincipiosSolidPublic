using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_PrincipioAbiertoCerrado
{
    public class EnumTipoAlimentos
    {
        public List<string> Value { get; set; }
        public TipoAnimal TipoAnimal { get; set; }


        private EnumTipoAlimentos(TipoAnimal tipoAnimal, List<string> value)
        {
            Value = value;
            TipoAnimal = tipoAnimal;
        }

        public static EnumTipoAlimentos AlimentosCarnivoros { get { return new EnumTipoAlimentos(TipoAnimal.carnivoro,  new List<string> { "Carne", "Animales vivos" }); } }

        public static EnumTipoAlimentos AlimentosHerbivoros { get { return new EnumTipoAlimentos(TipoAnimal.herbivoro, new List<string> { "Hierbas", "Plantas", "Pasto" }); } }

        public static EnumTipoAlimentos AlimentosOmnivoros { get { return new EnumTipoAlimentos(TipoAnimal.omnivoro, new List<string> { "Animales", "Plantas"}); } }
                
    }
}
