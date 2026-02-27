namespace Sklep_base
{
    partial class Confirmation
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
            btn_yes = new Button();
            btn_no = new Button();
            pan_left = new Panel();
            lbl_employee = new Label();
            lbl_sql = new Label();
            lbl_version = new Label();
            lbl_c = new Label();
            lbl_confirm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pan_left.SuspendLayout();
            SuspendLayout();
            // 
            // btn_yes
            // 
            btn_yes.AutoSize = true;
            btn_yes.Cursor = Cursors.Hand;
            btn_yes.FlatAppearance.BorderColor = Color.SeaGreen;
            btn_yes.FlatAppearance.BorderSize = 2;
            btn_yes.FlatStyle = FlatStyle.Flat;
            btn_yes.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_yes.ForeColor = Color.SeaGreen;
            btn_yes.Location = new Point(238, 101);
            btn_yes.Name = "btn_yes";
            btn_yes.Size = new Size(100, 37);
            btn_yes.TabIndex = 2;
            btn_yes.Text = "Go login";
            btn_yes.UseVisualStyleBackColor = false;
            btn_yes.Click += btn_yes_Click;
            // 
            // btn_no
            // 
            btn_no.AutoSize = true;
            btn_no.Cursor = Cursors.Hand;
            btn_no.FlatAppearance.BorderColor = Color.SeaGreen;
            btn_no.FlatAppearance.BorderSize = 2;
            btn_no.FlatStyle = FlatStyle.Flat;
            btn_no.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_no.ForeColor = Color.SeaGreen;
            btn_no.Location = new Point(344, 101);
            btn_no.Name = "btn_no";
            btn_no.Size = new Size(100, 37);
            btn_no.TabIndex = 1;
            btn_no.Text = "Exit";
            btn_no.UseVisualStyleBackColor = false;
            btn_no.Click += btn_no_Click;
            // 
            // pan_left
            // 
            pan_left.BackColor = Color.SeaGreen;
            pan_left.Controls.Add(lbl_employee);
            pan_left.Controls.Add(lbl_sql);
            pan_left.Controls.Add(lbl_version);
            pan_left.Controls.Add(lbl_c);
            pan_left.Location = new Point(0, 0);
            pan_left.Name = "pan_left";
            pan_left.Size = new Size(188, 179);
            pan_left.TabIndex = 8;
            // 
            // lbl_employee
            // 
            lbl_employee.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_employee.ForeColor = Color.White;
            lbl_employee.Location = new Point(0, 36);
            lbl_employee.Name = "lbl_employee";
            lbl_employee.Size = new Size(188, 23);
            lbl_employee.TabIndex = 2;
            lbl_employee.Text = "Employee MS";
            lbl_employee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_sql
            // 
            lbl_sql.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_sql.ForeColor = Color.White;
            lbl_sql.Location = new Point(0, 72);
            lbl_sql.Name = "lbl_sql";
            lbl_sql.Size = new Size(188, 23);
            lbl_sql.TabIndex = 1;
            lbl_sql.Text = "SQL Server";
            lbl_sql.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_version
            // 
            lbl_version.Font = new Font("Comic Sans MS", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_version.ForeColor = Color.White;
            lbl_version.Location = new Point(0, 140);
            lbl_version.Name = "lbl_version";
            lbl_version.Padding = new Padding(0, 8, 0, 0);
            lbl_version.Size = new Size(188, 23);
            lbl_version.TabIndex = 0;
            lbl_version.Text = new Version().GetVersion;
            lbl_version.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_c
            // 
            lbl_c.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_c.ForeColor = Color.White;
            lbl_c.Location = new Point(0, 107);
            lbl_c.Name = "lbl_c";
            lbl_c.Size = new Size(188, 23);
            lbl_c.TabIndex = 0;
            lbl_c.Text = "C#.NET";
            lbl_c.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_confirm
            // 
            lbl_confirm.AutoSize = false;
            lbl_confirm.BackColor = Color.Transparent;
            lbl_confirm.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_confirm.ForeColor = Color.SeaGreen;
            lbl_confirm.Location = new Point(223, 30);
            lbl_confirm.Name = "lbl_confirm";
            lbl_confirm.Size = new Size(245, 59);
            lbl_confirm.TabIndex = 9;
            lbl_confirm.TabStop = false;
            lbl_confirm.Text = "Do you want to go to login page or leave?";
            lbl_confirm.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Location = new Point(-3, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 10);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Location = new Point(-5, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 10);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Location = new Point(499, -5);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 194);
            panel3.TabIndex = 11;
            // 
            // confirmation_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 173);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbl_confirm);
            Controls.Add(pan_left);
            Controls.Add(btn_yes);
            Controls.Add(btn_no);
            FormBorderStyle = FormBorderStyle.None;
            Name = "confirmation_menu";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            pan_left.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_yes;
        private Button btn_no;
        private Panel pan_left;
        private Label lbl_employee;
        private Label lbl_sql;
        private Label lbl_version;
        private Label lbl_c;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_confirm;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}