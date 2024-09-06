namespace Sklep_base
{
    partial class Departmants
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DGV_DepList = new Guna.UI2.WinForms.Guna2DataGridView();
            pan_down = new Panel();
            pan_top = new Panel();
            btn_exit = new Button();
            lbl_system = new Label();
            pan_left = new Panel();
            btn_update = new Button();
            btn_add = new Button();
            lbl_new = new Label();
            txtBox_DepName = new Guna.UI2.WinForms.Guna2TextBox();
            lbl_name = new Label();
            btn_salary = new Button();
            btn_logout = new Button();
            btn_employee = new Button();
            lbl_departmants = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_DepList).BeginInit();
            pan_top.SuspendLayout();
            pan_left.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_DepList
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            DGV_DepList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DGV_DepList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DGV_DepList.ColumnHeadersHeight = 4;
            DGV_DepList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            DGV_DepList.DefaultCellStyle = dataGridViewCellStyle9;
            DGV_DepList.GridColor = Color.FromArgb(231, 229, 255);
            DGV_DepList.Location = new Point(377, 161);
            DGV_DepList.Name = "DGV_DepList";
            DGV_DepList.RowHeadersVisible = false;
            DGV_DepList.RowTemplate.Height = 25;
            DGV_DepList.Size = new Size(819, 327);
            DGV_DepList.TabIndex = 30;
            DGV_DepList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DGV_DepList.ThemeStyle.AlternatingRowsStyle.Font = null;
            DGV_DepList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DGV_DepList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DGV_DepList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DGV_DepList.ThemeStyle.BackColor = Color.White;
            DGV_DepList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DGV_DepList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DGV_DepList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_DepList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DGV_DepList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DGV_DepList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DGV_DepList.ThemeStyle.HeaderStyle.Height = 4;
            DGV_DepList.ThemeStyle.ReadOnly = false;
            DGV_DepList.ThemeStyle.RowsStyle.BackColor = Color.White;
            DGV_DepList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_DepList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DGV_DepList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DGV_DepList.ThemeStyle.RowsStyle.Height = 25;
            DGV_DepList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DGV_DepList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // pan_down
            // 
            pan_down.BackColor = Color.SeaGreen;
            pan_down.Location = new Point(-6, 494);
            pan_down.Name = "pan_down";
            pan_down.Size = new Size(1212, 14);
            pan_down.TabIndex = 29;
            // 
            // pan_top
            // 
            pan_top.BackColor = Color.SeaGreen;
            pan_top.Controls.Add(btn_exit);
            pan_top.Controls.Add(lbl_system);
            pan_top.Location = new Point(-6, -5);
            pan_top.Name = "pan_top";
            pan_top.Size = new Size(1212, 91);
            pan_top.TabIndex = 27;
            // 
            // btn_exit
            // 
            btn_exit.AutoSize = true;
            btn_exit.BackColor = Color.SeaGreen;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.FlatAppearance.BorderColor = Color.White;
            btn_exit.FlatAppearance.BorderSize = 2;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(1166, 9);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(36, 37);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // lbl_system
            // 
            lbl_system.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_system.ForeColor = Color.White;
            lbl_system.Location = new Point(0, 0);
            lbl_system.Name = "lbl_system";
            lbl_system.Size = new Size(1212, 91);
            lbl_system.TabIndex = 0;
            lbl_system.Text = "Emplojee managment system version 1.0";
            lbl_system.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pan_left
            // 
            pan_left.BackColor = Color.Honeydew;
            pan_left.Controls.Add(btn_update);
            pan_left.Controls.Add(btn_add);
            pan_left.Controls.Add(lbl_new);
            pan_left.Controls.Add(txtBox_DepName);
            pan_left.Controls.Add(lbl_name);
            pan_left.Location = new Point(-6, 86);
            pan_left.Name = "pan_left";
            pan_left.Size = new Size(378, 419);
            pan_left.TabIndex = 28;
            // 
            // btn_update
            // 
            btn_update.AutoSize = true;
            btn_update.BackColor = Color.Honeydew;
            btn_update.Cursor = Cursors.Hand;
            btn_update.FlatAppearance.BorderColor = Color.SeaGreen;
            btn_update.FlatAppearance.BorderSize = 2;
            btn_update.FlatStyle = FlatStyle.Popup;
            btn_update.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_update.ForeColor = Color.SeaGreen;
            btn_update.Location = new Point(198, 131);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(83, 37);
            btn_update.TabIndex = 30;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
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
            btn_add.Location = new Point(110, 131);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(83, 37);
            btn_add.TabIndex = 29;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            btn_add.MouseEnter += btn_save_MouseEnter;
            btn_add.MouseLeave += btn_save_MouseLeave;
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
            // txtBox_DepName
            // 
            txtBox_DepName.BackColor = Color.White;
            txtBox_DepName.CustomizableEdges = customizableEdges5;
            txtBox_DepName.DefaultText = "";
            txtBox_DepName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBox_DepName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBox_DepName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBox_DepName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBox_DepName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBox_DepName.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_DepName.ForeColor = Color.SeaGreen;
            txtBox_DepName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBox_DepName.Location = new Point(198, 75);
            txtBox_DepName.Margin = new Padding(4, 5, 4, 5);
            txtBox_DepName.Name = "txtBox_DepName";
            txtBox_DepName.PasswordChar = '\0';
            txtBox_DepName.PlaceholderText = "";
            txtBox_DepName.SelectedText = "";
            txtBox_DepName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtBox_DepName.Size = new Size(171, 36);
            txtBox_DepName.TabIndex = 25;
            // 
            // lbl_name
            // 
            lbl_name.BackColor = Color.Honeydew;
            lbl_name.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_name.ForeColor = Color.SeaGreen;
            lbl_name.Location = new Point(51, 82);
            lbl_name.Name = "lbl_name";
            lbl_name.Padding = new Padding(0, 7, 0, 0);
            lbl_name.Size = new Size(141, 29);
            lbl_name.TabIndex = 10;
            lbl_name.Text = "Department name:";
            lbl_name.TextAlign = ContentAlignment.MiddleRight;
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
            btn_salary.Location = new Point(805, 86);
            btn_salary.Name = "btn_salary";
            btn_salary.Size = new Size(127, 53);
            btn_salary.TabIndex = 61;
            btn_salary.Text = "Salary";
            btn_salary.TextAlign = ContentAlignment.BottomCenter;
            btn_salary.UseVisualStyleBackColor = false;
            btn_salary.Click += btn_salary_Click;
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
            btn_logout.Location = new Point(938, 86);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(127, 53);
            btn_logout.TabIndex = 60;
            btn_logout.Text = "Logout";
            btn_logout.TextAlign = ContentAlignment.BottomCenter;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_employee
            // 
            btn_employee.BackColor = Color.Honeydew;
            btn_employee.Cursor = Cursors.Hand;
            btn_employee.FlatAppearance.BorderColor = Color.SeaGreen;
            btn_employee.FlatAppearance.BorderSize = 0;
            btn_employee.FlatStyle = FlatStyle.Flat;
            btn_employee.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_employee.ForeColor = Color.SeaGreen;
            btn_employee.Location = new Point(539, 86);
            btn_employee.Name = "btn_employee";
            btn_employee.Size = new Size(127, 53);
            btn_employee.TabIndex = 58;
            btn_employee.Text = "Employee";
            btn_employee.TextAlign = ContentAlignment.BottomCenter;
            btn_employee.UseVisualStyleBackColor = false;
            btn_employee.Click += btn_employee_Click;
            // 
            // lbl_departmants
            // 
            lbl_departmants.BackColor = Color.SeaGreen;
            lbl_departmants.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_departmants.ForeColor = Color.White;
            lbl_departmants.Location = new Point(672, 86);
            lbl_departmants.Name = "lbl_departmants";
            lbl_departmants.Padding = new Padding(0, 0, 0, 4);
            lbl_departmants.Size = new Size(127, 53);
            lbl_departmants.TabIndex = 59;
            lbl_departmants.Text = "Departmants";
            lbl_departmants.TextAlign = ContentAlignment.BottomCenter;
            // 
            // Departmants
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 502);
            Controls.Add(btn_salary);
            Controls.Add(btn_logout);
            Controls.Add(btn_employee);
            Controls.Add(lbl_departmants);
            Controls.Add(DGV_DepList);
            Controls.Add(pan_down);
            Controls.Add(pan_top);
            Controls.Add(pan_left);
            Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "Departmants";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departmants";
            ((System.ComponentModel.ISupportInitialize)DGV_DepList).EndInit();
            pan_top.ResumeLayout(false);
            pan_top.PerformLayout();
            pan_left.ResumeLayout(false);
            pan_left.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DGV_DepList;
        private Panel pan_down;
        private Panel pan_top;
        private Label lbl_system;
        private Button btn_exit;
        private Panel pan_left;
        private Label lbl_new;
        private Button btn_update;
        private Button btn_add;
        private Guna.UI2.WinForms.Guna2TextBox txtBox_DepName;
        private Label lbl_name;
        private Button btn_salary;
        private Button btn_logout;
        private Button btn_employee;
        private Label lbl_departmants;
    }
}