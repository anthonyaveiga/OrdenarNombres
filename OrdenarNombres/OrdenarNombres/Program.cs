using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarNombres
{
	class Program
	{
		const int MAX = 10;
		static void Main(string[] args)
		{
			string[] nombres = new string[MAX];


			leerNombres(nombres);
			ordenarNombres(nombres);
			imprimirNombres(nombres);
			Console.ReadKey();
		}

		public static void leerNombres(string[] x)
		{
			for (int i = 0; i < MAX; i++)
			{
				Console.WriteLine("\nIngrese el nombre {0}: ", i + 1);
				x[i] = Console.ReadLine();

			}
		}

		public static void ordenarNombres(string[] x)
		{
			string aux = "";
			for (int i = 0; i < x.Length; i++)
			{
				for (int j = i; j < x.Length; j++)
				{
					if (String.Compare(x[i], x[j], StringComparison.Ordinal) > 0)
					{
						aux = x[i];
						x[i] = x[j];
						x[j] = aux;
					}
				}
			}
		}

		public static void imprimirNombres(string[] x)
		{
			foreach (string num in x)
			{
				Console.WriteLine("\nNombre ordenado: {0}", num);
			}
		}

	}
}
