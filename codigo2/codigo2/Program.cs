﻿
using System.Text;


namespace codigo2
{
	class Program
	{

		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.GetEncoding("iso-8859-1");

			Console.WriteLine("Desafio 2\n");
			CalculaFibonacci();

			Console.WriteLine("\nDesafio 4");
			PercentualEstados();

			Console.WriteLine("Desafio 5\n");
			InverteString();
			Console.ReadKey();
		}

		//Desafio 2
		static void CalculaFibonacci() 
		{
			Console.Write("Digite um número para a sequência de Fibonacci: ");
			int n = int.Parse(Console.ReadLine());

			int a = 0, b = 1, c;

			Console.Write(a + " " + b + " ");


			int i = 2;
			while (true)
			{
				c = a + b;
				Console.Write(c + " ");

				if (c == n)
				{
					Console.WriteLine($"\nO número {n} está na sequência de Fibonacci.");
					break;
				}
				else if (c > n)
				{
					Console.WriteLine($"\nO número {n} não está na sequência de Fibonacci.");
					break;
				}

				c = a + b;
				a = b;
				b = c;
				i++;
			}

		}

		//Desafio 4
		static void PercentualEstados()
		{
			{
				double sp = 67836.43;
				double rj = 36678.66;
				double mg = 29229.88;
				double es = 27165.48;
				double outros = 19849.53;
				double total = sp + rj + mg + es + outros;

				Console.WriteLine("\nValor de representação de cada estado no faturamento mensal:");
				Console.WriteLine($"SP: {sp}, RJ: {rj}, MG: {mg}, ES: {es} ");

				Console.WriteLine("\nPercentual de representação de cada estado no faturamento mensal:");
				Console.WriteLine("SP: " + (sp / total * 100).ToString("F2") + "%");
				Console.WriteLine("RJ: " + (rj / total * 100).ToString("F2") + "%");
				Console.WriteLine("MG: " + (mg / total * 100).ToString("F2") + "%");
				Console.WriteLine("ES: " + (es / total * 100).ToString("F2") + "%");
				Console.WriteLine("Outros: " + (outros / total * 100).ToString("F2") + "%\n");
			}
		}

		static void InverteString()
		{
			Console.WriteLine("Digite o que quer se seja invertido:");
			string digitado = Console.ReadLine();
			
			StringBuilder stringBuilder= new StringBuilder();

			for (int i = digitado.Length - 1; i >= 0; i--)
			{
				stringBuilder.Append(digitado[i]);
			}

			Console.WriteLine(stringBuilder.ToString());
		}
	}
}