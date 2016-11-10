using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods
{
    class Animal
    {
        //private = data'en kan grund bruges inden i classen
        //public = Data'en kan bruges af andre classer
        //static = Data'en er ikke brundt til en instance af classen men det er delt med alle andre instcences

        public static int count = 0;

        public string name; // hvis man ikke skrive f.eks public foran vaiabernes type er det standard private
        public int age;
        public float happiness;

        public void print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
        }
        public Animal() // Dette kaldes en Construcktor som gør det muligt at lave forkskellige dyr med den samme class
        {
            name = "Spotty";
            age = 6;
            happiness = 0.5f;

            count++;
        }
        public Animal(string _name, int _age, float _happiness) // Her laves også en Constructor men hvor den tage 3 agumenter ind og gemmer dem
        {
            name = _name;
            age = _age;
            happiness = _happiness;

            count++;
        }
                                
    }
    class Program
    {
        public static void Main(string[] args)// denne class er hvad der bliver kaldt når programmet starter
        {
            Animal dog = new Animal();// Nu kan man bruge Animal som en hvilken som helt anden type f.eks string, float eller int fordi vi har lavet den i classen Animal
            Console.WriteLine(dog.name);// hvis man så vil printe navnet som er blever diffineret i classen animal skal man bare kalde varibalen (name) og så får dog navnet
            //dog.name = "Larry";         // Ved at skrive som jeg gør her kan man også give dog et nyt navn 
            Console.WriteLine();
            dog.print();
            Animal.count += 2;// Hvis man vil bruge static som på virker hele classen og ikke bare den ene eksemple af det dyr man lave skal man kalde classen og ikke dyret
            Animal cat = new Animal("Larry", 10, 8.8f);
            Console.WriteLine();
            cat.print();
            Console.WriteLine();
            Console.WriteLine("Numb of animals: " + Animal.count);
            Console.ReadKey();
        }
    }
}
