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
    public partial class RegisterMenu : Form
    {
        MySqlConnector connector;
        MySqlDataReader reader;

        string login;
        string password ;
        string passwordRepeated;
        int id_budget = -1;

        public RegisterMenu()
        {
            InitializeComponent();

            connector = new MySqlConnector();
        }

        void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        void buttoncCreateBudget_Click(object sender, EventArgs e)
        {
            tryToRegister();
        }

        void tryToRegister()
        {
            this.Cursor = Cursors.WaitCursor;

            bool loginTooLong = false;
            bool passwordTooLong = false;
            bool good_pass = true;

            if (String.IsNullOrWhiteSpace(textBoxLogin.Text))
                textBoxLogin.BackColor = Color.PaleVioletRed;
            else
                textBoxLogin.BackColor = Color.White;

            if (String.IsNullOrWhiteSpace(textBoxPassword.Text))
                textBoxPassword.BackColor = Color.PaleVioletRed;
            else
                textBoxPassword.BackColor = Color.White;

            if (String.IsNullOrWhiteSpace(textBoxRepeatPassw.Text))
                textBoxRepeatPassw.BackColor = Color.PaleVioletRed;
            else
                textBoxRepeatPassw.BackColor = Color.White;

            if (textBoxLogin.Text.Count() > 20)
            {
                MessageBox.Show("Login nie może mieć więcej niż 20 znaków.");
                textBoxLogin.BackColor = Color.PaleVioletRed;
                loginTooLong = true;
            } 
            else textBoxLogin.BackColor = Color.White;

            if (textBoxPassword.Text.Count() > 30)
            { MessageBox.Show("Hasło nie może mieć więcej niż 30 znaków.");
                textBoxPassword.BackColor = Color.PaleVioletRed;
                passwordTooLong = true;
            }else textBoxPassword.BackColor = Color.White;

            if(textBoxRepeatPassw.Text != textBoxPassword.Text)
            {
                good_pass = false;
                textBoxRepeatPassw.BackColor = Color.PaleVioletRed;
            }
            else
                textBoxRepeatPassw.BackColor = Color.White;
            


            if (!String.IsNullOrWhiteSpace(textBoxLogin.Text) && !String.IsNullOrWhiteSpace(textBoxPassword.Text) && !String.IsNullOrWhiteSpace(textBoxRepeatPassw.Text) && !loginTooLong && !passwordTooLong && good_pass)
            {
                login = textBoxLogin.Text;
                password = textBoxPassword.Text;
                passwordRepeated = textBoxRepeatPassw.Text;

                reader = connector.Select("select * from Uzytkownicy where id_uzytkownika='" + login + "'");

                if (reader != null)
                {
                    if (reader.HasRows)
                    {
                        textBoxLogin.BackColor = Color.PaleVioletRed;
                        MessageBox.Show("Ten login jest już zajęty!");

                        connector.CloseConnection();
                    }
                    else
                    {
                        connector.CloseConnection();

                     
                            bool good = false;

                            // create a budget
                            if (connector.Query("insert into Budzety (id_administratora) values ('" + login + "')"))
                                good = true;
                                

                            // get created budget id
                            reader = connector.Select("select * from Budzety where id_administratora='" + login + "'");

                            if (reader.HasRows && reader != null)
                            {
                                reader.Read();
                                id_budget = reader.GetInt16(0);
                                connector.CloseConnection();
                            }

                            if (id_budget != -1 && good)
                            {
                                

                                // create an admin
                                if (connector.Query("insert into Uzytkownicy (id_uzytkownika, haslo, id_budzetu) values ('" + login + "', '" + password + "', " + id_budget + ")"))
                                    good = true;

                                if (good)
                                {
                                    // crate default categories

                                    // expenses
                                    connector.Query("insert into Kategorie (nazwa, id_budzetu, opis, czy_przychod, limit_) values ( 'jedzenie'," + id_budget + ", '---', false, '---')");
                                    connector.Query("insert into Kategorie (nazwa, id_budzetu, opis, czy_przychod, limit_) values ( 'mieszkanie'," + id_budget + ", 'opłaty za mieszkanie i media', false, '---')");
                                    connector.Query("insert into Kategorie (nazwa, id_budzetu, opis, czy_przychod, limit_) values ( 'zdrowie i higiena'," + id_budget + ", '---', false, '---')");
                                    connector.Query("insert into Kategorie (nazwa, id_budzetu, opis, czy_przychod, limit_) values ( 'ubrania'," + id_budget + ", '---', false, '---')");
                                    connector.Query("insert into Kategorie (nazwa, id_budzetu, opis, czy_przychod, limit_) values ( 'transport'," + id_budget + ", '---', false, '---')");
                                    connector.Query("insert into Kategorie (nazwa, id_budzetu, opis, czy_przychod, limit_) values ( 'rozrywka'," + id_budget + ", '---', false, '---')");
                                    connector.Query("insert into Kategorie (nazwa, id_budzetu, opis, czy_przychod, limit_) values ( 'inne wydatki'," + id_budget + ", '---', false, '---')");

                                    // earnings
                                    connector.Query("insert into Kategorie (nazwa, id_budzetu, opis, czy_przychod, limit_) values ( 'praca'," + id_budget + ", '---', true, '---')");
                                    connector.Query("insert into Kategorie (nazwa, id_budzetu, opis, czy_przychod, limit_) values ( 'działalność gospodarcza'," + id_budget + ", '---', true, '---')");
                                    connector.Query("insert into Kategorie (nazwa, id_budzetu, opis, czy_przychod, limit_) values ( 'inne przychody'," + id_budget + ", '---', true, '---')");

                                    MessageBox.Show("Administrator " + login + " utworzony!");
                                    textBoxLogin.Clear();
                                    textBoxPassword.Clear();
                                    textBoxRepeatPassw.Clear();
                                    id_budget = -1;

                                    Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Błąd tworzenia budżetu.");
                            }
                        
                    }
                }
                else
                    MessageBox.Show("Błąd połączenia z bazą danych.");
            }

            this.Cursor = Cursors.Default;
        }

        void textBoxLogin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tryToRegister();
        }

        void textBoxPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tryToRegister();
        }

        void textBoxRepeatPassw_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tryToRegister();
        }

      
    }
}
