using System.Collections;
using System.ComponentModel;
using System.Data;

namespace LT_Prototype
{
    //TODO: Excel formulier keuze dynamisch
    //TODO: Laad de rijen in van het Excel formulier
    //TODO: Maak een knop voor data exporteren
    //TODO: Maak een configuratie mapje die:
              // - Nummers matched aan namen
              // - Beschrijving van iets koppelen aan nummers
    //TODO: Nummers exporteren ipv namen
    //TODO: Door kunnen koppelen aan Exact Online
    //TODO: Onderzoek de mogelijkheden van de API.
    //TODO: Maak een inlog methode voor Exact Online om een Key te krijgen om data mee uit te wisselen.
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
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

        private void klantenSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            klantenSelectorActivated();
        }

        private void klantenSelector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                klantenSelectorActivated();
            }
        }

        private void klantenSelectorActivated()
        {
            //Get info from combo box and lock it & load data for containers & trucks
            klantenSelector.Enabled = false;
            containersGebruikt.Enabled = true;
            vrachtwagenSelector.Enabled = true;

            string containerPath = @"../../../excel/containers-csv.csv";
            fillComboBox(containerPath, containersGebruikt.Items);
            string vrachtwagensPath = @"../../../excel/vrachtwagens-csv.csv";
            fillComboBox(vrachtwagensPath, vrachtwagenSelector.Items);


            
            dt.Columns.Add(new DataColumn("Kvknummer"));
            dt.Columns.Add(new DataColumn("item"));
            usedItemsGrid.DataSource = dt;
        }

        private void fillComboBox(string filePath, ComboBox.ObjectCollection items)
        {
            string[] lines = File.ReadAllLines(filePath);
            string[] fields = lines[0].Split(',');
            int cols = fields.GetLength(0);

            DataTable dt = new DataTable();
            for (int i = 0; i < cols; i++)
            {
                dt.Columns.Add(fields[i]);
            }

            for (int i = 1; i < lines.GetLength(0); i++)
            {
                items.Add(lines[i].Split(',')[0]);
            }
        }

        #region selectedIndex for view

        private void containersGebruikt_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { updateGridView(containersGebruikt.SelectedItem.ToString()); }
        }

        private void containersGebruikt_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateGridView(containersGebruikt.SelectedItem.ToString());
        }

        private void vrachtwagenSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateGridView(vrachtwagenSelector.SelectedItem.ToString());
        }

        private void vrachtwagenSelector_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { updateGridView(vrachtwagenSelector.SelectedItem.ToString()); }
        }

        #endregion

        private void updateGridView(string selectedItem)
        {
            if(selectedItem != null) { 
                GridViewItem item = new GridViewItem(klantenSelector.SelectedItem.ToString(), selectedItem);
                DataRow dr = dt.NewRow();
                dr["Kvknummer"] = item.KVKNummer;
                dr["item"] = item.itemType;
                dt.Rows.Add(dr);
            }
        }


    }
}