using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    public class Train
    {
        public List<Wagon> WagonList { get; set; }
        public Train()
        {
            WagonList = new List<Wagon>();
            Wagon wagon = new Wagon(1);
            WagonList.Add(wagon);
        }
        public Wagon addwagon()
        {
                Wagon newwagon = new Wagon(WagonList.Count + 1);
                WagonList.Add(newwagon);
                return newwagon;
        }

        public void addanimal(List<Animal> newanimals)
        {

            newanimals.Sort((x, y) => y.Points.CompareTo(x.Points));
            foreach (Animal newanimal in newanimals)
            {
                bool animaladded = false;
                if (WagonList[0].Animals.Count == 0)
                {
                    WagonList[0].Animals.Add(newanimal);
                    WagonList[0].Points = WagonList[0].Points + newanimal.Points;
                    animaladded = true;
                    if (newanimal.Carnivore == true)
                    {
                        WagonList[0].Hascarnivore = true;
                    }
                }
                if (newanimal.Carnivore == true && animaladded == false)
                {
                    animaladded = tryaddcarnivore(newanimal, animaladded);
                }
                else if (animaladded == false)
                {
                    animaladded = tryaddherbivore(newanimal, animaladded);
                    if (animaladded == false)
                    {
                        Wagon newwagon = addwagon();
                        newwagon.Animals.Add(newanimal);
                        newwagon.Points = newwagon.Points + newanimal.Points;
                        animaladded = true;
                    }
                }
            }
        }


        public bool tryaddcarnivore(Animal newanimal, bool animaladded)
        {
            foreach (Wagon wagon in WagonList)
            {
                Size.size smallestanimalsize = new();
                foreach (Animal wagonanimal in wagon.Animals)
                {
                    switch (wagonanimal.Size)
                    {
                        case Size.size.small:
                            if (smallestanimalsize >= Size.size.small)
                            {
                                smallestanimalsize = Size.size.small;
                            }
                            break;
                        case Size.size.medium:
                            if (smallestanimalsize >= Size.size.medium)
                            {
                                smallestanimalsize = Size.size.medium;
                            }
                            break;
                        case Size.size.big:
                            if (smallestanimalsize >= Size.size.big)
                            {
                                smallestanimalsize = Size.size.big;
                            }
                            break;
                    }

                }
                if (wagon.Hascarnivore == false && newanimal.Points + wagon.Points < 11 && newanimal.Size < smallestanimalsize)
                {
                    animaladded = true;
                    wagon.Hascarnivore = true;
                    wagon.Animals.Add(newanimal);
                    wagon.Points = wagon.Points + newanimal.Points;
                    break;
                }
                else
                {
                    Wagon newwagon = addwagon();
                    newwagon.Animals.Add(newanimal);
                    wagon.Points = wagon.Points + newanimal.Points;
                    newwagon.Hascarnivore = true;
                    animaladded = true;
                    break;
                }
            }
            return animaladded;
        }

        public bool tryaddherbivore(Animal newanimal, bool animaladded)
        {
            foreach (Wagon wagon in WagonList)
            {
                if (wagon.Hascarnivore == false && newanimal.Points + wagon.Points < 11)
                {
                    animaladded = true;
                    wagon.Animals.Add(newanimal);
                    wagon.Points = wagon.Points + newanimal.Points;
                    break;
                }
                else if (wagon.Hascarnivore == true && newanimal.Points + wagon.Points < 11)
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
                        if (newanimal.Size > carnivoresize)
                        {
                            wagon.Animals.Add(newanimal);
                            wagon.Points = wagon.Points + newanimal.Points;
                            animaladded = true;
                            return animaladded;
                        }
                    }
                }
            }
            return animaladded;
        }
    }
}
