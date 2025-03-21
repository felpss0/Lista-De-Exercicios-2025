namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Digite um numero");
            int fn = Convert.ToInt32(Console.ReadLine());

            int ultimoNumero = 0;
            int penultimoNumero = 1;

            while (numero < fn) 
            {
                int resultado = ultimoNumero + penultimoNumero;
                penultimoNumero = ultimoNumero;
                ultimoNumero = resultado;

                if (ultimoNumero > fn)
                    break;

                Console.Write($"{ultimoNumero} ");

                numero++;
            }
            Console.ReadLine();

        }
    }
}
