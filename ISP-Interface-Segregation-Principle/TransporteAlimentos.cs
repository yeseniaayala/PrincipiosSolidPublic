using System;
using ISP_Interface_Segregation_Principle.Enums;
using ISP_Interface_Segregation_Principle.Interfaces;

namespace ISP_Interface_Segregation_Principle
{
    public class TransporteAlimentos : ITerrestre
    {
        string ITerrestre.CapacidadCarga { get => "10"; set => throw new NotImplementedException(); }
        string ITerrestre.flexibilidad { get => "Flexibilidad"; set => throw new NotImplementedException(); }
        EnumTipoTerrestre ITerrestre.Tipo { get => EnumTipoTerrestre.Camion; set => throw new NotImplementedException(); }
    }
}
