using AssignmentCollection.Que1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2. Write a C# Program to operate the Bank Token system, where people can get the unique
token number which will be tied up with Customer name (Use Dictionary). Get the
information of 5 customers (Token Number and Customer Name) from User and Make sure
that you are serving the customer sequentially (Use Queue to add customers).
Print the Customer Details after serving him (Token Number, Customer Name, Withdraw
Amount) in tabular format.*/
namespace AssignmentCollection.Que2
{
    internal class DictionaryAnsQue2
    {
        // Token == Random -- use random class to generate number 1-100 this will be the kwy for dictionary 
        // need customer class object cust with name prop ❓ token generate random or taken from user ⭕  take from user 
        // put dic to que and tag them one by one as servd 
        // after serev print cust 

        Dictionary <int,Customer> customers = new Dictionary <int,Customer> ();
        Queue<Customer> customerQueue = new Queue<Customer>();
        Queue<Customer> servedCustomerQueue = new Queue<Customer>();
        int Withdraw;
        public  void Getuserdata()
        {
            int custCount = 0;
            for (int i = 0; i < 5; i++)
            {
                
                Console.Clear();
                Console.WriteLine($"Enter your information for customer {++custCount} :");

                Console.Write("Enter your Token number  = : ");
                int Token = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your  Name = : ");
                string Name = Console.ReadLine();

                // Need to check if Token is already taken by any other customer or not 
                 if (customers.ContainsKey(Token))
                {
                    Console.WriteLine("This token is already taken try another one");
                }
               else if (!customers.ContainsKey(Token))
                {
                    customers.Add(Token, new Customer() { Name = Name, Token = Token });
                }

            }

            // After adding the details to customers DICT 👇

        }

        // adding the customers to queue
        public void ServeCustomer()
        {

            
            foreach (Customer customer in customers.Values)
            {
                customerQueue.Enqueue(customer);
            }

            // now cosutomer is in queue so perform money Withdraw

            foreach (Customer currentCust in customerQueue)
            {

                //Customer currentCust = customerQueue.Peek(); // here we get 1 customer in queue   ❌  every time loop start we get same cust
                Console.WriteLine($"Hello {currentCust.Name} Enter how much you want to Withdraw :");
                Withdraw = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The amout you Withdraw successfully -- {Withdraw}");
                Console.WriteLine($"Your current balance is {(currentCust.money) - Withdraw}"); // here we get balance as well as Withdraw amount
                // lets put the served customer to other queue
                currentCust.money = (currentCust.money) - Withdraw;
                currentCust.Withdrawl = Withdraw;
                 servedCustomerQueue.Enqueue(currentCust);


            }

        }

        // print the queue now that is after customer is serve 
        public void PrintUserData()
        {
            Console.Clear();
            Console.WriteLine(" Customers served - : \n\n");
            Console.WriteLine("------- Token-------Name---------withdraw---------balance\n");
            foreach (Customer o in servedCustomerQueue)
            {
                Console.Write($"        {o.Token}");
                Console.Write($"        {o.Name}");
                Console.Write($"        {o.Withdrawl}");
                Console.Write($"        {o.money}\n\n");

            }
        }

             











    }
}
