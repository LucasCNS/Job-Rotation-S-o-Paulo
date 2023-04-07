
namespace codigo2
{
	class Program
	{
		static void Main(string[] args)
		{
			CalculaFibonacci();
		}

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

		
	}
}