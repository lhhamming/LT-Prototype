using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_Prototype
{
    /*
     * This class will act like an database of som sort. So that the application only has to load in the
     * Items once.
     * 
     * SINGLETON (There can only be on instance) More info: https://en.wikipedia.org/wiki/Singleton_pattern
     */
    public class Storage
    {
        private List<Customer> customerList;
        private List<GridViewItem> genericList;
        private static Storage s = null; 
        
        Storage()
        {
            customerList = new List<Customer>();
            genericList = new List<GridViewItem>();
        }

        public static Storage getInstance()
        {
            if (s == null)
            {
                s = new Storage();
            }
            return s;
        }
    }
}
