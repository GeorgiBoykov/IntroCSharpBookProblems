namespace BookLibrary
{
    using System;

    public class Book
    {
        private string title;
        private string author;
        private string publisher;
        private DateTime releaseDate;
        private string isbn;

        public Book(string title, string author, string publisher, DateTime releaseDate, string isbn)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBN = isbn;
        }

        public string Title 
        {
            get 
            {
                return this.title;
            } 
            set 
            {
                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                this.author = value;
            }
        }

        public string Publisher
        {
            get
            {
                return this.publisher;
            }
            set
            {
                this.publisher = value;
            }
        }

        public DateTime ReleaseDate
        {
            get
            {
                return this.releaseDate;
            }
            set
            {
                this.releaseDate = value;
            }
        }

        public string ISBN
        {
            get
            {
                return this.isbn;
            }
            set
            {
                this.isbn = value;
            }
        }
    }
}
