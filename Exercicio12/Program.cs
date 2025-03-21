namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal porcentagemAumento = 1.15m;
            decimal porcentagemDesconto = 0.80m;

            Console.WriteLine("Digite o salario");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            decimal salarioPosAumento = salario * porcentagemAumento;

            Console.WriteLine($"Salario depois do aumento {salarioPosAumento}");

            decimal salarioPosImposto = salarioPosAumento * porcentagemDesconto * porcentagemAumento;

            Console.WriteLine($"O salario depois dos descontos fica {salarioPosImposto:F2}");




        }
    }
}
