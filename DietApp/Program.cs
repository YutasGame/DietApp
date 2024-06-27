using System;
using System.Windows.Forms;

namespace DietApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserManager userManager = new UserManager();
            Application.Run(new LoginForm(userManager));
        }
    }
}
