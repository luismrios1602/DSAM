/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 30/10/2019
 * Hora: 08:43 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num;
			Console.WriteLine("ingrese un numero para hacer la tabla de multiplicar ");
			num=int.Parse(Console.ReadLine());
			
			mostrarTabla(num);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void mostrarTabla(int num){
			
			
			for (int i = 1; i <= 10; i++) {
				Console.WriteLine(num+" x "+i+ " = "+num*i);
			}
		}
		
	}
}