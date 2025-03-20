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
            
            Console.WriteLine("Digite a terceira nota");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"A média do aluno é {media}");
            Console.ReadLine();
        }
    }
}
