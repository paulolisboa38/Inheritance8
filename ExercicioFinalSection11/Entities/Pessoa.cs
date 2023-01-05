namespace ExercicioFinalSection11.Entities
{
    abstract class Pessoa
    {
        public string Name { get; set; }
        public double Income { get; set; }
        protected Pessoa (string name,double income)
        {
            Name = name;
            Income = income;
        }
        public abstract double Taxes ();
    }
}
