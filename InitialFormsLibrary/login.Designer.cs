namespace InitialFormsLibrary
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.poweredby = new System.Windows.Forms.Label();
            this.trademark = new System.Windows.Forms.Panel();
            this.secureVersion = new System.Windows.Forms.Label();
            this.MCimg = new System.Windows.Forms.PictureBox();
            this.borderTop = new System.Windows.Forms.Panel();
            this.borderLeft = new System.Windows.Forms.Panel();
            this.borderBottom = new System.Windows.Forms.Panel();
            this.borderRight = new System.Windows.Forms.Panel();
            this.topbar = new System.Windows.Forms.Panel();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.loginBar = new System.Windows.Forms.ProgressBar();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.mtxt_password = new System.Windows.Forms.MaskedTextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.messageLoginLabel = new System.Windows.Forms.Label();
            this.incorrectlbl = new System.Windows.Forms.Label();
            this.inputsPanel = new System.Windows.Forms.Panel();
            this.validImg = new System.Windows.Forms.PictureBox();
            this.password_warning = new System.Windows.Forms.PictureBox();
            this.username_warning = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pic_logo_login = new System.Windows.Forms.PictureBox();
            this.trademark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MCimg)).BeginInit();
            this.topbar.SuspendLayout();
            this.inputsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_warning)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_login)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(199, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 73);
            this.label1.TabIndex = 10;
            this.label1.Text = "SECURECORE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // poweredby
            // 
            this.poweredby.AutoSize = true;
            this.poweredby.BackColor = System.Drawing.Color.Transparent;
            this.poweredby.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poweredby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.poweredby.Location = new System.Drawing.Point(6, 28);
            this.poweredby.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.poweredby.Name = "poweredby";
            this.poweredby.Size = new System.Drawing.Size(73, 13);
            this.poweredby.TabIndex = 11;
            this.poweredby.Text = "Powered by";
            // 
            // trademark
            // 
            this.trademark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trademark.Controls.Add(this.secureVersion);
            this.trademark.Controls.Add(this.MCimg);
            this.trademark.Controls.Add(this.poweredby);
            this.trademark.Location = new System.Drawing.Point(635, 401);
            this.trademark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trademark.Name = "trademark";
            this.trademark.Size = new System.Drawing.Size(137, 45);
            this.trademark.TabIndex = 12;
            // 
            // secureVersion
            // 
            this.secureVersion.AutoSize = true;
            this.secureVersion.BackColor = System.Drawing.Color.Transparent;
            this.secureVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secureVersion.ForeColor = System.Drawing.Color.Gray;
            this.secureVersion.Location = new System.Drawing.Point(28, 17);
            this.secureVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secureVersion.Name = "secureVersion";
            this.secureVersion.Size = new System.Drawing.Size(49, 9);
            this.secureVersion.TabIndex = 13;
            this.secureVersion.Text = "Versión 0.6.6";
            // 
            // MCimg
            // 
            this.MCimg.Image = ((System.Drawing.Image)(resources.GetObject("MCimg.Image")));
            this.MCimg.Location = new System.Drawing.Point(81, 4);
            this.MCimg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MCimg.Name = "MCimg";
            this.MCimg.Size = new System.Drawing.Size(56, 40);
            this.MCimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MCimg.TabIndex = 12;
            this.MCimg.TabStop = false;
            // 
            // borderTop
            // 
            this.borderTop.BackColor = System.Drawing.Color.Yellow;
            this.borderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderTop.Location = new System.Drawing.Point(0, 0);
            this.borderTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.borderTop.Name = "borderTop";
            this.borderTop.Size = new System.Drawing.Size(786, 6);
            this.borderTop.TabIndex = 13;
            // 
            // borderLeft
            // 
            this.borderLeft.BackColor = System.Drawing.Color.Yellow;
            this.borderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderLeft.Location = new System.Drawing.Point(0, 6);
            this.borderLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.borderLeft.Name = "borderLeft";
            this.borderLeft.Size = new System.Drawing.Size(6, 505);
            this.borderLeft.TabIndex = 14;
            // 
            // borderBottom
            // 
            this.borderBottom.BackColor = System.Drawing.Color.Yellow;
            this.borderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderBottom.Location = new System.Drawing.Point(6, 505);
            this.borderBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.borderBottom.Name = "borderBottom";
            this.borderBottom.Size = new System.Drawing.Size(780, 6);
            this.borderBottom.TabIndex = 15;
            // 
            // borderRight
            // 
            this.borderRight.BackColor = System.Drawing.Color.Yellow;
            this.borderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.borderRight.ForeColor = System.Drawing.Color.Yellow;
            this.borderRight.Location = new System.Drawing.Point(780, 6);
            this.borderRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.borderRight.Name = "borderRight";
            this.borderRight.Size = new System.Drawing.Size(6, 499);
            this.borderRight.TabIndex = 16;
            // 
            // topbar
            // 
            this.topbar.AutoSize = true;
            this.topbar.BackColor = System.Drawing.Color.Black;
            this.topbar.Controls.Add(this.minimizebtn);
            this.topbar.Controls.Add(this.closebtn);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(6, 6);
            this.topbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(774, 34);
            this.topbar.TabIndex = 17;
            this.topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseDown);
            this.topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseMove);
            this.topbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseUp);
            // 
            // minimizebtn
            // 
            this.minimizebtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizebtn.FlatAppearance.BorderSize = 0;
            this.minimizebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizebtn.ForeColor = System.Drawing.Color.Yellow;
            this.minimizebtn.Location = new System.Drawing.Point(687, -1);
            this.minimizebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(37, 33);
            this.minimizebtn.TabIndex = 3;
            this.minimizebtn.Text = "-";
            this.minimizebtn.UseVisualStyleBackColor = false;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            this.minimizebtn.MouseLeave += new System.EventHandler(this.minimizebtn_MouseLeave);
            this.minimizebtn.MouseHover += new System.EventHandler(this.minimizebtn_MouseHover);
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.Red;
            this.closebtn.Location = new System.Drawing.Point(728, 0);
            this.closebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(39, 32);
            this.closebtn.TabIndex = 5;
            this.closebtn.Text = "x";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            this.closebtn.MouseLeave += new System.EventHandler(this.closebtn_MouseLeave);
            this.closebtn.MouseHover += new System.EventHandler(this.closebtn_MouseHover);
            // 
            // loginBar
            // 
            this.loginBar.BackColor = System.Drawing.Color.Red;
            this.loginBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.loginBar.Location = new System.Drawing.Point(6, 489);
            this.loginBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBar.Name = "loginBar";
            this.loginBar.Size = new System.Drawing.Size(774, 16);
            this.loginBar.TabIndex = 18;
            this.loginBar.Visible = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.usernameLabel.Location = new System.Drawing.Point(142, 11);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 20);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Usuari";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.passwordLabel.Location = new System.Drawing.Point(122, 60);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(99, 20);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Contrasenya";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(85, 33);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(182, 23);
            this.txt_username.TabIndex = 1;
            this.txt_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxt_password_KeyDown);
            // 
            // mtxt_password
            // 
            this.mtxt_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtxt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mtxt_password.Location = new System.Drawing.Point(85, 82);
            this.mtxt_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxt_password.Name = "mtxt_password";
            this.mtxt_password.PasswordChar = '*';
            this.mtxt_password.Size = new System.Drawing.Size(182, 23);
            this.mtxt_password.TabIndex = 2;
            this.mtxt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxt_password_KeyDown);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Yellow;
            this.btn_login.Location = new System.Drawing.Point(117, 109);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(118, 27);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "INICIA";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // messageLoginLabel
            // 
            this.messageLoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.messageLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(31)))));
            this.messageLoginLabel.Location = new System.Drawing.Point(7, 165);
            this.messageLoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLoginLabel.Name = "messageLoginLabel";
            this.messageLoginLabel.Size = new System.Drawing.Size(342, 43);
            this.messageLoginLabel.TabIndex = 9;
            this.messageLoginLabel.Text = "Estamos validando sus datos!\r\nEsto puede tardar unos minutos...\r\n";
            this.messageLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageLoginLabel.Visible = false;
            // 
            // incorrectlbl
            // 
            this.incorrectlbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.incorrectlbl.BackColor = System.Drawing.Color.Transparent;
            this.incorrectlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectlbl.ForeColor = System.Drawing.Color.Red;
            this.incorrectlbl.Location = new System.Drawing.Point(8, 168);
            this.incorrectlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incorrectlbl.Name = "incorrectlbl";
            this.incorrectlbl.Size = new System.Drawing.Size(335, 43);
            this.incorrectlbl.TabIndex = 19;
            this.incorrectlbl.Text = "Usuario/contraseña incorrectos";
            this.incorrectlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.incorrectlbl.Visible = false;
            // 
            // inputsPanel
            // 
            this.inputsPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inputsPanel.Controls.Add(this.validImg);
            this.inputsPanel.Controls.Add(this.password_warning);
            this.inputsPanel.Controls.Add(this.username_warning);
            this.inputsPanel.Controls.Add(this.incorrectlbl);
            this.inputsPanel.Controls.Add(this.messageLoginLabel);
            this.inputsPanel.Controls.Add(this.usernameLabel);
            this.inputsPanel.Controls.Add(this.btn_login);
            this.inputsPanel.Controls.Add(this.txt_username);
            this.inputsPanel.Controls.Add(this.passwordLabel);
            this.inputsPanel.Controls.Add(this.mtxt_password);
            this.inputsPanel.Location = new System.Drawing.Point(209, 220);
            this.inputsPanel.Name = "inputsPanel";
            this.inputsPanel.Size = new System.Drawing.Size(349, 216);
            this.inputsPanel.TabIndex = 21;
            // 
            // validImg
            // 
            this.validImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.validImg.Image = global::InitialFormsLibrary.Properties.Resources.loginvalidation;
            this.validImg.Location = new System.Drawing.Point(57, 3);
            this.validImg.Name = "validImg";
            this.validImg.Size = new System.Drawing.Size(237, 150);
            this.validImg.TabIndex = 20;
            this.validImg.TabStop = false;
            this.validImg.Visible = false;
            // 
            // password_warning
            // 
            this.password_warning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password_warning.Image = ((System.Drawing.Image)(resources.GetObject("password_warning.Image")));
            this.password_warning.InitialImage = ((System.Drawing.Image)(resources.GetObject("password_warning.InitialImage")));
            this.password_warning.Location = new System.Drawing.Point(57, 82);
            this.password_warning.Name = "password_warning";
            this.password_warning.Size = new System.Drawing.Size(23, 23);
            this.password_warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.password_warning.TabIndex = 21;
            this.password_warning.TabStop = false;
            this.password_warning.Visible = false;
            // 
            // username_warning
            // 
            this.username_warning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.username_warning.Image = global::InitialFormsLibrary.Properties.Resources.warning;
            this.username_warning.InitialImage = ((System.Drawing.Image)(resources.GetObject("username_warning.InitialImage")));
            this.username_warning.Location = new System.Drawing.Point(57, 33);
            this.username_warning.Name = "username_warning";
            this.username_warning.Size = new System.Drawing.Size(23, 23);
            this.username_warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.username_warning.TabIndex = 20;
            this.username_warning.TabStop = false;
            this.username_warning.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.inputsPanel);
            this.panel7.Controls.Add(this.trademark);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.pic_logo_login);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(6, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(774, 449);
            this.panel7.TabIndex = 22;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // pic_logo_login
            // 
            this.pic_logo_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_logo_login.BackColor = System.Drawing.Color.Transparent;
            this.pic_logo_login.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo_login.Image")));
            this.pic_logo_login.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_logo_login.InitialImage")));
            this.pic_logo_login.Location = new System.Drawing.Point(310, 2);
            this.pic_logo_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_logo_login.Name = "pic_logo_login";
            this.pic_logo_login.Size = new System.Drawing.Size(146, 149);
            this.pic_logo_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo_login.TabIndex = 6;
            this.pic_logo_login.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(786, 511);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.loginBar);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.borderRight);
            this.Controls.Add(this.borderBottom);
            this.Controls.Add(this.borderLeft);
            this.Controls.Add(this.borderTop);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Init);
            this.trademark.ResumeLayout(false);
            this.trademark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MCimg)).EndInit();
            this.topbar.ResumeLayout(false);
            this.inputsPanel.ResumeLayout(false);
            this.inputsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_warning)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_logo_login;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label poweredby;
        private System.Windows.Forms.Panel trademark;
        private System.Windows.Forms.PictureBox MCimg;
        private System.Windows.Forms.Panel borderTop;
        private System.Windows.Forms.Panel borderLeft;
        private System.Windows.Forms.Panel borderBottom;
        private System.Windows.Forms.Panel borderRight;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Button minimizebtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label secureVersion;
        private System.Windows.Forms.ProgressBar loginBar;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.MaskedTextBox mtxt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label messageLoginLabel;
        private System.Windows.Forms.PictureBox validImg;
        private System.Windows.Forms.Label incorrectlbl;
        private System.Windows.Forms.Panel inputsPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox username_warning;
        private System.Windows.Forms.PictureBox password_warning;
    }
}