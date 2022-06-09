using LT_Prototype.Classes;
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

    //BELANGRIJK TODO: Door kunnen koppelen aan Exact Online. BELANGRIJK
    //TODO: Onderzoek de mogelijkheden van de API.

    //TODO: Maak een inlog methode voor Exact Online om een Key te krijgen om data mee uit te wisselen.


    /*  Hoe het Excel eruit ziet: 
     *  
     *  Header -> Diensten x overzichten
     *  2-3 lege lijnen
     *  soms cel A(0)(uitvoerder) en B(1)(Dag) niet ingevuld 
     *  Cellen C(2, Datum) D(3, Uren) E(4, Naam(van uitvoering)) F(5, Werk) G(6, Naam(?)) H(7, Bon nummer) 
     *  
     *  Voorbeeld non factuurbon:
     *  datum	    uren	Naam	                    werk	                naam	bon no.
     *  10/21/2021	1.00	6 m3 cont afval afgevoerd	weefkamer 22 wierden	
     *  
     *  ----------------------------------------------------
     *  
     *  Voorbeeld Factuurbon:
     *  uitvoerder	dag	datum	    uren	materieel	                werk	                    Naam	Bon lesker	Bon klant
     *  Erwin	    ma	10/25/2021	8.00	uur dieplepel	            emmen	                    thijs		
     *  Erwin	    ma	10/25/2021	8.00	uur auto 6x6 wsg met kraan	Slagharen, Emmen	        brian	12489
     *  Niek	    ma	9/13/2021	1.50	uur auto 6x6	            haerstraat 120 oldenzaal	harry		        nl-0002
     *  
     *  
     *  Het volgende kan ook voorkomen: 
     *  uitvoerder	dag	datum	uren	materieel	    werk	Naam	Bon lesker	Bon klant
     *  Niek	ma	9/13/2021	1.50	uur auto 6x6	haerstraat 120 oldenzaal	harry		nl-0002
	 *		                    4.00	m3 vulzand geleverd				                        nl-0002
     *  Niek	ma	9/13/2021	0.75	uur containerauto	Pietheinstraat Borne	harry		nl-0002
	 *			                        10 m3 cont geplaatst voor tegels				
     *
     *  hierbij nemen wij aan dat deze bij elkaar horen & dat de werkzaamheden uitgevoerd zijn door dezelfde persoon (Hierbij dus Harry)
     *  
     *  
     *  De Applicatie gaat gebouwd worden op het voorbeeld wat geleverd is door Lesker Transport. 
     *  Deze is verstuurd naar 479184@student.saxion.nl op 6/9
     */
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
        /*
         * This function loads in data from an CSV. 
         */
        private void loadCSV(string path)
        {
            string exstenstion = path.Split('.')[1]; //split at the . and grab the last part. This means we should have gotten .csv
            if(exstenstion != "csv" && !File.Exists(path))
            {
                MessageBox.Show("Bestand is of geen csv bestand of het pad bestaat niet!");
                MessageBox.Show("Het opgegeven pad: " + path + " Bestand type: " + exstenstion);
                return;
            }
            // file exists. Load it

            try
            {
                string[] lines = File.ReadAllLines(path);
                string[] fields = lines[0].Split(',');
                int cols = fields.GetLength(0);

                DataTable dtParticulier = new DataTable();
                DataTable dtBedrijven = new DataTable();
                DataTable dtFactuurbon = new DataTable();

                DataTable dtCompanies = new DataTable();

                //Lets sort them out. 
                for (int i = 1; i < lines.GetLength(0); i++)
                {
                    fields = lines[i].Split(',');
                    for (int f = 0; f < cols; f++)
                    {
                        string fieldData = fields[f];
                        if (fieldData.ToLower().Contains("diensten"))
                        {
                            /* We are currently inside on of the following "Diensten" Columns
                             * Particulier
                             * Bedijrven
                             * overzicht
                             * 
                             * After spitting the text on an space bar. We can get the second word so we can determine which fields we are going to fill in.
                             */
                            string dienstenType = fieldData.ToLower().Split(' ')[1];
                            if (dienstenType == "particulier")
                            {
                                //Particulier field
                                /*
                                 * all we have to do now is to read till we found the end of the current selected fields.
                                 * This will end at the next "Diensten" section
                                 */
                                
                                i++; //Increment i by 1 so that we are on the next line. 
                                fields = lines[i].Split(','); // Manually redo the split cause of manual skip.
                                fieldData = fields[f];


                                int mandatoryFilledIn = 4; // the 4(5th) line is always filled. 
                                
                                
                                while (!fieldData.ToLower().Contains("diensten")){
                                    //Check if the 4th column is filled in. Then we have data coming in.
                                    if (fields[mandatoryFilledIn] != "" || fields[mandatoryFilledIn] != null) 
                                    {
                                        //Company name.
                                        CompanyItem c = new CompanyItem(fields[mandatoryFilledIn]);
                                        //Find next line until row mandatoryFilledIn(4) is empty
                                        for (int companyLines = i + 1; lines[companyLines].Split(',')[mandatoryFilledIn] != "" || lines[companyLines].Split(',')[mandatoryFilledIn] != null; i++)
                                        {
                                            //We make this loop so that the CompanyItem stays in the scope.
                                            
                                        }
                                    }

                                     
                                }

                                for (int dienstLines = i + 1; !fields[dienstLines].Contains("Diensten"); dienstLines++)
                                {
                                    // Find data
                                    
                                }

                            }
                            if(dienstenType == "bedrijven")
                            {
                                //Bedrijven field
                            }
                            if(dienstenType == "factuurbon")
                            {
                                //factuurbon field
                            }
                        }
                        /*
                        string fieldData = fields[f];
                        string[] splittedData = fieldData.Split('_');
                        int parsedKvkNummer = int.Parse(splittedData[1]);
                        klantenSelector.Items.Add(new Customer(splittedData[0], parsedKvkNummer)); //Parse them to an customer
                        */
                    }
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Error is: " + ex.Message);
                throw;
            }

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