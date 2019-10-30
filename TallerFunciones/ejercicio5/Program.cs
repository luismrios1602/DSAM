/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 30/10/2019
 * Hora: 08:25 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n1,n2,n3;
			Console.WriteLine("ingrese el primer numero ");
			n1=int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese el segundo numero ");
			n2=int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese el tercer numero ");
			n3=int.Parse(Console.ReadLine());
			
			Console.WriteLine("el numero mayor es: "+calcularMayor(n1,n2,n3));
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static int calcularMayor(int num1, int num2, int num3){
			int numMayor=0;
			if (num1>num2 && num1>num3) {
				numMayor=num1;
			}else if (num2>num1 && num2>num3) {
				numMayor=num2;
			}else if (num3>num1 && num3>num2) {
				numMayor=num3;
			}
			
			return numMayor;
			
		}
		
		
	}
}