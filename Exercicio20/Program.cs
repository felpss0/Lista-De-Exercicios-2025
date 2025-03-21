namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numeroTabuada = Convert.ToInt32(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++) 
            {
                int resultado = numeroTabuada * contador;
                Console.WriteLine($"{numeroTabuada} X {contador} = {resultado}");
            }
        }
    }
}
