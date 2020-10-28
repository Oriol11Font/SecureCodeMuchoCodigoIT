namespace ProvaClasse.Forms
{
    partial class TestOriol
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
            this.mcCodi1 = new TextBoxControls.MCCodi();
            this.mcCodi2 = new TextBoxControls.MCCodi();
            this.SuspendLayout();
            // 
            // mcCodi1
            // 
            this.mcCodi1.Location = new System.Drawing.Point(267, 178);
            this.mcCodi1.Name = "mcCodi1";
            this.mcCodi1.Size = new System.Drawing.Size(349, 28);
            this.mcCodi1.TabIndex = 18;
            // 
            // mcCodi2
            // 
            this.mcCodi2.Location = new System.Drawing.Point(267, 212);
            this.mcCodi2.Name = "mcCodi2";
            this.mcCodi2.Size = new System.Drawing.Size(349, 28);
            this.mcCodi2.TabIndex = 19;
            // 
            // TestOriol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.mcCodi2);
            this.Controls.Add(this.mcCodi1);
            this.Name = "TestOriol";
            this.Text = "TestOriol";
            this.Load += new System.EventHandler(this.TestOriol_Load);
            this.Controls.SetChildIndex(this.mcCodi1, 0);
            this.Controls.SetChildIndex(this.mcCodi2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxControls.MCCodi mcCodi1;
        private TextBoxControls.MCCodi mcCodi2;
    }
}