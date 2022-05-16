using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_Prototype
{
    public class Customer
    {
        public string _Name;
        public int _KVKNummer; 

        public Customer(string name, int kvknummer)
        {
            _Name = name;
            _KVKNummer = kvknummer;
        }

        public string Name
        { 
            get { return _Name; }
            set { _Name = value; }
        }

        public int KVKNummer
        {
            get { return _KVKNummer; }
            set { _KVKNummer = value;}
        }
    }
}
