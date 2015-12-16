// 6. Implement the following classes: Dog, Frog, Cat, Kitten and Tomcat. All of
// them are animals (Animal). Animals are characterized by age, name and
// gender. Each animal makes a sound (use a virtual method in the Animal
// class). Create an array of different animals and print on the console their
// name, age and the corresponding sound each one makes

namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AnimalsMain
    {
        static void Main(string[] args)
        {
            Cat matsa = new Cat("Matsa", 12, "female");
            Cat patsa = new Cat("Patsa", 15, "female");
            matsa.ProduceSound();

            Dog sharo = new Dog("Sharo", 9, "male");
            sharo.ProduceSound();

            Frog froggy = new Frog("Froggy", 2, "male");
            froggy.ProduceSound();

            Kitten kitty = new Kitten("Kitty", 5, "female");
            kitty.ProduceSound();

            TomCat tom = new TomCat("Tom", 12, "male");
            tom.ProduceSound();

            Console.WriteLine("\n-Avarage life length-\n");

            List<Animal> animalsList = new List<Animal>() { sharo, tom, kitty, froggy, matsa, patsa };

            Dictionary<string, List<int>> avarageAgeList = new Dictionary<string, List<int>>();

            foreach (Animal a in animalsList)
            {
                string type = a.GetType().ToString();
                if (avarageAgeList.ContainsKey(type))
                {
                    avarageAgeList[type].Add(a.Age);
                }
                else
                {
                    List<int> temp = new List<int>();
                    temp.Add(a.Age);
                    avarageAgeList.Add(type, temp);
                }
            }

            foreach (string animal in avarageAgeList.Keys)
            {
                Console.WriteLine(animal + ": " + avarageAgeList[animal].Average());
            }
        }
    }
}
