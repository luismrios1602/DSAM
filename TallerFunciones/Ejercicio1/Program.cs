﻿/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 30/10/2019
 * Hora: 08:01 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			double peso, estatura;
			
			Console.Write("Ingrese el peso: "); peso = double.Parse(Console.ReadLine());
			Console.Write("Ingrese la estatura (m): "); estatura = double.Parse(Console.ReadLine());
			
			Console.WriteLine("El IMC es: "+CalcularMasaCorporal(peso, estatura).ToString("#.##"));
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static double CalcularMasaCorporal(double peso, double estatura){
			double IMC;
			IMC = peso / (estatura*estatura);
			return IMC;
		}
	}
}