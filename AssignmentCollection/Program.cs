using System;
using System.Runtime.CompilerServices;
using AssignmentCollection.Que1;
using AssignmentCollection.Que2;
using AssignmentCollection.Que3;
using AssignmentCollection.Que4;

/* ---------------------------------------------------------------------------------------------------
 1. Write a C# program that uses a ArrayList to store a list of people.
Required: Create a class called Member.cs with properties (Name, Age and Location)
Then use a ArrayList and request the information (Name, Age and Location) of three
members from the user, you will have to store the information in the list
After getting data from user, print that in tabular format.


2. Write a C# Program to operate the Bank Token system, where people can get the unique
token number which will be tied up with Customer name (Use Dictionary). Get the
information of 5 customers (Token Number and Customer Name) from User and Make sure
that you are serving the customer sequentially (Use Queue to add customers).
Print the Customer Details after serving him (Token Number, Customer Name, Withdraw
Amount) in tabular format.


3. Write a C# program to keep 5 different the books in Stack. Get the Book Name from the user.
Access the third book and print its name.


4. Write a C# program to get the List of Tour Package types(Package Name, Location and
Number Of Days). Asked user to search package based on 2 criteria (package name and
number of days) and check if any package is available or not. If it is not available then get the
choice from user whether the searched package need to add in the list or not. If he wanted
to add that package then get the details from user and store that in the List. 
 -----------------------------------------------------------------------------------------------------------
 */

namespace ConsoleApp2Lec1
{
    internal class Program
    {



        
        static void Showmenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------Assignement Questions ------------");
            Console.WriteLine("Que 1 - Write a C# program that uses a ArrayList to store a list of people.");
            Console.WriteLine("Que 2 - Write a C# Program to operate the Bank Token system");
            Console.WriteLine("Que 3 -  Write a C# program to keep 5 different the books in Stack.");
            Console.WriteLine("Que 4 - Write a C# program to get the List of Tour Package types(Package Name, Location and\r\nNumber Of Days)");

            Console.ResetColor();
        }

        


        static void TakingOptionAndOpration()
        {
           Console.WriteLine("Please choose one of the Question to see its implementation");

            int choice = int.Parse(Console.ReadLine());

            // Objects ------------
            ListAnsQue4 Que4Obj = new ListAnsQue4();
            StackAnsQue3 Que3Obj = new StackAnsQue3();
            DictionaryAnsQue2 Que2Obj = new DictionaryAnsQue2();
            ArrayListAnsQue1 Que1Obj = new ArrayListAnsQue1();
            switch (choice)
            {
                
                case 1:
                    Que1Obj.Getuserdata();
                    Que1Obj.Getuserdata();
                    Que1Obj.Getuserdata();
                    Que1Obj.PrintUserData();
                    break;
                case 2:
                    Que2Obj.Getuserdata();
                    Que2Obj.ServeCustomer();
                    Que2Obj.PrintUserData();
                    break;
                case 3:
                    Que3Obj.Getuserdata();
                    Que3Obj.ThirdBookFromStack();
                    break;
                case 4:
                    Que4Obj.addSampleData();
                    Que4Obj.searchPackage();
                    
                    break;


            }
                
        }




            



        

      
        static void Main(string[] args)
        {
            Console.WriteLine("------------------Welcome-----------------");

           
            Boolean wantRepeat = true;
            do
            {


                Showmenu();
                TakingOptionAndOpration();

                Console.WriteLine("Do you want to continue ? if yes Enter Y and if no then N  ");
                string reapeatChoice = Console.ReadLine();
                if (reapeatChoice == "Y" || reapeatChoice == "y")
                {
                    Console.Clear();
                    wantRepeat = true;
                }
                else if (reapeatChoice == "N" || reapeatChoice == "n")
                {
                    wantRepeat = false;
                    Console.Clear();
                    Console.WriteLine("Thanks for your time :)");
                }
            }
            while (wantRepeat);






        }
    }
}

