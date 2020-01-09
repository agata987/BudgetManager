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
    public partial class UserManager : Form
    {
        MySqlConnector connector;
        MySqlDataAdapter dataAdapter;
        MySqlDataReader reader;
        DataTable dataTable_users;

        string login;
        int id_budget;

        public UserManager(string login, int id_budget)
        {
            connector = new MySqlConnector();
            dataTable_users = new DataTable();

            this.login = login;
            this.id_budget = id_budget;

            InitializeComponent();

            updateTable();
        }

        void updateTable()
        {
            dataAdapter = connector.dataAdapter("select id_uzytkownika from Uzytkownicy where id_uzytkownika !='" + login+"' and id_budzetu ="+id_budget);

            if (dataAdapter != null)
            {
                dataTable_users.Clear();
                dataAdapter.Fill(dataTable_users);

                dataGridViewUsers.AutoGenerateColumns = false;
                dataGridViewUsers.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsers.DataSource = dataTable_users;

                connector.CloseConnection();
            }
            else MessageBox.Show("Błąd pobierania użytkowników z bazy danych.");
        }

        void buttonAddUser_Click(object sender, EventArgs e)
        {
            addUser();
        }

        void addUser()
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
            {
                MessageBox.Show("Hasło nie może mieć więcej niż 30 znaków.");
                textBoxPassword.BackColor = Color.PaleVioletRed;
                passwordTooLong = true;
            }
            else textBoxPassword.BackColor = Color.White;

            if (textBoxRepeatPassw.Text != textBoxPassword.Text)
            {
                good_pass = false;
                textBoxRepeatPassw.BackColor = Color.PaleVioletRed;
            }
            else
                textBoxRepeatPassw.BackColor = Color.White;

            if (!String.IsNullOrWhiteSpace(textBoxLogin.Text) && !String.IsNullOrWhiteSpace(textBoxPassword.Text) && !String.IsNullOrWhiteSpace(textBoxRepeatPassw.Text) && !loginTooLong && !passwordTooLong && good_pass)
            {
                string login_new = textBoxLogin.Text;
                string password_new = textBoxPassword.Text;
                string passwordRepeated = textBoxRepeatPassw.Text;

                reader = connector.Select("select * from Uzytkownicy where id_uzytkownika='" + login_new + "'");

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


                        if (id_budget > -1)
                        {
                            if (connector.Query("insert into Uzytkownicy (id_uzytkownika, haslo, id_budzetu) values ('" + login_new + "', '" + password_new + "', " + id_budget + ")"))
                            { 
                                textBoxLogin.Clear();
                                textBoxPassword.Clear();
                                textBoxRepeatPassw.Clear();

                            }
                            else
                            {
                                MessageBox.Show("Błąd dodawania użytkownika.");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Błąd dodawania użytkownika.");
                        }

                    }
                }
                else
                    MessageBox.Show("Błąd połączenia z bazą danych.");
            }

            updateTable();
            this.Cursor = Cursors.Default;
        }

        private void textBoxLogin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addUser();
        }

        private void textBoxPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addUser();
        }

        private void textBoxRepeatPassw_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addUser();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (dataGridViewUsers.Rows.Count > 0)
            {
                string selected_user = dataGridViewUsers.Rows[dataGridViewUsers.SelectedRows[0].Index].Cells[0].Value.ToString();

                connector.Query("delete from Uzytkownicy where id_uzytkownika ='" + selected_user + "'");

                updateTable();
            }

            this.Cursor = Cursors.Default;
        }

    }
}
