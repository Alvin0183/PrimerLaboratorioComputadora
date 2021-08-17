using Computadora.Entidades;
using Computadora.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora
{
    class Program
    {

        static void Main(string[] args)
        {
            ClsComputadora clscomputadora = new ClsComputadora();
            NClsComputadora nclscomputadora = new NClsComputadora();

            clscomputadora.Modelo = " DELL";
            clscomputadora.Teclado = " Teclado Mecanico, Ryzen 989. ";
            clscomputadora.Procesador = " Intel Core 9, 8 nucleos. ";
            clscomputadora.Ram1 = 120;
            clscomputadora.Targetavideo = " RTX 3090";
            clscomputadora.Almacenamiento = 1000;
            clscomputadora.Dimensiones = " 34 x 39 x 19 cm " ;
            clscomputadora.Resolucion = " 1280 x 720 HD ";
            clscomputadora.Sistema = " Windows 11 pro ";
            clscomputadora.Placamadre = " Strix Z390-I de ASUS ";

            Console.WriteLine(nclscomputadora.Encender(clscomputadora));

            Console.ReadLine();
        }
    }
}

