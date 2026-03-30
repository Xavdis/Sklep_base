using Sklep_base.DataAccess;
using Sklep_base.Helpers;
using Sklep_base.Forms;
using System.Data.SqlClient;
using Button = System.Windows.Forms.Button;


namespace Sklep_base
{

    public partial class login_window : Form
    {
        private void ClearLbl()
        {
            txt_login.Clear();
            txt_password.Clear();
            txt_login.Focus();
        }
        public login_window()
        {
            InitializeComponent();
            lbl_version.Text = new Sklep_base.Helpers.Version().GetVersion;

            btn_exit.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_exit.MouseLeave += new EventHandler(Button_MouseLeave);

            btn_login.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_login.MouseLeave += new EventHandler(Button_MouseLeave);

            btn_createLogin.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_createLogin.MouseLeave += new EventHandler(Button_MouseLeave);

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


        private void btn_login_Click(object sender, EventArgs e)
        {
            var auth = new AuthService();
            string
                username = txt_login.Text,
                password = txt_password.Text;
            if (txt_login.Text == string.Empty || txt_password.Text == string.Empty)
            {
                MessageBox.Show("Data missing!!!");
            }
            else if (auth.Login(username, password))
            {
                this.Hide();
                WindowManager.Check(nameof(MainMenu));
            }
            else
            {
                MessageBox.Show("Logig or password isn`t correct!");
            }
        }
        private void btn_createLogin_Click(object sender, EventArgs e)
        {
            WindowManager.Check(nameof(Signup_window));
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_clear_Click(object sender, EventArgs e)
        {
            ClearLbl();
        }

        private void chbox_Visible_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox_Visible.Checked == true)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
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
