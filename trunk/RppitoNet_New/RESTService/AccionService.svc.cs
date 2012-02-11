using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RppitoNet.Models;

using System.Messaging;


namespace RESTService
{
    public class AccionService : IAccionService
    {

        public bool PublicaNoticia()
        {
            string cola = ".\\private$\\" + "publicaciones" + "in";

            NoticiaBL modelo = new NoticiaBL();

            if (!MessageQueue.Exists(cola))
                MessageQueue.Create(cola);

            MessageQueue colaOut = new MessageQueue(cola);
            colaOut.Formatter = new XmlMessageFormatter(new Type[] { typeof(NoticiaBE) });

            Message msg = null;

            try
            {
                //while (true)
                //{
                    msg = colaOut.Receive();
                    modelo.Publicacion(((NoticiaBE)msg.Body).IdNoticia);
                //}

                return true;
            }
            catch ( Exception ex)
            {
                return false;
            }

        }
    }
}
