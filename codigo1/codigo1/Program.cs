namespace codigo1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int indice = 13;
			int soma = 0;
			int k = 0;

			for (int i = 0; i < indice; i++)
			{
				k = k + 1;
				soma = soma + k;
			}

			Console.WriteLine($"{soma}");
			Console.ReadKey();

		}
	}
}