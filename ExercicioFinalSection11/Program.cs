using ExercicioFinalSection11.Entities;
using System.Globalization;
namespace ExercicioFinalSection11
{
    internal class Program
    {
        static void Main (string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();
            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char c = char.Parse(Console.ReadLine());
                if (c == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(name,income,healthExpenditures));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int workersQuantity = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(name,income,workersQuantity));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Pessoa item in list)
            {
                Console.WriteLine($"{item.Name}: $ " +
                    $"{item.Taxes().ToString("F2",CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine();
            double totalTaxes = 0;
            foreach (Pessoa item in list)
            {
                totalTaxes += item.Taxes();
            }
            Console.WriteLine($"TOTAL TAXES: $ {totalTaxes.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}