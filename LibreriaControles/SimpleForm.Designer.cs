﻿namespace BasicForms
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.btn_actualitzar = new System.Windows.Forms.Button();
            this.btn_datagrid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.createbtn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.agenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg
            // 
            this.dtg.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            this.dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtg.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg.ColumnHeadersHeight = 29;
            this.dtg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg.EnableHeadersVisualStyles = false;
            this.dtg.Location = new System.Drawing.Point(0, 75);
            this.dtg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg.Name = "dtg";
            this.dtg.ReadOnly = true;
            this.dtg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg.RowHeadersWidth = 20;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dtg.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg.RowTemplate.Height = 30;
            this.dtg.Size = new System.Drawing.Size(2113, 675);
            this.dtg.TabIndex = 19;
            // 
            // btn_actualitzar
            // 
            this.btn_actualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualitzar.ForeColor = System.Drawing.Color.White;
            this.btn_actualitzar.Location = new System.Drawing.Point(231, 2);
            this.btn_actualitzar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_actualitzar.Name = "btn_actualitzar";
            this.btn_actualitzar.Size = new System.Drawing.Size(200, 49);
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
            this.btn_datagrid.Location = new System.Drawing.Point(438, 2);
            this.btn_datagrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_datagrid.Name = "btn_datagrid";
            this.btn_datagrid.Size = new System.Drawing.Size(200, 49);
            this.btn_datagrid.TabIndex = 21;
            this.btn_datagrid.Text = "Veure DataSet";
            this.btn_datagrid.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(36, 220);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 49);
            this.button1.TabIndex = 22;
            this.button1.Text = "Tornar al Menú";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // createbtn
            // 
            this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createbtn.ForeColor = System.Drawing.Color.White;
            this.createbtn.Location = new System.Drawing.Point(24, 2);
            this.createbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(200, 49);
            this.createbtn.TabIndex = 23;
            this.createbtn.Text = "Afegir";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            this.createbtn.Leave += new System.EventHandler(this.createbtn_Leave);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Controls.Add(this.dtg);
            this.panel8.Controls.Add(this.createbtn);
            this.panel8.Controls.Add(this.btn_actualitzar);
            this.panel8.Controls.Add(this.btn_datagrid);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(10, 590);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2113, 750);
            this.panel8.TabIndex = 24;
            // 
            // agenciesBindingSource
            // 
            this.agenciesBindingSource.DataMember = "Agencies";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = global::LibreriaControles.Properties.Resources.Guti;
            this.pictureBox1.Image = global::LibreriaControles.Properties.Resources.logo_login;
            this.pictureBox1.InitialImage = global::LibreriaControles.Properties.Resources.Guti;
            this.pictureBox1.Location = new System.Drawing.Point(1678, 241);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // SimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1350);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.button1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SimpleForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SimpleForm_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.panel8, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.Button btn_actualitzar;
        private System.Windows.Forms.Button btn_datagrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.BindingSource agenciesBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}