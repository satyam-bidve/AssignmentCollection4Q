using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/*4. Write a C# program to get the List of Tour Package types(Package Name, Location and
Number Of Days). Asked user to search package based on 2 criteria (package name and
number of days) and check if any package is available or not. If it is not available then get the
choice from user whether the searched package need to add in the list or not. If he wanted
to add that package then get the details from user and store that in the List. */
namespace AssignmentCollection.Que4
{
   

    internal class ListAnsQue4
    {
        List<PackageTour> listPackageTour=new List<PackageTour>();
        List<PackageTour> listFoundPackageTour = new List<PackageTour>();

        public void addSampleData() 
        {
            listPackageTour.Add(new PackageTour() { PackageName = "South",Location ="Keral", days = 14 });
            listPackageTour.Add(new PackageTour() { PackageName = "Moont", Location = "Hima", days = 8 });
            listPackageTour.Add(new PackageTour() { PackageName = "Beach", Location = "Bali", days = 10 });
            listPackageTour.Add(new PackageTour() { PackageName = "CityT", Location = "Paris", days = 5 });
            listPackageTour.Add(new PackageTour() { PackageName = "Country", Location = "Tusc", days = 7 });
        }

        public void searchPackage()
        {
            Console.WriteLine("Enter Which package to serach - :do you want to get and for how many days :");
            Console.Write("Package Name :");
            string Pakage = Console.ReadLine();
            Console.Write("days :");
            int days  = Convert.ToInt32(Console.ReadLine());
            if (listPackageTour.Any(x => (x.PackageName == Pakage) && x.days == days))
            {
                Console.WriteLine("Here are the packages that match your requirement");
                Console.WriteLine("----------- PackageName----------Days--------------Location---------\n");
                listFoundPackageTour = listPackageTour.FindAll(x => (x.PackageName == Pakage && x.days == days));
                foreach (PackageTour item in listFoundPackageTour)
                {
                    Console.Write($"           {item.PackageName}");
                    Console.Write($"           {item.days}");
                    Console.Write($"            {item.Location}\n");
                }
            }
            else
            {
                Boolean wantRepeat = true;
                Console.WriteLine("The package you want is not found :(");
                Console.WriteLine("Do you want to make your custom package If yes = y and if no = n ");
                
                string reapeatChoice = Console.ReadLine();
                if (reapeatChoice == "Y" || reapeatChoice == "y")
                {
                    Console.WriteLine("Enter Which package details :");
                    Console.Write("Package Name :");
                    string NewPakage = Console.ReadLine();
                    Console.Write("Package Location :");
                    string NewLocation = Console.ReadLine();
                    Console.Write("and days :");
                    int Newdays = Convert.ToInt32(Console.ReadLine());
                    listPackageTour.Add(new PackageTour() { PackageName = NewPakage, Location = NewLocation, days = Newdays });

                    Console.WriteLine("Here is the full list of avilable packages :");
                    Console.WriteLine("----------- PackageName----------Days--------------Location---------\n");
                    foreach (PackageTour item in listPackageTour)
                    {
                        Console.Write($"           {item.PackageName}");
                        Console.Write($"           { item.days}");
                        Console.Write($"           {item.Location}\n");
                    }


                }
                else if (reapeatChoice == "N" || reapeatChoice == "n")
                {
                    wantRepeat = false;
                    Console.Clear();
                    Console.WriteLine("Thanks for your time :)");
                }

            }

        }

            

       

    }
}
