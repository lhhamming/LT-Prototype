namespace LT_Prototype
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.klantenSelector = new System.Windows.Forms.ComboBox();
            this.KlantenLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.containersGebruikt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vrachtwagenSelector = new System.Windows.Forms.ComboBox();
            this.usedItemsGrid = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usedItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // klantenSelector
            // 
            this.klantenSelector.FormattingEnabled = true;
            this.klantenSelector.Location = new System.Drawing.Point(21, 72);
            this.klantenSelector.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.klantenSelector.Name = "klantenSelector";
            this.klantenSelector.Size = new System.Drawing.Size(580, 45);
            this.klantenSelector.TabIndex = 0;
            this.klantenSelector.SelectedIndexChanged += new System.EventHandler(this.klantenSelector_SelectedIndexChanged);
            this.klantenSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.klantenSelector_KeyDown);
            // 
            // KlantenLabel
            // 
            this.KlantenLabel.AutoSize = true;
            this.KlantenLabel.Location = new System.Drawing.Point(21, 27);
            this.KlantenLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.KlantenLabel.Name = "KlantenLabel";
            this.KlantenLabel.Size = new System.Drawing.Size(78, 37);
            this.KlantenLabel.TabIndex = 1;
            this.KlantenLabel.Text = "Klant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 340);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welke containers gebruikt";
            // 
            // containersGebruikt
            // 
            this.containersGebruikt.Enabled = false;
            this.containersGebruikt.FormattingEnabled = true;
            this.containersGebruikt.Location = new System.Drawing.Point(26, 400);
            this.containersGebruikt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.containersGebruikt.Name = "containersGebruikt";
            this.containersGebruikt.Size = new System.Drawing.Size(580, 45);
            this.containersGebruikt.TabIndex = 2;
            this.containersGebruikt.SelectedIndexChanged += new System.EventHandler(this.containersGebruikt_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welke vrachtwagens zijn er gebruikt";
            // 
            // vrachtwagenSelector
            // 
            this.vrachtwagenSelector.Enabled = false;
            this.vrachtwagenSelector.FormattingEnabled = true;
            this.vrachtwagenSelector.Location = new System.Drawing.Point(705, 400);
            this.vrachtwagenSelector.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.vrachtwagenSelector.Name = "vrachtwagenSelector";
            this.vrachtwagenSelector.Size = new System.Drawing.Size(580, 45);
            this.vrachtwagenSelector.TabIndex = 4;
            this.vrachtwagenSelector.SelectedIndexChanged += new System.EventHandler(this.vrachtwagenSelector_SelectedIndexChanged);
            // 
            // usedItemsGrid
            // 
            this.usedItemsGrid.AllowUserToAddRows = false;
            this.usedItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usedItemsGrid.Location = new System.Drawing.Point(28, 528);
            this.usedItemsGrid.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.usedItemsGrid.Name = "usedItemsGrid";
            this.usedItemsGrid.ReadOnly = true;
            this.usedItemsGrid.RowHeadersWidth = 92;
            this.usedItemsGrid.RowTemplate.Height = 25;
            this.usedItemsGrid.Size = new System.Drawing.Size(1616, 427);
            this.usedItemsGrid.TabIndex = 6;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(28, 1006);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(219, 74);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Opslaan";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1714, 1110);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.usedItemsGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vrachtwagenSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.containersGebruikt);
            this.Controls.Add(this.KlantenLabel);
            this.Controls.Add(this.klantenSelector);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usedItemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox klantenSelector;
        private Label KlantenLabel;
        private Label label1;
        private ComboBox containersGebruikt;
        private Label label2;
        private ComboBox vrachtwagenSelector;
        private DataGridView usedItemsGrid;
        private Button saveBtn;
    }
}