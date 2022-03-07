using System;
using ISP_Interface_Segregation_Principle.Enums;
using ISP_Interface_Segregation_Principle.Interfaces;

namespace ISP_Interface_Segregation_Principle
{
    public class TransporteGanado : IMaritimo
    {
        public string CapacidadCarga { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string flexibilidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public EnumTipoMaritimo Tipo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
