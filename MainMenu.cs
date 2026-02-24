using System.Globalization;

namespace Sklep_base
{
    public partial class MainMenu : Form
    {
        Loading load = new Loading();
        SQLFunctions conn;
        int? Employee_Key = null;
        public MainMenu()
        {
            try
            {
                load.Show();
                InitializeComponent();
                load.progressBar.Value = 15;
                conn = new SQLFunctions();
                ShowEmployee();
                load.progressBar.Value = 30;
                ShowDepartmants();
                load.progressBar.Value = 45;
                ShowSalary();
                load.progressBar.Value = 60;
                GetEmployeeBase();
                load.progressBar.Value = 75;
                GetDepartmentBase();
                load.progressBar.Value = 90;
                Employee_ClearLebles();
                load.progressBar.Value = 100;
                load.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            confirmation_menu conf = new confirmation_menu();
            conf.ShowDialog();
            if (confirmation_menu.Confirm == true)
            {
                new login_window().Show();
                this.Close();
            }
        }

        #region Panel with btn pages
        // Hide and Open systme for EMPLOYEE page
        private void hide_emoloyee_page()
        {
            lbl_employee.Visible = false;

            employee_pan_left.Visible = false;
            employee_DGV_EmplList.Visible = false;
            employee_btn_update.Visible = false;
            employee_btn_add.Visible = false;
            employee_btn_delete.Visible = false;
            employee_btn_clear.Visible = false;
            employee_timpic_joinDate.Visible = false;
            employee_timpic_dateOfBith.Visible = false;
            employee_combox_employeeGender.Visible = false;
            employee_combox_employeeDepartment.Visible = false;
            employee_txtbox_name.Visible = false;
            employee_txtbox_surname.Visible = false;
            employee_lbl_gender.Visible = false;
            employee_lbl_name.Visible = false;
            employee_lbl_surname.Visible = false;
            employee_lbl_department.Visible = false;
            employee_lbl_title.Visible = false;
            employee_lbl_bith.Visible = false;
            employee_lbl_joinDate.Visible = false;
            lbl_employee.Visible = false;
        }
        private void open_emoloyee_page()
        {
            lbl_employee.Visible = true;

            employee_pan_left.Visible = true;
            employee_DGV_EmplList.Visible = true;
            employee_btn_update.Visible = true;
            employee_btn_add.Visible = true;
            employee_btn_delete.Visible = true;
            employee_btn_clear.Visible = true;
            employee_timpic_joinDate.Visible = true;
            employee_timpic_dateOfBith.Visible = true;
            employee_combox_employeeGender.Visible = true;
            employee_combox_employeeDepartment.Visible = true;
            employee_txtbox_name.Visible = true;
            employee_txtbox_surname.Visible = true;
            employee_lbl_gender.Visible = true;
            employee_lbl_name.Visible = true;
            employee_lbl_surname.Visible = true;
            employee_lbl_department.Visible = true;
            employee_lbl_title.Visible = true;
            employee_lbl_bith.Visible = true;
            employee_lbl_joinDate.Visible = true;
        }
        // Hide and Open systme for DEPARTMENT page
        private void hide_departaments_page()
        {
            lbl_departmants.Visible = false;

            department_pan_left.Visible = false;
            department_btn_delete.Visible = false;
            department_btn_update.Visible = false;
            department_btn_add.Visible = false;
            department_lbl_new.Visible = false;
            department_txtBox_DepName.Visible = false;
            department_lbl_name.Visible = false;
            department_DGV_DepList.Visible = false;


        }
        private void open_departaments_page()
        {
            lbl_departmants.Visible = true;

            department_pan_left.Visible = true;
            department_btn_delete.Visible = true;
            department_btn_update.Visible = true;
            department_btn_add.Visible = true;
            department_lbl_new.Visible = true;
            department_txtBox_DepName.Visible = true;
            department_lbl_name.Visible = true;
            department_DGV_DepList.Visible = true;

        }
        // Hide and Open system for SALARY page
        private void hide_salary_page()
        {
            lbl_salary.Visible = false;

            salary_pan_left.Visible = false;
            salary_txtbox_salaryPerHour.Visible = false;
            salary_lbl_seleryPerHour.Visible = false;
            salary_txtbox_salaryAmount.Visible = false;
            salary_btn_update.Visible = false;
            salary_btn_add.Visible = false;
            salary_txtbox_daysAttended.Visible = false;
            salary_combox_Employee.Visible = false;
            salary_lbl_new.Visible = false;
            salary_lbl_PeyDate.Visible = false;
            salary_timpic_period.Visible = false;
            salary_lbl_joinDate.Visible = false;
            salary_lbl_gender.Visible = false;
            salary_lbl_name.Visible = false;
            salary_DGV_SalaryList.Visible = false;
        }
        private void open_salary_page()
        {
            lbl_salary.Visible = true;

            salary_pan_left.Visible = true;
            salary_txtbox_salaryPerHour.Visible = true;
            salary_lbl_seleryPerHour.Visible = true;
            salary_txtbox_salaryAmount.Visible = true;
            salary_btn_update.Visible = true;
            salary_btn_add.Visible = true;
            salary_txtbox_daysAttended.Visible = true;
            salary_combox_Employee.Visible = true;
            salary_lbl_new.Visible = true;
            salary_lbl_PeyDate.Visible = true;
            salary_timpic_period.Visible = true;
            salary_lbl_joinDate.Visible = true;
            salary_lbl_gender.Visible = true;
            salary_lbl_name.Visible = true;
            salary_DGV_SalaryList.Visible = true;

        }
        //
        private void btn_employee_Click(object sender, EventArgs e)
        {
            open_emoloyee_page();
            hide_departaments_page();
            hide_salary_page();
        }
        private void btn_salary_Click(object sender, EventArgs e)
        {
            open_salary_page();
            hide_departaments_page();
            hide_emoloyee_page();
        }
        private void btn_departmants_Click(object sender, EventArgs e)
        {
            open_departaments_page();
            hide_salary_page();
            hide_emoloyee_page();
        }
        #endregion

        private Point lastPoint;
        private void ClickOnWindow(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                lastPoint = new Point(e.X, e.Y);
            }
        }
        private void MoveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        #region Change color of button 
        private void btn_green_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.SeaGreen;
                btn.ForeColor = Color.Honeydew;
            }
        }
        private void btn_green_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.MediumSeaGreen;
                btn.ForeColor = Color.SeaGreen;
            }
        }
        private void btn_lightGreen_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.Honeydew;
                btn.ForeColor = Color.SeaGreen;
            }
        }
        private void btn_lightGreen_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.MediumSeaGreen;
                btn.ForeColor = Color.Honeydew;
            }
        }
        #endregion

        #region Employee page

        #region SQL DataBase Command For Employee Page

        private void ShowEmployee()
        {
            string Query = "select " +
                "EmployeeTbl.ID as Code, EmployeeTbl.EmpName as Name, EmployeeTbl.EmpSurname as Surname, EmployeeTbl.EmpGender as Gender, DepartmantTbl.DepName as Department, " +
                "EmployeeTbl.EmpBornDate as Birthday, EmployeeTbl.EmpJoingDate as 'Joing Date' " +
                "FROM EmployeeTbl INNER JOIN DepartmantTbl on EmployeeTbl.DepID = DepartmantTbl.ID;";
            employee_DGV_EmplList.DataSource = conn.GetData(Query);
        }

        private void GetDepartmentBase()
        {
            string Query = "SELECT * FROM DepartmantTbl";
            employee_combox_employeeDepartment.DisplayMember = conn.GetData(Query).Columns["DepName"].ToString();
            employee_combox_employeeDepartment.ValueMember = conn.GetData(Query).Columns["ID"].ToString();
            employee_combox_employeeDepartment.DataSource = conn.GetData(Query);
        }

        #endregion 

        private void employee_btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (employee_txtbox_name.Text == "" || employee_txtbox_surname.Text == ""
                    || employee_combox_employeeGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = employee_txtbox_name.Text;
                    string Surname = employee_txtbox_surname.Text;
                    string Gender = employee_combox_employeeGender.SelectedItem.ToString();
                    int Departmant = Convert.ToInt32(employee_combox_employeeDepartment.SelectedValue.ToString());
                    string DateOfBith = DateTime.ParseExact(employee_timpic_dateOfBith.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                    string JoinDate = DateTime.ParseExact(employee_timpic_joinDate.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

                    string Query = $"INSERT INTO EmployeeTbl (EmpName,EmpSurname,EmpGender,DepID,EmpBornDate,EmpJoingDate) " +
                        $"VALUES ('{Name}','{Surname}','{Gender}',{Departmant},'{DateOfBith}','{JoinDate}')";
                    conn.SetData(Query);
                    ShowEmployee();
                    GetEmployeeBase();
                    MessageBox.Show("Employee Added!!!");
                    Employee_ClearLebles();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void employee_btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Employee_Key == 0)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Query = $"DELETE FROM EmployeeTbl WHERE ID = {Employee_Key}";
                    conn.SetData(Query);
                    ShowEmployee();
                    GetEmployeeBase();
                    MessageBox.Show("Employee Deleted!!!");

                }
                Employee_ClearLebles();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void employee_btn_update_Click(object sender, EventArgs e)
        {

            if (employee_txtbox_name.Text == "" || employee_txtbox_surname.Text == ""
                || employee_combox_employeeGender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                string Name = employee_txtbox_name.Text;
                string Surname = employee_txtbox_surname.Text;
                string Gender = employee_combox_employeeGender.SelectedItem.ToString();
                int Departmant = Convert.ToInt32(employee_combox_employeeDepartment.SelectedValue.ToString());
                string DateOfBith = DateTime.ParseExact(employee_timpic_dateOfBith.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                string JoinDate = DateTime.ParseExact(employee_timpic_joinDate.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

                string Query = $"UPDATE EmployeeTbl SET EmpName = '{Name}',EmpSurname = '{Surname}',EmpGender = '{Gender}',DepID = {Departmant},EmpBornDate = '{DateOfBith}',EmpJoingDate = '{JoinDate}' WHERE ID = {Employee_Key}";
                if (Employee_Key != null)
                {
                    try
                    {

                        conn.SetData(Query);
                        ShowEmployee();
                        GetEmployeeBase();
                        MessageBox.Show("Employee Update!!!");
                        Employee_Key = null;
                        Employee_ClearLebles();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message + "Please call your administrator!");
                    }
                }
                else
                {
                    MessageBox.Show("You need to choose somone from the list!");
                }

            }
        }

        private void Employee_ClearLebles()
        {
            employee_txtbox_name.Text = "";
            employee_txtbox_surname.Text = "";
            employee_combox_employeeGender.SelectedIndex = -1;

            employee_combox_employeeDepartment.SelectedItem = null;
            employee_combox_employeeDepartment.SelectedIndex = -1;
            employee_combox_employeeDepartment.Text = string.Empty;

            employee_timpic_dateOfBith.Value = DateTime.Now;
            employee_timpic_joinDate.Value = DateTime.Now;
        }
        private void employee_btn_clear_Click(object sender, EventArgs e)
        {
            Employee_ClearLebles();
        }
        private void employee_DGV_DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            employee_txtbox_name.Text = employee_DGV_EmplList.SelectedRows[0].Cells[1].Value.ToString();
            employee_txtbox_surname.Text = employee_DGV_EmplList.SelectedRows[0].Cells[2].Value.ToString();
            employee_combox_employeeGender.Text = employee_DGV_EmplList.SelectedRows[0].Cells[3].Value.ToString();
            employee_combox_employeeDepartment.Text = employee_DGV_EmplList.SelectedRows[0].Cells[4].Value.ToString();
            employee_timpic_dateOfBith.Text = employee_DGV_EmplList.SelectedRows[0].Cells[5].Value.ToString();
            employee_timpic_joinDate.Text = employee_DGV_EmplList.SelectedRows[0].Cells[6].Value.ToString();
            Employee_Key = Convert.ToInt32(employee_DGV_EmplList.SelectedRows[0].Cells[0].Value.ToString());
        }
        #endregion

        #region Department page
        private void ShowDepartmants()
        {
            string Query = "SELECT ID as Code, DepName as Department FROM DepartmantTbl";
            department_DGV_DepList.DataSource = conn.GetData(Query);

        }

        private void Department_btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (department_txtBox_DepName.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = department_txtBox_DepName.Text;
                    string Query = "INSERT INTO DepartmantTbl values ('{0}')";
                    Query = string.Format(Query, department_txtBox_DepName.Text);
                    conn.SetData(Query);
                    ShowDepartmants();
                    GetDepartmentBase();
                    MessageBox.Show("Departmant Added!!!");
                    department_txtBox_DepName.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        int Key = 0;

        private void Department_DGV_DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            department_txtBox_DepName.Text = department_DGV_DepList.SelectedRows[0].Cells[1].Value.ToString();
            if (department_txtBox_DepName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(department_DGV_DepList.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void Department_btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (department_txtBox_DepName.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = department_txtBox_DepName.Text;
                    string Query = "UPDATE DepartmantTbl SET DepName = '{0}' WHERE ID = '{1}'";
                    Query = string.Format(Query, department_txtBox_DepName.Text, Key);
                    conn.SetData(Query);
                    ShowDepartmants();
                    GetDepartmentBase();
                    MessageBox.Show("Departmant Update!!!");
                    department_txtBox_DepName.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Department_btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (department_txtBox_DepName.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Query = $"DELETE FROM DepartmantTbl WHERE DepName = '{department_txtBox_DepName.Text}'";
                    conn.SetData(Query);
                    ShowDepartmants();
                    GetDepartmentBase();
                    MessageBox.Show("Departmant Delete!!!");
                    department_txtBox_DepName.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        #endregion

        #region Salary page

        #region SQL DataBase Command
        SQLFunctions functions = new SQLFunctions();

        int DaySalary; //Here save employee salary
        string Period = "";

        private void ShowSalary()
        {
            string Query = "SELECT ID as Code, EmployeeID as 'Employee Code', MonthlyWorkDays, SalaryPerHour, Amount, PayDate as Payday FROM SalaryTbl";
            salary_DGV_SalaryList.DataSource = functions.GetData(Query);
        }
        private void GetEmployeeBase()
        {
            string Query = "SELECT ID as Code, CAST(ID as VARCHAR(3)) + ' ' + EmpName + ' ' + EmpSurname AS 'Full Name' FROM EmployeeTbl";
            salary_combox_Employee.DisplayMember = functions.GetData(Query).Columns["Full Name"].ToString();
            salary_combox_Employee.ValueMember = functions.GetData(Query).Columns["Code"].ToString();
            salary_combox_Employee.DataSource = functions.GetData(Query);
        }

        #endregion 

        int day = 1;

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (salary_combox_Employee.SelectedIndex == -1 || salary_txtbox_daysAttended.Text == "" || salary_txtbox_salaryAmount.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    Period = salary_timpic_period.Value.Date.Year.ToString() + "." + salary_timpic_period.Value.Date.Month.ToString();
                    string today = DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString();
                    int Amount = day * (DaySalary = Convert.ToInt32(salary_txtbox_daysAttended.Text));
                    int Days = Convert.ToInt32(salary_txtbox_daysAttended.Text);


                    string Query = $"INSERT INTO SalaryTbl (Employee,Attendance,Period,Amount,PayDate) " +
                        $"VALUES ({salary_combox_Employee.SelectedValue},{Days},'{Period}',{Amount},'{today}')";
                    functions.SetData(Query);
                    ShowSalary();
                    MessageBox.Show("Salary Paid!!!");


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void salary_btn_update_Click(object sender, EventArgs e)
        {

        }

        private void salary_combox_Employee_SelectedValueChanged(object sender, EventArgs e)
        {
            /*GetSalary(Convert.ToInt32(combox_Employee.SelectedValue));*/
            Salary_ChangeAmount();
        }

        private void salary_txtbox_daysAttended_TextChanged(object sender, EventArgs e)
        {
            Salary_ChangeAmount();
        }
        private void Salary_ChangeAmount()
        {
            if (salary_txtbox_daysAttended.Text == "")
            {
                salary_txtbox_salaryAmount.Text = "Set 'Days Attended'";
            }
            else if (Convert.ToInt32(salary_txtbox_daysAttended.Text) > 31)
            {
                salary_txtbox_salaryAmount.Text = "Max days 31!!!";
            }
            else
            {
                day = Convert.ToInt32(salary_txtbox_daysAttended.Text);
                salary_txtbox_salaryAmount.Text = "$ " + (day * DaySalary);
            }
        }

        private void salary_txtbox_daysAttended_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        #endregion
    }
}
