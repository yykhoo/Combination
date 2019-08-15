using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{
    class Invoice
    {
        public long Id { get; set; }
        public double Amount { get; set; }

        public void setVal( long id, double amount)
        {
            this.Id = id;
            this.Amount = amount;
        }
    }
}
