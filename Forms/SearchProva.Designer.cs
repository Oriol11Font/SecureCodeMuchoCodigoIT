using System.ComponentModel;

namespace ProvaClasse.Forms
{
    partial class SearchProva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.input1 = new TextBoxControls.SwInput();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(294, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 33);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // input1
            // 
            this.input1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.input1.BackColor = System.Drawing.Color.Transparent;
            this.input1.Location = new System.Drawing.Point(12, 116);
            this.input1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(260, 80);
            this.input1.TabIndex = 24;
            // 
            // SearchProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.button1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchProva";
            this.Text = "SearchProva";
            this.Load += new System.EventHandler(this.Initialize);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.input1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        #endregion

        private TextBoxControls.SwInput input1;
    }
}