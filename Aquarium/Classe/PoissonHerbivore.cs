using Aquarium.Enum;

namespace Aquarium.Classe
{
    public class HerbivorousFish : Fishes
    {
        public HerbivorousFish(string name, string gender,Herbivore herbivore) : base(name, gender)
        {
            this.Herbivore = herbivore;
        }
        public Herbivore Herbivore { get; set; }
    }
    public class Sole : HerbivorousFish
    {
        public Sole(string name, string gender, Herbivore herbivore) : base(name, gender, herbivore)
        {


        }
    }
    public class SeaBass : HerbivorousFish

    {
        public SeaBass(string name, string gender, Herbivore herbivore) : base(name, gender, herbivore)
        {


        }
    }
    public class Carpe : HerbivorousFish
    {
        public Carpe(string name, string gender, Herbivore herbivore) : base(name, gender, herbivore)
        {


        }
    }
}
