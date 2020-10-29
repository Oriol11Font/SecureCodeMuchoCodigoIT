namespace ProvaClasse.Forms
{
    partial class TestOriol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mcCodi2 = new TextBoxControls.MCCodi();
            this.mcCodi1 = new TextBoxControls.MCCodi();
            this.SuspendLayout();
            // 
            // mcCodi2
            // 
            this.mcCodi2.ClasseCS = null;
            this.mcCodi2.FormCS = null;
            this.mcCodi2.Location = new System.Drawing.Point(267, 212);
            this.mcCodi2.Name = "mcCodi2";
            this.mcCodi2.NomCodi = null;
            this.mcCodi2.NomDesc = null;
            this.mcCodi2.NomId = null;
            this.mcCodi2.NomTaula = null;
            this.mcCodi2.Requerit = false;
            this.mcCodi2.Size = new System.Drawing.Size(349, 28);
            this.mcCodi2.TabIndex = 19;
            // 
            // mcCodi1
            // 
            this.mcCodi1.ClasseCS = "TextBoxControls";
            this.mcCodi1.FormCS = "Menu";
            this.mcCodi1.Location = new System.Drawing.Point(267, 178);
            this.mcCodi1.Name = "mcCodi1";
            this.mcCodi1.NomCodi = "CodeAgency";
            this.mcCodi1.NomDesc = "DescAgency";
            this.mcCodi1.NomId = "idAgency";
            this.mcCodi1.NomTaula = "Agencies";
            this.mcCodi1.Requerit = true;
            this.mcCodi1.Size = new System.Drawing.Size(349, 28);
            this.mcCodi1.TabIndex = 18;
            // 
            // TestOriol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.mcCodi2);
            this.Controls.Add(this.mcCodi1);
            this.Name = "TestOriol";
            this.Text = "TestOriol";
            this.Load += new System.EventHandler(this.TestOriol_Load);
            this.Controls.SetChildIndex(this.mcCodi1, 0);
            this.Controls.SetChildIndex(this.mcCodi2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxControls.MCCodi mcCodi1;
        private TextBoxControls.MCCodi mcCodi2;
    }
}