namespace BasicForms
{
    partial class ForaniForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.btn_actualitzar = new System.Windows.Forms.Button();
            this.btn_datagrid = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.createbtn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg
            // 
            this.dtg.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtg.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg.ColumnHeadersHeight = 29;
            this.dtg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg.EnableHeadersVisualStyles = false;
            this.dtg.Location = new System.Drawing.Point(0, 60);
            this.dtg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg.Name = "dtg";
            this.dtg.ReadOnly = true;
            this.dtg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg.RowHeadersWidth = 20;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtg.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg.Size = new System.Drawing.Size(1922, 640);
            this.dtg.TabIndex = 19;
            // 
            // btn_actualitzar
            // 
            this.btn_actualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualitzar.ForeColor = System.Drawing.Color.White;
            this.btn_actualitzar.Location = new System.Drawing.Point(192, 11);
            this.btn_actualitzar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_actualitzar.Name = "btn_actualitzar";
            this.btn_actualitzar.Size = new System.Drawing.Size(180, 39);
            this.btn_actualitzar.TabIndex = 20;
            this.btn_actualitzar.Text = "Actualitzar";
            this.btn_actualitzar.UseVisualStyleBackColor = true;
            this.btn_actualitzar.Click += new System.EventHandler(this.btn_actualitzar_Click);
            this.btn_actualitzar.Leave += new System.EventHandler(this.btn_actualitzar_Leave);
            // 
            // btn_datagrid
            // 
            this.btn_datagrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datagrid.ForeColor = System.Drawing.Color.White;
            this.btn_datagrid.Location = new System.Drawing.Point(378, 11);
            this.btn_datagrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_datagrid.Name = "btn_datagrid";
            this.btn_datagrid.Size = new System.Drawing.Size(180, 39);
            this.btn_datagrid.TabIndex = 21;
            this.btn_datagrid.Text = "Veure DataSet";
            this.btn_datagrid.UseVisualStyleBackColor = true;
            // 
            // backbtn
            // 
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(29, 185);
            this.backbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(180, 39);
            this.backbtn.TabIndex = 22;
            this.backbtn.Text = "Tornar al Menú";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // createbtn
            // 
            this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createbtn.ForeColor = System.Drawing.Color.White;
            this.createbtn.Location = new System.Drawing.Point(6, 11);
            this.createbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(180, 39);
            this.createbtn.TabIndex = 23;
            this.createbtn.Text = "Afegir";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            this.createbtn.Leave += new System.EventHandler(this.createbtn_Leave);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtg);
            this.panel8.Controls.Add(this.createbtn);
            this.panel8.Controls.Add(this.btn_actualitzar);
            this.panel8.Controls.Add(this.btn_datagrid);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(10, 392);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1922, 700);
            this.panel8.TabIndex = 24;
            // 
            // ForaniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.backbtn);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ForaniForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SimpleForm_Load);
            this.Controls.SetChildIndex(this.backbtn, 0);
            this.Controls.SetChildIndex(this.panel8, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.Button btn_actualitzar;
        private System.Windows.Forms.Button btn_datagrid;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Panel panel8;
    }
}