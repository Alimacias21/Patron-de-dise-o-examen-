using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseño_Examen2P_AliMacias
{
    interface IObservadorSeguidor
    {
        //2. Se crea la interfaz de observador con su metodo base
        //  El metodo Update actualiza a los observadores cada que el sujeto realiza algun cambio
        void Update();

    }
}
