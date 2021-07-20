using System;
namespace Propiedades
{
    public class Caja
    {
        //Miembro variables
        private int largo;
        private int alto;
       // private int ancho;
        private int volumen;


        public int Alto
        {
            get
            {
               return alto;
            }
            set
            {
                if (value < 0) throw new Exception("El tamaño debe ser positivo");
                alto = value;
            }
        }

        //Prpiedad Auto-Implementada
        public int  Ancho { get; set; }

        public int Largo { get {return largo;} set{largo = value;} }


        //Miembro Método

        public void MuestraInfo()
        {
            Console.WriteLine("El largo es {0}. La altura es {1}. El ancho es {2}. Por lo tanto el volumen es {3}"
                , largo, alto, Ancho, volumen = Ancho*alto*largo);
        }

       /* public void SetLargo(int largo)
        {
            this.largo = largo;

        }*/
    }

}
