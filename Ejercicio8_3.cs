using System;

namespace Ejer.Cap8_Y_9{

    public class Ejercicio8_3{

        public static void FechaHora(){

            String formato;

            formato= String.Format("La Hora y la Fecha es: {0:HH:mmtt yyyy dd MM}", DateTime.Now);
            Console.WriteLine(formato);

        }
    }
}