using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
            string
                username = txt_login.Text,
                password = txt_password.Text,
                sqluser = string.Empty,
                sqlpass = string.Empty;

            using (SqlConnection conn = new SqlConnection(new SQLFunctions().ConnStr))
            {
                try
                {
                    conn.Open();

                    string selectQuery = "SELECT username, password FROM Login_new WHERE username = @username AND password = @password";
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        sqluser = dr["username"].ToString();
                        sqlpass = dr["password"].ToString();

                    }

                    if (username == string.Empty || password == string.Empty)
                    {
                        MessageBox.Show("Please, enter your username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_login.Focus();
                    }
                    else if (sqluser == username && sqlpass == password)
                    {
                        this.Hide();
                        Is_it_open.Check(nameof(MainMenu));
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearLbl();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    ClearLbl();
                }
                finally
                {
                    conn.Close();
                }
            }

        }
        private void btn_createLogin_Click(object sender, EventArgs e)
        {
            Is_it_open.Check(nameof(Signup_window));
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
