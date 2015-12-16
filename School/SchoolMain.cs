// 5. By using the extension methods OrderBy(…) and ThenBy(…) with lambda
// expression, sort a list of students by their first and last name in
// descending order. Rewrite the same functionality using a LINQ query.

namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SchoolMain
    {
        static void Main()
        {
            School school = new School();

            school.Students.Add(new Student { FirstName = "Ivan", LastName = "Ivanov" });
            school.Students.Add(new Student { FirstName = "Angel", LastName = "Todorov" });
            school.Students.Add(new Student { FirstName = "Marin", LastName = "Marinov" });
            school.Students.Add(new Student { FirstName = "Tosho", LastName = "Toshov" });
            school.Students.Add(new Student { FirstName = "Pesho", LastName = "Peshev" });

            IOrderedEnumerable<Student> sortedStudentsQuery =
                from student in school.Students
                orderby student.FirstName descending, student.LastName descending
                select student;

            List<Student> sortedStudentsLinq = school.Students
                .OrderByDescending(s => s.FirstName)
                .ThenByDescending(s => s.LastName)
                .ToList();

            Console.WriteLine("-Linq Query-\n");
            foreach (Student student in sortedStudentsQuery)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n-Lambda Expression-\n");
            foreach (Student student in sortedStudentsLinq)
            {
                Console.WriteLine(student);
            }
        }
    }
}
