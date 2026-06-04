using Aquarium.Enum;

namespace Aquarium.Classe
{
    public class CarnivorousFish : Fishes
    {
        public CarnivorousFish(string name, string gender, Carnivore carnivore) : base(name, gender)
        {
            this.Carnivore = carnivore;
        }
        public Carnivore Carnivore { get; set; }
    }
    public class Grouper : CarnivorousFish
    {
        public Grouper(string name, string gender, Carnivore carnivore) : base(name, gender, carnivore)
        {


        }
    }
    public class Tuna : CarnivorousFish
    {
        public Tuna(string name, string gender, Carnivore carnivore) : base(name, gender, carnivore)
        {


        }
    }
    public class ClownFish : CarnivorousFish
    {
        public ClownFish(string name, string gender,Carnivore carnivore) : base(name, gender, carnivore)
        {
        }

    }
}
