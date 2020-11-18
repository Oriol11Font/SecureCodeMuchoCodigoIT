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
            this.dtg = new System.Windows.Forms.DataGridView();
            this.btn_actualitzar = new System.Windows.Forms.Button();
            this.btn_datagrid = new System.Windows.Forms.Button();
            this.conn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg
            // 
            this.dtg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Location = new System.Drawing.Point(1194, 140);
            this.dtg.Margin = new System.Windows.Forms.Padding(20, 100, 20, 20);
            this.dtg.Name = "dtg";
            this.dtg.RowHeadersWidth = 62;
            this.dtg.Size = new System.Drawing.Size(700, 400);
            this.dtg.TabIndex = 19;
            // 
            // btn_actualitzar
            // 
            this.btn_actualitzar.ForeColor = System.Drawing.Color.Black;
            this.btn_actualitzar.Location = new System.Drawing.Point(993, 475);
            this.btn_actualitzar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_actualitzar.Name = "btn_actualitzar";
            this.btn_actualitzar.Size = new System.Drawing.Size(144, 24);
            this.btn_actualitzar.TabIndex = 20;
            this.btn_actualitzar.Text = "Actualitzar";
            this.btn_actualitzar.UseVisualStyleBackColor = true;
            // 
            // btn_datagrid
            // 
            this.btn_datagrid.ForeColor = System.Drawing.Color.Black;
            this.btn_datagrid.Location = new System.Drawing.Point(993, 516);
            this.btn_datagrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_datagrid.Name = "btn_datagrid";
            this.btn_datagrid.Size = new System.Drawing.Size(144, 24);
            this.btn_datagrid.TabIndex = 21;
            this.btn_datagrid.Text = "Veure DataSet";
            this.btn_datagrid.UseVisualStyleBackColor = true;
            // 
            // conn
            // 
            this.conn.ForeColor = System.Drawing.Color.Black;
            this.conn.Location = new System.Drawing.Point(993, 430);
            this.conn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conn.Name = "conn";
            this.conn.Size = new System.Drawing.Size(144, 24);
            this.conn.TabIndex = 22;
            this.conn.Text = "Conectar";
            this.conn.UseVisualStyleBackColor = true;
            this.conn.Click += new System.EventHandler(this.conn_Click);
            // 
            // SimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 1102);
            this.Controls.Add(this.conn);
            this.Controls.Add(this.btn_datagrid);
            this.Controls.Add(this.btn_actualitzar);
            this.Controls.Add(this.dtg);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "SimpleForm";
            this.Text = "Form2";
            this.Controls.SetChildIndex(this.dtg, 0);
            this.Controls.SetChildIndex(this.btn_actualitzar, 0);
            this.Controls.SetChildIndex(this.btn_datagrid, 0);
            this.Controls.SetChildIndex(this.conn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.Button btn_actualitzar;
        private System.Windows.Forms.Button btn_datagrid;
        private System.Windows.Forms.Button conn;
    }
}