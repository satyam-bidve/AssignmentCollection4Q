using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/*1. Write a C# program that uses a ArrayList to store a list of people.
Required: Create a class called Member.cs with properties (Name, Age and Location)
Then use a ArrayList and request the information (Name, Age and Location) of three
members from the user, you will have to store the information in the list
After getting data from user, print that in tabular format.*/
namespace AssignmentCollection.Que1
{
    internal class ArrayListAnsQue1
    {
        ArrayList UsersData = new ArrayList();
        public void Getuserdata()
        {
            Console.Clear();
            Console.WriteLine("Enter your information below as mention :");
            Console.Write("Enter your name = : "); 
            string Name = Console.ReadLine();
            Console.Write("Enter your age = : ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Location = : ");
            string Location = Console.ReadLine();

            UsersData.Add(new Members() { Name = Name ,Age = Age, Location = Location });



        }
          
        public void PrintUserData()
        {
            Console.Clear();
            Console.WriteLine(" Here is the User Data\n\n");
            Console.WriteLine("------- Name-------Age----------Location---------\n");
            foreach (Members o in UsersData)
            {

                /*Console.Write(o.Name);
                Console.Write(o.Age);
                Console.Write(o.Location);*/

               
                Console.Write($"        {o.Name}");
                Console.Write($"        {o.Age}");
                Console.Write($"        {o.Location}\n\n");

            }
        }
            



    }
}
