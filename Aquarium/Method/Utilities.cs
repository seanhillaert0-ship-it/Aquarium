using Aquarium.Classe;
using Aquarium.Enum;
using System.Security.Cryptography.X509Certificates;

namespace Aquarium.Method
{
    public class Utilities
    {



        public static List<Fishes> MyFishInTheTank = new List<Fishes>();
        public static void AddAFish()
        {

            Console.Clear();
            Console.WriteLine("Do you want to add a fish to your tank yes/no");
            string add = Console.ReadLine();
            if (add.ToLower() == "yes")
            {
                Console.Clear();



                Console.WriteLine("Name Your fish");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter the gender of your fish");
                string sexe = Console.ReadLine();

                Console.WriteLine("Choose the dietary regime and the type of fish");
                Console.WriteLine("Choice 1 : carnivorous fish");
                Console.WriteLine("Choice 2 : herbivorous fish");
                int ChoixPoisson = int.Parse(Console.ReadLine());
                if (ChoixPoisson == 1)
                {
                    Console.WriteLine("Choose the type of carnivorous fish");
                    Console.WriteLine("Here are the available types of carnivorous fish :");
                    foreach (Carnivore C in Carnivore.GetValues(typeof(Carnivore)))
                    {
                        Console.WriteLine(C);
                    }
                    bool ChoixCarnivore = Carnivore.TryParse(Console.ReadLine(), out Carnivore poissonCarnivore);
                    Console.WriteLine("what is the age of your fish ?");
                    int Age = int.Parse(Console.ReadLine());

                    CarnivorousFish CarnivorousFish1 = new CarnivorousFish(name, sexe, 10, 0, poissonCarnivore);
                    if(CarnivorousFish1 != null)
                    {

                    MyFishInTheTank.Add(CarnivorousFish1);
                    }
                    Console.Clear();

                }
                else if (ChoixPoisson == 2)
                {
                    Console.WriteLine("Choose the type of herbivorous fish");
                    Console.WriteLine("Here are the available types of herbivorous fish :");
                    foreach (Herbivore H in Herbivore.GetValues(typeof(Herbivore)))
                    {
                        Console.WriteLine(H);
                    }

                    bool ChoixHerbivore = Herbivore.TryParse(Console.ReadLine(), out Herbivore poissonHerbivore);
                    Console.WriteLine("what is the age of your fish ?");
                    int Age = int.Parse(Console.ReadLine());
                    HerbivorousFish HerbivorousFish1 = new HerbivorousFish(name, sexe, 10,0, poissonHerbivore);
                    if (HerbivorousFish1 != null)
                    {
                        MyFishInTheTank.Add(HerbivorousFish1);
                    }
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine("invalid choice");
                }
                Console.WriteLine("Do you want to add another fish yes/no");
                string continuer = Console.ReadLine();
                if (continuer.ToLower() == "yes")
                {
                    AddAFish();
                }
                else
                {
                    Remenu();
                }
            }
        }







