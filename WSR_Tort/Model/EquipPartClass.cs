using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSR_Tort.Model
{
    public partial class Equipment
    {
        public string GetAmount
        {
            get
            {
                string amount = Amount + " шт.";
                return amount;
            }
        }
    }
}
