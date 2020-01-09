using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BudzetManager
{
    public partial class Add_inc_outc_mainTab : Form
    {
        string login;
        int id_budget;

        MySqlConnector connector;
        MySqlDataReader reader;

        public delegate void AddedEventHandler(object source, EventArgs args);
        public event AddedEventHandler Added;

        public Add_inc_outc_mainTab(string login, int id_budget)
        {
            this.login = login;
            this.id_budget = id_budget;

            connector = new MySqlConnector();

            InitializeComponent();
            prepare();

        }

        void prepare()
        {
            comboBox_inOr_out.Items.Add("wydatek");
            comboBox_inOr_out.Items.Add("przychód");

            comboBox_inOr_out.SelectedIndex = 0;
            
        }

        private void button_submit_add_Click(object sender, EventArgs e)
        {
            sendToDatabse();
        }

        void updateComboBoxCategories()
        {
            bool czy_przychod = true;
            comboBox_category.Items.Clear();

            if (comboBox_inOr_out.GetItemText(comboBox_inOr_out.SelectedItem) == "przychód")
                czy_przychod = true;
            else
                czy_przychod = false;

            reader = connector.Select("select * from Kategorie where id_budzetu =" + id_budget + " and czy_przychod=" + czy_przychod);

            if (reader != null)
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBox_category.Items.Add(reader.GetString(1));
                    }
                }

                connector.CloseConnection();
            }

            if (czy_przychod && comboBox_category.Items.Contains("inne przychody"))
                comboBox_category.SelectedIndex = comboBox_category.Items.IndexOf("inne przychody");
            else
                if (comboBox_category.Items.Contains("inne wydatki"))
                comboBox_category.SelectedIndex = comboBox_category.Items.IndexOf("inne wydatki");
            else
                comboBox_category.SelectedIndex = 0;
        }

        private void comboBox_inOr_out_SelectedIndexChanged(object sender, EventArgs e)
        {
           updateComboBoxCategories();
        }

        void sendToDatabse()
        {
            this.Cursor = Cursors.WaitCursor;

            //--------- reading from form

            // money
            bool money_good = true;
            string money_s = textBox_money.Text.ToString();

            // we need "," for double
            money_s = money_s.Replace(".", ",");

            double money = 0;

            try
            {
                money = Convert.ToDouble(money_s);
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                    MessageBox.Show("Niepoprawna kwota.");

                if (ex is OverflowException)
                    MessageBox.Show("Za duża kwota.");

                money_good = false;
            }

            if(money < 0)
            {
                money_good = false;
                MessageBox.Show("Nie można podawać ujemnej kwoty.");
            }

            // category
            string category = comboBox_category.GetItemText(comboBox_category.SelectedItem);

            // date
            bool dateGood = true;
            DateTime dateTime = dateTimePicker.Value;
            string date = dateTime.ToShortDateString();


            // check if chosen date is current or in the past
            if (dateTime.Year > DateTime.Today.Year)
                dateGood = false;
            else
            if (dateTime.Year == DateTime.Today.Year)
                if (dateTime.Month > DateTime.Today.Month)
                    dateGood = false;
                else if (dateTime.Month == DateTime.Today.Month)
                    if (dateTime.Day > DateTime.Today.Day)
                        dateGood = false;

            

            // income or outcome
            bool income = true;
            string in_or_out = comboBox_inOr_out.GetItemText(comboBox_inOr_out.SelectedItem);

            if (in_or_out == "wydatek")
                income = false;

            //------ to database
            in_or_out = in_or_out.Replace("w","W");
            in_or_out = in_or_out.Replace("p", "P");

            if (money_good && dateGood)
            {
                string moneyForDataBase = money.ToString();
                moneyForDataBase = moneyForDataBase.Replace(",",".");
                if (connector.Query("insert into Przychody_wydatki (id_budzetu, kwota, nazwa_kategorii, data_, id_uzytkownika, czy_przychod) values (" + id_budget + "," + moneyForDataBase + ",'" + category + "', STR_TO_DATE('" + date + "', '%d.%m.%Y'), '" + login + "', " + income.ToString() + ")"))
                {
                    
                    OnAdded();

                    MessageBox.Show("Dodano.");

                    if (!income)
                    {

                        reader = connector.Select("select kwota from Przychody_wydatki where id_budzetu = " + id_budget + " and nazwa_kategorii ='" + category + "' and czy_przychod = false");

                        double spent = -1;
                        if (reader != null && reader.HasRows)
                        {
                            spent = 0;

                            while (reader.Read())
                                spent += reader.GetDouble(0);

                        }

                        connector.CloseConnection();

                        if (spent != -1)
                        {
                            reader = connector.Select("select limit_ from Kategorie where id_budzetu =" + id_budget + " and nazwa ='" + category + "' and czy_przychod = false");

                            if (reader != null && reader.HasRows)
                            {
                                reader.Read();

                                string l = reader.GetString(0);

                                if (l != "---")
                                {
                                    l = l.Replace(".", ",");

                                    try
                                    {
                                        double l_d = Convert.ToDouble(l);

                                        double r = spent- l_d;

                                        r = Math.Round(r, 2);

                                        if (r > 0)
                                            MessageBox.Show("Uwaga, przekroczyłeś limit w kategorii "+category+" o " + r.ToString() + " zł.");

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Convert exception");
                                    }
                                }
                            }
                            connector.CloseConnection();
                        }

                        
                    }

                    
                    textBox_money.Clear();
                }
                else
                    MessageBox.Show("Nie dodano, błąd bazy danych.");
            }
            else if (!dateGood)
                MessageBox.Show("Nie można wybrać daty, której jeszcze nie było.");


            this.Cursor = Cursors.Default;
        }

        private void textBox_money_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            sendToDatabse();
        }

        private void comboBox_category_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                sendToDatabse();
        }

        private void dateTimePicker_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                sendToDatabse();
        }

        private void comboBox_inOr_out_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                sendToDatabse();
        }

        protected virtual void OnAdded()
        {
            if (Added != null)
                Added(this, EventArgs.Empty);
        }
    }
}
