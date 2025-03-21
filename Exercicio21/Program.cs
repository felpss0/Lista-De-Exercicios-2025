namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            double resultado = 1;

            while (numero != 1) 
            {
                Console.Write($"{numero} x ");
                resultado = resultado * numero;
                numero = numero - 1;
                
            }
            Console.WriteLine($" = {resultado} ");
        }
    }
}
