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
    public partial class Signup_window : Form
    {
        public Signup_window()
        {
            InitializeComponent();

            btn_login.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_login.MouseLeave += new EventHandler(Button_MouseLeave);

            btn_cencel.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_cencel.MouseLeave += new EventHandler(Button_MouseLeave);

            lbl_clear.MouseEnter += new EventHandler(Lable_MouseEnter);
            lbl_clear.MouseLeave += new EventHandler(Lable_MouseLeave);
        }

        private void Lable_MouseEnter(object sender, EventArgs e)
        {
            Label hoveredButton = sender as Label;
            if (hoveredButton != null)
            {
                hoveredButton.ForeColor = Color.MediumSeaGreen;
            }
        }
        private void Lable_MouseLeave(object sender, EventArgs e)
        {
            Label hoveredButton = sender as Label;
            if (hoveredButton != null)
            {
                hoveredButton.ForeColor = Color.SeaGreen;
            }
        }

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

        private void Signup_window_Load(object sender, EventArgs e)
        {

        }

        private void btn_cencel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
