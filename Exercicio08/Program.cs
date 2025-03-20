namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool numeroEhPrimo = true;

            if (numero < 2)
                numeroEhPrimo = false;
            else if (numero == 2)
                numeroEhPrimo = true;
            else if (numero % 2 == 0)
                numeroEhPrimo = false;

            for (int i = 3; i * i <= numero; i += 2) 
            {
                if (numero % i == 0)
                    numeroEhPrimo = false;
            }

            Console.WriteLine(numeroEhPrimo ? "Número primo" : "Não é primo");
            Console.ReadLine();

        }
    }
}
