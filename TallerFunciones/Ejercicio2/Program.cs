/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 30/10/2019
 * Hora: 08:06 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			String cadena;
			Console.WriteLine("Ingrese la cadena: ");
			cadena = Console.ReadLine();
			
			Console.WriteLine(Ultima(cadena));
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static String Ultima(String cadena){
			String ultimo;
			if (cadena.Equals("")){
				ultimo="Cadena vacía";
			} else {
				ultimo = cadena.Substring(cadena.Length-1);
			}
			
			return ultimo;
		}
	}
}