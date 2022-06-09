using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_Prototype.Classes
{
    public class LeskerExcelRow
    {
        private string? _executor; //Uitvoerder | Can be null | Only at factuurbon
        private string? _day; //Dag | Can be null | Only at factuurbon
        private DateTime _date; // Datum | Can't be null
        private float _hours; //Uren | Can't be null
        private string _material; // Meterieel | Can't be null
        private string _jobName; //Naam | can't be null | Only at Bedrijven
        private string _work; // Werk | Can't be null
        private string _name; //nNaam | Can't be null
        private string? _receiptNo; //Bon no | Can be null
        private string? _receiptLesker; //Bon Lekser | Can be null
        private string? _receiptCustomer; // Bon Klant | Can be null

        //Empty Init. 
        public LeskerExcelRow()
        {
            _date = DateTime.MinValue;
            _hours = -99;
            _material = "";
            _jobName = "";
            _work = "";
            _name = "";
        }

        //Mandatory fields
        public LeskerExcelRow(DateTime date, float hours, string material, string jobName, string work, string name)
        {
            _date = date;
            _hours = hours;
            _material = material;
            _jobName = jobName;
            _work = work;
            _name = name;
        }
        //Full constructor
        public LeskerExcelRow(string executer, string day, DateTime date, float hours,
                              string material, string jobName, string work, string name,
                              string receiptNo, string receiptLesker, string receiptCustomer)
        {
            _executor = executor;
            _day = day;
            _date = date;
            _hours = hours;
            _material = material;
            _jobName = jobName;
            _work = work;
            _name = name;
            _receiptNo = receiptNo;
            _receiptLesker = receiptLesker;
            _receiptCustomer = receiptCustomer;
        }


        #region Getters and Setters
        public string executor
        {
            get { return _executor; }
            set { _executor = value; }
        }
        public string day
        {
            get { return _day; }
            set { _day = value; }
        }

        public DateTime date
        {
            get { return _date; }
            set { _date = value; }
        }
        public float hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        public string jobName
        {
            get { return _jobName; }
            set { _jobName = value; }
        }

        public string material
        {
            get { return _material; }
            set { _material = value; }
        }

        public string work
        {
            get { return _work; }
            set { _work = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string receiptNo
        {
            get { return _receiptNo; }
            set { _receiptNo = value; }
        }
        
        public string receiptLesker
        {
            get { return _receiptLesker; }
            set { _receiptLesker = value;}
        }

        public string receiptCustomer
        {
            get { return _receiptCustomer; }
            set { _receiptCustomer = value; }
        }
        #endregion

        public bool isValid()
        {
            bool valid = true;
            //These fields are mandatory
            if(_date == DateTime.MinValue || _hours == -99 || _material.Equals(""))
            {
                valid = false;
            }
            return valid;
        }
    }
}
