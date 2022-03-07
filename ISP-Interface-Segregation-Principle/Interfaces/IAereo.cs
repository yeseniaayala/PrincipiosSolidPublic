﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Interface_Segregation_Principle.Interfaces
{
    public interface IAereo
    {
        public string CapacidadCarga { get; set; }

        public string flexibilidad { get; set; }

        public Enums.EnumTipoAereo Tipo { get; set; }
    }
}
