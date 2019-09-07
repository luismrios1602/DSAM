/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 7/09/2019
 * Hora: 12:56 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			double n,f;
			
			Console.WriteLine("Ingrese el valor de N");
			n = double.Parse(Console.ReadLine());
			
			double variable1 = 1/Math.Sqrt(5);
			double variable2 = (1+Math.Sqrt(5))/2;
			double variable3 = (1-Math.Sqrt(5))/2;
			f = n/(variable1*(Math.Pow(variable2,n)-Math.Pow(variable3,n)));
			
	       	Console.WriteLine("F(N)= "+f);
				
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}