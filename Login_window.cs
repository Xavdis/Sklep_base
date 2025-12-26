using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;


namespace Sklep_base
{

    public partial class login_window : Form
    {
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

        Functions functions = new Functions();

        private void login_window_Load(object sender, EventArgs e)
        {
            
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
                sqlpass = string.Empty,
                test = $"\n\n****************** {sqluser} {sqlpass} {username} {password}\n\n";

            Debug.WriteLine(test);

            try
            {

                SqlConnection conn = new SqlConnection(functions.ConnStr);
                SqlCommand cmdOpen = new SqlCommand(functions.ConnStr, );
                cmdOpen.Parameters.AddWithValue("@userID", new Functions().User);
                cmdOpen.Parameters.AddWithValue("@password", new Functions().Password);

                conn.Open();

                // Параметризований SQL-запит для уникнення SQL-ін'єкцій
                string selectQuery = "SELECT username, password FROM Login_new WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(selectQuery, conn);

                // Передаємо значення з TextBox до параметрів SQL-запиту
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                // Виконуємо запит і зчитуємо дані
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) // Перевіряємо, чи є результати
                {
                    sqluser = dr["username"].ToString();
                    sqlpass = dr["password"].ToString();


                    Debug.WriteLine(test);
                }
                else
                {
                    MessageBox.Show("i can`t read!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                if (username == string.Empty || password == string.Empty)
                {
                    MessageBox.Show("Please, enter your username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_login.Focus();
                }
                else if (sqluser == username && sqlpass == password)
                {

                    new Employee().Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_login.Clear();
                    txt_password.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                txt_login.Clear();
                txt_password.Clear();
                txt_login.Focus();
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_createLogin_Click(object sender, EventArgs e)
        {
            Signup_window sign_up = new Signup_window();
            sign_up.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_clear_Click(object sender, EventArgs e)
        {
            txt_login.Clear();
            txt_password.Clear();
            txt_login.Focus();
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
    }
}
