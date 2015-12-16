namespace AnotherNamespace
{
    using CreatingAndUsingObjects;
    using System;

    public class AnotherClass
    {
        public AnotherClass()
        {
        }

        public void CallClasses()
        {
            Cat cat = new Cat("Tom", "Brown");
            cat.SayMiau();

            Console.WriteLine("Sequence[1...3]: {0}, {1}, {2}",
            Sequence.NextValue(), Sequence.NextValue(),
            Sequence.NextValue());
        }
    }
}