using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Interface_Segregation_Principle.Enums
{
    public enum EnumTipoMaritimo
    {
        BuqueCargaGeneral,
        BuqueRefrigerados,
        BuqueGanado,
        BuquePetrolero,
        BuquePortacontenedores
    }

    public enum EnumTipoTerrestre
    {
        Camion,
        Tractocamion,
        CamionRefrigerado,
        CamionTolva,
        CamionCisterna,
        CamionJaula
    }

    public enum EnumTipoAereo
    {
        AvionMixto,
        AvionCarga,
        SuperTransportes
    }
}
