namespace BookLibrary
{
    using System.Collections.Generic;
    using System.Linq;

    public class Library
    {
        private string name;
        private List<Book> books;

        public Library(string name)
        {
            this.Name = name;
            this.Books = new List<Book>();
        }

        public List<Book> Books { 
            get 
            {
                return this.books;
            }
            set 
            {
                this.books = value;
            }
        }

        public string Name 
        {
            get
            {
                return this.name;
            } 
            set 
            {
                this.name = value;
            } 
        }

        public void AddBook(Book book)
        {
            this.Books.Add(book);
        }

        public Book SearchBook(string author)
        {
            return this.Books.FirstOrDefault(b => b.Author == author);
        }

        public string GetBookInfo(Book book)
        {
            return string.Format("Title: {0}\nAuthor: {1}\nPublisher: {2}\nRelease Date: {3}\nISBN: {4}"
                , book.Title, book.Author, book.Publisher, book.ReleaseDate, book.ISBN);
        }

        public void DeleteBook(Book book)
        {
            this.Books.Remove(book);
        }
    }
}
