﻿namespace ProvaClasse.Forms
{
    partial class Test
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
            this.swTextBox1 = new ControlsMC.SwTextBox();
            this.swTextBox2 = new ControlsMC.SwTextBox();
            this.swTextBox3 = new ControlsMC.SwTextBox();
            this.swTextBox4 = new ControlsMC.SwTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mcCodi1 = new TextBoxControls.MCCodi();
            this.SuspendLayout();
            // 
            // swTextBox1
            // 
            this.swTextBox1.AllowEmpty = true;
            this.swTextBox1.CampoBbdd = "securecode";
            this.swTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox1.Foranea = true;
            this.swTextBox1.Location = new System.Drawing.Point(183, 112);
            this.swTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(150, 23);
            this.swTextBox1.TabIndex = 18;
            this.swTextBox1.Tipus = ControlsMC.SwTextBox.TipusDada.Numero;
            // 
            // swTextBox2
            // 
            this.swTextBox2.AllowEmpty = true;
            this.swTextBox2.CampoBbdd = "";
            this.swTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox2.Foranea = false;
            this.swTextBox2.Location = new System.Drawing.Point(183, 164);
            this.swTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(150, 23);
            this.swTextBox2.TabIndex = 19;
            this.swTextBox2.Tipus = ControlsMC.SwTextBox.TipusDada.Text;
            // 
            // swTextBox3
            // 
            this.swTextBox3.AllowEmpty = true;
            this.swTextBox3.CampoBbdd = "";
            this.swTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox3.Foranea = false;
            this.swTextBox3.Location = new System.Drawing.Point(183, 213);
            this.swTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swTextBox3.Name = "swTextBox3";
            this.swTextBox3.Size = new System.Drawing.Size(150, 23);
            this.swTextBox3.TabIndex = 20;
            this.swTextBox3.Tipus = ControlsMC.SwTextBox.TipusDada.Data;
            // 
            // swTextBox4
            // 
            this.swTextBox4.AllowEmpty = true;
            this.swTextBox4.CampoBbdd = "";
            this.swTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox4.Foranea = false;
            this.swTextBox4.Location = new System.Drawing.Point(183, 266);
            this.swTextBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swTextBox4.Name = "swTextBox4";
            this.swTextBox4.Size = new System.Drawing.Size(150, 23);
            this.swTextBox4.TabIndex = 21;
            this.swTextBox4.Tipus = ControlsMC.SwTextBox.TipusDada.Codi;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(97, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(97, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(97, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(97, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "codi";
            // 
            // mcCodi1
            // 
            this.mcCodi1.ControlID = 0;
            this.mcCodi1.dll = "ClassLibrary1.dll";
            this.mcCodi1.FormCS = "ClassLibrary1.Form1";
            this.mcCodi1.Location = new System.Drawing.Point(436, 188);
            this.mcCodi1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcCodi1.Name = "mcCodi1";
            this.mcCodi1.NomCodi = "CodeAgency";
            this.mcCodi1.NomDesc = "DescAgency";
            this.mcCodi1.NomId = "idAgency";
            this.mcCodi1.NomTaula = "Agencies";
            this.mcCodi1.Requerit = false;
            this.mcCodi1.Size = new System.Drawing.Size(297, 23);
            this.mcCodi1.TabIndex = 26;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.mcCodi1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swTextBox4);
            this.Controls.Add(this.swTextBox3);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.swTextBox1);
<<<<<<< HEAD
            this.Name = "Test";
=======
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "test";
>>>>>>> b91467d0016be5a888474066fbaa0b16d6fafd67
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.swTextBox1, 0);
            this.Controls.SetChildIndex(this.swTextBox2, 0);
            this.Controls.SetChildIndex(this.swTextBox3, 0);
            this.Controls.SetChildIndex(this.swTextBox4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.mcCodi1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlsMC.SwTextBox swTextBox1;
        private ControlsMC.SwTextBox swTextBox2;
        private ControlsMC.SwTextBox swTextBox3;
        private ControlsMC.SwTextBox swTextBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private TextBoxControls.MCCodi mcCodi1;
    }
}