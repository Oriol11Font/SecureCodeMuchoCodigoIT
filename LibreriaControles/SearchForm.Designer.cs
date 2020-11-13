using System.ComponentModel;

namespace LibreriaControles
{
    sealed partial class SearchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.RichTextBox();
            this.listColumns = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize) (this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid.Location = new System.Drawing.Point(0, 302);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(1923, 800);
            this.dataGrid.TabIndex = 19;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchButton.Location = new System.Drawing.Point(753, 141);
            this.searchButton.Name = "searchButton";
            this.searchButton.Padding = new System.Windows.Forms.Padding(5);
            this.searchButton.Size = new System.Drawing.Size(120, 50);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.searchTextBox.Location = new System.Drawing.Point(443, 141);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.searchTextBox.Size = new System.Drawing.Size(290, 50);
            this.searchTextBox.TabIndex = 21;
            this.searchTextBox.Text = "";
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleTextBoxKey);
            // 
            // listColumns
            // 
            this.listColumns.FormattingEnabled = true;
            this.listColumns.ItemHeight = 16;
            this.listColumns.Location = new System.Drawing.Point(27, 141);
            this.listColumns.Name = "listColumns";
            this.listColumns.Size = new System.Drawing.Size(396, 68);
            this.listColumns.TabIndex = 22;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 1102);
            this.Controls.Add(this.listColumns);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dataGrid);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Controls.SetChildIndex(this.dataGrid, 0);
            this.Controls.SetChildIndex(this.searchButton, 0);
            this.Controls.SetChildIndex(this.searchTextBox, 0);
            this.Controls.SetChildIndex(this.listColumns, 0);
            ((System.ComponentModel.ISupportInitialize) (this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox listColumns;

        private System.Windows.Forms.RichTextBox searchTextBox;

        private System.Windows.Forms.Button searchButton;

        private System.Windows.Forms.DataGridView dataGrid;

        #endregion
    }
}