namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu nome");
            string nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());

            int diasVividos = idade * 365;

            Console.WriteLine($"{nome}, voce já viveu {diasVividos} Dias.");




        }
    }
}
