namespace ExercicioFinalSection11.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public double HealthExpenditures { get; set; }
        public PessoaFisica (string name,double income,double healthExpenditures)
            : base(name,income)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Taxes ()
        {
            double tax = 0;
            if (Income < 20000.00)
            {
                tax = Income * 0.15;
            }
            else
            {
                tax = Income * 0.25;
            }
            tax -= (HealthExpenditures / 2);
            return tax;
        }
    }
}
