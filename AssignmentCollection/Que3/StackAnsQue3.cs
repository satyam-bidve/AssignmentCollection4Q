using AssignmentCollection.Que1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3. Write a C# program to keep 5 different the books in Stack. Get the Book Name from the user.
Access the third book and print its name.*/
namespace AssignmentCollection.Que3
{

    //1. get user input store 5 books 👍
    //2. store each book in stack 

    internal class StackAnsQue3
    {
        Stack<Book> books = new Stack<Book>();
        public void Getuserdata()
        {
           for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Enter your book details  :");
                Console.Write("Enter your BookName = : ");
                string BookName = Console.ReadLine();

                Console.Write($"Enter {BookName}'s Discription  : ");
                string Discription = Console.ReadLine();

                // add to stack 
                books.Push(new Book() { BookName = BookName , Description = Discription });

            }

          
        }

        public void ThirdBookFromStack()
        {
           Book thirdBook =  books.ElementAt(4);
            Console.WriteLine("Third book in stack is ");
            Console.WriteLine($"name = {thirdBook.BookName}");
            Console.WriteLine($"Discription = {thirdBook.Description}");
        }



    }
}
