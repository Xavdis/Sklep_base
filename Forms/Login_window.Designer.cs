namespace Sklep_base
{
    partial class login_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        ///
        
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
            lbl_welcome = new Label();
            lbl_login = new Label();
            lbl_pasw = new Label();
            txt_login = new TextBox();
            txt_password = new TextBox();
            btn_createLogin = new Button();
            btn_login = new Button();
            btn_exit = new Button();
            lbl_clear = new Label();
            pan_left = new Panel();
            lbl_employee = new Label();
            lbl_server = new Label();
            lbl_version = new Label();
            lbl_net = new Label();
            chbox_Visible = new CheckBox();
            pan_left.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_welcome
            // 
            lbl_welcome.Font = new Font("Comic Sans MS", 28F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_welcome.ForeColor = Color.SeaGreen;
            lbl_welcome.Location = new Point(203, 59);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Padding = new Padding(0, 10, 0, 10);
            lbl_welcome.Size = new Size(402, 66);
            lbl_welcome.TabIndex = 0;
            lbl_welcome.Text = "Welcome";
            lbl_welcome.TextAlign = ContentAlignment.MiddleCenter;
            lbl_welcome.MouseDown += ClickOnWindow;
            lbl_welcome.MouseMove += MoveWindow;
            // 
            // lbl_login
            // 
            lbl_login.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_login.ForeColor = Color.SeaGreen;
            lbl_login.Location = new Point(221, 149);
            lbl_login.Name = "lbl_login";
            lbl_login.Padding = new Padding(0, 7, 0, 0);
            lbl_login.Size = new Size(140, 29);
            lbl_login.TabIndex = 0;
            lbl_login.Text = "Login:";
            lbl_login.TextAlign = ContentAlignment.MiddleRight;
            lbl_login.MouseDown += ClickOnWindow;
            lbl_login.MouseMove += MoveWindow;
            // 
            // lbl_pasw
            // 
            lbl_pasw.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pasw.ForeColor = Color.SeaGreen;
            lbl_pasw.Location = new Point(221, 185);
            lbl_pasw.Name = "lbl_pasw";
            lbl_pasw.Padding = new Padding(0, 7, 0, 0);
            lbl_pasw.Size = new Size(140, 29);
            lbl_pasw.TabIndex = 0;
            lbl_pasw.Text = "Password:";
            lbl_pasw.TextAlign = ContentAlignment.MiddleRight;
            lbl_pasw.MouseDown += ClickOnWindow;
            lbl_pasw.MouseMove += MoveWindow;
            // 
            // txt_login
            // 
            txt_login.BackColor = Color.White;
            txt_login.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_login.ForeColor = Color.SeaGreen;
            txt_login.Location = new Point(367, 148);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(171, 30);
            txt_login.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.White;
            txt_password.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.ForeColor = Color.SeaGreen;
            txt_password.Location = new Point(367, 184);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(171, 30);
            txt_password.TabIndex = 2;
            // 
            // btn_createLogin
            // 
            btn_createLogin.AutoSize = true;
            btn_createLogin.BackColor = Color.White;
            btn_createLogin.Cursor = Cursors.Hand;
            btn_createLogin.FlatAppearance.BorderColor = Color.SeaGreen;
            btn_createLogin.FlatAppearance.BorderSize = 2;
            btn_createLogin.FlatStyle = FlatStyle.Flat;
            btn_createLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_createLogin.ForeColor = Color.SeaGreen;
            btn_createLogin.Location = new Point(404, 279);
            btn_createLogin.Name = "btn_createLogin";
            btn_createLogin.Size = new Size(100, 37);
            btn_createLogin.TabIndex = 5;
            btn_createLogin.Text = "Sign up";
            btn_createLogin.UseVisualStyleBackColor = false;
            btn_createLogin.Click += btn_createLogin_Click;
            // 
            // btn_login
            // 
            btn_login.AutoSize = true;
            btn_login.BackColor = Color.White;
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.BorderColor = Color.SeaGreen;
            btn_login.FlatAppearance.BorderSize = 2;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = Color.SeaGreen;
            btn_login.Location = new Point(298, 279);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(100, 37);
            btn_login.TabIndex = 4;
            btn_login.Text = "Log in";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.AutoSize = true;
            btn_exit.BackColor = Color.White;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.FlatAppearance.BorderColor = Color.SeaGreen;
            btn_exit.FlatAppearance.BorderSize = 2;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_exit.ForeColor = Color.SeaGreen;
            btn_exit.Location = new Point(564, 9);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(36, 37);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // lbl_clear
            // 
            lbl_clear.Cursor = Cursors.Hand;
            lbl_clear.Font = new Font("Comic Sans MS", 12F, FontStyle.Underline, GraphicsUnit.Point);
            lbl_clear.ForeColor = Color.SeaGreen;
            lbl_clear.Location = new Point(367, 217);
            lbl_clear.Name = "lbl_clear";
            lbl_clear.Padding = new Padding(0, 0, 0, 8);
            lbl_clear.Size = new Size(59, 29);
            lbl_clear.TabIndex = 3;
            lbl_clear.Text = "Clear";
            lbl_clear.Click += lbl_clear_Click;
            // 
            // pan_left
            // 
            pan_left.BackColor = Color.SeaGreen;
            pan_left.Controls.Add(lbl_employee);
            pan_left.Controls.Add(lbl_server);
            pan_left.Controls.Add(lbl_version);
            pan_left.Controls.Add(lbl_net);
            pan_left.Location = new Point(-1, -6);
            pan_left.Name = "pan_left";
            pan_left.Size = new Size(200, 373);
            pan_left.TabIndex = 14;
            pan_left.MouseDown += ClickOnWindow;
            pan_left.MouseMove += MoveWindow;
            // 
            // lbl_employee
            // 
            lbl_employee.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_employee.ForeColor = Color.White;
            lbl_employee.Location = new Point(46, 131);
            lbl_employee.Name = "lbl_employee";
            lbl_employee.Size = new Size(100, 23);
            lbl_employee.TabIndex = 2;
            lbl_employee.Text = "Employee MS";
            lbl_employee.TextAlign = ContentAlignment.MiddleCenter;
            lbl_employee.MouseDown += ClickOnWindow;
            lbl_employee.MouseMove += MoveWindow;
            // 
            // lbl_server
            // 
            lbl_server.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_server.ForeColor = Color.White;
            lbl_server.Location = new Point(46, 167);
            lbl_server.Name = "lbl_server";
            lbl_server.Size = new Size(100, 23);
            lbl_server.TabIndex = 1;
            lbl_server.Text = "SQL Server";
            lbl_server.TextAlign = ContentAlignment.MiddleCenter;
            lbl_server.MouseDown += ClickOnWindow;
            lbl_server.MouseMove += MoveWindow;
            // 
            // lbl_version
            // 
            lbl_version.Font = new Font("Comic Sans MS", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_version.ForeColor = Color.White;
            lbl_version.Location = new Point(46, 343);
            lbl_version.Name = "lbl_version";
            lbl_version.Padding = new Padding(0, 8, 0, 0);
            lbl_version.Size = new Size(100, 23);
            lbl_version.TabIndex = 0;
            lbl_version.Text = "Version 1.33";
            lbl_version.TextAlign = ContentAlignment.MiddleCenter;
            lbl_version.MouseDown += ClickOnWindow;
            lbl_version.MouseMove += MoveWindow;
            // 
            // lbl_net
            // 
            lbl_net.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_net.ForeColor = Color.White;
            lbl_net.Location = new Point(46, 203);
            lbl_net.Name = "lbl_net";
            lbl_net.Size = new Size(100, 23);
            lbl_net.TabIndex = 0;
            lbl_net.Text = "C#.NET";
            lbl_net.TextAlign = ContentAlignment.MiddleCenter;
            lbl_net.MouseDown += ClickOnWindow;
            lbl_net.MouseMove += MoveWindow;
            // 
            // chbox_Visible
            // 
            chbox_Visible.AutoSize = true;
            chbox_Visible.Cursor = Cursors.Hand;
            chbox_Visible.FlatStyle = FlatStyle.Flat;
            chbox_Visible.Font = new Font("Comic Sans MS", 12F, FontStyle.Underline, GraphicsUnit.Point);
            chbox_Visible.ForeColor = Color.SeaGreen;
            chbox_Visible.Location = new Point(460, 215);
            chbox_Visible.Name = "chbox_Visible";
            chbox_Visible.Size = new Size(84, 27);
            chbox_Visible.TabIndex = 15;
            chbox_Visible.Text = "Visiable";
            chbox_Visible.UseVisualStyleBackColor = true;
            chbox_Visible.CheckedChanged += chbox_Visible_CheckedChanged;
            // 
            // login_window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(609, 360);
            Controls.Add(btn_exit);
            Controls.Add(chbox_Visible);
            Controls.Add(pan_left);
            Controls.Add(lbl_clear);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_login);
            Controls.Add(lbl_login);
            Controls.Add(lbl_pasw);
            Controls.Add(lbl_welcome);
            Controls.Add(btn_createLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login_window";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            MouseDown += ClickOnWindow;
            MouseMove += MoveWindow;
            pan_left.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_welcome;
        private Label lbl_login;
        private Label lbl_pasw;
        private TextBox txt_login;
        private TextBox txt_password;
        private Button btn_createLogin;
        private Button btn_login;
        private Button btn_exit;
        private Label lbl_clear;
        private Panel pan_left;
        private Label lbl_employee;
        private Label lbl_server;
        private Label lbl_version;
        private Label lbl_net;
        private CheckBox chbox_Visible;
    }
}