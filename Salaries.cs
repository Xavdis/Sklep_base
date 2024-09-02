using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklep_base
{
    public partial class Salaries : Form
    {
        public Salaries()
        {
            InitializeComponent();
            btn_departmants.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_departmants.MouseLeave += new EventHandler(Button_MouseLeave);

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
    }
}
