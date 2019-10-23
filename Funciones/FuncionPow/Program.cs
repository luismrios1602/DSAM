/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 23/10/2019
 * Hora: 08:09 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace FuncionPow
{
	class Program
	{
		public static void Main(string[] args)
		{
			int basesinha, exponente;
			Console.Write("Ingrese la base vale mondá esa: ");
			basesinha = int.Parse(Console.ReadLine());
			Console.Write("Ingrese el exponente que vale más mondá todavía: ");
			exponente = int.Parse(Console.ReadLine());
			
			Console.WriteLine(basesinha+"^"+exponente+" = "+Powiar(basesinha, exponente));
			Console.WriteLine(basesinha+"^"+exponente+" = "+Math.Pow(basesinha, exponente));
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int Powiar(int basesinha, int exponente){
			int potencia=1;
			
			for (int i = 1; i <= exponente; i++) {
				potencia *= basesinha;
			}
			return potencia;
		}
	}
}