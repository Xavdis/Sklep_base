﻿namespace Sklep_base
{
    partial class Employee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btn_update = new Button();
            btn_add = new Button();
            timpic_joinDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lbl_new = new Label();
            lbl_department = new Label();
            timpic_dateOfBith = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lbl_bith = new Label();
            combox_employeeGender = new Guna.UI2.WinForms.Guna2ComboBox();
            txbox_salary = new Guna.UI2.WinForms.Guna2TextBox();
            lbl_joinDate = new Label();
            txtbox_name = new Guna.UI2.WinForms.Guna2TextBox();
            txtbox_surname = new Guna.UI2.WinForms.Guna2TextBox();
            combox_employeeDepartment = new Guna.UI2.WinForms.Guna2ComboBox();
            lbl_salary = new Label();
            lbl_gender = new Label();
            lbl_name = new Label();
            lbl_surname = new Label();
            lbl_system = new Label();
            btn_exit = new Button();
            pan_down = new Panel();
            pan_top = new Panel();
            pan_left = new Panel();
            lbl_employee = new Label();
            btn_departmants = new Button();
            btn_logout = new Button();
            btn_salary = new Button();
            DGV_EmplList = new Guna.UI2.WinForms.Guna2DataGridView();
            btn_delete = new Button();
            pan_top.SuspendLayout();
            pan_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_EmplList).BeginInit();
            SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.AutoSize = true;
            btn_update.BackColor = Color.Honeydew;
            btn_update.Cursor = Cursors.Hand;
            btn_update.FlatAppearance.BorderColor = Color.SeaGreen;
            btn_update.FlatAppearance.BorderSize = 2;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_update.ForeColor = Color.SeaGreen;
            btn_update.Location = new Point(155, 368);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(83, 37);
            btn_update.TabIndex = 30;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            btn_update.MouseEnter += btn_update_MouseEnter;
            btn_update.MouseLeave += btn_update_MouseLeave;
            // 
            // btn_add
            // 
            btn_add.AutoSize = true;
            btn_add.BackColor = Color.SeaGreen;
            btn_add.Cursor = Cursors.Hand;
            btn_add.FlatAppearance.BorderColor = Color.SeaGreen;
            btn_add.FlatAppearance.BorderSize = 2;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(66, 368);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(83, 37);
            btn_add.TabIndex = 29;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            btn_add.MouseEnter += btn_save_MouseEnter;
            btn_add.MouseLeave += btn_save_MouseLeave;
            // 
            // timpic_joinDate
            // 
            timpic_joinDate.BorderColor = Color.White;
            timpic_joinDate.Checked = true;
            timpic_joinDate.Cursor = Cursors.Hand;
            timpic_joinDate.CustomizableEdges = customizableEdges1;
            timpic_joinDate.FillColor = Color.SeaGreen;
            timpic_joinDate.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timpic_joinDate.ForeColor = Color.White;
            timpic_joinDate.Format = DateTimePickerFormat.Short;
            timpic_joinDate.Location = new Point(198, 285);
            timpic_joinDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            timpic_joinDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            timpic_joinDate.Name = "timpic_joinDate";
            timpic_joinDate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            timpic_joinDate.Size = new Size(171, 36);
            timpic_joinDate.TabIndex = 26;
            timpic_joinDate.TextAlign = HorizontalAlignment.Right;
            timpic_joinDate.Value = new DateTime(2024, 9, 2, 0, 0, 0, 0);
            // 
            // lbl_new
            // 
            lbl_new.AutoSize = true;
            lbl_new.BackColor = Color.Honeydew;
            lbl_new.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_new.ForeColor = Color.SeaGreen;
            lbl_new.Location = new Point(71, 25);
            lbl_new.Name = "lbl_new";
            lbl_new.Size = new Size(248, 28);
            lbl_new.TabIndex = 14;
            lbl_new.Text = "Add new employee or update";
            // 
            // lbl_department
            // 
            lbl_department.BackColor = Color.Honeydew;
            lbl_department.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_department.ForeColor = Color.SeaGreen;
            lbl_department.Location = new Point(8, 208);
            lbl_department.Name = "lbl_department";
            lbl_department.Padding = new Padding(0, 7, 0, 0);
            lbl_department.Size = new Size(184, 29);
            lbl_department.TabIndex = 16;
            lbl_department.Text = "Employee Department:";
            lbl_department.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timpic_dateOfBith
            // 
            timpic_dateOfBith.BorderColor = Color.White;
            timpic_dateOfBith.Checked = true;
            timpic_dateOfBith.Cursor = Cursors.Hand;
            timpic_dateOfBith.CustomizableEdges = customizableEdges3;
            timpic_dateOfBith.FillColor = Color.SeaGreen;
            timpic_dateOfBith.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timpic_dateOfBith.ForeColor = Color.White;
            timpic_dateOfBith.Format = DateTimePickerFormat.Short;
            timpic_dateOfBith.Location = new Point(198, 243);
            timpic_dateOfBith.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            timpic_dateOfBith.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            timpic_dateOfBith.Name = "timpic_dateOfBith";
            timpic_dateOfBith.ShadowDecoration.CustomizableEdges = customizableEdges4;
            timpic_dateOfBith.Size = new Size(171, 36);
            timpic_dateOfBith.TabIndex = 26;
            timpic_dateOfBith.TextAlign = HorizontalAlignment.Right;
            timpic_dateOfBith.Value = new DateTime(2024, 9, 2, 0, 0, 0, 0);
            // 
            // lbl_bith
            // 
            lbl_bith.BackColor = Color.Honeydew;
            lbl_bith.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_bith.ForeColor = Color.SeaGreen;
            lbl_bith.Location = new Point(60, 250);
            lbl_bith.Name = "lbl_bith";
            lbl_bith.Padding = new Padding(0, 7, 0, 0);
            lbl_bith.Size = new Size(132, 29);
            lbl_bith.TabIndex = 19;
            lbl_bith.Text = "Date Of Bith:";
            lbl_bith.TextAlign = ContentAlignment.MiddleRight;
            // 
            // combox_employeeGender
            // 
            combox_employeeGender.BackColor = Color.White;
            combox_employeeGender.Cursor = Cursors.Hand;
            combox_employeeGender.CustomizableEdges = customizableEdges5;
            combox_employeeGender.DrawMode = DrawMode.OwnerDrawFixed;
            combox_employeeGender.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_employeeGender.FocusedColor = Color.FromArgb(94, 148, 255);
            combox_employeeGender.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            combox_employeeGender.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            combox_employeeGender.ForeColor = Color.SeaGreen;
            combox_employeeGender.ItemHeight = 30;
            combox_employeeGender.Items.AddRange(new object[] { "Male", "Female" });
            combox_employeeGender.Location = new Point(198, 159);
            combox_employeeGender.Name = "combox_employeeGender";
            combox_employeeGender.ShadowDecoration.CustomizableEdges = customizableEdges6;
            combox_employeeGender.Size = new Size(171, 36);
            combox_employeeGender.TabIndex = 26;
            // 
            // txbox_salary
            // 
            txbox_salary.BackColor = Color.White;
            txbox_salary.Cursor = Cursors.IBeam;
            txbox_salary.CustomizableEdges = customizableEdges7;
            txbox_salary.DefaultText = "";
            txbox_salary.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbox_salary.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbox_salary.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbox_salary.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbox_salary.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbox_salary.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbox_salary.ForeColor = Color.SeaGreen;
            txbox_salary.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbox_salary.Location = new Point(198, 325);
            txbox_salary.Margin = new Padding(4, 5, 4, 5);
            txbox_salary.Name = "txbox_salary";
            txbox_salary.PasswordChar = '\0';
            txbox_salary.PlaceholderText = "";
            txbox_salary.SelectedText = "";
            txbox_salary.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txbox_salary.Size = new Size(171, 36);
            txbox_salary.TabIndex = 28;
            // 
            // lbl_joinDate
            // 
            lbl_joinDate.BackColor = Color.Honeydew;
            lbl_joinDate.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_joinDate.ForeColor = Color.SeaGreen;
            lbl_joinDate.Location = new Point(60, 292);
            lbl_joinDate.Name = "lbl_joinDate";
            lbl_joinDate.Padding = new Padding(0, 7, 0, 0);
            lbl_joinDate.Size = new Size(132, 29);
            lbl_joinDate.TabIndex = 20;
            lbl_joinDate.Text = "Join Date:";
            lbl_joinDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbox_name
            // 
            txtbox_name.BackColor = Color.White;
            txtbox_name.Cursor = Cursors.IBeam;
            txtbox_name.CustomizableEdges = customizableEdges9;
            txtbox_name.DefaultText = "";
            txtbox_name.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbox_name.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbox_name.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbox_name.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbox_name.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbox_name.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_name.ForeColor = Color.SeaGreen;
            txtbox_name.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbox_name.Location = new Point(198, 75);
            txtbox_name.Margin = new Padding(4, 5, 4, 5);
            txtbox_name.Name = "txtbox_name";
            txtbox_name.PasswordChar = '\0';
            txtbox_name.PlaceholderText = "";
            txtbox_name.SelectedText = "";
            txtbox_name.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtbox_name.Size = new Size(171, 36);
            txtbox_name.TabIndex = 25;
            // 
            // txtbox_surname
            // 
            txtbox_surname.BackColor = Color.White;
            txtbox_surname.Cursor = Cursors.IBeam;
            txtbox_surname.CustomizableEdges = customizableEdges11;
            txtbox_surname.DefaultText = "";
            txtbox_surname.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbox_surname.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbox_surname.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbox_surname.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbox_surname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbox_surname.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_surname.ForeColor = Color.SeaGreen;
            txtbox_surname.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbox_surname.Location = new Point(198, 117);
            txtbox_surname.Margin = new Padding(4, 5, 4, 5);
            txtbox_surname.Name = "txtbox_surname";
            txtbox_surname.PasswordChar = '\0';
            txtbox_surname.PlaceholderText = "";
            txtbox_surname.SelectedText = "";
            txtbox_surname.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtbox_surname.Size = new Size(171, 36);
            txtbox_surname.TabIndex = 27;
            // 
            // combox_employeeDepartment
            // 
            combox_employeeDepartment.BackColor = Color.White;
            combox_employeeDepartment.Cursor = Cursors.Hand;
            combox_employeeDepartment.CustomizableEdges = customizableEdges13;
            combox_employeeDepartment.DrawMode = DrawMode.OwnerDrawFixed;
            combox_employeeDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_employeeDepartment.FocusedColor = Color.FromArgb(94, 148, 255);
            combox_employeeDepartment.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            combox_employeeDepartment.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            combox_employeeDepartment.ForeColor = Color.SeaGreen;
            combox_employeeDepartment.ItemHeight = 30;
            combox_employeeDepartment.Location = new Point(198, 201);
            combox_employeeDepartment.Name = "combox_employeeDepartment";
            combox_employeeDepartment.ShadowDecoration.CustomizableEdges = customizableEdges14;
            combox_employeeDepartment.Size = new Size(171, 36);
            combox_employeeDepartment.TabIndex = 25;
            // 
            // lbl_salary
            // 
            lbl_salary.BackColor = Color.Honeydew;
            lbl_salary.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_salary.ForeColor = Color.SeaGreen;
            lbl_salary.Location = new Point(18, 332);
            lbl_salary.Name = "lbl_salary";
            lbl_salary.Padding = new Padding(0, 7, 0, 0);
            lbl_salary.Size = new Size(174, 29);
            lbl_salary.TabIndex = 20;
            lbl_salary.Text = "Employee daily salary:";
            lbl_salary.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_gender
            // 
            lbl_gender.BackColor = Color.Honeydew;
            lbl_gender.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_gender.ForeColor = Color.SeaGreen;
            lbl_gender.Location = new Point(51, 166);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Padding = new Padding(0, 7, 0, 0);
            lbl_gender.Size = new Size(141, 29);
            lbl_gender.TabIndex = 15;
            lbl_gender.Text = "Employee Gender:";
            lbl_gender.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_name
            // 
            lbl_name.BackColor = Color.Honeydew;
            lbl_name.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_name.ForeColor = Color.SeaGreen;
            lbl_name.Location = new Point(59, 82);
            lbl_name.Name = "lbl_name";
            lbl_name.Padding = new Padding(0, 7, 0, 0);
            lbl_name.Size = new Size(132, 29);
            lbl_name.TabIndex = 10;
            lbl_name.Text = "Name:";
            lbl_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_surname
            // 
            lbl_surname.BackColor = Color.Honeydew;
            lbl_surname.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_surname.ForeColor = Color.SeaGreen;
            lbl_surname.Location = new Point(59, 124);
            lbl_surname.Name = "lbl_surname";
            lbl_surname.Padding = new Padding(0, 7, 0, 0);
            lbl_surname.Size = new Size(132, 29);
            lbl_surname.TabIndex = 11;
            lbl_surname.Text = "Surname:";
            lbl_surname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_system
            // 
            lbl_system.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_system.ForeColor = Color.White;
            lbl_system.Location = new Point(4, 0);
            lbl_system.Name = "lbl_system";
            lbl_system.Size = new Size(1353, 91);
            lbl_system.TabIndex = 0;
            lbl_system.Text = "Emplojee managment system version 1.0";
            lbl_system.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_exit
            // 
            btn_exit.AutoSize = true;
            btn_exit.BackColor = Color.SeaGreen;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.FlatAppearance.BorderColor = Color.Honeydew;
            btn_exit.FlatAppearance.BorderSize = 2;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_exit.ForeColor = Color.Honeydew;
            btn_exit.Location = new Point(1315, 10);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(36, 37);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            btn_exit.MouseEnter += btn_exit_MouseEnter;
            btn_exit.MouseLeave += btn_exit_MouseLeave;
            // 
            // pan_down
            // 
            pan_down.BackColor = Color.SeaGreen;
            pan_down.Location = new Point(-6, 496);
            pan_down.Name = "pan_down";
            pan_down.Size = new Size(1357, 12);
            pan_down.TabIndex = 34;
            // 
            // pan_top
            // 
            pan_top.BackColor = Color.SeaGreen;
            pan_top.Controls.Add(btn_exit);
            pan_top.Controls.Add(lbl_system);
            pan_top.Location = new Point(-6, -5);
            pan_top.Name = "pan_top";
            pan_top.Size = new Size(1357, 91);
            pan_top.TabIndex = 32;
            // 
            // pan_left
            // 
            pan_left.BackColor = Color.Honeydew;
            pan_left.Controls.Add(btn_update);
            pan_left.Controls.Add(timpic_joinDate);
            pan_left.Controls.Add(btn_add);
            pan_left.Controls.Add(lbl_new);
            pan_left.Controls.Add(btn_delete);
            pan_left.Controls.Add(lbl_department);
            pan_left.Controls.Add(timpic_dateOfBith);
            pan_left.Controls.Add(lbl_bith);
            pan_left.Controls.Add(combox_employeeGender);
            pan_left.Controls.Add(txbox_salary);
            pan_left.Controls.Add(lbl_joinDate);
            pan_left.Controls.Add(txtbox_name);
            pan_left.Controls.Add(txtbox_surname);
            pan_left.Controls.Add(combox_employeeDepartment);
            pan_left.Controls.Add(lbl_salary);
            pan_left.Controls.Add(lbl_gender);
            pan_left.Controls.Add(lbl_name);
            pan_left.Controls.Add(lbl_surname);
            pan_left.Location = new Point(-6, 86);
            pan_left.Name = "pan_left";
            pan_left.Size = new Size(378, 419);
            pan_left.TabIndex = 33;
            // 
            // lbl_employee
            // 
            lbl_employee.BackColor = Color.SeaGreen;
            lbl_employee.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_employee.ForeColor = Color.White;
            lbl_employee.Location = new Point(611, 86);
            lbl_employee.Name = "lbl_employee";
            lbl_employee.Padding = new Padding(0, 0, 0, 4);
            lbl_employee.Size = new Size(127, 53);
            lbl_employee.TabIndex = 53;
            lbl_employee.Text = "Employee";
            lbl_employee.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btn_departmants
            // 
            btn_departmants.BackColor = Color.Honeydew;
            btn_departmants.Cursor = Cursors.Hand;
            btn_departmants.FlatAppearance.BorderColor = Color.SeaGreen;
            btn_departmants.FlatAppearance.BorderSize = 0;
            btn_departmants.FlatStyle = FlatStyle.Flat;
            btn_departmants.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_departmants.ForeColor = Color.SeaGreen;
            btn_departmants.Location = new Point(744, 86);
            btn_departmants.Name = "btn_departmants";
            btn_departmants.Size = new Size(127, 53);
            btn_departmants.TabIndex = 31;
            btn_departmants.Text = "Departmants";
            btn_departmants.TextAlign = ContentAlignment.BottomCenter;
            btn_departmants.UseVisualStyleBackColor = false;
            btn_departmants.Click += btn_departmants_Click;
            btn_departmants.MouseEnter += btn_departmants_MouseEnter;
            btn_departmants.MouseLeave += btn_departmants_MouseLeave;
            // 
            // btn_logout
            // 
            btn_logout.AutoSize = true;
            btn_logout.BackColor = Color.Honeydew;
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.FlatAppearance.BorderColor = Color.SeaGreen;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_logout.ForeColor = Color.SeaGreen;
            btn_logout.Location = new Point(1010, 86);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(127, 53);
            btn_logout.TabIndex = 56;
            btn_logout.Text = "Logout";
            btn_logout.TextAlign = ContentAlignment.BottomCenter;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            btn_logout.MouseEnter += btn_logout_MouseEnter;
            btn_logout.MouseLeave += btn_logout_MouseLeave;
            // 
            // btn_salary
            // 
            btn_salary.AutoSize = true;
            btn_salary.BackColor = Color.Honeydew;
            btn_salary.Cursor = Cursors.Hand;
            btn_salary.FlatAppearance.BorderColor = Color.SeaGreen;
            btn_salary.FlatAppearance.BorderSize = 0;
            btn_salary.FlatStyle = FlatStyle.Flat;
            btn_salary.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salary.ForeColor = Color.SeaGreen;
            btn_salary.Location = new Point(877, 86);
            btn_salary.Name = "btn_salary";
            btn_salary.Size = new Size(127, 53);
            btn_salary.TabIndex = 57;
            btn_salary.Text = "Salary";
            btn_salary.TextAlign = ContentAlignment.BottomCenter;
            btn_salary.UseVisualStyleBackColor = false;
            btn_salary.Click += btn_salary_Click;
            btn_salary.MouseEnter += btn_salary_MouseEnter;
            btn_salary.MouseLeave += btn_salary_MouseLeave;
            // 
            // DGV_EmplList
            // 
            dataGridViewCellStyle1.BackColor = Color.Honeydew;
            dataGridViewCellStyle1.NullValue = null;
            DGV_EmplList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGV_EmplList.Anchor = AnchorStyles.None;
            DGV_EmplList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_EmplList.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SeaGreen;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGV_EmplList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV_EmplList.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGV_EmplList.DefaultCellStyle = dataGridViewCellStyle3;
            DGV_EmplList.GridColor = Color.SeaGreen;
            DGV_EmplList.ImeMode = ImeMode.NoControl;
            DGV_EmplList.Location = new Point(377, 163);
            DGV_EmplList.MultiSelect = false;
            DGV_EmplList.Name = "DGV_EmplList";
            DGV_EmplList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SeaGreen;
            dataGridViewCellStyle4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Honeydew;
            dataGridViewCellStyle4.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DGV_EmplList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGV_EmplList.RowHeadersVisible = false;
            DGV_EmplList.RowTemplate.Height = 25;
            DGV_EmplList.Size = new Size(969, 329);
            DGV_EmplList.TabIndex = 58;
            DGV_EmplList.TabStop = false;
            DGV_EmplList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.Honeydew;
            DGV_EmplList.ThemeStyle.AlternatingRowsStyle.Font = null;
            DGV_EmplList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DGV_EmplList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.SeaGreen;
            DGV_EmplList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DGV_EmplList.ThemeStyle.BackColor = Color.White;
            DGV_EmplList.ThemeStyle.GridColor = Color.SeaGreen;
            DGV_EmplList.ThemeStyle.HeaderStyle.BackColor = Color.Sienna;
            DGV_EmplList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_EmplList.ThemeStyle.HeaderStyle.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DGV_EmplList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DGV_EmplList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV_EmplList.ThemeStyle.HeaderStyle.Height = 25;
            DGV_EmplList.ThemeStyle.ReadOnly = true;
            DGV_EmplList.ThemeStyle.RowsStyle.BackColor = Color.Honeydew;
            DGV_EmplList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            DGV_EmplList.ThemeStyle.RowsStyle.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DGV_EmplList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DGV_EmplList.ThemeStyle.RowsStyle.Height = 25;
            DGV_EmplList.ThemeStyle.RowsStyle.SelectionBackColor = Color.Honeydew;
            DGV_EmplList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DGV_EmplList.CellContentClick += DGV_EmplList_CellContentClick;
            // 
            // btn_delete
            // 
            btn_delete.AutoSize = true;
            btn_delete.BackColor = Color.Honeydew;
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.FlatAppearance.BorderColor = Color.SeaGreen;
            btn_delete.FlatAppearance.BorderSize = 2;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.SeaGreen;
            btn_delete.Location = new Point(244, 368);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(83, 37);
            btn_delete.TabIndex = 31;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 502);
            Controls.Add(DGV_EmplList);
            Controls.Add(btn_salary);
            Controls.Add(btn_logout);
            Controls.Add(btn_departmants);
            Controls.Add(lbl_employee);
            Controls.Add(pan_down);
            Controls.Add(pan_top);
            Controls.Add(pan_left);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            pan_top.ResumeLayout(false);
            pan_top.PerformLayout();
            pan_left.ResumeLayout(false);
            pan_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_EmplList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_update;
        private Button btn_add;
        private Guna.UI2.WinForms.Guna2DateTimePicker timpic_joinDate;
        private Label lbl_new;
        private Label lbl_department;
        private Guna.UI2.WinForms.Guna2DateTimePicker timpic_dateOfBith;
        private Label lbl_bith;
        private Guna.UI2.WinForms.Guna2ComboBox combox_employeeGender;
        private Guna.UI2.WinForms.Guna2TextBox txbox_salary;
        private Label lbl_joinDate;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_name;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_surname;
        private Guna.UI2.WinForms.Guna2ComboBox combox_employeeDepartment;
        private Label lbl_salary;
        private Label lbl_gender;
        private Label lbl_name;
        private Label lbl_surname;
        private Label lbl_system;
        private Button btn_exit;
        private Panel pan_down;
        private Panel pan_top;
        private Panel pan_left;
        private Label lbl_employee;
        private Button btn_departmants;
        private Button btn_logout;
        private Button btn_salary;
        public Guna.UI2.WinForms.Guna2DataGridView DGV_EmplList;
        private Button btn_delete;
    }
}
