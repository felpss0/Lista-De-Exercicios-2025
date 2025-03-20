namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pao = 0.12;
            double broa = 1.50;

            Console.WriteLine("Digite quantas unidades de pão foram vendidas");
            double qtdpao = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite quantas unidades de broa foram vendidas");
            double qtdbroa = Convert.ToDouble(Console.ReadLine());


            double totalArrecadado = (qtdpao * pao) + (qtdbroa * broa);
            Console.WriteLine($"A quantidade arrecadada com os itens vendidos é: {totalArrecadado}");
            Console.WriteLine();

            double poupanca = (totalArrecadado * (10.0 / 100.0)) ;

            Console.Write($"O valor que deve ser guardado na poupança é de: {poupanca}");
            Console.WriteLine();
        }
    }
}
