using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrincipiosSOLID.Models;
using PrincipiosSOLID.Repository;
using PrincipiosSOLID.Utilities;

namespace PrincipiosSOLID.Service
{
    public class JugadorService
    {
        private readonly JugadorRepository _jugadorRepository;
        private readonly EnvioCorreo _envioCorreo;
        private readonly EnvioMensajeTexto _envioMensajeTexto;

        public JugadorService(JugadorRepository jugadorRepository, EnvioCorreo envioCorreo, EnvioMensajeTexto envioMensajeTexto)
        {
            _jugadorRepository = jugadorRepository;
            _envioCorreo = envioCorreo;
            _envioMensajeTexto = envioMensajeTexto;
        }

        //Crear Jugador y Notificarlo
        public JugadorModel InsertarJugador(JugadorModel jugadorModel, NotificacionModel notificacionModel)
        {
            if (jugadorModel != null)
            {
                JugadorModel jugadorModel1 =
                 _jugadorRepository.InsertarJugador(jugadorModel);                

                if ( !string.IsNullOrEmpty(notificacionModel.Correo))
                {
                    _envioCorreo.EnviarCorreo(notificacionModel);
                }
                
                if ( notificacionModel.NumeroCelular > 0)
                {
                    _envioMensajeTexto.EnviarMensajeTexto(notificacionModel);
                }

                return jugadorModel1;
            }
            return null;
        }
    }
}
