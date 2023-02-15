using System;
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
            List<Animal> sortedanimallist = new();
            int totalpoints = 0;
            foreach(Animal animal in newanimals)
            {
                totalpoints = totalpoints + animal.Points;
            }
            if (totalpoints % 2 != 0 || totalpoints % 10 == 0)
            {
                sortedanimallist = newanimals.OrderBy(x => x.Points).ThenByDescending(x => x.Carnivore).ToList();
            }
            else
            {
               sortedanimallist = newanimals.OrderBy(x => x.Size).ThenByDescending(x => x.Carnivore).ToList();
            }
            

            foreach (Animal newanimal in sortedanimallist)
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
                    if (animaladded == false)
                    {
                        Wagon newwagon = addwagon();
                        newwagon.Animals.Add(newanimal);
                        newwagon.Points = newwagon.Points + newanimal.Points;
                        animaladded = true;
                        newwagon.Hascarnivore = true;
                    }
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
                int smallestanimalsize = wagon.Animals[0].Points;
                foreach (Animal wagonanimal in wagon.Animals)
                {
                    switch (wagonanimal.Size)
                    {
                        case Size.size.small:
                            if (smallestanimalsize >= 1)
                            {
                                smallestanimalsize = 1;
                            }
                            break;
                        case Size.size.medium:
                            if (smallestanimalsize >= 3)
                            {
                                smallestanimalsize = 3;
                            }
                            break;
                        case Size.size.big:
                            if (smallestanimalsize >= 5)
                            {
                                smallestanimalsize = 5;
                            }
                            break;
                    }
                }
                if (wagon.Hascarnivore == false && newanimal.Points + wagon.Points < 11 && newanimal.Points < smallestanimalsize)
                {
                    animaladded = true;
                    wagon.Hascarnivore = true;
                    wagon.Animals.Add(newanimal);
                    wagon.Points = wagon.Points + newanimal.Points;
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
                    int carnivoresize = new();
                    foreach (Animal wagonanimal in wagon.Animals)
                    {
                        switch (wagonanimal.Points)
                        {
                            case 1:
                                carnivoresize = 1;
                                break;
                            case 3:
                                carnivoresize = 3;
                                break;
                            case 5:
                                carnivoresize = 5;
                                break;
                        }
                        if (newanimal.Points > carnivoresize)
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