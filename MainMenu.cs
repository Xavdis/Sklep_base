using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklep_base
{
    public partial class MainMenu : Form
    {
        SQLFunctions conn;
        int? Employee_Key = null;
        public MainMenu()
        {
            try
            {

                InitializeComponent();
                conn = new SQLFunctions();
                ShowEmployee();
                GetDepartmentBase();
                Employee_ClearLebles();
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
        
        private void btn_salary_Click(object sender, EventArgs e)
        {
            this.Close();
            new Salaries().Show();
        }

        private void btn_departmants_Click(object sender, EventArgs e)
        {
            this.Close();
            new Departments().Show();
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
        #region Employee page

        #region SQL DataBase Command

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

        private void btn_save_MouseEnter(object sender, EventArgs e)
        {
            employee_btn_add.BackColor = Color.MediumSeaGreen;
        }

        private void btn_save_MouseLeave(object sender, EventArgs e)
        {
            employee_btn_add.BackColor = Color.SeaGreen;
        }

        private void btn_update_MouseEnter(object sender, EventArgs e)
        {
            employee_btn_update.BackColor = Color.MediumSeaGreen;
            employee_btn_update.ForeColor = Color.Honeydew;
        }

        private void btn_update_MouseLeave(object sender, EventArgs e)
        {
            employee_btn_update.BackColor = Color.Honeydew;
            employee_btn_update.ForeColor = Color.SeaGreen;
        }
        #endregion


        private void btn_add_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Employee Added!!!");
                    Employee_ClearLebles();
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
                if (Employee_Key == 0)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Query = $"DELETE FROM EmployeeTbl WHERE ID = {Employee_Key}";
                    conn.SetData(Query);
                    ShowEmployee();
                    MessageBox.Show("Employee Deleted!!!");
                }
                Employee_ClearLebles();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
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
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Employee_ClearLebles();
        }

        private void DGV_DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
