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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.mtxt_password = new System.Windows.Forms.MaskedTextBox();
            this.pic_logo_login = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.loginBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.messageLoginLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_login)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.btn_minimize);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 26);
            this.panel1.TabIndex = 1;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.Location = new System.Drawing.Point(662, 0);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(44, 26);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.Text = "-";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(705, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(46, 26);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.usernameLabel.Location = new System.Drawing.Point(325, 268);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(110, 25);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.passwordLabel.Location = new System.Drawing.Point(325, 332);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(106, 25);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
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
            this.mtxt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_password.Location = new System.Drawing.Point(280, 353);
            this.mtxt_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxt_password.Name = "mtxt_password";
            this.mtxt_password.PasswordChar = '*';
            this.mtxt_password.Size = new System.Drawing.Size(182, 23);
            this.mtxt_password.TabIndex = 5;
            this.mtxt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxt_password_KeyDown);
            // 
            // pic_logo_login
            // 
            this.pic_logo_login.BackColor = System.Drawing.Color.Transparent;
            this.pic_logo_login.Image = global::ProvaClasse.Properties.Resources.logo_login;
            this.pic_logo_login.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_logo_login.InitialImage")));
            this.pic_logo_login.Location = new System.Drawing.Point(264, 44);
            this.pic_logo_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_logo_login.Name = "pic_logo_login";
            this.pic_logo_login.Size = new System.Drawing.Size(208, 210);
            this.pic_logo_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo_login.TabIndex = 6;
            this.pic_logo_login.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Yellow;
            this.btn_login.Location = new System.Drawing.Point(317, 396);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(118, 27);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Inicia sessió";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // loginBar
            // 
            this.loginBar.BackColor = System.Drawing.Color.Red;
            this.loginBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.loginBar.Location = new System.Drawing.Point(212, 353);
            this.loginBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBar.Name = "loginBar";
            this.loginBar.Size = new System.Drawing.Size(312, 19);
            this.loginBar.TabIndex = 8;
            this.loginBar.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // messageLoginLabel
            // 
            this.messageLoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.messageLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.messageLoginLabel.Location = new System.Drawing.Point(209, 289);
            this.messageLoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLoginLabel.Name = "messageLoginLabel";
            this.messageLoginLabel.Size = new System.Drawing.Size(315, 43);
            this.messageLoginLabel.TabIndex = 9;
            this.messageLoginLabel.Text = "Estamos validando sus datos!\r\nEsto puede tardar unos minutos...\r\n";
            this.messageLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageLoginLabel.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::ProvaClasse.Properties.Resources.bg_image;
            this.ClientSize = new System.Drawing.Size(751, 470);
            this.Controls.Add(this.messageLoginLabel);
            this.Controls.Add(this.loginBar);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pic_logo_login);
            this.Controls.Add(this.mtxt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.MaskedTextBox mtxt_password;
        private System.Windows.Forms.PictureBox pic_logo_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ProgressBar loginBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label messageLoginLabel;
    }
}