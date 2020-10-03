using System;

namespace Ejer.Cap8_Y_9{
    public class Ejercicio9_4{
        public static void Neumatico(){

            Neumaticos neumaticos;
            neumaticos = Neumaticos.Diagonal;
            Console.WriteLine("Los neumaticos son: {0}", neumaticos); 
        }
        enum Neumaticos {Diagonal=1,Radial,Verano,Invierno,AllSeason,Asimetrico,Direccionales,Tubuless,
        PerfilBajo,ReCauchutados,RunFlat,Ecologicos}
    }
}