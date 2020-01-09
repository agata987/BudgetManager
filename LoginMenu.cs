using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BudzetManager
{
    public partial class LoginMenu : Form
    {
        MySqlConnector connector;
        MySqlDataReader reader;

        string login = null;
        string password = null;
        int id_budget = -1;

        bool loginCorrect;
        bool passwordCorrect;

        // login and password correct
        bool match;

        bool done;

        RegisterMenu registerMenu;

        public LoginMenu()
        {
            done = false;
            connector = new MySqlConnector();
            InitializeComponent();
        }

        void buttonLogin_Click(object sender, EventArgs e)
        {
            tryToLog();
        }

        public bool logged()
        {
            return done;
        }

        public string getLogin()
        {
            return login;
        }

        public string getPassword()
        {
            return password;
        }

        public int get_id_budget()
        {
            return id_budget;
        }

        void buttonRegister_Click(object sender, EventArgs e)
        {
            registerMenu = new RegisterMenu();
            registerMenu.Show();
        }

        void textBoxPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tryToLog();
        }

        void textBoxLogin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tryToLog();
        }

        void tryToLog()
        {
            Cursor.Current = Cursors.WaitCursor;

            login = textBoxLogin.Text;
            password = textBoxPassword.Text;

            loginCorrect = false;
            passwordCorrect = false;
            match = false;

            textBoxLogin.BackColor = Color.White;
            textBoxPassword.BackColor = Color.White;

            if (!String.IsNullOrWhiteSpace(login) && !String.IsNullOrWhiteSpace(password))
            {
                

                reader = connector.Select("select * from Uzytkownicy where id_uzytkownika='" + login + "'");

                if (reader != null)
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(0) == login)
                            loginCorrect = true;
                        if (reader.GetString(1) == password)
                            passwordCorrect = true;

                        id_budget = reader.GetInt16(2);

                        if (loginCorrect && passwordCorrect)
                        {
                            match = true;
                            break;
                        }
                    }

                    connector.CloseConnection();
                }

                if (!loginCorrect)
                    textBoxLogin.BackColor = Color.PaleVioletRed;

                if (!passwordCorrect)
                    textBoxPassword.BackColor = Color.PaleVioletRed;

                if (match)
                {
                    done = true;
                    this.Close();
                }

                
            } 
            else
            {
                if(String.IsNullOrWhiteSpace(login))
                 textBoxLogin.BackColor = Color.PaleVioletRed;

                if (String.IsNullOrWhiteSpace(password))
                 textBoxPassword.BackColor = Color.PaleVioletRed;
            }

            Cursor.Current = Cursors.Default;
        }

    }
}
