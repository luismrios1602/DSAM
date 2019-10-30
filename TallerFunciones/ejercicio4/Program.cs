/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 30/10/2019
 * Hora: 08:01 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("");
			
			
			
			Console.WriteLine("el triple es: "+triple(pedir()));
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static int pedir(){
			Console.WriteLine("ingrese un numero ");
			int num=int.Parse(Console.ReadLine());
			Console.WriteLine("el numero entero es: "+num);
			return num;
		}
		
		public static int triple(int num){
			int resultado=num*3;
			return resultado;
		}
	}
}