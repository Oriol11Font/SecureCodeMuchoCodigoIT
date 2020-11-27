using System.ComponentModel;

namespace TextBoxControls
{
    partial class SwInput
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label.Location = new System.Drawing.Point(3, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(264, 36);
            this.label.TabIndex = 0;
            this.label.Text = "label1";
            // 
            // inputbox
            // 
            this.inputbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.inputbox.Location = new System.Drawing.Point(35, 29);
            this.inputbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(279, 38);
            this.inputbox.TabIndex = 1;
            this.inputbox.TextChanged += new System.EventHandler(this.HandleTextChange);
            // 
            // SwInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SwInput";
            this.Size = new System.Drawing.Size(284, 69);
            this.Load += new System.EventHandler(this.Init);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Label label;

        #endregion
    }
}