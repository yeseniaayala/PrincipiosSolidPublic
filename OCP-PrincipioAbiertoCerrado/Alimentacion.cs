using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_PrincipioAbiertoCerrado
{
    public class Alimentacion : CaracteristicasAnimales
    {

        public EnumTipoAlimentos GetAlimentacion( CaracteristicasAnimales caracteristicasAnimales)
        {
            if (caracteristicasAnimales.TipoAnimal == EnumTipoAnimal.TipoAnimal.Value[0])
            {
                return EnumTipoAlimentos.AlimentosCarnivoros;
            }

            if (caracteristicasAnimales.TipoAnimal == EnumTipoAnimal.TipoAnimal.Value[1])
            {
                return EnumTipoAlimentos.AlimentosHerbivoros;
            }

            if (caracteristicasAnimales.TipoAnimal == EnumTipoAnimal.TipoAnimal.Value[2])
            {
                return EnumTipoAlimentos.AlimentosOmnivoros;
            }

            return null;
        }
    }
}
