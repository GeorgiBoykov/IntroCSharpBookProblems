// 20. There is a book library. Define classes respectively for a book and a
// library. The library must contain a name and a list of books. The books
// must contain the title, author, publisher, release date and ISBN-number.
// In the class, which describes the library, create methods to add a book to
// the library, to search for a book by a predefined author, to display
// information about a book and to delete a book from the library.

namespace BookLibrary
{
    using System;

    public class BookLibraryMain
    {
        static void Main()
        {
            Library library = new Library("TestLibrary");

            Book book = new Book("Intro C#", "Nakov", "Pesho", DateTime.Now, "121-12-12--12");
            library.AddBook(book);

            Console.WriteLine(library.GetBookInfo(book));

            Book foundBook = library.SearchBook("Nakov");

            //Console.WriteLine(library.GetBookInfo(foundBook));
        }
    }
}
