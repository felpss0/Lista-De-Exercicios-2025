namespace Exercicio05
{
    internal class Program
    {
        //Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
        //vendas.A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.
        static void Main(string[] args)
        {
            decimal salarioTotal;

            Console.WriteLine("Digite o salario base do Funcionario");
            decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas");
            decimal totalVendas = Convert.ToDecimal(Console.ReadLine());
              
            salarioTotal = salarioBase + (10.0m / 100.0m ) * totalVendas ;
            Console.WriteLine(salarioTotal);
            Console.ReadLine();
            

            



        }
    }
}
