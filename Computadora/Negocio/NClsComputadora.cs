using Computadora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Negocio
{

    class NClsComputadora
    {
        public String Encender(ClsComputadora computadora)  
        {
            return "La computadora con memoria ram de " + computadora.Ram1 + "Con procesador " + computadora.Procesador + "Esta encendida";
            
    
            }
        public String Actualizar(ClsComputadora computadora)
        {
            return "La computadora con memoria ram de" + computadora.Ram1 + "Con procesador" + computadora.Procesador + "Se esta actualizando";

        }
        public String Reiniciar(ClsComputadora computadora)
        {
            return "La computadora con memoria ram de" + computadora.Ram1 + "Con procesador" + computadora.Procesador + "Se esta reiniciando ";

        }
        public String Apagar(ClsComputadora computadora)
        {
            return "La computadora con memoria ram de" + computadora.Ram1 + "Con procesador" + computadora.Procesador + "Apagar computadora ";


        }
}
}






