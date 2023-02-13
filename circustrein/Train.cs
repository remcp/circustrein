using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    internal class Train
    {
        public List<Wagon> WagonList { get; set; }

        public Wagon addwagon()
        {
            Wagon newwagon = new Wagon(WagonList.Count + 1);
            WagonList.Add(newwagon);
            return newwagon;
        }

        public void addanimal(Animal newanimal)
        {
            bool animaladded = false;
            if (newanimal.Carnivore == true)
            {
                foreach (Wagon wagon in WagonList)
                {
                    Size.size smallestanimalsize = new();
                    foreach (Animal wagonanimal in wagon.Animals)
                    {
                        switch (wagonanimal.Size)
                        {
                            case Size.size.small:
                                if (smallestanimalsize! < Size.size.small)
                                {
                                    smallestanimalsize = Size.size.small;
                                }
                                break;
                            case Size.size.medium:
                                if (smallestanimalsize! < Size.size.medium)
                                {
                                    smallestanimalsize = Size.size.medium;
                                }
                                break;
                            case Size.size.big:
                                if (smallestanimalsize! < Size.size.big)
                                {
                                    smallestanimalsize = Size.size.big;
                                }
                                break;
                        }
                        if (wagon.Hascarnivore == false && newanimal.Points + wagon.Points! > 10 && newanimal.Size < smallestanimalsize)
                        {
                            animaladded = true;
                            wagon.Hascarnivore = true;
                            wagon.Animals.Add(newanimal);
                            break;
                        }
                        else
                        {
                            Wagon newwagon = addwagon();
                            newwagon.Animals.Add(newanimal);
                            newwagon.Hascarnivore = true;
                            animaladded = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (Wagon wagon in WagonList)
                {
                    if (wagon.Hascarnivore == false && newanimal.Points + wagon.Points! > 10)
                    {
                        animaladded = true;
                        wagon.Hascarnivore = true;
                        wagon.Animals.Add(newanimal);
                        break;
                    }
                    else if (wagon.Hascarnivore == true && newanimal.Points + wagon.Points! > 10)
                    {
                        Size.size carnivoresize = new();
                        foreach (Animal wagonanimal in wagon.Animals)
                        {
                            switch (wagonanimal.Size)
                            {
                                case Size.size.small:
                                        carnivoresize = Size.size.small;
                                    break;
                                case Size.size.medium:
                                        carnivoresize = Size.size.medium;
                                    break;
                                case Size.size.big:
                                        carnivoresize = Size.size.big;
                                    break;
                            }
                        }
                        if(newanimal.Size > carnivoresize)
                        {
                            wagon.Animals.Add (newanimal);
                            animaladded = true;
                            break;
                        }
                    }
                    else
                    {
                        Wagon newwagon = addwagon();
                        newwagon.Animals.Add(newanimal);
                        animaladded = true;
                        break;
                    }
                }
            }
        }
    }
}
