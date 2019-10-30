/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 30/10/2019
 * Hora: 08:26 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			String cadena;
			Console.WriteLine("Ingrese la cadena: ");
			cadena = Console.ReadLine();
			
			Console.WriteLine("La cantidad de caracteres es: "+strlen2(cadena));
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int strlen2(String cadena){
			int cantidad;
			cantidad = cadena.Length;
			return cantidad;
		}
		
	}
}