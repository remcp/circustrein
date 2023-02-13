using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    internal class Wagon
    {
        public List<Animal> Animals { get; set; }
        public int Points { get; set; }
         public bool Hascarnivore { get; set; }

        public int Number { get; set; }

        public Wagon(int number) 
        {
            Number = number;
            Animals = new List<Animal>();
        }

        public void addanimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public override string ToString()
        {
            string returnstring = "";
            string carnivore = "";
            foreach (Animal animal in Animals)
            {
                if(animal.Carnivore == true)
                {
                    carnivore = "yes";
                }
                else
                {
                    carnivore = "no";
                }
                returnstring += "\n" + animal.Name + "(" +animal.Points.ToString() + " size:" + animal.Size.ToString() + " carnivore: " + carnivore + ") ";
            }

            return "wagon number: " + Number.ToString() + " " + returnstring;
        }
    }
}