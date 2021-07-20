using System;

namespace Propiedades
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Caja caja = new Caja();
            caja.Ancho = 3;
            caja.Alto = -4;
            caja.MuestraInfo();
            Console.Read();
        }
    }
}
