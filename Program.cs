using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudzetManager
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        /// 
        static LoginMenu loginMenu;
        static MainMenu mainMenu;

        static string login = null;
        static int id_budget = -1;

        static bool exit = false;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainMenu = new MainMenu("noone",-1);

            while (!exit)
            {
                loginMenu = new LoginMenu();
                Application.Run(loginMenu);

                if (loginMenu.logged())
                {
                    login = loginMenu.getLogin();
                    id_budget = loginMenu.get_id_budget();

                    mainMenu = new MainMenu(login, id_budget);
                    Application.Run(mainMenu);
                }
                else
                    exit = true;

                if (mainMenu.getLogged())
                    exit = true;
            }
        }

    }
}
