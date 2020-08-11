using telCom_2._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telCom_2._1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (new connectionForm().ShowDialog() != DialogResult.OK)
                    return;

                global.CheckAdmin();

                while (true)
                {
                    if (new LoginForm().ShowDialog() != DialogResult.OK)
                        return;

                    if (global.CurrentUser.IsWorker)
                    {
                        if (global.CurrentUser.Position == WorkerRoles.Admin)
                            Application.Run(new WorkerMainForm());
                        else
                            Application.Run(new WorkerMainForm());
                    }
                    else
                        Application.Run(new ClientMainForm());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критическая ошибка: " + ex.ToString());
            }
        }
    }
}

