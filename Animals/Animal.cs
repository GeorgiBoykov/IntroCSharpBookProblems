namespace Animals 
{
    using System;

    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (String.IsNullOrEmpty(value.ToString()))
                {
                    throw new ArgumentNullException();
                }
                if (value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.gender = value;
            }
        }

        public virtual void ProduceSound()
        {
            Console.WriteLine("Unknown sound");
        }
    }
}
