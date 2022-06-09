using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_Prototype.Classes
{
    public class GenericItem
    {
        public string _Name;
        public int _TotalAmount;
        public int _AmountInUse;

        public GenericItem(string name, int totalAmount, int amountInUse)
        {
            _Name = name;
            _TotalAmount = totalAmount;
            _AmountInUse = amountInUse;
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int TotalAmount
        {
            get { return _TotalAmount; }
            set { _TotalAmount = value; }
        }

        public int AmountInUse
        {
            get { return _AmountInUse; }
            set { _AmountInUse = value; }
        }

        public int amountLeft()
        {
            return _TotalAmount - _AmountInUse;
        }
    }
}
