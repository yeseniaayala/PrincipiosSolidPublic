using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_PrincipioAbiertoCerrado
{
    public class Alimentacion
    {

        public EnumTipoAlimentos GetAlimentacion( CaracteristicasAnimales caracteristicasAnimales)
        {
            if (caracteristicasAnimales.TipoAnimal == TipoAnimal.carnivoro)
            {
                return EnumTipoAlimentos.AlimentosCarnivoros;
            }

            if (caracteristicasAnimales.TipoAnimal == TipoAnimal.herbivoro)
            {
                return EnumTipoAlimentos.AlimentosHerbivoros;
            }

            if (caracteristicasAnimales.TipoAnimal == TipoAnimal.omnivoro)
            {
                return EnumTipoAlimentos.AlimentosOmnivoros;
            }

            return null;
        }
    }
}
