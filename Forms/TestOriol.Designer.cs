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
            this.swTextBox1 = new ControlsMC.SWTextBox();
            this.mcCodi2 = new TextBoxControls.MCCodi();
            this.mcCodi1 = new TextBoxControls.MCCodi();
            this.mcExecuteApp1 = new TextBoxControls.MCExecuteApp();
            this.SuspendLayout();
            // 
            // swTextBox1
            // 
            this.swTextBox1.AllowEmpty = true;
            this.swTextBox1.CampoBBDD = null;
            this.swTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox1.Foranea = false;
            this.swTextBox1.Location = new System.Drawing.Point(299, 278);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(100, 23);
            this.swTextBox1.TabIndex = 20;
            this.swTextBox1.Tipus = ControlsMC.SWTextBox.TipusDada.Text;
            // 
            // mcCodi2
            // 
            this.mcCodi2.ClasseCS = null;
            this.mcCodi2.ControlID = 0;
            this.mcCodi2.FormCS = null;
            this.mcCodi2.Location = new System.Drawing.Point(267, 212);
            this.mcCodi2.Name = "mcCodi2";
            this.mcCodi2.NomCodi = "CodeAgency";
            this.mcCodi2.NomDesc = "DescAgency";
            this.mcCodi2.NomId = "idAgency";
            this.mcCodi2.NomTaula = "Agencies";
            this.mcCodi2.Requerit = false;
            this.mcCodi2.Size = new System.Drawing.Size(349, 28);
            this.mcCodi2.TabIndex = 19;
            // 
            // mcCodi1
            // 
            this.mcCodi1.ClasseCS = "TextBoxControls";
            this.mcCodi1.ControlID = 0;
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
            // mcExecuteApp1
            // 
            this.mcExecuteApp1.BackColor = System.Drawing.Color.Transparent;
            this.mcExecuteApp1.Classe = "Menu";
            this.mcExecuteApp1.Form = "Menu";
            this.mcExecuteApp1.Location = new System.Drawing.Point(767, 395);
            this.mcExecuteApp1.Name = "mcExecuteApp1";
            this.mcExecuteApp1.Size = new System.Drawing.Size(117, 43);
            this.mcExecuteApp1.TabIndex = 21;
            // 
            // TestOriol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.mcExecuteApp1);
            this.Controls.Add(this.swTextBox1);
            this.Controls.Add(this.mcCodi2);
            this.Controls.Add(this.mcCodi1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "TestOriol";
            this.Text = "TestOriol";
            this.Controls.SetChildIndex(this.mcCodi1, 0);
            this.Controls.SetChildIndex(this.mcCodi2, 0);
            this.Controls.SetChildIndex(this.swTextBox1, 0);
            this.Controls.SetChildIndex(this.mcExecuteApp1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxControls.MCCodi mcCodi1;
        private TextBoxControls.MCCodi mcCodi2;
        private ControlsMC.SWTextBox swTextBox1;
        private TextBoxControls.MCExecuteApp mcExecuteApp1;
    }
}