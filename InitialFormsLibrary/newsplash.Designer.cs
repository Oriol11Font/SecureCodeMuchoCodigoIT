
﻿namespace SecureCoreMain


{
    partial class newsplash
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newsplash));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_progressCarga = new System.Windows.Forms.Label();
            this.splashBar1 = new System.Windows.Forms.ProgressBar();
            this.splashimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splashimg)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_progressCarga
            // 
            this.lbl_progressCarga.AutoSize = true;
            this.lbl_progressCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_progressCarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.lbl_progressCarga.Location = new System.Drawing.Point(332, 284);
            this.lbl_progressCarga.Name = "lbl_progressCarga";
            this.lbl_progressCarga.Size = new System.Drawing.Size(0, 36);
            this.lbl_progressCarga.TabIndex = 1;
            // 
            // splashBar1
            // 
            this.splashBar1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.splashBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splashBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.splashBar1.Location = new System.Drawing.Point(0, 352);
            this.splashBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splashBar1.Maximum = 102;
            this.splashBar1.Name = "splashBar1";
            this.splashBar1.Size = new System.Drawing.Size(711, 7);
            this.splashBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.splashBar1.TabIndex = 2;
            // 
            // splashimg
            // 
            this.splashimg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splashimg.Image = global::InitialFormsLibrary.Properties.Resources.bqsplash;
            this.splashimg.Location = new System.Drawing.Point(187, 51);
            this.splashimg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splashimg.Name = "splashimg";
            this.splashimg.Size = new System.Drawing.Size(335, 269);
            this.splashimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.splashimg.TabIndex = 4;
            this.splashimg.TabStop = false;
            // 
            // newsplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(711, 359);
            this.Controls.Add(this.splashimg);
            this.Controls.Add(this.splashBar1);
            this.Controls.Add(this.lbl_progressCarga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "newsplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.splashimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_progressCarga;
        private System.Windows.Forms.ProgressBar splashBar1;
        private System.Windows.Forms.PictureBox splashimg;
    }
}

