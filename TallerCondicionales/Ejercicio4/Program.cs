/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 7/09/2019
 * Hora: 12:10 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
		double carga=0, unidad, total;
		string nombre;

        Console.WriteLine("ELECTRICARIBE CAREVERGA S.A.R.\n---------------------------------------\n"+
        "Ingrese los siguientes datos: \n*Nombre \n*Unidades Consumidas \n");
		Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();
		Console.Write("Ingrese las unidades consumidas: ");
		unidad = double.Parse(Console.ReadLine());

        if (unidad <= 199) {
            carga = 1.20;
        } else if (unidad >= 200 && unidad < 400) {
            carga = 1.50;
        } else if (unidad >= 400 && unidad < 600) {
            carga = 1.80;
        } else if (unidad >= 600) {
            carga = 2.00;
        }

        total = carga * unidad;
        Console.WriteLine("\nELECTRICARIBE CAREVERGA S.A.R.\n---------------------------------------\n"+
        "Señor "+nombre+", el total a pagar es de: $"+total);
			
			// TODO: Implement Functionality Here
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}