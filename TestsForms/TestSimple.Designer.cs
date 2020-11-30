
namespace TestsForms
{
    partial class TestSimple
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swTextBox1 = new ControlsMC.SWTextBox();
            this.swTextBox2 = new ControlsMC.SWTextBox();
            this.swTextBox3 = new ControlsMC.SWTextBox();
            this.swTextBox4 = new ControlsMC.SWTextBox();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idAgency";
            this.dataGridViewTextBoxColumn1.HeaderText = "idAgency";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodeAgency";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodeAgency";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DescAgency";
            this.dataGridViewTextBoxColumn3.HeaderText = "DescAgency";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // swTextBox1
            // 
            this.swTextBox1.AllowEmpty = true;
            this.swTextBox1.CampoBBDD = null;
            this.swTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox1.Foranea = false;
            this.swTextBox1.Location = new System.Drawing.Point(277, 273);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(100, 23);
            this.swTextBox1.TabIndex = 25;
            this.swTextBox1.Tipus = ControlsMC.SWTextBox.TipusDada.Numero;
            // 
            // swTextBox2
            // 
            this.swTextBox2.AllowEmpty = true;
            this.swTextBox2.CampoBBDD = null;
            this.swTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox2.Foranea = false;
            this.swTextBox2.Location = new System.Drawing.Point(910, 529);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(100, 23);
            this.swTextBox2.TabIndex = 26;
            this.swTextBox2.Tipus = ControlsMC.SWTextBox.TipusDada.Numero;
            // 
            // swTextBox3
            // 
            this.swTextBox3.AllowEmpty = true;
            this.swTextBox3.CampoBBDD = null;
            this.swTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox3.Foranea = false;
            this.swTextBox3.Location = new System.Drawing.Point(918, 537);
            this.swTextBox3.Name = "swTextBox3";
            this.swTextBox3.Size = new System.Drawing.Size(100, 23);
            this.swTextBox3.TabIndex = 27;
            this.swTextBox3.Tipus = ControlsMC.SWTextBox.TipusDada.Numero;
            // 
            // swTextBox4
            // 
            this.swTextBox4.AllowEmpty = true;
            this.swTextBox4.CampoBBDD = null;
            this.swTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox4.Foranea = false;
            this.swTextBox4.Location = new System.Drawing.Point(926, 545);
            this.swTextBox4.Name = "swTextBox4";
            this.swTextBox4.Size = new System.Drawing.Size(100, 23);
            this.swTextBox4.TabIndex = 28;
            this.swTextBox4.Tipus = ControlsMC.SWTextBox.TipusDada.Numero;
            // 
            // TestSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.swTextBox4);
            this.Controls.Add(this.swTextBox3);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.swTextBox1);
            this.Name = "TestSimple";
            this.Text = "TestSimple";
            this.Controls.SetChildIndex(this.swTextBox1, 0);
            this.Controls.SetChildIndex(this.swTextBox2, 0);
            this.Controls.SetChildIndex(this.swTextBox3, 0);
            this.Controls.SetChildIndex(this.swTextBox4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private ControlsMC.SWTextBox swTextBox1;
        private ControlsMC.SWTextBox swTextBox2;
        private ControlsMC.SWTextBox swTextBox3;
        private ControlsMC.SWTextBox swTextBox4;
    }
}