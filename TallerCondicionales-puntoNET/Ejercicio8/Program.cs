/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 7/09/2019
 * Hora: 1:40 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{
			double precio, total=0, descuento=0;
			
			Console.Write("Ingrese el valor de la compra: ");
			precio = double.Parse(Console.ReadLine());
            
            if (precio >= 200) {
                    descuento = precio * 0.15;
                    total = precio - descuento;
            } else  if (precio >= 100 && precio < 200)  {
                    descuento = precio * 0.12;
                    total = precio - descuento;
            } else  if (precio < 100)  {
                    descuento = precio * 0.10;
                    total = precio - descuento;
            } else{
                Console.WriteLine("Escriba bien ome bobo >:v ");
            }

            Console.WriteLine("\nEl descuento es de: $"+descuento+" y el total a pagar es de: $"+total);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}