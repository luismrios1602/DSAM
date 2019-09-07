/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 04/09/2019
 * Hora: 08:11 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1, num2, res = 0, opcion;
			string operacion="Invalida";
			
			Console.Write("Ingrese un número: ");
			num1 = int.Parse(Console.ReadLine());
			Console.Write("Ingrese un segundo número: ");
			num2 = int.Parse(Console.ReadLine());
			
			Console.WriteLine("\nLas opciones son: ");
			Console.WriteLine("1 - Adicion\n2 - Sustraccion\n3 - Multiplicación\n4 - División\n");
			Console.Write("Introduzca su elección: ");
			opcion = int.Parse(Console.ReadLine());
			
			if (opcion == 1) {
				res = num1 + num2 ;
				operacion = "Adicion";
			} else if (opcion == 2) {
				res = num1 - num2;
				operacion = "Sustracción";
			} else if (opcion == 3) {
				res = num1 * num2;
				operacion = "Multiplicacion";
			} else if (opcion == 4) {
				res = num1 / num2;
				operacion = "Division";
			} else {
				Console.WriteLine("\nIngrese una operación válida");
			}
			
			Console.WriteLine("\nLa "+operacion+" entre "+num1+" y "+num2+" es igual a "+res);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}