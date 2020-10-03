using System;

namespace Ejer.Cap8_Y_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=0;

            Console.WriteLine("Bienvenido al Menu");
            Console.WriteLine("1.Ejercicio8_3");
            Console.WriteLine("2.Ejercicio9_1");
            Console.WriteLine("3.Ejercicio9_3");
            Console.WriteLine("4.Ejercicio9_4");
            Console.WriteLine("Elija una opcion");
            op= Convert.ToInt32(Console.ReadLine());

            switch(op){

                case 1:{
                    Console.WriteLine("Hora y Fecha");
                    Ejercicio8_3.FechaHora();
                    break;
                }
                case 2:{
                    Console.WriteLine("Bienvenido a la Tienda");
                    Ejercicio9_1.Tienda();
                    break;
                }
                case 3:{
                    Console.WriteLine("Duenos y mascotas");
                    Ejercicio9_3.DuenoMascota();
                    break;
                }
                case 4:{
                    Console.WriteLine("Neumaticos");
                    Ejercicio9_4.Neumatico();
                    break;
                }
                default:{
                    Console.WriteLine("Esta opcion no existe");
                    break;
                }
            }
        }
    }
}
