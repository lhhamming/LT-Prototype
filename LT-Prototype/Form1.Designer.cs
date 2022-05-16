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
            this.SuspendLayout();
            // 
            // klantenSelector
            // 
            this.klantenSelector.FormattingEnabled = true;
            this.klantenSelector.Location = new System.Drawing.Point(12, 35);
            this.klantenSelector.Name = "klantenSelector";
            this.klantenSelector.Size = new System.Drawing.Size(273, 23);
            this.klantenSelector.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KlantenLabel);
            this.Controls.Add(this.klantenSelector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox klantenSelector;
        private Label KlantenLabel;
    }
}