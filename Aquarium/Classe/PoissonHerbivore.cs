using Aquarium.Enum;

namespace Aquarium.Classe
{
    public class HerbivorousFish : Fishes
    {
        public HerbivorousFish(string name, string gender, int pv, int age, Herbivore herbivore) : base(name, gender, pv, age)
        {
            this.Herbivore = herbivore;
        }
        public Herbivore Herbivore { get; set; }
    }
    public class Sole : HerbivorousFish
    {
        public Sole(string name, string gender, int pv, int age, Herbivore herbivore) : base(name, gender, pv, age, herbivore)
        {


        }
    }
    public class SeaBass : HerbivorousFish

    {
        public SeaBass(string name, string gender, int pv, int age, Herbivore herbivore) : base(name, gender, pv, age, herbivore)
        {


        }
    }
    public class Carpe : HerbivorousFish
    {
        public Carpe(string name, string gender, int pv, int age, Herbivore herbivore) : base(name, gender, pv, age, herbivore)
        {


        }
    }
}
