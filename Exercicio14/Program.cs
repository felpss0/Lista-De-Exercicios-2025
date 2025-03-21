namespace Exercicio14
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

            int[] numeros = [a, b, c];
            Array.Sort(numeros);
            Array.Reverse(numeros);

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]} ");

            }
            Console.ReadLine();

        }
    }
}
