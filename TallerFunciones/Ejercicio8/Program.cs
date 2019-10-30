/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 30/10/2019
 * Hora: 08:59 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{
			String nombre;
			int horas, tarifa;
			Console.Write("Ingrese el nombre del trabajador: "); nombre=Console.ReadLine();
			Console.Write("Ingrese las horas trabajadas: "); horas=int.Parse(Console.ReadLine());
			Console.Write("Ingrese el valor por hora trabajada: "); tarifa=int.Parse(Console.ReadLine());
			
			calcularSalario(nombre, horas, tarifa);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void calcularSalario(String nombre, int horas, int tarifas){
			int horasExtras=0;
			double tarifasHE=0, salario;
			if (horas>44) {
				horasExtras = horas - 44;
				tarifasHE = tarifas*0.25;
			}
			salario = (horas * tarifas)+(horasExtras*tarifasHE);
			
			Console.WriteLine("El salario del trabajador es: $"+salario);
		}
	}
}