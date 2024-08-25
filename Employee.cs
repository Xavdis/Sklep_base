namespace Sklep_base
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Salaries().Show();
        }

        private void btn_departmants_Click(object sender, EventArgs e)
        {
            this.Hide();
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

    }
}
