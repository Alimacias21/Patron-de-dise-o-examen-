using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseño_Examen2P_AliMacias
{
    class Streamer : ISujetoStreamer
    {
        //8. se crea la clase Streamer la cual hereda a la interfaz ISujetoStreamer


        //9. se crean las propiedades del streamer
        public string NombreStreamer { get; set; }


        private string UltimaTransmision = "";


        //10. se crea la lista donde se guardaran los seguidores
        private List<IObservadorSeguidor> seguidores = new List<IObservadorSeguidor>();


        //11. se le da funcionalidad al metodo Add
        public void Add(IObservadorSeguidor seguidor)
        {
            seguidores.Add(seguidor);
            Console.WriteLine($"{seguidor.ToString()} comenzó a seguir a {NombreStreamer}");
        }


        //12. se le da funcionalidad al metodo Remove
        public void Remove(IObservadorSeguidor seguidor)
        {
            seguidores.Remove(seguidor);
            Console.WriteLine($"{seguidor.ToString()} dejó de seguir a {NombreStreamer}");
        }



        //13. se le da funcionalidad al metodo Notify
        //  Por cada seguidor en la lista se llama al metodo Update
        public void Notify()
        {

            foreach (var item in seguidores)
            {
                item.Update();
            }

        }



        //14. se crea un nuevo metodo el cual pide el titulo de la nueva transmision y a su vez llama al metodo notify
        public void NuevaTransmision(string titulo)
        {
            this.UltimaTransmision = titulo;
            this.Notify();

        }



        //15. Se crea un nuevo metodo el cual retorna el nombre de la ultima trasnmision emitida
        public string UltimaTransmisionEmitida()
        {
            return this.UltimaTransmision;
        }




        

    }
}
