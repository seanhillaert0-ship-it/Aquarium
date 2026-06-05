using Aquarium.Enum;

namespace Aquarium.Classe
{
    public class Seaweed
    {
        public Seaweed(SeeweedVariete name, int number, int pv)
        {
            this.Variete = name;
            this.Number = number;
            this.Pv = pv;

        }

        public SeeweedVariete Variete { get; set; }
        public int Number { get; set; }
        public int Pv { get; set; } = 10;


    }
    public class Cladophora : Seaweed
    {
        public Cladophora(SeeweedVariete name, int number, int pv) : base(name, number, pv)
        {

        }

    }
    public class MousseDeJava : Seaweed
    {
        public MousseDeJava(SeeweedVariete name, int number, int pv) : base(name, number, pv)
        {
        }
    }
    public class Fluitans : Seaweed
    {
        public Fluitans(SeeweedVariete name, int number, int pv) : base(name, number, pv)
        {


        }
    }
}
 