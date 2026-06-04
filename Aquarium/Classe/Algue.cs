using Aquarium.Enum;

namespace Aquarium.Classe
{
    public class Seaweed
    {
        public  Seaweed(SeeweedVariete name,int number)
        {
            this.Variete = name;
            this.Number = number;


        }

        public SeeweedVariete Variete { get; set; }
        public int Number { get; set; }
       

    }

}
 