﻿namespace bookStore
{
    class book
    {
        private static int _transactions = 0;

        

        public void SetTrans()
        {
            _transactions=+1;
        }
        public int GetTrans()
        { 
            return _transactions; 
        }

        private int _Id;
        private string _Title;
        private string _Author;


        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }
        public book(int id, string title, string author)
        {
            _Id=id;
            _Title=title;
            _Author=author;
        }
        public int Get_Id()
        {
            return _Id;
        }
        public int Set_Id(int v)
        {
            return _Id;
        }

        public string Get_Title()
        {
            return _Title;
        }
        public string Set_Title(string v)
        {
            return _Title;
        }
        public string Get_Author()
        {
            return _Author;
        }
        public string Set_Author(string v)
        {
            return _Author;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            book member1 = new book();
            member1.Set_Id(1);
            member1.Set_Title("Holes");
            member1.Set_Author("Louis Sachar");
            

            book member2 = new book();
            Console.WriteLine("Please enter your library ID");
            member2.Set_Id(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the Book title");
            member2.Set_Title(Console.ReadLine());
            Console.WriteLine("Please enter the Author of book");
            member2.Set_Author(Console.ReadLine());

            book member3 = new book(3, "Captain Underpants and the Invasion of the Incredibly Naughty Cafeteria Ladies from Outer Space (and the Subsequent Assault of the Equally Evil Lunchroom Zombie Nerds)", "Dav Pilkey");


            Console.WriteLine("Please enter Library ID:");
            int _Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book title:");
            string _Title = Console.ReadLine();
            Console.WriteLine("Please enter the Author of book:");
            string _Author = Console.ReadLine();
            book member = new book(_Id, _Title, _Author);

            displayBooks(member);
            displayBooks(member3);
            displayBooks(member2);
            displayBooks(member1);
        }

        static void displayBooks(book member)
        {
            Console.WriteLine("Here's ypur library ID, Book and Author");
            Console.WriteLine($"Library ID: {member.Get_Id()}");
            Console.WriteLine($"Book:{member.Get_Title()}");
            Console.WriteLine($"Author:{member.Get_Author()}");
        }

    }
}