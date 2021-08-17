using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Entidades
{
    class ClsComputadora
    {
        private string modelo;
        private string teclado;
        private string procesador;
        private int Ram;
        private string targetavideo;
        private int almacenamiento;
        private string dimensiones;
        private string resolucion;
        private string sistema;
        private string placamadre;

        public string Modelo { get => modelo; set => modelo = value; }
        public string Teclado { get => teclado; set => teclado = value; }
        public string Procesador { get => procesador; set => procesador = value; }
        public int Ram1 { get => Ram; set => Ram = value; }
        public string Targetavideo { get => targetavideo; set => targetavideo = value; }
        public int Almacenamiento { get => almacenamiento; set => almacenamiento = value; }
        public string Dimensiones { get => dimensiones; set => dimensiones = value; }
        public string Resolucion { get => resolucion; set => resolucion = value; }
        public string Sistema { get => sistema; set => sistema = value; }
        public string Placamadre { get => placamadre; set => placamadre = value; }
    }
}
