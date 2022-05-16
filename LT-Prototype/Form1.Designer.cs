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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // klantenSelector
            // 
            this.klantenSelector.FormattingEnabled = true;
            this.klantenSelector.Location = new System.Drawing.Point(10, 29);
            this.klantenSelector.Name = "klantenSelector";
            this.klantenSelector.Size = new System.Drawing.Size(273, 23);
            this.klantenSelector.TabIndex = 0;
            this.klantenSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.klantenSelector_KeyDown);
            // 
            // KlantenLabel
            // 
            this.KlantenLabel.AutoSize = true;
            this.KlantenLabel.Location = new System.Drawing.Point(10, 11);
            this.KlantenLabel.Name = "KlantenLabel";
            this.KlantenLabel.Size = new System.Drawing.Size(34, 15);
            this.KlantenLabel.TabIndex = 1;
            this.KlantenLabel.Text = "Klant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welke containers gebruikt";
            // 
            // containersGebruikt
            // 
            this.containersGebruikt.Enabled = false;
            this.containersGebruikt.FormattingEnabled = true;
            this.containersGebruikt.Location = new System.Drawing.Point(12, 162);
            this.containersGebruikt.Name = "containersGebruikt";
            this.containersGebruikt.Size = new System.Drawing.Size(273, 23);
            this.containersGebruikt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welke vrachtwagens zijn er gebruikt";
            // 
            // vrachtwagenSelector
            // 
            this.vrachtwagenSelector.Enabled = false;
            this.vrachtwagenSelector.FormattingEnabled = true;
            this.vrachtwagenSelector.Location = new System.Drawing.Point(329, 162);
            this.vrachtwagenSelector.Name = "vrachtwagenSelector";
            this.vrachtwagenSelector.Size = new System.Drawing.Size(273, 23);
            this.vrachtwagenSelector.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(754, 173);
            this.dataGridView1.TabIndex = 6;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(13, 408);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(102, 30);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Opslaan";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vrachtwagenSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.containersGebruikt);
            this.Controls.Add(this.KlantenLabel);
            this.Controls.Add(this.klantenSelector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private DataGridView dataGridView1;
        private Button saveBtn;
    }
}