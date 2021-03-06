using System.Collections;
using System.Data;

namespace LT_Prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Load in data from csv
            try
            {
                string CSVPATH = @"../../../excel/klanten-csv.csv";
                string[] lines = File.ReadAllLines(CSVPATH);
                string[] fields = lines[0].Split(',');
                int cols = fields.GetLength(0);

                DataTable dt = new DataTable();
                for(int i = 0; i < cols; i++)
                {
                    dt.Columns.Add(fields[i]);
                }

                for(int i = 1; i < lines.GetLength(0); i++)
                {
                    fields = lines[i].Split(',');
                    for(int f = 0; f < cols; f++)
                    {
                        string fieldData = fields[f];
                        string[] splittedData = fieldData.Split('_');
                        int parsedKvkNummer = int.Parse(splittedData[1]);
                        klantenSelector.Items.Add(new Customer(splittedData[0],parsedKvkNummer)); //Parse them to an customer
                    }
                }

                klantenSelector.DisplayMember = "Name"; //Display the Customer.Name()
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is: " + ex.Message);
                throw;
            }
            #endregion
        }
    }
}