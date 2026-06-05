namespace Aquarium.Classe
{
    public class Fishes 
    {

        public Fishes (string name,string gender,int pv, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Pv = pv;
            this.Age = age;

        }


        public string Name { get; set; }
        public string Gender { get; set; }
        public int Pv { get; set; } = 10;
        public int Age { get; set; } = 0;







    }
}
