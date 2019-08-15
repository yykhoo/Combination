using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Add data to company A, company B and company C
            Company compA = new Company();

            Invoice tempInv = new Invoice();
            //List <Invoice> invA = new List <Invoice>();


            List<Invoice> invA = new List<Invoice>();
            var data = new Invoice { Id = 1001, Amount = 500 };
            invA.Add(data);
            data = new Invoice { Id = 1002, Amount = 1000 };
            invA.Add(data);
            data = new Invoice { Id = 1003, Amount = 200 };
            invA.Add(data);

            compA.setVal(100,invA);

            Company compB = new Company();

            List<Invoice> invB = new List<Invoice>();
            data = new Invoice { Id = 2001, Amount = 50 };
            invB.Add(data);
            data = new Invoice { Id = 2002, Amount = 100 };
            invB.Add(data);
            data = new Invoice { Id = 2003, Amount = 900 };
            invB.Add(data);
            data = new Invoice { Id = 2004, Amount = 200 };
            invB.Add(data);

            compB.setVal(200, invB);

            Company compC = new Company();

            List<Invoice> invC = new List<Invoice>();
            data = new Invoice { Id = 3001, Amount = 150 };
            invC.Add(data);
            data = new Invoice { Id = 3002, Amount = 500 };
            invC.Add(data);
            data = new Invoice { Id = 3003, Amount = 300 };
            invC.Add(data);

            compC.setVal(300, invC);

            List<Company> Companies = new List<Company>();
            Companies.Add(compA);
            Companies.Add(compB);
            Companies.Add(compC);


            foreach (Company comp in Companies)
            {
                comp.displayCompDetails();
            }

            List<Company> MatchingCompanies = new List<Company>();

            string strReal = null;
            Console.WriteLine("Enter an amount to find out which Company possibly has the combination..");
            Console.Write(">>>> ");
            strReal = Console.ReadLine();
            Console.WriteLine();

            double inputConvert = Convert.ToDouble(strReal);

            foreach( Company comp in Companies)
            {
                string matchingString = "Match";

                if (!comp.CombiMatch(inputConvert))
                {
                    matchingString = "No " + matchingString;
                }
                Console.WriteLine("Company ID: " + comp.Id + " ---> " + matchingString);

            }
            Console.ReadKey();

        }
    }
}
