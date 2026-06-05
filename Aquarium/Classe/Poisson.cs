namespace Aquarium.Classe
{
    public class Fishes 
    {

        public Fishes (string name,string gender,int pv)
        {
            this.Name = name;
            this.Gender = gender;
            this.Pv = pv;

        }


        public string Name { get; set; }
        public string Gender { get; set; }
        public int Pv { get; set; } = 10;
        
        
        
        

       

    }
}
