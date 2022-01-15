using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrincipiosSOLID.Models;

namespace PrincipiosSOLID.Repository
{
    public class JugadorRepository
    {
        //Insertar jugador
        public JugadorModel InsertarJugador(JugadorModel jugadorModel)
        {
            JugadorModel jugadorModel1 = new JugadorModel()
            {
                JugadorId = 1,
                EquipoId = null,
                Nombre = "Jugador 1"
            };

            return jugadorModel1;
        }
    }
}
