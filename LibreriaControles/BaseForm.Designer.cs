namespace LibreriaControles
{
    partial class BaseForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AppTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TitleForm = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.profileimg = new System.Windows.Forms.PictureBox();
            this.logoutlink = new System.Windows.Forms.LinkLabel();
            this.username = new System.Windows.Forms.Label();

            this.panel8 = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileimg)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.AppTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_minimize);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1774, 40);
            this.panel1.TabIndex = 0;
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AppTitle.Location = new System.Drawing.Point(48, 14);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(464, 17);
            this.AppTitle.TabIndex = 3;
            this.AppTitle.Text = "MuchoCodigoIT - SecureCore - Rebel Alliance System Upgrade";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibreriaControles.Properties.Resources.logo_app;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(9, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_minimize.Location = new System.Drawing.Point(1641, 0);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(66, 40);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.Text = "-";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_exit.Location = new System.Drawing.Point(1705, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(69, 40);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 1045);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1754, 10);
            this.panel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 1015);
            this.panel2.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1764, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 1015);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1754, 110);
            this.panel5.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TitleForm);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1256, 110);
            this.panel7.TabIndex = 4;
            // 
            // TitleForm
            // 
            this.TitleForm.AutoSize = true;
            this.TitleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleForm.Location = new System.Drawing.Point(38, 33);
            this.TitleForm.Name = "TitleForm";
            this.TitleForm.Size = new System.Drawing.Size(650, 91);
            this.TitleForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleForm.Location = new System.Drawing.Point(0, 0);
            this.TitleForm.Name = "TitleForm";
            this.TitleForm.Size = new System.Drawing.Size(749, 104);
            this.TitleForm.TabIndex = 0;
            this.TitleForm.Text = "Titulo Formulario";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.profileimg);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1256, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(498, 110);
            this.panel6.TabIndex = 3;
            // 
            // profileimg
            // 
            this.profileimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profileimg.Dock = System.Windows.Forms.DockStyle.Right;
            this.profileimg.Image = global::LibreriaControles.Properties.Resources.profile_img;
            this.profileimg.Location = new System.Drawing.Point(373, 0);
            this.profileimg.Name = "profileimg";
            this.profileimg.Size = new System.Drawing.Size(125, 110);
            this.profileimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileimg.TabIndex = 0;
            this.profileimg.TabStop = false;
            // 
            // logoutlink
            // 
            this.logoutlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutlink.LinkColor = System.Drawing.Color.White;
            this.logoutlink.Location = new System.Drawing.Point(0, 54);
            this.logoutlink.Name = "logoutlink";
            this.logoutlink.Size = new System.Drawing.Size(217, 20);
            this.logoutlink.TabIndex = 2;
            this.logoutlink.TabStop = true;
            this.logoutlink.Text = "Cerrar sesión";
            this.logoutlink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutlink.BackColor = System.Drawing.Color.Transparent;
            this.logoutlink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutlink.LinkColor = System.Drawing.Color.White;
            this.logoutlink.Location = new System.Drawing.Point(0, 39);
            this.logoutlink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoutlink.Size = new System.Drawing.Size(373, 71);
            this.logoutlink.TabIndex = 2;
            this.logoutlink.TabStop = true;
            this.logoutlink.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.logoutlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(3, 9);
            this.username.Name = "username";
            this.username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.username.Size = new System.Drawing.Size(217, 45);
            this.username.TabIndex = 1;
            this.username.Text = "UserName";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.username);
            this.panel8.Controls.Add(this.logoutlink);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(373, 110);
            this.panel8.TabIndex = 1;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1774, 1055);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BaseForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileimg)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel logoutlink;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox profileimg;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label TitleForm;
        private System.Windows.Forms.Panel panel8;
    }
}
