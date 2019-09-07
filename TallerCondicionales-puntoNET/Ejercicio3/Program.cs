/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 04/09/2019
 * Hora: 08:53 a.m.
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
			int mes;
			
			Console.Write("Ingrese el número del mes: ");
			mes = int.Parse(Console.ReadLine());
			
			if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) {
				Console.WriteLine("El mes "+mes+" tiene 31 días.");
			} else if (mes == 4 || mes == 6 || mes == 9 || mes == 11) {
				Console.WriteLine("El mes "+mes+" tiene 30 días.");
			} else if (mes == 2){
				Console.WriteLine("El mes "+mes+" tiene 28/29 días.");
			} else {
				Console.WriteLine("Ingrese un mes válido.");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}