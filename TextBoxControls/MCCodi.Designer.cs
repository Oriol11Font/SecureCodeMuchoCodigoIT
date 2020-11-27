namespace TextBoxControls
{
    partial class MCCodi
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CodiBox = new System.Windows.Forms.TextBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.AttentionRequerit = new System.Windows.Forms.PictureBox();
            this.controltxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AttentionRequerit)).BeginInit();
            this.SuspendLayout();
            // 
            // CodiBox
            // 
            this.CodiBox.Location = new System.Drawing.Point(3, 3);
            this.CodiBox.Name = "CodiBox";
            this.CodiBox.Size = new System.Drawing.Size(109, 22);
            this.CodiBox.TabIndex = 0;
            this.CodiBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObreCS);
            this.CodiBox.Leave += new System.EventHandler(this.ValidacioCodi);
            // 
            // DescBox
            // 
            this.DescBox.Enabled = false;
            this.DescBox.Location = new System.Drawing.Point(118, 3);
            this.DescBox.Name = "DescBox";
            this.DescBox.ReadOnly = true;
            this.DescBox.Size = new System.Drawing.Size(321, 22);
            this.DescBox.TabIndex = 1;
            // 
            // AttentionRequerit
            // 
            this.AttentionRequerit.Image = global::TextBoxControls.Properties.Resources.alertRequisit;
            this.AttentionRequerit.Location = new System.Drawing.Point(445, 3);
            this.AttentionRequerit.Name = "AttentionRequerit";
            this.AttentionRequerit.Size = new System.Drawing.Size(26, 22);
            this.AttentionRequerit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AttentionRequerit.TabIndex = 2;
            this.AttentionRequerit.TabStop = false;
            this.AttentionRequerit.Visible = false;
            // 
            // controltxt
            // 
            this.controltxt.Location = new System.Drawing.Point(440, 3);
            this.controltxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controltxt.Name = "controltxt";
            this.controltxt.Size = new System.Drawing.Size(32, 22);
            this.controltxt.TabIndex = 3;
            this.controltxt.Visible = false;
            this.controltxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MCCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.controltxt);
            this.Controls.Add(this.AttentionRequerit);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.CodiBox);
            this.Name = "MCCodi";
            this.Size = new System.Drawing.Size(506, 28);
            ((System.ComponentModel.ISupportInitialize)(this.AttentionRequerit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodiBox;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.PictureBox AttentionRequerit;
        private System.Windows.Forms.TextBox controltxt;
    }
}
