namespace ProvaClasse.Forms
{
    partial class AlertScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.alert1 = new System.Windows.Forms.PictureBox();
            this.alert2 = new System.Windows.Forms.PictureBox();
            this.alert3 = new System.Windows.Forms.PictureBox();
            this.alert4 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alert1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alert2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alert3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alert4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nasalization", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "AUTHENTIFICATON CRITICAL ERROR \r\nLEAVING APP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 10);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 404);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(166, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 404);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(577, 10);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(577, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 394);
            this.panel5.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(10, 394);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(567, 10);
            this.progressBar1.TabIndex = 5;
            // 
            // alert1
            // 
            this.alert1.Location = new System.Drawing.Point(16, 16);
            this.alert1.Name = "alert1";
            this.alert1.Size = new System.Drawing.Size(126, 95);
            this.alert1.TabIndex = 7;
            this.alert1.TabStop = false;
            // 
            // alert2
            // 
            this.alert2.Location = new System.Drawing.Point(441, 16);
            this.alert2.Name = "alert2";
            this.alert2.Size = new System.Drawing.Size(130, 95);
            this.alert2.TabIndex = 8;
            this.alert2.TabStop = false;
            // 
            // alert3
            // 
            this.alert3.Location = new System.Drawing.Point(16, 294);
            this.alert3.Name = "alert3";
            this.alert3.Size = new System.Drawing.Size(130, 95);
            this.alert3.TabIndex = 9;
            this.alert3.TabStop = false;
            // 
            // alert4
            // 
            this.alert4.Location = new System.Drawing.Point(441, 294);
            this.alert4.Name = "alert4";
            this.alert4.Size = new System.Drawing.Size(130, 95);
            this.alert4.TabIndex = 10;
            this.alert4.TabStop = false;
            // 
            // AlertScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 414);
            this.Controls.Add(this.alert4);
            this.Controls.Add(this.alert3);
            this.Controls.Add(this.alert2);
            this.Controls.Add(this.alert1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AlertScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AlertScreen_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alert1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alert2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alert3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alert4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox alert1;
        private System.Windows.Forms.PictureBox alert2;
        private System.Windows.Forms.PictureBox alert3;
        private System.Windows.Forms.PictureBox alert4;
    }
}