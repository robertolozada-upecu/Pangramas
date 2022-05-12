using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangrama
{
    internal class Program
    {
		static void Main(string[] args)
		{
			const string abecedarioMinusculas = "abcdefghijklmnñopqrstuvwxyz";
			string cadenaAValidar;
			bool pangramaValido = true;
			char letraActual;
			int opcionMenu;
			do
			{
				Console.Clear();
				Console.WriteLine("--------------------------------------------------");
				Console.WriteLine("------------ Ejercicio sobre Pangramas -----------");
				Console.WriteLine("--------------------------------------------------");
				Console.WriteLine("Menú de opciones:");
				Console.WriteLine("1. Verificar pangrama");
				Console.WriteLine("2. Salir");
				// ingresar una opcion
				Console.Write("Elija una opción (1-2): ");
				opcionMenu = int.Parse(Console.ReadLine());
				switch (opcionMenu)
				{
					case 1:
						Console.WriteLine();
						Console.Write("Por favor ingrese la cadena a validar: ");
						cadenaAValidar = Console.ReadLine();
						for (int i = 0; i < abecedarioMinusculas.Length; i++)
						{
							letraActual = abecedarioMinusculas[i];
							if (!cadenaAValidar.ToLower().Contains(letraActual))
							{
								Console.Clear();
								Console.WriteLine();
								Console.WriteLine("La cadena ingresada \"" + cadenaAValidar + "\", no es un pangrama.");
								pangramaValido = false;
								break;
							}
						}
						if (pangramaValido == true)
						{
							Console.WriteLine();
							Console.WriteLine("La cadena ingresada si es un pangrama");
						}
						break;
					case 2:
						Console.WriteLine();
						Console.WriteLine("Gracias, vuelva pronto!");
						break;
					default:
						Console.WriteLine();
						Console.WriteLine("Opción no válida!");
						break;
				}
				Console.WriteLine();
				Console.Write("Presione enter para continuar ");
				Console.ReadKey();
            } while (opcionMenu != 2);
		}
    }
}
