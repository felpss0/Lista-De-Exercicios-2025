namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int soma = 0;
           
            for (numero = 1; numero <= 500; numero+=2) 
            {
                if (numero % 3 == 0) 
                {
                    Console.WriteLine(numero);
                    soma += numero;
                    
                }
                    
            }
            Console.WriteLine(soma);











        }
    }
}
