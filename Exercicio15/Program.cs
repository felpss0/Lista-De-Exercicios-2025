namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o peso");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura");
            double altura = Convert.ToDouble(Console.ReadLine()); 

            double imc = peso / Math.Pow(altura, 2);

            Console.WriteLine($"Seu IMC é de: {imc:F2}");

            Console.ReadLine();

            if (imc < 18.5)
               Console.WriteLine("Abaixo do peso");
            else if (imc > 18.5 && imc < 25) 
                Console.WriteLine("Peso normal");
            else
                Console.WriteLine("Acima do peso");




        }
    }
}
