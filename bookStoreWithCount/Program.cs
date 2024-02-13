using System;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book1.SetTrans();
            book1.SetId(1);
            book1.SetTitle("One Piece");
            book1.SetAuthor("Eiichiro Oda");

            book book2 = new book();
            book2.SetTrans();
            Console.WriteLine("Please enter the book ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book author: ");
            book2.SetAuthor(Console.ReadLine());

            book book3 = new book(3, "Blue Lock", "Muneyuki Kaneshiro, Nomura Yusuke");
            book3.SetTrans();

            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the book author: ");
            string tempAuthor = Console.ReadLine();
            book book4 = new book(tempID, tempTitle, tempAuthor);
            book4.SetTrans();

            Console.WriteLine($"Number of transactions: {book.GetTotalTransactions()}");

            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
        }

        class book
        {
            private int _Id;
            private string _Title;
            private string _Author;
            private static int _Transactions = 0;

            public book()
            {
            }
            public book(int id, string title, string author)
            {
                _Id = id;
                _Title = title;
                _Author = author;
            }
            public int GetTrans()
            {
                return _Transactions;
            }
            public void SetTrans() 
            {
                _Transactions++;
            }
            public static int GetTotalTransactions()
            {
                return _Transactions;
            }
            public int GetId()
            {
                return _Id;
            }

            public void SetId(int id)
            {
                _Id = id;
            }

            public string GetTitle()
            {
                return _Title;
            }

            public void SetTitle(string title)
            {
                _Title = title;
            }

            public string GetAuthor()
            {
                return _Author;
            }

            public void SetAuthor(string author)
            {
                _Author = author;
            }
        }
        static void displayBooks(book b)
        {
            Console.WriteLine("Book Information:");
            Console.WriteLine($"Book ID: {b.GetId()}");
            Console.WriteLine($"Book Title: {b.GetTitle()}");
            Console.WriteLine($"Book Author: {b.GetAuthor()}");
            Console.WriteLine();
        }
    }
}