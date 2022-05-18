using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_Prototype
{
    public class GridViewItem
    {
        private string _KVKNummer;
        private string _itemType; 

        public GridViewItem(string kvkNummer, string itemType)
        {
            _KVKNummer = kvkNummer;
            _itemType = itemType;
        }

        public string KVKNummer { 
            get { return _KVKNummer; }
            set { _KVKNummer = value; }
        }

        public string itemType
        {
            get { return _itemType; }
            set { _itemType = value; }
        }
    }
}
