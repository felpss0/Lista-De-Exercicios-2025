namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite a segunda nota");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            
            double media = (2 /((1/nota1) + (1/nota2)));

            Console.WriteLine($"A média harmonica do aluno é {media}");
            Console.ReadLine();
        }
    }
}
