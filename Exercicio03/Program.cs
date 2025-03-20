namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kmInicial = 500;
            double kmFinal = 1000;

            double distanciaPercorrida = kmFinal - kmInicial;

            double consumoCombustivel = 40;

            double consumoPorKm = distanciaPercorrida / consumoCombustivel;

            Console.WriteLine($"O consumo de combustivel durante o percurso foi de {consumoPorKm} KM/l");
            
            
            Console.ReadLine();
        }
    }
}
