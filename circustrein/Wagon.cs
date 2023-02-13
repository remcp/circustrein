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
        public Train train = new();
        public List<Animal> Animals { get; set; }
        public int Points { get; set; }
         public bool Hascarnivore { get; set; }

        public int Number { get; set; }

        public Wagon(int number) 
        {
            Number = number;
        }

        public override string ToString()
        {
            string returnstring = "";

            foreach (Animal animal in Animals)
            {
                returnstring += animal.Name + "(" +animal.Points.ToString() + ") ";
            }

            return "wagon number: " + Number.ToString() + " " + returnstring;
        }
    }
}