/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 7/09/2019
 * Hora: 12:22 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			char letra;
			
			Console.WriteLine("Ingresar un caracter: ");
			letra = char.Parse(Console.ReadLine().ToUpper());
						
			if(letra =='A' || letra=='E' || letra=='I' || letra=='O' || letra=='U'){
			    Console.WriteLine("el caracter "+letra+" es una vocal");
			}else if(letra=='B' || letra=='C' || letra=='D' || letra=='F' || letra=='G' || letra=='H' || letra=='J' || letra=='K' || letra=='L' || letra=='M' || letra=='N' || letra=='Ñ' || letra=='P' || letra=='Q' || letra=='R' || letra=='S' || letra=='T' || letra=='V' || letra=='W' || letra=='X' || letra=='Y' || letra=='Z'){
			    Console.WriteLine("el caracter "+letra+" es una consonante");
			}else {
			    Console.WriteLine("ERROR... esto es un símbolo/número");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}