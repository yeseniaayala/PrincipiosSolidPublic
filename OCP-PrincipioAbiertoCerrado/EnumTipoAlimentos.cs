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
        public string TipoAnimal { get; set; }


        private EnumTipoAlimentos(string tipoAnimal, List<string> value)
        {
            Value = value;
            TipoAnimal = tipoAnimal;
        }

        public static EnumTipoAlimentos AlimentosCarnivoros { get { return new EnumTipoAlimentos(EnumTipoAnimal.TipoAnimal.Value[0],  new List<string> { "Carne", "Animales vivos" }); } }

        public static EnumTipoAlimentos AlimentosHerbivoros { get { return new EnumTipoAlimentos(EnumTipoAnimal.TipoAnimal.Value[1], new List<string> { "Hierbas", "Plantas", "Pasto" }); } }

        public static EnumTipoAlimentos AlimentosOmnivoros { get { return new EnumTipoAlimentos(EnumTipoAnimal.TipoAnimal.Value[2], new List<string> { "Animales", "Plantas"}); } }
                
    }
}
