using System;

namespace AbsbtractClass
{

    public class Program
    {
        static void Main(string[] args)
        {
            var grazy = new Phisical();
            grazy.Pay();

            var beapps = new Legal();
            beapps.Pay();
        }
    }

    public abstract class Person
    {
        public string Name { get; set; }

        public virtual void Pay()
        {
        }
    }

    public class Phisical : Person
    {
        public string Cpf { get; set; }

        public override void Pay()
        {
            Console.WriteLine("Paying by physical person");
        }
    }

    public class Legal : Person
    {
        public string Cnpj { get; set; }

        public override void Pay()
        {
            Console.WriteLine("Paying by legal person");
        }
    }
}
