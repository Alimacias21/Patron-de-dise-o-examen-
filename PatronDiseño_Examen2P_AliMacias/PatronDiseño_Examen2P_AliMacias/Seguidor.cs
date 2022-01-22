using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseño_Examen2P_AliMacias
{
    class Seguidor : IObservadorSeguidor
    {

        //3. Se crea la clase Seguidor la cual hereda a la interfaz IObservadorSeguidor


        //4. Se crean las propiedades de un seguidor
        public string NombreSeguidor { get; set; }

        private Streamer streamer = null;



        //5. En el constructor cada seguidor tendra que recibir un streamer
        public Seguidor(Streamer streamer)
        {
            this.streamer = streamer;
        }


        //6. Se le da funcionalidad al metodo Update
        //  Cada que se llame al metodo mandara un mensaje
        public void Update()
        {
            Console.WriteLine($"Ponte pilas {NombreSeguidor}, {streamer.NombreStreamer} está en directo. {streamer.UltimaTransmisionEmitida()}");
            
        }

        //7. con el override ToString imprimira los valores sin ningun problema
        public override string ToString()
        {
            return NombreSeguidor;
        }
    }
}
