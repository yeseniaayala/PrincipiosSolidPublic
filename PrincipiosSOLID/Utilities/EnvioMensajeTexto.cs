using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrincipiosSOLID.Models;

namespace PrincipiosSOLID.Utilities
{
    public class EnvioMensajeTexto
    {
        //Enviar Notificación por mensaje de texto
        public string EnviarMensajeTexto(NotificacionModel notificacionModel)
        {
            if (notificacionModel.NumeroCelular > 0)
            {
                //envío de mensaje
                return "El mensaje se envió exitosanente";
            }
            return null;
        }
    }
}
