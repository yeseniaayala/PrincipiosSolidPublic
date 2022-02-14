using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrincipiosSOLID.Models;

namespace PrincipiosSOLID.Utilities
{
    public class EnvioCorreo
    {
        //Enviar Notificación por correo
        public string EnviarCorreo(NotificacionModel notificacionModel)
        {
            if (!string.IsNullOrEmpty(notificacionModel.Correo))
            {
                //envío de correo
                return "El correo se envió exitosanente";
            }
            return null;
        }


    }
}
