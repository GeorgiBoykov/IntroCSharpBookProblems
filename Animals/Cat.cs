namespace Animals
{
    using System;

    public class Cat : Animal, ISound
    {
        public override void ProduceSound()
        {
            Console.WriteLine("Myauuuu");
        }

        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {
        }
    }
}


