namespace Exercicio04
{
    internal class Program
    {

        //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
        static void Main(string[] args)
        {
            Console.Write("Digite os graus em Celsius: ");
            decimal celsius = Convert.ToDecimal(Console.ReadLine());
           
            decimal fahrenheit =0;
            decimal valorApoio = 1.8m;
            
            fahrenheit = celsius * valorApoio + 32;

            Console.WriteLine(fahrenheit);


        }
    }
}
