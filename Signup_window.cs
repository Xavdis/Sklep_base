﻿using System.Data.SqlClient;

namespace Sklep_base
{
    public partial class Signup_window : Form
    {
        string code = "adm_adm";//add code for add new account
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9F97L89;Initial Catalog=login_base;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public Signup_window()
        {

            InitializeComponent();

            btn_createAccount.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_createAccount.MouseLeave += new EventHandler(Button_MouseLeave);

            btn_cencel.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_cencel.MouseLeave += new EventHandler(Button_MouseLeave);

            lbl_clear.MouseEnter += new EventHandler(Lable_MouseEnter);
            lbl_clear.MouseLeave += new EventHandler(Lable_MouseLeave);
        }

        #region Changed color of button
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
        #endregion

        private void btn_cencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            if (txt_login.Text == "" || txt_password.Text == "" || txt_code.Text == "")
            {
                MessageBox.Show("Invalid register details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_login.Focus();
            }
            else if (txt_code.Text != code)
            {
                MessageBox.Show("Invalid code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_login.Focus();
            }
            else if (txt_code.Text == code)
            {
                conn.Open();
                string register = "INSERT INTO Login_new VALUES ('" + txt_login.Text + "','" + txt_password.Text + "')";
                cmd = new SqlCommand(register, conn);
                cmd .ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_code.Clear();
                txt_login.Clear();
                txt_password.Clear();
            }
            else
            {
                MessageBox.Show("Invalid code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_code.Focus();
            }
        }
    }
}
