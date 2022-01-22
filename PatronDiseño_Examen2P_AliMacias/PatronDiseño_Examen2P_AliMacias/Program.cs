using System;
using System.Linq;

namespace PatronDiseño_Examen2P_AliMacias
{
    class Program
    {
        static void Main(string[] args)
        {

            //16. se crea un objeto de tipo streamer con su nombre
            Streamer streamer = new Streamer();
            streamer.NombreStreamer = "alimacias21";


            //17. se crean 3 objetos de tipo seguidor con sus nombres
            Seguidor seguidor = new Seguidor(streamer);
            Seguidor seguidor1 = new Seguidor(streamer);
            Seguidor seguidor2 = new Seguidor(streamer);
            seguidor.NombreSeguidor = "OpyMonkey69";
            seguidor1.NombreSeguidor = "lopezbriones";
            seguidor2.NombreSeguidor = "Daza2581";


            //18. se agregan los seguidores usando el metodo Add
            streamer.Add(seguidor);
            streamer.Add(seguidor1);
            streamer.Add(seguidor2);

            Console.WriteLine("\n");


            //19. Se hace una nueva transmision
            //  Debe mostrar 3 notificaciones
            streamer.NuevaTransmision("Directo 24 horas jugando candy crush");

            Console.WriteLine("\n");


            //20. Se elimina un seguidor
            streamer.Remove(seguidor1);

            Console.WriteLine("\n");


            //21. Se hace una nueva transmision
            //  Debe mostrar 2 notificaciones 
            streamer.NuevaTransmision("Anuncio mi skin en Clash Royale");

            Console.WriteLine("\n");


            //22. Se hace una nueva transmision
            //  Debe mostrar 2 notificaciones
            streamer.NuevaTransmision("Si me río pierdo plata");

        }
    }
}
