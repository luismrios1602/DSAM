/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 04/09/2019
 * Hora: 08:30 a.m.
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
			int op;
			double radio, b, altura, area=0;
			
			Console.WriteLine("Programa para calcular el área de diferentes figuras geometricas: ");
			Console.WriteLine("------------------------------------------------------------------");
			
			Console.WriteLine("\nDigite 1 para el area del circulo");
			Console.WriteLine("Digite 2 para el area del rectangulo");
			Console.WriteLine("Digite 3 para el area del triangulo");
			Console.Write("Digite su opcion: ");
			op = int.Parse(Console.ReadLine());
			
			if (op == 1) {
				Console.Write("Digite el radio del circulo: ");
				radio = double.Parse(Console.ReadLine());
				area = Math.PI * Math.Pow(radio,2);
			} else if (op == 2) {
				Console.Write("Digite la base del rectangulo: ");
				b = double.Parse(Console.ReadLine());
				Console.Write("Digite la altura del rectangulo: ");
				altura = double.Parse(Console.ReadLine());
				area = b * altura;
			} else if (op == 3) {
				Console.Write("Digite la base del triangulo: ");
				b = double.Parse(Console.ReadLine());
				Console.Write("Digite la altura del tringulo: ");
				altura = double.Parse(Console.ReadLine());
				area = (b * altura)/2;
			} else {
				Console.WriteLine("Digite una opción válida! ");
			}	
						
			Console.WriteLine("El area es: "+area);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}