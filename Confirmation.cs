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
    public partial class confirmation_menu : Form
    {

        public static bool Confirm { get; set; }
        

        public confirmation_menu()
        {
            InitializeComponent();
            btn_no.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_no.MouseLeave += new EventHandler(Button_MouseLeave);

            btn_yes.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_yes.MouseLeave += new EventHandler(Button_MouseLeave);
            
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

        private void btn_no_Click(object sender, EventArgs e)
        {
            Confirm = false;    
            this.Close();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            Confirm = true;
            this.Close();
        }
    }
}
