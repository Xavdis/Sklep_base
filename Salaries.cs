using System.Data;

namespace Sklep_base
{

    public partial class Salaries : Form
    {
        SQLFunctions functions = new SQLFunctions();
        public Salaries()
        {
            InitializeComponent();
            ShowSalary();
            //GetEmployeeBase();
            btn_departmants.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_departmants.MouseLeave += new EventHandler(Button_MouseLeave);

            btn_employee.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_employee.MouseLeave += new EventHandler(Button_MouseLeave);

            btn_logout.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_logout.MouseLeave += new EventHandler(Button_MouseLeave);
        }

        #region SQL DataBase Command


        int DaySalary = 0; //Here save employee salary
        string Period = "";
        private void GetSalary(int Key)
        {

            string Query = $"SELECT ID, EmpSalary FROM EmployeeTbl WHERE ID = {Key}";
            foreach (DataRow dr in functions.GetData(Query).Rows)
            {
                DaySalary = Convert.ToInt32(dr["EmpSalary"].ToString());
            }
            //txtbox_daysAttended.Text = DSal.ToString();

        }

        private void ShowSalary()
        {
            string Query = "SELECT * FROM SalaryTbl";
            DGV_SalaryList.DataSource = functions.GetData(Query);
        }
        private void GetEmployeeBase()
        {
            string Query = "SELECT ID, EmpName + ' ' + EmpSurname AS FullName FROM EmployeeTbl";
            combox_Employee.DisplayMember = functions.GetData(Query).Columns["FullName"].ToString();
            combox_Employee.ValueMember = functions.GetData(Query).Columns["ID"].ToString();
            combox_Employee.DataSource = functions.GetData(Query);
        }

        #endregion 


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

        private void btn_employee_Click(object sender, EventArgs e)
        {
            this.Close();
            new Employee().Show();
        }

        private void btn_departmants_Click(object sender, EventArgs e)
        {
            this.Close();
            new Departmants().Show();
        }

        #region Changed color of button

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button hoveredButton = sender as Button;
            if (hoveredButton != null)
            {
                hoveredButton.BackColor = Color.MediumSeaGreen;
                hoveredButton.ForeColor = Color.Honeydew;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button hoveredButton = sender as Button;
            if (hoveredButton != null)
            {
                hoveredButton.BackColor = Color.White;
                hoveredButton.ForeColor = Color.SeaGreen;
            }
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

        #endregion

        int day = 1;

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (combox_Employee.SelectedIndex == -1 || txtbox_daysAttended.Text == "" || txtbox_salaryAmount.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    Period = timpic_period.Value.Date.Year.ToString() + "." + timpic_period.Value.Date.Month.ToString();
                    string today = DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString();
                    int Amount = day * DaySalary;
                    int Days = Convert.ToInt32(txtbox_daysAttended.Text);


                    string Query = $"INSERT INTO SalaryTbl (Employee,Attendance,Period,Amount,PayDate) " +
                        $"VALUES ({combox_Employee.SelectedValue},{Days},'{Period}',{Amount},'{today}')";
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

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void combox_Employee_SelectedValueChanged(object sender, EventArgs e)
        {
            GetSalary(Convert.ToInt32(combox_Employee.SelectedValue));
            ChangeAmount();
        }

        private void txtbox_daysAttended_TextChanged(object sender, EventArgs e)
        {
            ChangeAmount();
        }
        private void ChangeAmount()
        {
            if (txtbox_daysAttended.Text == "")
            {
                txtbox_salaryAmount.Text = "Set 'Days Attended'";
            }
            else if (Convert.ToInt32(txtbox_daysAttended.Text) > 31)
            {
                txtbox_salaryAmount.Text = "Max days 31!!!";
            }
            else
            {
                day = Convert.ToInt32(txtbox_daysAttended.Text);
                txtbox_salaryAmount.Text = "$ " + (day * DaySalary);
            }
        }

        private void txtbox_daysAttended_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
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

        private void combox_Employee_Click(object sender, EventArgs e)
        {
            try
            {
                string item;
                functions.UpdateUserDataForComboBox(item);
                combox_Employee.DataSource = ;
                combox_Employee.DisplayMember = "Name"; // Поле, яке буде відображатися (Імена)
                combox_Employee.ValueMember = "ID";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
