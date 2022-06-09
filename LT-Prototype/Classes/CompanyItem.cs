using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_Prototype.Classes
{
    public class CompanyItem
    {
        public string _name { get; set; }
        public List<LeskerExcelRow> _row { get; set; }

        public CompanyItem(string name)
        {
            _name = name;
            _row = new List<LeskerExcelRow> { new LeskerExcelRow() };
        }

        public CompanyItem(string name, LeskerExcelRow row)
        {
            _name = name;
            _row = new List<LeskerExcelRow> { new LeskerExcelRow() };
            _row.Add(row);
        }
    }
}
