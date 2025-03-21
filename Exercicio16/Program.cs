namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite um numero inteiro");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                    Console.WriteLine("O numero é par");
                else
                    Console.WriteLine("O numero é impar");
            }
        }
    }
}
