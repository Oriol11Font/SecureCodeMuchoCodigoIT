namespace LibreriaControles
{
    partial class SimpleForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_actualitzar = new System.Windows.Forms.Button();
            this.btn_datagrid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.swTextBox1 = new ControlsMC.SWTextBox();
            this.swTextBox2 = new ControlsMC.SWTextBox();
            this.swTextBox3 = new ControlsMC.SWTextBox();
            this.swTextBox4 = new ControlsMC.SWTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(550, 350);
            this.dataGridView1.TabIndex = 19;
            // 
            // btn_actualitzar
            // 
            this.btn_actualitzar.ForeColor = System.Drawing.Color.Black;
            this.btn_actualitzar.Location = new System.Drawing.Point(643, 118);
            this.btn_actualitzar.Name = "btn_actualitzar";
            this.btn_actualitzar.Size = new System.Drawing.Size(160, 30);
            this.btn_actualitzar.TabIndex = 20;
            this.btn_actualitzar.Text = "Actualitzar";
            this.btn_actualitzar.UseVisualStyleBackColor = true;
            // 
            // btn_datagrid
            // 
            this.btn_datagrid.ForeColor = System.Drawing.Color.Black;
            this.btn_datagrid.Location = new System.Drawing.Point(643, 173);
            this.btn_datagrid.Name = "btn_datagrid";
            this.btn_datagrid.Size = new System.Drawing.Size(160, 30);
            this.btn_datagrid.TabIndex = 21;
            this.btn_datagrid.Text = "Veure DataSet";
            this.btn_datagrid.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Camp1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Camp2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Camp3 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Camp4 :";
            // 
            // swTextBox1
            // 
            this.swTextBox1.AllowEmpty = true;
            this.swTextBox1.CampoBBDD = null;
            this.swTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox1.Foranea = false;
            this.swTextBox1.Location = new System.Drawing.Point(106, 120);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(170, 26);
            this.swTextBox1.TabIndex = 26;
            this.swTextBox1.Tipus = ControlsMC.SWTextBox.TipusDada.Numero;
            // 
            // swTextBox2
            // 
            this.swTextBox2.AllowEmpty = true;
            this.swTextBox2.CampoBBDD = null;
            this.swTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox2.Foranea = false;
            this.swTextBox2.Location = new System.Drawing.Point(106, 175);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(170, 26);
            this.swTextBox2.TabIndex = 27;
            this.swTextBox2.Tipus = ControlsMC.SWTextBox.TipusDada.Numero;
            // 
            // swTextBox3
            // 
            this.swTextBox3.AllowEmpty = true;
            this.swTextBox3.CampoBBDD = null;
            this.swTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox3.Foranea = false;
            this.swTextBox3.Location = new System.Drawing.Point(392, 120);
            this.swTextBox3.Name = "swTextBox3";
            this.swTextBox3.Size = new System.Drawing.Size(170, 26);
            this.swTextBox3.TabIndex = 28;
            this.swTextBox3.Tipus = ControlsMC.SWTextBox.TipusDada.Numero;
            // 
            // swTextBox4
            // 
            this.swTextBox4.AllowEmpty = true;
            this.swTextBox4.CampoBBDD = null;
            this.swTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTextBox4.Foranea = false;
            this.swTextBox4.Location = new System.Drawing.Point(392, 178);
            this.swTextBox4.Name = "swTextBox4";
            this.swTextBox4.Size = new System.Drawing.Size(170, 26);
            this.swTextBox4.TabIndex = 29;
            this.swTextBox4.Tipus = ControlsMC.SWTextBox.TipusDada.Numero;
            // 
            // SimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 606);
            this.Controls.Add(this.swTextBox4);
            this.Controls.Add(this.swTextBox3);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.swTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_datagrid);
            this.Controls.Add(this.btn_actualitzar);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "SimpleForm";
            this.Text = "Form2";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btn_actualitzar, 0);
            this.Controls.SetChildIndex(this.btn_datagrid, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.swTextBox1, 0);
            this.Controls.SetChildIndex(this.swTextBox2, 0);
            this.Controls.SetChildIndex(this.swTextBox3, 0);
            this.Controls.SetChildIndex(this.swTextBox4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_actualitzar;
        private System.Windows.Forms.Button btn_datagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ControlsMC.SWTextBox swTextBox1;
        private ControlsMC.SWTextBox swTextBox2;
        private ControlsMC.SWTextBox swTextBox3;
        private ControlsMC.SWTextBox swTextBox4;
    }
}