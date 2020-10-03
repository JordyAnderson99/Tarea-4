using System;
using System.Text;

namespace Ejer.Cap8_Y_9{

    public class Ejercicio9_1{

        public static void Tienda(){

            Producto tienda;
            float precio;
            int cantidad;
            String nombre;

            Console.WriteLine("Digite el nombre del producto:");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite el precio del producto:");
            precio = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite la cantidad del producto:");
            cantidad = Convert.ToInt32(Console.ReadLine());

            tienda = new Producto(precio, nombre, cantidad);

            Console.WriteLine(tienda.ToString());

            
        }
        public struct Producto
        {
            
            public float precio;
            public String nombre;
            public int cantidad;

            public Producto(float precio1, String nombre1, int cantidad1)
            {
                precio = precio1;
                nombre = nombre1;
                cantidad = cantidad1;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("El Nombre del Producto Es: {0}, La Cantidad del Producto Es: {1}, El Precio del Producto ES: {2}", nombre, cantidad, precio);
                return sb.ToString();
            }
        }


    }
}