using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_base
{
    public static class Is_it_open
    {
         public static void Check(string lookingWidnow)
        {
            string confirmation = new Confirmation().Text;
            switch (lookingWidnow)
            {
                case confirmation:
                    Confirmation_Open();
                    break;
                case "Loading":
                    Loading();
                    break;
                case "Login_window":
                    Login_window();
                    break;
                case "MainMenu":
                    MainMenu();
                    break;
                case "Signup_window":
                    Signup_window();
                    break;
            }
        }

        private static void Confirmation_Open()
        {
            foreach (Form window in Application.OpenForms)
            {
                if (window is Confirmation)
                {
                    window.ShowDialog();
                    window.Focus();
                    return;
                }
            }
        }
        private static void Loading()
        {

        }
        private static void Login_window()
        {

        }
        private static void MainMenu()
        {

        }
        private static void Signup_window()
        {

        }
    }
}
