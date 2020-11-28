namespace ProvaClasse
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.mtxt_password = new System.Windows.Forms.MaskedTextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.messageLoginLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.poweredby = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.secureVersion = new System.Windows.Forms.Label();
            this.MCimg = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.pic_logo_login = new System.Windows.Forms.PictureBox();
            this.loginBar = new System.Windows.Forms.ProgressBar();
            this.incorrectlbl = new System.Windows.Forms.Label();
            this.validImg = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MCimg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validImg)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Nasalization", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.usernameLabel.Location = new System.Drawing.Point(325, 266);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(104, 14);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Nasalization", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.passwordLabel.Location = new System.Drawing.Point(325, 329);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(104, 14);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(280, 289);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(182, 20);
            this.txt_username.TabIndex = 4;
            // 
            // mtxt_password
            // 
            this.mtxt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_password.Location = new System.Drawing.Point(280, 353);
            this.mtxt_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxt_password.Name = "mtxt_password";
            this.mtxt_password.PasswordChar = '*';
            this.mtxt_password.Size = new System.Drawing.Size(182, 20);
            this.mtxt_password.TabIndex = 5;
            this.mtxt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxt_password_KeyDown);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Nasalization", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Yellow;
            this.btn_login.Location = new System.Drawing.Point(317, 396);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(118, 27);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "INICIA";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // messageLoginLabel
            // 
            this.messageLoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.messageLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageLoginLabel.Font = new System.Drawing.Font("Nasalization", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.messageLoginLabel.Location = new System.Drawing.Point(162, 407);
            this.messageLoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLoginLabel.Name = "messageLoginLabel";
            this.messageLoginLabel.Size = new System.Drawing.Size(429, 43);
            this.messageLoginLabel.TabIndex = 9;
            this.messageLoginLabel.Text = "Estamos validando sus datos!\r\nEsto puede tardar unos minutos...\r\n";
            this.messageLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageLoginLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nasalization", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(167, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 57);
            this.label1.TabIndex = 10;
            this.label1.Text = "SECURECORE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // poweredby
            // 
            this.poweredby.AutoSize = true;
            this.poweredby.BackColor = System.Drawing.Color.Transparent;
            this.poweredby.Font = new System.Drawing.Font("Nasalization", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poweredby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.poweredby.Location = new System.Drawing.Point(40, 26);
            this.poweredby.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.poweredby.Name = "poweredby";
            this.poweredby.Size = new System.Drawing.Size(89, 10);
            this.poweredby.TabIndex = 11;
            this.poweredby.Text = "Powered by";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.secureVersion);
            this.panel2.Controls.Add(this.MCimg);
            this.panel2.Controls.Add(this.poweredby);
            this.panel2.Location = new System.Drawing.Point(556, 396);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 53);
            this.panel2.TabIndex = 12;
            // 
            // secureVersion
            // 
            this.secureVersion.AutoSize = true;
            this.secureVersion.BackColor = System.Drawing.Color.Transparent;
            this.secureVersion.Font = new System.Drawing.Font("Nasalization", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secureVersion.ForeColor = System.Drawing.Color.Gray;
            this.secureVersion.Location = new System.Drawing.Point(76, 36);
            this.secureVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secureVersion.Name = "secureVersion";
            this.secureVersion.Size = new System.Drawing.Size(45, 5);
            this.secureVersion.TabIndex = 13;
            this.secureVersion.Text = "Versión 0.6.6";
            // 
            // MCimg
            // 
            this.MCimg.Image = global::InitialFormsLibrary.Properties.Resources.logo_app;
            this.MCimg.Location = new System.Drawing.Point(127, 6);
            this.MCimg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MCimg.Name = "MCimg";
            this.MCimg.Size = new System.Drawing.Size(56, 40);
            this.MCimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MCimg.TabIndex = 12;
            this.MCimg.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 8);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 8);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 462);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Yellow;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(8, 462);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(743, 8);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Yellow;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.ForeColor = System.Drawing.Color.Yellow;
            this.panel6.Location = new System.Drawing.Point(743, 8);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(8, 454);
            this.panel6.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.minimizebtn);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 34);
            this.panel1.TabIndex = 17;
            // 
            // minimizebtn
            // 
            this.minimizebtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizebtn.FlatAppearance.BorderSize = 0;
            this.minimizebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebtn.Font = new System.Drawing.Font("Nasalization", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizebtn.ForeColor = System.Drawing.Color.Yellow;
            this.minimizebtn.Location = new System.Drawing.Point(656, 0);
            this.minimizebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(41, 32);
            this.minimizebtn.TabIndex = 14;
            this.minimizebtn.Text = "-";
            this.minimizebtn.UseVisualStyleBackColor = false;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Nasalization", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.Red;
            this.closebtn.Location = new System.Drawing.Point(694, 0);
            this.closebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(39, 32);
            this.closebtn.TabIndex = 13;
            this.closebtn.Text = "x";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // pic_logo_login
            // 
            this.pic_logo_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_logo_login.BackColor = System.Drawing.Color.Transparent;
            this.pic_logo_login.Image = global::InitialFormsLibrary.Properties.Resources.logo_login;
            this.pic_logo_login.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_logo_login.InitialImage")));
            this.pic_logo_login.Location = new System.Drawing.Point(230, 46);
            this.pic_logo_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_logo_login.Name = "pic_logo_login";
            this.pic_logo_login.Size = new System.Drawing.Size(295, 195);
            this.pic_logo_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo_login.TabIndex = 6;
            this.pic_logo_login.TabStop = false;
            // 
            // loginBar
            // 
            this.loginBar.BackColor = System.Drawing.Color.Red;
            this.loginBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.loginBar.Location = new System.Drawing.Point(8, 452);
            this.loginBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBar.Name = "loginBar";
            this.loginBar.Size = new System.Drawing.Size(735, 10);
            this.loginBar.TabIndex = 18;
            this.loginBar.Visible = false;
            // 
            // incorrectlbl
            // 
            this.incorrectlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.incorrectlbl.BackColor = System.Drawing.Color.Transparent;
            this.incorrectlbl.Font = new System.Drawing.Font("Nasalization", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectlbl.ForeColor = System.Drawing.Color.Red;
            this.incorrectlbl.Location = new System.Drawing.Point(162, 246);
            this.incorrectlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incorrectlbl.Name = "incorrectlbl";
            this.incorrectlbl.Size = new System.Drawing.Size(429, 20);
            this.incorrectlbl.TabIndex = 19;
            this.incorrectlbl.Text = "Usuario o contraseña incorrecta";
            this.incorrectlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.incorrectlbl.Visible = false;
            // 
            // validImg
            // 
            this.validImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.validImg.Location = new System.Drawing.Point(245, 246);
            this.validImg.Name = "validImg";
            this.validImg.Size = new System.Drawing.Size(261, 158);
            this.validImg.TabIndex = 20;
            this.validImg.TabStop = false;
            this.validImg.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(751, 470);
            this.Controls.Add(this.validImg);
            this.Controls.Add(this.incorrectlbl);
            this.Controls.Add(this.loginBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageLoginLabel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pic_logo_login);
            this.Controls.Add(this.mtxt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MCimg)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.MaskedTextBox mtxt_password;
        private System.Windows.Forms.PictureBox pic_logo_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label messageLoginLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label poweredby;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox MCimg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimizebtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label secureVersion;
        private System.Windows.Forms.ProgressBar loginBar;
        private System.Windows.Forms.Label incorrectlbl;
        private System.Windows.Forms.PictureBox validImg;
    }
}