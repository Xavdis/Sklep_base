namespace Sklep_base
{
    public partial class Departmants : Form
    {

        public Departmants()
        {
            InitializeComponent();
            conn = new Functions();
            ShowDepartmants();
            btn_salary.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_salary.MouseLeave += new EventHandler(Button_MouseLeave);

            btn_employee.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_employee.MouseLeave += new EventHandler(Button_MouseLeave);

            btn_logout.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_logout.MouseLeave += new EventHandler(Button_MouseLeave);
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

        private void btn_salary_Click(object sender, EventArgs e)
        {
            this.Close();
            new Salaries().Show();
        }

        #region Change color of button
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
                hoveredButton.BackColor = Color.Honeydew;
                hoveredButton.ForeColor = Color.SeaGreen;
            }
        }

        private void btn_save_MouseEnter(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.MediumSeaGreen;
            btn_add.ForeColor = Color.Honeydew;
        }

        private void btn_save_MouseLeave(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.SeaGreen;
            btn_add.ForeColor = Color.Honeydew;
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

        Functions conn;
        private void ShowDepartmants()
        {
            string Query = "SELECT * FROM DepartmantTbl";
            DGV_DepList.DataSource = conn.GetData(Query);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBox_DepName.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = txtBox_DepName.Text;
                    string Query = "INSERT INTO DepartmantTbl values ('{0 }')";
                    Query = string.Format(txtBox_DepName.Text);
                    conn.SetData(Query);
                    ShowDepartmants();
                    MessageBox.Show("Departmant Added!!!");
                    txtBox_DepName.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
