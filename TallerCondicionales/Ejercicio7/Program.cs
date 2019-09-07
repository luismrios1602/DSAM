/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 7/09/2019
 * Hora: 1:29 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n1, n2, n3;
			
			Console.WriteLine("Digite el primer número: ");
			n1= int.Parse(Console.ReadLine());
		    Console.WriteLine("Digite el segundo número: ");
			n2= int.Parse(Console.ReadLine());
		    Console.WriteLine("Digite el tercer número: ");
			n3= int.Parse(Console.ReadLine());
		
		    if (n1>=n2 && n1>=n3) {
		        Console.WriteLine("el numero "+n1+" es el mayor");
		    } else if(n2>=n1 && n2>=n3){
		        Console.WriteLine("el numero "+n2+" es el mayor");
		    }else {
		        Console.WriteLine("el numero "+n3+" es el mayor");
		    }
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}