namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado;

            Console.WriteLine("Digite a primeira nota:");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o primeiro peso");
            double peso1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo peso:");
            double peso2 = Convert.ToDouble(Console.ReadLine());

            resultado = ((n1 * peso1) + (n2 * peso2)) / (peso1+peso2);

            Console.WriteLine($"A media ponderada é {resultado}");



        }
    }
}
