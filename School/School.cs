namespace School
{
    using System.Collections.Generic;

    public class School
    {
        public School()
        {
            this.Students = new List<Student>();
        }

        public List<Student> Students { get; set; }
    }
}