        public static List<Seaweed> SeaWeedInMyTank = new List<Seaweed>();
        public static void AddASeaWeed()
        {

            Console.Clear();
            Console.WriteLine("Do you want seaweed in your aquarium yes/no");
            string Present = Console.ReadLine();
            if (Present.ToLower() == "yes")
            {

                Console.WriteLine("Enter the name of the chosen seaweed type :");
                Console.WriteLine("Here are the available types of seaweed :");
                foreach (SeeweedVariete type in SeeweedVariete.GetValues(typeof(SeeweedVariete)))
                {
                    Console.WriteLine(type);
                }
                bool ChoixAlgue = SeeweedVariete.TryParse(Console.ReadLine(), out SeeweedVariete algueChoisie);
                if (ChoixAlgue)
                {
                    Console.WriteLine("How many of this seaweed variety do you want ?");
                    int nombre = int.Parse(Console.ReadLine());
                    Console.WriteLine("what is the age of your seaweed ?");
                    int Age = int.Parse(Console.ReadLine());
                    Seaweed algue = new Seaweed(algueChoisie, nombre, 10, Age);
                    SeaWeedInMyTank.Add(algue);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("invalid choice");
                }


            }
            Console.WriteLine("Do you want to add another type of seaweed yes/no");
            string continuer = Console.ReadLine();
            if (continuer.ToLower() == "yes")
            {
                AddASeaWeed();
            }
            else
            {
                Remenu();
            }





        }
        public static void eatFish(Fishes MyFishes)
        {

            var rand = new Random();


            foreach (Fishes f in MyFishInTheTank.ToList())
            {
                if (f is CarnivorousFish carnivore)
                {
                    if (MyFishInTheTank.Count > 1 && carnivore.Pv <= 5)
                    {
                        int indexAuHasard;
                        Fishes poissonCible;

                        do
                        {
                            indexAuHasard = rand.Next(0, MyFishInTheTank.Count);
                            poissonCible = MyFishInTheTank[indexAuHasard];
                        } while (poissonCible == carnivore);
                        if (poissonCible.Pv == 0)
                        {

                            Console.WriteLine($"The carnivore {carnivore.Name} is eating {poissonCible.Name}");
                            MyFishInTheTank.RemoveAt(indexAuHasard);
                            carnivore.Pv += 5;
                        }
                        else
                        {
                            poissonCible.Pv -= 4;
                            Console.WriteLine($"The carnivore {carnivore.Name} is attacking {poissonCible.Name} and loses 5 Pv ");
                            carnivore.Pv += 5;
                        }
                    }
                }
                else if (f is HerbivorousFish herbivore)
                {

                    if (SeaWeedInMyTank.Count > 0 && herbivore.Pv <= 5)
                    {
                        int indexAuHasard;
                        Seaweed algueCible;
                        do
                        {
                            indexAuHasard = rand.Next(0, SeaWeedInMyTank.Count);
                            algueCible = SeaWeedInMyTank[indexAuHasard];
                        } while (algueCible.Pv == 0);
                        if (algueCible.Pv == 0)
                        {
                            Console.WriteLine($"The herbivore {herbivore.Name} is eat the seaweed {algueCible.Variete}");
                            SeaWeedInMyTank.RemoveAt(indexAuHasard);
                            herbivore.Pv += 3;


                        }
                        else
                        {
                            Console.WriteLine("the herbivore " + herbivore.Name + " is eating the seaweed " + algueCible.Variete + " and the seaweed loses 2 Pv");
                            algueCible.Pv -= 2;
                            herbivore.Pv += 3;
                        }
                    }
                }
            }
        }
        public static void Menu()
        {
            Console.WriteLine("Welcome to your aquarium");
            Console.WriteLine("Do you want to add a fish or a seaweed to your tank 1 for fish, 2 for seaweed, 3 for playing the simulation, 4 for exiting");
            int choix = int.Parse(Console.ReadLine());
            switch (choix)
            {
                case 1:
                    AddAFish();
                    break;
                case 2:
                    AddASeaWeed();
                    break;
                case 3:
                    PlayingSimulation();
                    break;
                case 4:
                    Console.WriteLine("thank you for playing");
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;




            }
            
            

        }
        public static void AgeFishesAndSeaweed()
        {
            foreach (Fishes f in MyFishInTheTank.ToList())
            {
                f.Age += 1;
                Console.WriteLine("this is the current age of " + f.Name + " : " + f.Age);
             if (f.Age > 20)
                {
                    Console.WriteLine("this fish is too old and dies : " + f.Name);
                    MyFishInTheTank.Remove(f);
                }
            }
            foreach (Seaweed s in SeaWeedInMyTank.ToList())
            {
                s.Age += 1;
                Console.WriteLine("this is the current age of " + s.Variete + " : " + s.Age);
                if (s.Age > 20)
                {
                    Console.WriteLine("this seaweed is too old and dies : " + s.Variete);
                    SeaWeedInMyTank.Remove(s);
                }

            }
        }


        int day = 0;
        public static void PlayingSimulation()
        {

            for (int i = 0; i < 10000000; i++)
            {
                Console.WriteLine("Day " + (i));
                Console.WriteLine("Resume of the day :");
                Console.WriteLine("This is all the carinivorous fishes in your tank :");
                foreach (Fishes fish in MyFishInTheTank)
                {
                    if (fish is CarnivorousFish carnivore)
                    {
                        Console.WriteLine($"Name : {carnivore.Name}, Gender : {carnivore.Gender},Race : {carnivore.Carnivore}");
                    }
                }
                Console.WriteLine("this is all the herbivorous fishes in your tank :");
                foreach (Fishes fish in MyFishInTheTank)
                {
                    if (fish is HerbivorousFish herbivore)
                    {
                        Console.WriteLine($"Name : {herbivore.Name}, Gender : {herbivore.Gender}, Race : {herbivore.Herbivore}");
                    }
                }
                Console.WriteLine("this is all the seaweed in your tank :");
                foreach (Seaweed g in SeaWeedInMyTank)
                {
                    Console.WriteLine($"Number : {g.Number}, Variety : {g.Variete}");
                }
                foreach (Fishes f in MyFishInTheTank)
                {
                    f.Pv -= 1;
                    Console.WriteLine("this is the current Pv of " + f.Name + " : " + f.Pv);
                }
                foreach (Seaweed s in SeaWeedInMyTank)
                {
                    s.Pv += 2;
                    Console.WriteLine("this is the current Pv of " + s.Variete + " : " + s.Pv);
                }
                foreach (Fishes f in MyFishInTheTank)
                {

                    eatFish(f);
                    AgeFishesAndSeaweed();
                }


                

                Console.WriteLine("do you want to continue to the next day yes/no");
                string continuer = Console.ReadLine();
                if (continuer.ToLower() == "yes")
                {
                    Console.Clear();
                    PlayingSimulation();
                }
                else
                {
                    Remenu();
                }






            }
        }

       
        public static void Remenu()
        {
            Console.WriteLine("Do you want to return to the menu yes/no");
            string retour = Console.ReadLine();
            if (retour.ToLower() == "yes")
            {
                Console.Clear();
                Menu();
            }
            else
            {
                Console.WriteLine("thank you for playing");
            }
        }
    }
}








