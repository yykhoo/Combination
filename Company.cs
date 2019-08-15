using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{
    class Company
    {
        public long Id { get; set; }
        public List <Invoice> Invoices { get; set; }

        public void setVal( long id, List<Invoice> invoices)
        {
            this.Id = id;
            this.Invoices = invoices;
        }


        public bool getCombiSumFromPointAB(int indexA, int indexB, double amountInput, List<Invoice> invList)
        {
            /* double sums = Enumerable.Range(0.00, invList[0].Amount)
            .Select(i => invList.Select(
                      nums => nums[i]
                   ).Sum()
            );*/
            bool valTrue = false;
            double sum = 0;
            for( int i=indexA; i<=indexB; i++)
            {
                sum += invList[i].Amount;

                if (sum == amountInput)
                {
                    valTrue = true;
                    break;
                }

            }

            return valTrue;
        }

        public bool CombiMatch( double amountInput)
        {
            bool match = false;
            List<Invoice> invCpy = new List<Invoice>();
            invCpy = this.Invoices;

            for (int i = 0; i < invCpy.Count; i++)
            {
                if (invCpy[i].Amount == amountInput)
                {
                    match = true;
                }
                else
                {
                    match = this.getCombiSumFromPointAB(i, (invCpy.Count - 1 ), amountInput, invCpy);
                }

                //to reduce looping if there are too many combination. Improves performance
                if (match)
                    break;
                
            }


            return match;
        }

        public void displayCompDetails()
        {
            Console.WriteLine("Company ID: " + this.Id);

            foreach( Invoice inv in this.Invoices)
            {
                Console.WriteLine("Invoice " + inv.Id + "--> RM" + inv.Amount);
            }
            Console.WriteLine();
        }
    }
}
