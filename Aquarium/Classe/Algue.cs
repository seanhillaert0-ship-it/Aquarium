using Aquarium.Enum;

namespace Aquarium.Classe
{
    public class Seaweed
    {
        public Seaweed(SeeweedVariete name, int number, int pv, int age)
        {
            this.Variete = name;
            this.Number = number;
            this.Pv = pv;
            this.Age = age;

        }

        public SeeweedVariete Variete { get; set; }
        public int Number { get; set; }
        public int Pv { get; set; } = 10;
        public int Age { get; set; } = 0;

    }
    public class Cladophora : Seaweed
    {
        public Cladophora(SeeweedVariete name, int number, int pv, int age) : base(name, number, pv, age)
        {

        }

    }
    public class MousseDeJava : Seaweed
    {
        public MousseDeJava(SeeweedVariete name, int number, int pv, int age) : base(name, number, pv, age)
        {
        }
    }
    public class Fluitans : Seaweed
    {
        public Fluitans(SeeweedVariete name, int number, int pv, int age) : base(name, number, pv, age)
        {


        }
    }
}
 