namespace Sklep_base
{
    public partial class Employee : Form
    {
        SQLFunctions conn;
        public Employee()
        {
            try
            {

                InitializeComponent();
                conn = new SQLFunctions();
                ShowEmployee();
                GetDepartmentBase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        #region SQL DataBase Command

        private void ShowEmployee()
        {
            string Query = "select " +
                "row_number() over (order by EmployeeTbl.ID) as ID, " +
                "EmployeeTbl.EmpName, EmployeeTbl.EmpSurname, EmployeeTbl.EmpGender, DepartmantTbl.DepName, " +
                "EmployeeTbl.EmpBornDate, EmployeeTbl.EmpJoingDate " +
                "FROM EmployeeTbl INNER JOIN DepartmantTbl on EmployeeTbl.DepID = DepartmantTbl.ID;";
            DGV_EmplList.DataSource = conn.GetData(Query);
        }

        private void GetDepartmentBase()
        {
            string Query = "SELECT * FROM DepartmantTbl";
            combox_employeeDepartment.DisplayMember = conn.GetData(Query).Columns["DepName"].ToString();
            combox_employeeDepartment.ValueMember = conn.GetData(Query).Columns["ID"].ToString();
            combox_employeeDepartment.DataSource = conn.GetData(Query);
        }

        #endregion 

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

        #region Change color of button 

        private void btn_salary_MouseLeave(object sender, EventArgs e)
        {
            btn_salary.BackColor = Color.Honeydew;
            btn_salary.ForeColor = Color.SeaGreen;
        }

        private void btn_salary_MouseEnter(object sender, EventArgs e)
        {
            btn_salary.BackColor = Color.MediumSeaGreen;
            btn_salary.ForeColor = Color.Honeydew;
        }

        private void btn_departmants_MouseEnter(object sender, EventArgs e)
        {
            btn_departmants.BackColor = Color.MediumSeaGreen;
            btn_departmants.ForeColor = Color.Honeydew;
        }

        private void btn_departmants_MouseLeave(object sender, EventArgs e)
        {
            btn_departmants.BackColor = Color.Honeydew;
            btn_departmants.ForeColor = Color.SeaGreen;
        }

        private void btn_exit_MouseEnter(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.MediumSeaGreen;
            btn_exit.ForeColor = Color.Honeydew;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.SeaGreen;
            btn_exit.ForeColor = Color.Honeydew;
        }

        private void btn_logout_MouseEnter(object sender, EventArgs e)
        {
            btn_logout.BackColor = Color.MediumSeaGreen;
            btn_logout.ForeColor = Color.Honeydew;
        }

        private void btn_logout_MouseLeave(object sender, EventArgs e)
        {
            btn_logout.BackColor = Color.Honeydew;
            btn_logout.ForeColor = Color.SeaGreen;
        }

        private void btn_save_MouseEnter(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.MediumSeaGreen;
        }

        private void btn_save_MouseLeave(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.SeaGreen;
        }

        private void btn_update_MouseEnter(object sender, EventArgs e)
        {
            btn_update.BackColor = Color.MediumSeaGreen;
            btn_update.ForeColor = Color.Honeydew;
        }

        private void btn_update_MouseLeave(object sender, EventArgs e)
        {
            btn_update.BackColor = Color.Honeydew;
            btn_update.ForeColor = Color.SeaGreen;
        }
        #endregion

        private void btn_salary_Click(object sender, EventArgs e)
        {
            this.Close();
            new Salaries().Show();
        }

        private void btn_departmants_Click(object sender, EventArgs e)
        {
            this.Close();
            new Departmants().Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            confirmation_menu conf = new confirmation_menu();
            conf.ShowDialog();
            if (confirmation_menu.Confirm == true)
            {
                new login_window().Show();
                this.Close();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_name.Text == "" || txtbox_surname.Text == ""
                    || combox_employeeGender.SelectedIndex == -1 || txbox_salary.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = txtbox_name.Text;
                    string Surname = txtbox_surname.Text;
                    string Gender = combox_employeeGender.SelectedItem.ToString();
                    int Departmant = Convert.ToInt32(combox_employeeDepartment.SelectedValue.ToString());
                    string DateOfBith = timpic_dateOfBith.Text;
                    string JoinDate = timpic_joinDate.Text;
                    int Salary = Convert.ToInt32(txbox_salary.Text);

                    string Query = $"INSERT INTO EmployeeTbl (EmpName,EmpSurname,EmpGender,DepID,EmpBornDate,EmpJoingDate) " +
                        $"VALUES ('{Name}','{Surname}','{Gender}',{Departmant},'{DateOfBith}','{JoinDate}')";
                    conn.SetData(Query);
                    ShowEmployee();
                    MessageBox.Show("Employee Added!!!");
                    txtbox_name.Text = "";
                    txtbox_surname.Text = "";
                    combox_employeeGender.SelectedIndex = -1;
                    combox_employeeDepartment.SelectedIndex = -1;
                    txbox_salary.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Query = $"DELETE FROM EmployeeTbl WHERE ID = {Key}";
                    conn.SetData(Query);
                    ShowEmployee();
                    MessageBox.Show("Employee Deleted!!!");
                    txtbox_name.Text = "";
                    txtbox_surname.Text = "";
                    combox_employeeGender.SelectedIndex = -1;
                    combox_employeeDepartment.SelectedIndex = -1;
                    txbox_salary.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_name.Text == "" || txtbox_surname.Text == ""
                    || combox_employeeGender.SelectedIndex == -1 || txbox_salary.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = txtbox_name.Text;
                    string Surname = txtbox_surname.Text;
                    string Gender = combox_employeeGender.SelectedItem.ToString();
                    int Departmant = Convert.ToInt32(combox_employeeDepartment.SelectedValue.ToString());
                    string DateOfBith = timpic_dateOfBith.Text;
                    string JoinDate = timpic_joinDate.Text;
                    int Salary = Convert.ToInt32(txbox_salary.Text);

                    string Query = $"UPDATE EmployeeTbl SET EmpName = '{Name}',EmpSurname = '{Surname}',EmpGender = '{Gender}',EmpDepart = {Departmant},EmpBornDate = '{DateOfBith}',EmpJoingDate = '{JoinDate}',EmpSalary = '{Salary}' WHERE EmpId = {Key}";
                    conn.SetData(Query);
                    ShowEmployee();
                    MessageBox.Show("Employee Update!!!");
                    txtbox_name.Text = "";
                    txtbox_surname.Text = "";
                    combox_employeeGender.SelectedIndex = -1;
                    combox_employeeDepartment.SelectedIndex = -1;
                    txbox_salary.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void DGV_EmplList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbox_name.Text = DGV_EmplList.SelectedRows[0].Cells[1].Value.ToString();
                txtbox_surname.Text = DGV_EmplList.SelectedRows[0].Cells[2].Value.ToString();
                combox_employeeGender.Text = DGV_EmplList.SelectedRows[0].Cells[3].Value.ToString();
                combox_employeeDepartment.SelectedText = DGV_EmplList.SelectedRows[0].Cells[4].Value.ToString();
                timpic_dateOfBith.Text = DGV_EmplList.SelectedRows[0].Cells[5].Value.ToString();
                timpic_joinDate.Text = DGV_EmplList.SelectedRows[0].Cells[6].Value.ToString();
                if (txtbox_name.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(DGV_EmplList.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }
        }
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
    }
}
