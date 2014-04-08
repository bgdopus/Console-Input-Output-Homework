using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Company Name:");
            string companyName = Console.ReadLine();
            Console.Write("Company Address:");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number:");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number:");
            string faxNumber = Console.ReadLine();
            Console.Write("Web site:");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name:");
            string manFirstName = Console.ReadLine();
            Console.Write("Manager last name:");
            string manLastName = Console.ReadLine();
            Console.Write("Manager age:");
            string manAge = Console.ReadLine();
            Console.Write("Manager phone:");
            string manPhone = Console.ReadLine();

            Console.WriteLine("---------------------");
            Console.Write("Company Name:");
            Console.WriteLine(companyName);
            Console.Write("Company Address:");
            Console.WriteLine(companyAddress);
            Console.Write("Phone Number:");
            Console.WriteLine(phoneNumber);
            Console.Write("Fax number:");
            Console.WriteLine(faxNumber);
            Console.Write("Web site:");
            Console.WriteLine(faxNumber);
            Console.Write("Manager first name:");
            Console.WriteLine(manFirstName);
            Console.Write("Manager last name:");
            Console.WriteLine(manLastName);
            Console.Write("Manager age:");
            Console.WriteLine(manAge);
            Console.Write("Manager phone:");
            Console.WriteLine(manPhone);
            Console.WriteLine("\n Software University \n Address: 26 V. Kanchev, Sofia \n Tel. +359 899 55 55 92 \n Fax: (no fax) \n Web site: http://softuni.bg \n Manager: Svetlin Nakov (age: 25, tel. +359 2 981 981)");
            
        }
    }
}
