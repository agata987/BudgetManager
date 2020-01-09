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
    public partial class InAndOut_REG_mainTab : Form
    {
        MySqlConnector connector;
        MySqlDataReader reader;

        string login;
        int id_budget;

        public delegate void AddedRegEventHandler(object source, EventArgs args);
        public event AddedRegEventHandler AddedReg;

        DataTable table;

        public InAndOut_REG_mainTab(string login, int id_budget)
        {
            //-------------------------------------
            this.login = login;
            this.id_budget = id_budget;

            connector = new MySqlConnector();
            table = new DataTable();

            table.Columns.Add("Rodzaj", typeof(string));
            table.Columns.Add("Kwota", typeof(string));
            table.Columns.Add("Od kiedy", typeof(string));
            table.Columns.Add("Do kiedy", typeof(string));
            table.Columns.Add("Co ile tygodni", typeof(string));
            table.Columns.Add("Co ile miesięcy", typeof(string));
            table.Columns.Add("Kategoria", typeof(string));
            table.Columns.Add("Użytkownik", typeof(string));

            
            InitializeComponent();

            prepareForm();

            string query = "select * from Przychody_oplaty_regularne where id_budzetu =" + id_budget;
            updateTable(query);
        }

        protected virtual void OnAddedReg()
        {
            if (AddedReg != null)
                AddedReg(this, EventArgs.Empty);
        }

        void updateTable(string query)
        {
            reader = connector.Select(query);

            if (reader != null)
            {
                table.Clear();
                
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        string rodzaj = "przychód";
                        if (!reader.GetBoolean(9))
                            rodzaj = "wydatek";

                        string kwota = reader.GetString(2);
                        kwota = kwota.Replace(".",",");

                        DateTime data = reader.GetDateTime(5);
                        string data_s = data.ToShortDateString();

                        DateTime data2 = reader.GetDateTime(6);
                        string data_s2 = data2.ToShortDateString();

                        int co_ile_t = reader.GetInt16(7);
                        string co_ile_t_s ="";

                        if (co_ile_t == null || co_ile_t == -1)
                            co_ile_t_s = "---";
                        else if (co_ile_t > 0)
                            co_ile_t_s = co_ile_t.ToString();

                        int co_ile_m = reader.GetInt16(8);
                        string co_ile_m_s = "";

                        if (co_ile_m == null || co_ile_m == -1)
                            co_ile_m_s = "---";
                        else if (co_ile_m > 0)
                            co_ile_m_s = co_ile_m.ToString();

                        string kategoria = reader.GetString(4);
                        string uzytkownik = reader.GetString(3);

                        table.Rows.Add(rodzaj, kwota, data_s, data_s2, co_ile_t_s, co_ile_m_s, kategoria, uzytkownik);
                    }
                }

                dataGridView.AutoGenerateColumns = false;
                dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView.DataSource = table;

                connector.CloseConnection();
            }
            else MessageBox.Show("Błąd pobierania przychodów/ opłat regularnych z bazy danych.");
        }

        void prepareForm()
        {
            // rodzaj
            updateRodzaj(comboBoxIn_or_out);

            // rodzaj (filtr)
            updateRodzaj(comboBoxIn_orOut_filtr);

            // kategorie
            updateCategories(comboBoxIn_or_out,comboBox_category);

            // kategorie (filtr)
            updateCategories(comboBoxIn_orOut_filtr, comboBox_category_filtr);

            // uzytkownik
            reader = connector.Select("select id_uzytkownika from Uzytkownicy where id_budzetu =" + id_budget);

            if(reader != null)
            {
                    while(reader.Read())
                    {
                        comboBox_User_filtr.Items.Add(reader.GetString(0));
                    }

                    comboBox_User_filtr.SelectedIndex = 0;
                
                connector.CloseConnection();
            }
            else MessageBox.Show("Błąd pobierania danych z bazy");
        }

        void updateCategories(ComboBox r, ComboBox c)
        {
            string rodzaj = r.Text;
            if(rodzaj == "Przychód")
            reader = connector.Select("select nazwa from Kategorie where id_budzetu =" + id_budget + " and czy_przychod=true");
            else
                reader = connector.Select("select nazwa from Kategorie where id_budzetu =" + id_budget + " and czy_przychod=false");

            if (reader != null)
            {
                if (reader.HasRows)
                {
                    c.Items.Clear();
                    while (reader.Read())
                    {
                        c.Items.Add(reader.GetString(0));
                    }

                    if (rodzaj == "Przychód" && c.Items.Contains("inne przychody"))
                        c.SelectedIndex = c.Items.IndexOf("inne przychody");
                    else
                        if (c.Items.Contains("inne wydatki"))
                        c.SelectedIndex = c.Items.IndexOf("inne wydatki");
                    else
                        c.SelectedIndex = 0;

                }

                connector.CloseConnection();
            }
            else MessageBox.Show("Błąd pobierania danych z bazy");
        }

        void updateRodzaj(ComboBox c)
        {
            c.Items.Clear();
            
            c.Items.Add("Wydatek");
            c.Items.Add("Przychód");

            c.SelectedIndex = 0;
        }

        private void comboBoxIn_or_out_SelectedIndexChanged(object sender, EventArgs e)
        {
            // kategorie
            updateCategories(comboBoxIn_or_out, comboBox_category);
        }

        private void comboBoxIn_orOut_filtr_SelectedIndexChanged(object sender, EventArgs e)
        {
            // kategorie (filtr)
            updateCategories(comboBoxIn_orOut_filtr, comboBox_category_filtr);
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            bool good = true;

            string rodzaj = comboBoxIn_or_out.Text.ToString();
            string kategoria = comboBox_category.Text.ToString();
            DateTime dateTimeFromWhen = dateTimePickerFromWhen.Value;
            DateTime dateTimeToWhen = dateTimePickerToWhen.Value;

            if(dateTimeFromWhen > dateTimeToWhen)
            {
                good = false;
                MessageBox.Show("Data 'od kiedy' musi być wcześniej niż data 'do kiedy'.'");
            }

            string dateFrom = dateTimeFromWhen.ToShortDateString();
            string dateTo = dateTimeToWhen.ToShortDateString();

            int howOften = -1;

            try
            {
                howOften = Int16.Parse(textBoxHowOften.Text);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException)
                    MessageBox.Show("Nie podałeś co ile tygodni/ miesięcy.");

                if (ex is FormatException)
                    MessageBox.Show("Niepoprawna wartość w polu 'Co ile tygodni/ miesięcy'");

                if (ex is OverflowException)
                    MessageBox.Show("Zbyt duża wartość w polu 'Co ile tygodni/ miesięcy'");

                good = false;
            }

            if (howOften < 1 && good)
            {
                good = false;
                MessageBox.Show("Pole 'Co ile tygodni/ miesięcy musi mieć wartość min. 1.'");
            }

            double kwota = -1;
            string kwota_s = textBoxMoney.Text.ToString();

            if (String.IsNullOrEmpty(textBoxMoney.Text))
            {
                good = false;
                MessageBox.Show("Podaj kwotę.");
            }
            else
            {
                // we need "," for double
                kwota_s = kwota_s.Replace(".", ",");

                try
                {
                    kwota = Convert.ToDouble(kwota_s);
                }
                catch (Exception ex)
                {
                    if (ex is FormatException)
                        MessageBox.Show("Niepoprawna kwota.");

                    if (ex is OverflowException)
                        MessageBox.Show("Zbyt duża kwota.");

                    good = false;
                }
            }

            if (kwota < 0 && good)
            {
                good = false;
                MessageBox.Show("Podana kwota nie może być ujemna.");
            }

            if (good)
            {
                bool income = false;
                if (comboBoxIn_or_out.SelectedItem.ToString() == "Przychód")
                    income = true;

                // for database
                kwota_s = kwota_s.Replace(",", ".");

                // when next operation
                DateTime next = dateTimeFromWhen;
                string next_s;

                string query = "";

                if (checkBoxMonths.Checked)
                {

                    //next = next.AddMonths(howOften);
                    next_s = next.ToShortDateString();
                    query = "insert into Przychody_oplaty_regularne (id_budzetu, kwota, id_uzytkownika, nazwa_kategorii, od_kiedy, do_kiedy, co_ile_tygodni, co_ile_miesiecy, czy_przychod, nast_operacja) values (" + id_budget + ", " + kwota_s + ", '" + login + "','" + kategoria + "', str_to_date('" + dateFrom + "','%d.%m.%Y'), str_to_date('" + dateTo + "','%d.%m.%Y'), -1, " + howOften + ", " + income + ",  str_to_date('" + next_s + "','%d.%m.%Y'))";
                }
                else
                {
                    //next = next.AddDays(7 * howOften);
                    next_s = next.ToShortDateString();
                    query = "insert into Przychody_oplaty_regularne (id_budzetu, kwota, id_uzytkownika, nazwa_kategorii, od_kiedy, do_kiedy, co_ile_tygodni, co_ile_miesiecy, czy_przychod, nast_operacja) values (" + id_budget + ", " + kwota_s + ", '" + login + "','" + kategoria + "', str_to_date('" + dateFrom + "','%d.%m.%Y'), str_to_date('" + dateTo + "','%d.%m.%Y'), " + howOften + ", -1," + income + ",  str_to_date('" + next_s + "','%d.%m.%Y'))";
                }

                if (!connector.Query(query))
                { MessageBox.Show("Błąd połączenia z bazą danych."); }
                else
                {
                    textBoxHowOften.Clear();
                    textBoxMoney.Clear();
                    checkBoxMonths.Checked = false;
                    OnAdded();
                }


                string query_ = "select * from Przychody_oplaty_regularne where id_budzetu =" + id_budget;
                updateTable(query_);

                //---------------------
                // OnAddedReg();

            }

            this.Cursor = Cursors.Default;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string query_ = "select * from Przychody_oplaty_regularne where id_budzetu =" + id_budget;
            if (dataGridView.Rows.Count>0)
            {
                try
                {
                    string rodzaj = dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[0].Value.ToString();
                    string kwota = dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[1].Value.ToString();
                    string odKiedy = dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[2].Value.ToString();
                    string doKiedy = dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[3].Value.ToString();
                    string co_ile_tygodni = dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[4].Value.ToString();
                    string co_ile_miesiecy = dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[5].Value.ToString();
                    string kategoria = dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[6].Value.ToString();
                    string uzytkownik = dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[7].Value.ToString();

                    int czy_przychod = 0;
                    if (rodzaj == "Przychód" || rodzaj == "przychód")
                        czy_przychod = 1;



                    if (String.IsNullOrEmpty(co_ile_tygodni) || co_ile_tygodni == "---")
                    {

                        kwota = kwota.Replace(",",".");
                        
                        reader = connector.Select("select id_przychodu_oplaty_reg from Przychody_oplaty_regularne where id_budzetu = " + id_budget + " and kwota = " + kwota + " and id_uzytkownika = '" + uzytkownik + "' and nazwa_kategorii = '" + kategoria + "' and od_kiedy = str_to_date('" + odKiedy + "', '%d.%m.%Y') and do_kiedy = str_to_date('" + doKiedy + "', '%d.%m.%Y') and co_ile_miesiecy = " + co_ile_miesiecy + " and czy_przychod=" + czy_przychod);
                        if (reader != null && reader.HasRows)
                        {
                            reader.Read();
                            string id_ = reader.GetString(0);

                            connector.CloseConnection();

                            connector.Query("delete from Przychody_oplaty_regularne where id_przychodu_oplaty_reg =" + id_);

                        }



                        updateTable(query_);
                    }
                    else
                    {
                        kwota = kwota.Replace(",", ".");
                        
                        reader = connector.Select("select id_przychodu_oplaty_reg from Przychody_oplaty_regularne where id_budzetu = " + id_budget + " and kwota = " + kwota + " and id_uzytkownika = '" + uzytkownik + "' and nazwa_kategorii = '" + kategoria + "' and od_kiedy = str_to_date('" + odKiedy + "', '%d.%m.%Y') and do_kiedy = str_to_date('" + doKiedy + "', '%d.%m.%Y') and co_ile_tygodni = " + co_ile_tygodni + " and czy_przychod=" + czy_przychod);

                        if (reader != null && reader.HasRows)
                        {
                            reader.Read();
                            string id_ = reader.GetString(0);

                            connector.CloseConnection();

                            connector.Query("delete from Przychody_oplaty_regularne where id_przychodu_oplaty_reg =" + id_);

                        }


                        updateTable(query_);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie wybrano wiersza.");
                }


            }

            this.Cursor = Cursors.Default;
        }

        private void buttonfiltr_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string rodzaj = comboBoxIn_orOut_filtr.Text.ToString();

            bool income = false;
            if (rodzaj == "Przychód")
                income = true;

            string uzytkownik = comboBox_User_filtr.Text.ToString();
            string kategoria = comboBox_category_filtr.Text.ToString();

            string query = "select * from Przychody_oplaty_regularne where id_budzetu =" + id_budget+" and czy_przychod=" +income+" and id_uzytkownika ='"+uzytkownik+"' and nazwa_kategorii='"+kategoria+"'";
            updateTable(query);

            this.Cursor = Cursors.Default;
        }

        private void buttonRenew_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string query =  "select * from Przychody_oplaty_regularne where id_budzetu =" + id_budget;
            updateTable(query);

            this.Cursor = Cursors.Default;
        }

        protected virtual void OnAdded()
        {
            if (AddedReg != null)
                AddedReg(this, EventArgs.Empty);
        }

    }
}
