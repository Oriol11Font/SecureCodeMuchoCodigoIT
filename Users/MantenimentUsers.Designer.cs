﻿namespace Users
{
    partial class MantenimentUsers
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
            this.createbtn = new System.Windows.Forms.Button();
            this.btn_actualitzar = new System.Windows.Forms.Button();
            this.btn_datagrid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
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
            this.dtg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg.ColumnHeadersHeight = 29;
            this.dtg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg.EnableHeadersVisualStyles = false;
            this.dtg.Location = new System.Drawing.Point(10, 665);
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
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtg.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg.RowTemplate.Height = 30;
            this.dtg.Size = new System.Drawing.Size(2113, 675);
            this.dtg.TabIndex = 20;
            // 
            // createbtn
            // 
            this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createbtn.ForeColor = System.Drawing.Color.White;
            this.createbtn.Location = new System.Drawing.Point(47, 587);
            this.createbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(200, 49);
            this.createbtn.TabIndex = 26;
            this.createbtn.Text = "Afegir";
            this.createbtn.UseVisualStyleBackColor = true;
            // 
            // btn_actualitzar
            // 
            this.btn_actualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualitzar.ForeColor = System.Drawing.Color.White;
            this.btn_actualitzar.Location = new System.Drawing.Point(254, 587);
            this.btn_actualitzar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_actualitzar.Name = "btn_actualitzar";
            this.btn_actualitzar.Size = new System.Drawing.Size(200, 49);
            this.btn_actualitzar.TabIndex = 24;
            this.btn_actualitzar.Text = "Actualitzar";
            this.btn_actualitzar.UseVisualStyleBackColor = true;
            // 
            // btn_datagrid
            // 
            this.btn_datagrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datagrid.ForeColor = System.Drawing.Color.White;
            this.btn_datagrid.Location = new System.Drawing.Point(461, 587);
            this.btn_datagrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_datagrid.Name = "btn_datagrid";
            this.btn_datagrid.Size = new System.Drawing.Size(200, 49);
            this.btn_datagrid.TabIndex = 25;
            this.btn_datagrid.Text = "Veure DataSet";
            this.btn_datagrid.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(47, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 49);
            this.button1.TabIndex = 27;
            this.button1.Text = "Tornar al Menú";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MantenimentUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.btn_actualitzar);
            this.Controls.Add(this.btn_datagrid);
            this.Controls.Add(this.dtg);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MantenimentUsers";
            this.Text = "MantenimentUsers";
            this.Load += new System.EventHandler(this.MantenimentUsers_Load);
            this.Controls.SetChildIndex(this.dtg, 0);
            this.Controls.SetChildIndex(this.btn_datagrid, 0);
            this.Controls.SetChildIndex(this.btn_actualitzar, 0);
            this.Controls.SetChildIndex(this.createbtn, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button btn_actualitzar;
        private System.Windows.Forms.Button btn_datagrid;
        private System.Windows.Forms.Button button1;
    }
}