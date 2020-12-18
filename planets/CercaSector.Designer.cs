
namespace planets
{
    partial class CercaSector
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CodiSector = new System.Windows.Forms.Label();
            this.Remarks = new System.Windows.Forms.Label();
            this.DescSector = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createbtn
            // 
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(10, 470);
            this.panel8.Size = new System.Drawing.Size(1903, 600);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(239, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(462, 30);
            this.textBox1.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(707, 315);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(462, 30);
            this.textBox2.TabIndex = 34;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(1175, 315);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(462, 30);
            this.textBox4.TabIndex = 36;
            // 
            // CodiSector
            // 
            this.CodiSector.AutoSize = true;
            this.CodiSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodiSector.Location = new System.Drawing.Point(233, 280);
            this.CodiSector.Name = "CodiSector";
            this.CodiSector.Size = new System.Drawing.Size(87, 32);
            this.CodiSector.TabIndex = 40;
            this.CodiSector.Text = "Codi:";
            // 
            // Remarks
            // 
            this.Remarks.AutoSize = true;
            this.Remarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remarks.Location = new System.Drawing.Point(1169, 280);
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(170, 32);
            this.Remarks.TabIndex = 41;
            this.Remarks.Text = "Remarques";
            // 
            // DescSector
            // 
            this.DescSector.AutoSize = true;
            this.DescSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescSector.Location = new System.Drawing.Point(701, 280);
            this.DescSector.Name = "DescSector";
            this.DescSector.Size = new System.Drawing.Size(167, 32);
            this.DescSector.TabIndex = 43;
            this.DescSector.Text = "Descripció:";
            // 
            // CercaSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 1080);
            this.Controls.Add(this.DescSector);
            this.Controls.Add(this.Remarks);
            this.Controls.Add(this.CodiSector);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.DtName = "Sectors";
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CercaSector";
            this.Text = "CercaSector";
            this.Controls.SetChildIndex(this.createbtn, 0);
            this.Controls.SetChildIndex(this.panel8, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.textBox4, 0);
            this.Controls.SetChildIndex(this.CodiSector, 0);
            this.Controls.SetChildIndex(this.Remarks, 0);
            this.Controls.SetChildIndex(this.DescSector, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label CodiSector;
        private System.Windows.Forms.Label Remarks;
        private System.Windows.Forms.Label DescSector;
    }
}