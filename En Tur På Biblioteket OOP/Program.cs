using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_Tur_På_Biblioteket_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Books døden = new Books("Døden", 1);
            Books hjernen = new Books("Hjernen", 1);
            Books denFortvivledeDame = new Books("Den fortvivlede dame", 1);
            Books morderen = new Books("Morderen", 1);
            List<Books> books = new List<Books>();
            books.Add(døden);
            books.Add(hjernen);
            books.Add(denFortvivledeDame);
            books.Add(morderen);
            Stack<Books> borrowedBooks = new Stack<Books>();

            for (; ; )
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("       Borrow some books");
                Console.WriteLine("-------------------------------\n");
                Console.WriteLine("1. Hjernen");
                Console.WriteLine("2. Døden");
                Console.WriteLine("3. Den Fortvivlede Dame");
                Console.WriteLine("4. Morderen\n");
                Console.WriteLine("Books selected count: " + borrowedBooks.Count);

                Console.WriteLine("\n\rWrite the number for the book u want. Press 9 for finish");

                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 1)
                    borrowedBooks.Push(hjernen);
                if (number == 2)
                    borrowedBooks.Push(døden);
                if (number == 3)
                    borrowedBooks.Push(denFortvivledeDame);
                if (number == 4)
                    borrowedBooks.Push(morderen);
                else if (number == 9)
                {
                    Console.Clear();
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine(" Here are your books selected");
                    Console.WriteLine("-------------------------------\n");
                    int a = borrowedBooks.Count;
                    for (int i = 0; i < a; i++)
                    {
                        Console.WriteLine(borrowedBooks.Peek().Name);
                        borrowedBooks.Pop();
                    }       
                }              
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
