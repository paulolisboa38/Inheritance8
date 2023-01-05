namespace ExercicioFinalSection11.Entities
{
    internal class PessoaJuridica : Pessoa
    {
        public int WorkersQuantity { get; set; }
        public PessoaJuridica (string name,double income,int workersQuantity)
            : base(name,income)
        {
            WorkersQuantity = workersQuantity;
        }
        public override double Taxes ()
        {
            double tax = 0;
            if (WorkersQuantity > 10)
            {
                tax = Income * 0.14;
            }
            else
            {
                tax = Income * 0.16;
            }
            return tax;
        }
    }
}
