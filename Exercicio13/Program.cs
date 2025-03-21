namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b < c) 
            {
                Console.WriteLine("A soma de A + B é menor que o valor de C");
            }
            else
                Console.WriteLine("A soma de A + B é maior que o valor de C");

            Console.ReadLine();

        }
    }
}
