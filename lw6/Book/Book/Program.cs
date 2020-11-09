using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bk = new Book();
            bk.BookName = "X";
            bk.BookAuthor = "Y";
            bk.BookId = "123";
            bk.BookType = "Thriller";
            bk.BookCopy = 10;

            Console.WriteLine("Book name is: " + bk.BookName);
            Console.WriteLine("Book author is: " + bk.BookAuthor);
            Console.WriteLine("Book id is :" + bk.BookId);
            Console.WriteLine("Book type is :" + bk.BookType);
            Console.WriteLine("Book copy amount is :" + bk.BookCopy);


        }
        public class Book
        {
            private string bookName;
            private string bookAuthor;
            private string bookId;
            private string bookType;
            private int bookCopy;

            public string BookName
            {
                get { return bookName; }
                set { bookName = value; }
            }
            public string BookAuthor
            {
                get { return bookAuthor; }
                set { bookAuthor = value; }
            }
            public string BookId
            {
                get { return bookId; }
                set { bookId = value; }
            }
            public string BookType
            {
                get { return bookType; }
                set { bookType = value; }
            }
            public int BookCopy
            {
                get { return bookCopy; }
                set { bookCopy = value; }
            }

            public void AddBookCopy(int x)
            {
                bookCopy += x;
            }
        }
    }
}
