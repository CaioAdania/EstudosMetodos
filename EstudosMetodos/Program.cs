using EstudosMetodos.Entities;
using System.Globalization;

namespace EstudosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto: " + p);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtdAdicionar = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtdAdicionar);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int qtdRetirar = int.Parse(Console.ReadLine());
            p.RetirarProdutos(qtdRetirar);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
