namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite um valor inteiro");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite outro valor inteiro");
                int b = Convert.ToInt32(Console.ReadLine());

                if (a == b)
                {
                    int c = a + b;
                    Console.WriteLine($"A soma dos valores é: {c}");
                }
                else
                {
                    int c = a * b;
                    Console.WriteLine($"A multiplicação dos valores é: {c}");
                }
            }

        }
    }
}
