using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseño_Examen2P_AliMacias
{
    interface ISujetoStreamer
    {

        //1. Se crea la interfaz del sujeto con sus metodos base
        //  Un metodo para agregar observadores (Add)
        //  Un metodo para remover observadores (Remove)
        //  Un metodo para notificar a los observadores (Notify)

        void Add(IObservadorSeguidor seguidor);

        void Remove(IObservadorSeguidor seguidor);

        void Notify();

    }
}
