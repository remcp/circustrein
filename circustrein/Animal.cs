using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    internal class Animal
    {
        public string Name { get; set; }
        public Size.size Size { get; set; }

        public int Points { get; set; }

        public bool Carnivore { get; set; }

        public Animal(string name, Size.size size, bool carnivore) 
        {
            Name = name;
            Size = size;
            Carnivore = carnivore;
            switch (Size)
            {
                case circustrein.Size.size.small:
                    Points = 1;
                    break;
                case circustrein.Size.size.medium:
                    Points = 3;
                    break;
                case circustrein.Size.size.big:
                    Points = 5;
                    break;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
