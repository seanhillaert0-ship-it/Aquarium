using Aquarium.Enum;

namespace Aquarium.Classe
{
    public class CarnivorousFish : Fishes
    {
        public CarnivorousFish(string name, string gender,int pv, int age, Carnivore carnivore) : base(name, gender,pv, age)
        {
            this.Carnivore = carnivore;
        }
        public Carnivore Carnivore { get; set; }
    }
    public class Grouper : CarnivorousFish
    {
        public Grouper(string name, string gender, int pv, int age, Carnivore carnivore) : base(name, gender, pv, age, carnivore)
        {


        }
    }
    public class Tuna : CarnivorousFish
    {
        public Tuna(string name, string gender, int pv, int age, Carnivore carnivore) : base(name, gender, pv, age, carnivore)
        {


        }
    }
    public class ClownFish : CarnivorousFish
    {
        public ClownFish(string name, string gender,int pv, int age, Carnivore carnivore) : base(name, gender, pv, age, carnivore)
        {
        }

    }
}
