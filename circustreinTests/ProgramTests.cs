using Microsoft.VisualStudio.TestTools.UnitTesting;
using circustrein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace circustrein.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void scenario1()
        {
            //properties
            Train train = new Train();
            List<Animal> animallist = new List<Animal>();
            Animal animal1 = new Animal("compy" , Size.size.small, true);
            animallist.Add(animal1);

            Animal animal2 = new Animal("anky", Size.size.medium, false);
            animallist.Add(animal2);

            Animal animal3 = new Animal("para", Size.size.medium, false);
            animallist.Add(animal3);

            Animal animal4 = new Animal("theri", Size.size.medium, false);
            animallist.Add(animal4);

            Animal animal5 = new Animal("bronto", Size.size.big, false);
            animallist.Add(animal5);

            Animal animal6 = new Animal("diplo", Size.size.big, false);
            animallist.Add(animal6);

            //sorting
            train.addanimal(animallist);


            //result
            Assert.IsTrue(train.WagonList.Count == 2);
        }

        [TestMethod()]
        public void scenario2()
        {
            //properties
            Train train = new Train();
            List<Animal> animallist = new List<Animal>();
            
            for(int i = 0; i < 1;i++)
            {
                Animal animal = new Animal("small carnivore", Size.size.small, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 0; i++)
            {
                Animal animal = new Animal("medium carnivore", Size.size.medium, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 0; i++)
            {
                Animal animal = new Animal("big carnivore", Size.size.big, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 5; i++)
            {
                Animal animal = new Animal("small herbivore", Size.size.small, false);
                animallist.Add(animal);
            }
            for (int i = 0; i < 2; i++)
            {
                Animal animal = new Animal("medium herbivore", Size.size.medium, false);
                animallist.Add(animal);
            }
            for (int i = 0; i < 1; i++)
            {
                Animal animal = new Animal("big herbivore", Size.size.big, false);
                animallist.Add(animal);
            }

            //sorting

                train.addanimal(animallist);


            //result
            Assert.IsTrue(train.WagonList.Count == 2);
        }

        [TestMethod()]
        public void scenario3()
        {
            //properties
            Train train = new Train();
            List<Animal> animallist = new List<Animal>();
            for (int i = 0; i < 1; i++)
            {
                Animal animal = new Animal("small carnivore", Size.size.small, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 1; i++)
            {
                Animal animal = new Animal("medium carnivore", Size.size.medium, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 1; i++)
            {
                Animal animal = new Animal("big carnivore", Size.size.big, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 1; i++)
            {
                Animal animal = new Animal("small herbivore", Size.size.small, false);
                animallist.Add(animal);
            }
            for (int i = 0; i < 1; i++)
            {
                Animal animal = new Animal("medium herbivore", Size.size.medium, false);
                animallist.Add(animal);
            }
            for (int i = 0; i < 1; i++)
            {
                Animal animal = new Animal("big herbivore", Size.size.big, false);
                animallist.Add(animal);
            }

            //sorting
                train.addanimal(animallist);


            //result
            Assert.IsTrue(train.WagonList.Count == 4);
        }

        [TestMethod()]
        public void scenario4()
        {
            //properties
            Train train = new Train();
            List<Animal> animallist = new List<Animal>();
            for (int i = 0; i < 2; i++)
            {
                Animal animal = new Animal("small carnivore", Size.size.small, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 1; i++)
            {
                Animal animal = new Animal("medium carnivore", Size.size.medium, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 1; i++)
            {
                Animal animal = new Animal("big carnivore", Size.size.big, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 1; i++)
            {
                Animal animal = new Animal("small herbivore", Size.size.small, false);
                animallist.Add(animal);
            }
            for (int i = 0; i < 5; i++)
            {
                Animal animal = new Animal("medium herbivore", Size.size.medium, false);
                animallist.Add(animal);
            }
            for (int i = 0; i < 1; i++)
            {
                Animal animal = new Animal("big herbivore", Size.size.big, false);
                animallist.Add(animal);
            }

            //sorting

                train.addanimal(animallist);
            


            //result
            Assert.IsTrue(train.WagonList.Count == 5);
        }

        [TestMethod()]
        public void scenario5()
        {
            //properties
            Train train = new Train();
            List<Animal> animallist = new List<Animal>();
            for (int i = 0; i < 1; i++)
            {
                Animal animal = new Animal("small carnivore", Size.size.small, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 0; i++)
            {
                Animal animal = new Animal("medium carnivore", Size.size.medium, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 0; i++)
            {
                Animal animal = new Animal("big carnivore", Size.size.big, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 1; i++)
            {
                Animal animal = new Animal("small herbivore", Size.size.small, false);
                animallist.Add(animal);
            }
            for (int i = 0; i < 1; i++)
            {
                Animal animal = new Animal("medium herbivore", Size.size.medium, false);
                animallist.Add(animal);
            }
            for (int i = 0; i < 2; i++)
            {
                Animal animal = new Animal("big herbivore", Size.size.big, false);
                animallist.Add(animal);
            }

            //sorting
                train.addanimal(animallist);


            //result
            Assert.IsTrue(train.WagonList.Count == 2);
        }

        [TestMethod()]
        public void scenario6()
        {
            //properties
            Train train = new Train();
            List<Animal> animallist = new List<Animal>();
            for (int i = 0; i < 3; i++)
            {
                Animal animal = new Animal("small carnivore", Size.size.small, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 0; i++)
            {
                Animal animal = new Animal("medium carnivore", Size.size.medium, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 0; i++)
            {
                Animal animal = new Animal("big carnivore", Size.size.big, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 0; i++)
            {
                Animal animal = new Animal("small herbivore", Size.size.small, false);
                animallist.Add(animal);
            }
            for (int i = 0; i < 2; i++)
            {
                Animal animal = new Animal("medium herbivore", Size.size.medium, false);
                animallist.Add(animal);
            }
            for (int i = 0; i < 3; i++)
            {
                Animal animal = new Animal("big herbivore", Size.size.big, false);
                animallist.Add(animal);
            }

            //add animals
                train.addanimal(animallist);
            


            //result
            Assert.IsTrue(train.WagonList.Count == 3);
        }
        [TestMethod()]
        public void scenario7()
        {
            //properties
            Train train = new Train();
            List<Animal> animallist = new List<Animal>();
            for (int i = 0; i < 7; i++)
            {
                Animal animal = new Animal("small carnivore", Size.size.small, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 3; i++)
            {
                Animal animal = new Animal("medium carnivore", Size.size.medium, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 3; i++)
            {
                Animal animal = new Animal("big carnivore", Size.size.big, true);
                animallist.Add(animal);
            }
            for (int i = 0; i < 0; i++)
            {
                Animal animal = new Animal("small herbivore", Size.size.small, false);
                animallist.Add(animal);
            }
            for (int i = 0; i < 5; i++)
            {
                Animal animal = new Animal("medium herbivore", Size.size.medium, false);
                animallist.Add(animal);
            }
            for (int i = 0; i < 6; i++)
            {
                Animal animal = new Animal("big herbivore", Size.size.big, false);
                animallist.Add(animal);
            }

            //sorting

                train.addanimal(animallist);


            //result
            Assert.IsTrue(train.WagonList.Count == 13);
        }
    }
}