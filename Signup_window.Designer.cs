namespace Sklep_base
{
    partial class Signup_window
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
            pan_left = new Panel();
            lbl_employee = new Label();
            lbl_server = new Label();
            lbl_version = new Label();
            lbl_net = new Label();
            btn_createAccount = new Button();
            txt_password = new TextBox();
            txt_login = new TextBox();
            lbl_login = new Label();
            lbl_pasw1 = new Label();
            lbl_welcome = new Label();
            btn_cencel = new Button();
            lbl_clear = new Label();
            lbl_pasw = new Label();
            txt_code = new TextBox();
            chbox_Visible = new CheckBox();
            pan_left.SuspendLayout();
            SuspendLayout();
            // 
            // pan_left
            // 
            pan_left.BackColor = Color.SeaGreen;
            pan_left.Controls.Add(lbl_employee);
            pan_left.Controls.Add(lbl_server);
            pan_left.Controls.Add(lbl_version);
            pan_left.Controls.Add(lbl_net);
            pan_left.Location = new Point(-1, -8);
            pan_left.Margin = new Padding(3, 4, 3, 4);
            pan_left.Name = "pan_left";
            pan_left.Size = new Size(229, 497);
            pan_left.TabIndex = 13;
            pan_left.MouseDown += ClickOnWindow;
            pan_left.MouseMove += MoveWindow;
            // 
            // lbl_employee
            // 
            lbl_employee.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_employee.ForeColor = Color.White;
            lbl_employee.Location = new Point(53, 175);
            lbl_employee.Name = "lbl_employee";
            lbl_employee.Size = new Size(114, 31);
            lbl_employee.TabIndex = 0;
            lbl_employee.Text = "Employee MS";
            lbl_employee.TextAlign = ContentAlignment.MiddleCenter;
            lbl_employee.MouseDown += ClickOnWindow;
            lbl_employee.MouseMove += MoveWindow;
            // 
            // lbl_server
            // 
            lbl_server.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_server.ForeColor = Color.White;
            lbl_server.Location = new Point(53, 223);
            lbl_server.Name = "lbl_server";
            lbl_server.Size = new Size(114, 31);
            lbl_server.TabIndex = 0;
            lbl_server.Text = "SQL Server";
            lbl_server.TextAlign = ContentAlignment.MiddleCenter;
            lbl_server.MouseDown += ClickOnWindow;
            lbl_server.MouseMove += MoveWindow;
            // 
            // lbl_version
            // 
            lbl_version.Font = new Font("Comic Sans MS", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_version.ForeColor = Color.White;
            lbl_version.Location = new Point(53, 457);
            lbl_version.Name = "lbl_version";
            lbl_version.Padding = new Padding(0, 11, 0, 0);
            lbl_version.Size = new Size(114, 31);
            lbl_version.TabIndex = 0;
            lbl_version.Text = "Version 1.0";
            lbl_version.TextAlign = ContentAlignment.MiddleCenter;
            lbl_version.MouseDown += ClickOnWindow;
            lbl_version.MouseMove += MoveWindow;
            // 
            // lbl_net
            // 
            lbl_net.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_net.ForeColor = Color.White;
            lbl_net.Location = new Point(53, 271);
            lbl_net.Name = "lbl_net";
            lbl_net.Size = new Size(114, 31);
            lbl_net.TabIndex = 0;
            lbl_net.Text = "C#.NET";
            lbl_net.TextAlign = ContentAlignment.MiddleCenter;
            lbl_net.MouseDown += ClickOnWindow;
            lbl_net.MouseMove += MoveWindow;
            // 
            // btn_createAccount
            // 
            btn_createAccount.AutoSize = true;
            btn_createAccount.Cursor = Cursors.Hand;
            btn_createAccount.FlatAppearance.BorderColor = Color.SeaGreen;
            btn_createAccount.FlatAppearance.BorderSize = 2;
            btn_createAccount.FlatStyle = FlatStyle.Flat;
            btn_createAccount.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_createAccount.ForeColor = Color.SeaGreen;
            btn_createAccount.Location = new Point(327, 373);
            btn_createAccount.Margin = new Padding(3, 4, 3, 4);
            btn_createAccount.Name = "btn_createAccount";
            btn_createAccount.Size = new Size(167, 49);
            btn_createAccount.TabIndex = 4;
            btn_createAccount.Text = "Create Account";
            btn_createAccount.UseVisualStyleBackColor = false;
            btn_createAccount.Click += btn_createAccount_Click;
            // 
            // txt_password
            // 
            txt_password.Cursor = Cursors.IBeam;
            txt_password.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.ForeColor = Color.SeaGreen;
            txt_password.Location = new Point(419, 217);
            txt_password.Margin = new Padding(3, 4, 3, 4);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(195, 35);
            txt_password.TabIndex = 2;
            // 
            // txt_login
            // 
            txt_login.Cursor = Cursors.IBeam;
            txt_login.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_login.ForeColor = Color.SeaGreen;
            txt_login.Location = new Point(419, 169);
            txt_login.Margin = new Padding(3, 4, 3, 4);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(195, 35);
            txt_login.TabIndex = 1;
            // 
            // lbl_login
            // 
            lbl_login.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_login.ForeColor = Color.SeaGreen;
            lbl_login.Location = new Point(253, 171);
            lbl_login.Name = "lbl_login";
            lbl_login.Padding = new Padding(0, 9, 0, 0);
            lbl_login.Size = new Size(160, 39);
            lbl_login.TabIndex = 7;
            lbl_login.Text = "Login:";
            lbl_login.TextAlign = ContentAlignment.MiddleRight;
            lbl_login.MouseDown += ClickOnWindow;
            lbl_login.MouseMove += MoveWindow;
            // 
            // lbl_pasw1
            // 
            lbl_pasw1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pasw1.ForeColor = Color.SeaGreen;
            lbl_pasw1.Location = new Point(253, 219);
            lbl_pasw1.Name = "lbl_pasw1";
            lbl_pasw1.Padding = new Padding(0, 9, 0, 0);
            lbl_pasw1.Size = new Size(160, 39);
            lbl_pasw1.TabIndex = 8;
            lbl_pasw1.Text = "Password:";
            lbl_pasw1.TextAlign = ContentAlignment.MiddleRight;
            lbl_pasw1.MouseDown += ClickOnWindow;
            lbl_pasw1.MouseMove += MoveWindow;
            // 
            // lbl_welcome
            // 
            lbl_welcome.Font = new Font("Comic Sans MS", 28F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_welcome.ForeColor = Color.SeaGreen;
            lbl_welcome.Location = new Point(231, 59);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Padding = new Padding(0, 13, 0, 13);
            lbl_welcome.Size = new Size(459, 88);
            lbl_welcome.TabIndex = 0;
            lbl_welcome.Text = "Create new account";
            lbl_welcome.TextAlign = ContentAlignment.MiddleCenter;
            lbl_welcome.MouseDown += ClickOnWindow;
            lbl_welcome.MouseMove += MoveWindow;
            // 
            // btn_cencel
            // 
            btn_cencel.AutoSize = true;
            btn_cencel.Cursor = Cursors.Hand;
            btn_cencel.FlatAppearance.BorderColor = Color.SeaGreen;
            btn_cencel.FlatAppearance.BorderSize = 2;
            btn_cencel.FlatStyle = FlatStyle.Flat;
            btn_cencel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cencel.ForeColor = Color.SeaGreen;
            btn_cencel.Location = new Point(500, 373);
            btn_cencel.Margin = new Padding(3, 4, 3, 4);
            btn_cencel.Name = "btn_cencel";
            btn_cencel.Size = new Size(114, 49);
            btn_cencel.TabIndex = 5;
            btn_cencel.Text = "Cencel";
            btn_cencel.UseVisualStyleBackColor = false;
            btn_cencel.Click += btn_cencel_Click;
            // 
            // lbl_clear
            // 
            lbl_clear.AutoSize = true;
            lbl_clear.Cursor = Cursors.Hand;
            lbl_clear.Font = new Font("Comic Sans MS", 12F, FontStyle.Underline, GraphicsUnit.Point);
            lbl_clear.ForeColor = Color.SeaGreen;
            lbl_clear.Location = new Point(419, 312);
            lbl_clear.Name = "lbl_clear";
            lbl_clear.Padding = new Padding(0, 0, 0, 11);
            lbl_clear.Size = new Size(60, 39);
            lbl_clear.TabIndex = 0;
            lbl_clear.Text = "Clear";
            // 
            // lbl_pasw
            // 
            lbl_pasw.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pasw.ForeColor = Color.SeaGreen;
            lbl_pasw.Location = new Point(253, 267);
            lbl_pasw.Name = "lbl_pasw";
            lbl_pasw.Padding = new Padding(0, 9, 0, 0);
            lbl_pasw.Size = new Size(160, 39);
            lbl_pasw.TabIndex = 8;
            lbl_pasw.Text = "Code:";
            lbl_pasw.TextAlign = ContentAlignment.MiddleRight;
            lbl_pasw.MouseDown += ClickOnWindow;
            lbl_pasw.MouseMove += MoveWindow;
            // 
            // txt_code
            // 
            txt_code.Cursor = Cursors.IBeam;
            txt_code.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_code.ForeColor = Color.SeaGreen;
            txt_code.Location = new Point(419, 265);
            txt_code.Margin = new Padding(3, 4, 3, 4);
            txt_code.Name = "txt_code";
            txt_code.Size = new Size(195, 35);
            txt_code.TabIndex = 3;
            // 
            // chbox_Visible
            // 
            chbox_Visible.AutoSize = true;
            chbox_Visible.FlatStyle = FlatStyle.Flat;
            chbox_Visible.Font = new Font("Comic Sans MS", 12F, FontStyle.Underline, GraphicsUnit.Point);
            chbox_Visible.ForeColor = Color.SeaGreen;
            chbox_Visible.Location = new Point(519, 310);
            chbox_Visible.Margin = new Padding(3, 4, 3, 4);
            chbox_Visible.Name = "chbox_Visible";
            chbox_Visible.Size = new Size(95, 32);
            chbox_Visible.TabIndex = 16;
            chbox_Visible.Text = "Vidible";
            chbox_Visible.UseVisualStyleBackColor = true;
            chbox_Visible.CheckedChanged += chbox_Visible_CheckedChanged;
            // 
            // Signup_window
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(696, 480);
            Controls.Add(chbox_Visible);
            Controls.Add(pan_left);
            Controls.Add(btn_createAccount);
            Controls.Add(txt_code);
            Controls.Add(txt_password);
            Controls.Add(txt_login);
            Controls.Add(lbl_pasw);
            Controls.Add(lbl_login);
            Controls.Add(lbl_pasw1);
            Controls.Add(btn_cencel);
            Controls.Add(lbl_clear);
            Controls.Add(lbl_welcome);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Signup_window";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign up";
            pan_left.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pan_left;
        private Label lbl_employee;
        private Label lbl_server;
        private Label lbl_version;
        private Label lbl_net;
        private Button btn_createAccount;
        private TextBox txt_password;
        private TextBox txt_login;
        private Label lbl_login;
        private Label lbl_pasw1;
        private Label lbl_welcome;
        private Button btn_cencel;
        private Label lbl_clear;
        private Label lbl_pasw;
        private TextBox txt_code;
        private CheckBox chbox_Visible;
    }
}