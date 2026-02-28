using System.Data.Common;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace Sklep_base
{
    public static class Is_it_open
    {
        public static void Check(string lookingWidnow)
        {
            foreach (Form window in Application.OpenForms)
            {
                if (window.Name == lookingWidnow)
                {
                    window.DesktopLocation = new Point((Screen.PrimaryScreen.WorkingArea.Width - window.Width)/2, (Screen.PrimaryScreen.WorkingArea.Height - window.Height) / 2);
                    window.Show();
                    window.Focus();
                    return;
                }
            }
            
            switch (lookingWidnow)
            {
                case nameof(MainMenu):
                    new MainMenu().Show();
                    break;
                case nameof(login_window):
                    new login_window().Show();
                    break;
                case nameof(Signup_window):
                    new Signup_window().Show();
                    break;
                case nameof(Confirmation):
                    new Confirmation().Show();
                    break;
                case nameof(Loading):
                    new Loading().Show();
                    break;
            } 
        }
    }
}
