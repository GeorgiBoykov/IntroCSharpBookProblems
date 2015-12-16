//7. Define your own namespace CreatingAndUsingObjects and place in it
//two classes Cat and Sequence, which we used in the examples of the
//current chapter. Define one more namespace and make a class, which
//calls the classes Cat and Sequence, in it.

namespace CreatingAndUsingObjects
{
    using AnotherNamespace;

    public class ProgramMain
    {
        static void Main()
        {
            AnotherClass anotherClass = new AnotherClass();

            anotherClass.CallClasses();
        }
    }
}
