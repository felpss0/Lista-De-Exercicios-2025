namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal area;
            
            Console.WriteLine("Digite a base do terreno");
            decimal base1 = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("Digite a altura do terreno");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            area = base1 * altura;

            Console.WriteLine($"A area do terreno é {area}");
            Console.ReadLine();
            



        }
    }
}
