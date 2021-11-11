using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSR_Tort.Model
{
    public partial class Ingridient
    {
        public string GetName
        {
            get
            {
                string name = Id + ". " + Name + " #" + Label;
                return name;
            }
        }

        public string GetDescription
        {
            get
            {
                string desc = "Нет информации";
                try
                {
                    desc = "Годен до " + ExpireDate + " | " + Unit.Name + " | " + Supplier.Name + " " + Supplier.DeliveryPeriod;
                }
                catch
                {

                }
                return desc;
            }
        }
    }
}
