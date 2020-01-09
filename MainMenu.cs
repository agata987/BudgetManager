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
using System.Threading;

namespace BudzetManager
{
    public partial class MainMenu : Form
    {
        MySqlConnector connector;
        MySqlDataReader reader;

        bool logged;

        string login;
        string administrator;
        int id_budget;

        UserManager userManager;
        Add_inc_outc_mainTab add_Inc_Outc_MainTab;
        InAndOut_REG_mainTab inAndOut_REG_MainTab;
        CategoriesLimits categoriesLimits;
        BudzetManager checkLimits;
        Forecast forecast;
        FinancialSt financialSt;

        DataTable tableHistory;

        struct Przychod_wydatek
        {
           public int id;
           public DateTime now;
           public double kwota;
           public string nazwa_kategorii;
           public bool czy_przychod;
           public DateTime nast_opr;
        }

        //----------budget
        double budget;

        public MainMenu(string login, int id_budget)
        {
            this.Cursor = Cursors.WaitCursor;

            InitializeComponent();
            this.login = login;
            this.id_budget = id_budget;
            logged = true;

            connector = new MySqlConnector();
            tableHistory = new DataTable();

            prepare();

            this.Cursor = Cursors.Default;
        }

        public bool getLogged()
        {
            return logged;
        }

        void button_logout_konto_Click(object sender, EventArgs e)
        {
            logged = false;
            Close();
        }

        void prepare()
        {
            updateBudget_R();
            prepareMainTab();
            prepareHistoryTab();
            preprareAccountTab();
        }

        void prepareMainTab()
        {
            labelUserName_mainTab.Text = "Witaj "+login + "!";
            updateBudget();
        }

        void prepareHistoryTab()
        {
            tableHistory.Columns.Add("Rodzaj", typeof(string));
            tableHistory.Columns.Add("Kwota", typeof(double));
            tableHistory.Columns.Add("Data", typeof(string));
            tableHistory.Columns.Add("Kategoria", typeof(string));
            tableHistory.Columns.Add("Uzytkownik", typeof(string));


            comboBox_income_history.Items.Add("Wszystko");
            comboBox_income_history.Items.Add("Przychód");
            comboBox_income_history.Items.Add("Wydatek");
            comboBox_income_history.SelectedIndex = 0;

            comboBox_month_history.Items.Add("Wszystko");
            comboBox_month_history.Items.Add("Styczeń");
            comboBox_month_history.Items.Add("Luty");
            comboBox_month_history.Items.Add("Marzec");
            comboBox_month_history.Items.Add("Kwiecień");
            comboBox_month_history.Items.Add("Maj");
            comboBox_month_history.Items.Add("Czerwiec");
            comboBox_month_history.Items.Add("Lipiec");
            comboBox_month_history.Items.Add("Sierpień");
            comboBox_month_history.Items.Add("Wrzesień");
            comboBox_month_history.Items.Add("Październik");
            comboBox_month_history.Items.Add("Listopad");
            comboBox_month_history.Items.Add("Grudzień");
            comboBox_month_history.SelectedIndex = 0;

            reader = connector.Select("select id_uzytkownika from Uzytkownicy where id_budzetu = " + id_budget);

            comboBox_user_history.Items.Add("Wszystko");
            if (reader != null && reader.HasRows)
            {
                while(reader.Read())
                {
                    comboBox_user_history.Items.Add(reader.GetString(0));
                }
            }

            connector.CloseConnection();
            comboBox_user_history.SelectedIndex = 0;

            reader = connector.Select("select nazwa from Kategorie where id_budzetu =" + id_budget);
            comboBox_category_history.Items.Add("Wszystko");
            if (reader != null && reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox_category_history.Items.Add(reader.GetString(0));
                }
            }

            connector.CloseConnection();
            comboBox_category_history.SelectedIndex = 0;

            updateHistoryGridView();

            
        }

        void updateSum_history()
        {
            double sum = 0;

            if (dataGridView_history.Rows.Count > 0)
            {
                string value, income;

                foreach (DataGridViewRow row in dataGridView_history.Rows)
                {
                    value = row.Cells[1].Value.ToString();
                    income = row.Cells[0].Value.ToString();
                    try
                    {
                        if(income == "Wydatek")
                        sum -= Convert.ToDouble(value);
                        else
                            sum += Convert.ToDouble(value);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Convertion ex");
                    }
                }
            }

            sum = Math.Round(sum,2);
            textBox_sum_history.Text = "Razem: " + sum + " zł";
        }

        void updateHistoryGridView()
        {
            string query = "select czy_przychod, kwota, data_, nazwa_kategorii, id_uzytkownika  from Przychody_wydatki where id_budzetu = " + id_budget;

            string uzytkownik, rodzaj, miesiac, rok, kategoria;

            // uzytkownik
            if (comboBox_user_history.Text == "Wszystko")
                uzytkownik = "";
            else
                uzytkownik = " and id_uzytkownika = " + comboBox_user_history.Text;

            // rodzaj
            if (comboBox_income_history.Text == "Wszystko")
                rodzaj = "";
            else if (comboBox_income_history.Text == "Wydatek")
                rodzaj = " and czy_przychod = false";
            else
                rodzaj = " and czy_przychod = true";

            // miesiac
            if (comboBox_month_history.Text == "Wszystko")
                miesiac = "";
            else if (comboBox_month_history.Text == "Styczeń")
                miesiac = " and MONTH(data_) = 1";
            else if (comboBox_month_history.Text == "Luty")
                miesiac = " and MONTH(data_) = 2";
            else if (comboBox_month_history.Text == "Marzec")
                miesiac = " and MONTH(data_) = 3";
            else if (comboBox_month_history.Text == "Kwiecień")
                miesiac = " and MONTH(data_) = 4";
            else if (comboBox_month_history.Text == "Maj")
                miesiac = " and MONTH(data_) = 5";
            else if (comboBox_month_history.Text == "Czerwiec")
                miesiac = " and MONTH(data_) = 6";
            else if (comboBox_month_history.Text == "Lipiec")
                miesiac = " and MONTH(data_) = 7";
            else if (comboBox_month_history.Text == "Sierpień")
                miesiac = " and MONTH(data_) = 8";
            else if (comboBox_month_history.Text == "Wrzesień")
                miesiac = " and MONTH(data_) = 9";
            else if (comboBox_month_history.Text == "Październik")
                miesiac = " and MONTH(data_) = 10";
            else if (comboBox_month_history.Text == "Listopad")
                miesiac = " and MONTH(data_) = 11";
            else 
                miesiac = " and MONTH(data_) = 12";

            // rok
            bool good_rok = true;
            if (String.IsNullOrEmpty(textBox_year_history.Text) || String.IsNullOrWhiteSpace(textBox_year_history.Text))
                rok = "";
            else
            {
                rok = textBox_year_history.Text;
                

                try
                {
                    int rok_int = Convert.ToInt16(rok);

                    if (rok_int < 0)
                        good_rok = false;

                } catch(Exception ex)
                {
                    good_rok = false;
                }

                if (!good_rok)
                    MessageBox.Show("Niepoprawny rok.");
                else
                {
                    rok = " and YEAR(data_) =" + rok;
                }

            }

            // kategoria
            if (comboBox_category_history.Text == "Wszystko")
                kategoria = "";
            else
                kategoria = " and nazwa_kategorii = '" + comboBox_category_history.Text + "'";

            if (good_rok)
            {

                query = query + uzytkownik + rodzaj + miesiac + rok + kategoria + " order by data_ desc";

                reader = connector.Select(query);

                tableHistory.Rows.Clear();
                bool rodzaj_b;
                string rodzaj_s;

                DateTime date_t;
                string date_s;

                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rodzaj_b = reader.GetBoolean(0);

                        if (rodzaj_b)
                            rodzaj_s = "Przychód";
                        else
                            rodzaj_s = "Wydatek";

                        date_t = reader.GetDateTime(2);
                        date_s = date_t.ToShortDateString();

                        tableHistory.Rows.Add(rodzaj_s, reader.GetString(1), date_s, reader.GetString(3), reader.GetString(4));
                    }
                }

                dataGridView_history.AutoGenerateColumns = false;
                dataGridView_history.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView_history.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView_history.DataSource = tableHistory;

                connector.CloseConnection();

                updateSum_history();
            }
        }

        void preprareAccountTab()
        {
            textBox_login_konto.Text = login;

            reader = connector.Select("select id_administratora from Budzety where id_budzetu ="+id_budget);

            if (reader.HasRows && reader != null)
            {
                reader.Read();
                administrator = reader.GetString(0);
                connector.CloseConnection();
            }
            else
                administrator = "?(błąd bazy danych)";

            textBox_admin_konto.Text = administrator;

            if (login == administrator)
            {
                textBox_admin_konto.Text += " (ty)";

                button_manage_konto.Enabled = true;
            }
        }

        void button_changePass_konto_Click(object sender, EventArgs e)
        {

            changePassword();
        }

        void changePassword()
        {
            textBox_ChangePass_konto.BackColor = Color.White;
            textBox_repeatPass_konto.BackColor = Color.White;


            if (!String.IsNullOrWhiteSpace(textBox_ChangePass_konto.Text) && !String.IsNullOrWhiteSpace(textBox_repeatPass_konto.Text))
            {
                if (textBox_ChangePass_konto.Text == textBox_repeatPass_konto.Text)
                {
                    string pass = textBox_ChangePass_konto.Text;
                    connector.Query("update Uzytkownicy set haslo = '" + pass + "' where id_uzytkownika = '" + login + "'");

                    reader = connector.Select("select haslo from Uzytkownicy where id_uzytkownika='" + login + "'");

                    if (reader.HasRows && reader != null)
                    {
                        reader.Read();

                        if (reader.GetString(0) == pass)
                            MessageBox.Show("Hasło zmienione poprawnie!");
                        else
                            MessageBox.Show("Błąd zmiany hasła!");

                        connector.CloseConnection();
                    }
                    else
                        MessageBox.Show("Błąd zmiany hasła!");


                }
                else
                    textBox_repeatPass_konto.BackColor = Color.PaleVioletRed;
            }
            else
            {
                if (String.IsNullOrWhiteSpace(textBox_ChangePass_konto.Text))
                    textBox_ChangePass_konto.BackColor = Color.PaleVioletRed;


                if (String.IsNullOrWhiteSpace(textBox_repeatPass_konto.Text))
                    textBox_repeatPass_konto.BackColor = Color.PaleVioletRed;
            }
        }

        private void textBox_ChangePass_konto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                changePassword();
        }

        private void textBox_repeatPass_konto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                changePassword();
        }

        private void button_delete_acc_konto_Click(object sender, EventArgs e)
        {
            if(login == administrator)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "\t\tJesteś administratorem.\n" +
                    "  Usunięcie Twojego konta spowoduje usunięcie budżetu\n" +
                    "        wraz z powiązanymi z budżetem użytkownikami.\n" +
                    "\t\t      Usunąć budżet?"
                    , "Usuwanie budżetu...", MessageBoxButtons.OKCancel);

                if(dialogResult == DialogResult.OK)
                {
                    this.Enabled = false;
                    Cursor.Current = Cursors.WaitCursor;

                    bool good = true;
                    
                        connector.Query("delete from Budzety where id_budzetu=" + id_budget);

                        reader = connector.Select("select * from Budzety where id_budzetu=" + id_budget);

                        if (reader != null)
                        {
                            if (reader.HasRows)
                            {   good = false;
                                MessageBox.Show("Błąd usuwania budzetu."); 
                            }

                            connector.CloseConnection();
                        }
                        else MessageBox.Show("Błąd usuwania budzetu.");

                        
                        if(good)
                        {
                            MessageBox.Show("Budżet został usunięty.");
                            logged = false;
                            Close();
                        }
                        else
                        {
                            this.Enabled = true;
                            Cursor.Current = Cursors.Default;
                        }

                    

                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Czy na pewno chcesz usunąć konto?"
                    , "Usuwanie konta...", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK)
                {

                    connector.Query("delete from Uzytkownicy where id_uzytkownika = '" + login + "'");

                    reader = connector.Select("select * from Uzytkownicy where id_uzytkownika ='" + login + "'");

                    if (reader != null)
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Użytkownik usunięty z bazy!");
                            logged = false;
                            Close();
                        }
                        else MessageBox.Show("Błąd usuwania użytkownika.");

                        connector.CloseConnection();
                    }
                    else MessageBox.Show("Błąd usuwania użytkownika.");

                }
            }

        }

        private void button_manage_konto_Click(object sender, EventArgs e)
        {
            userManager = new UserManager(login, id_budget);
            userManager.Show();
        }

        void updateBudget()
        {
            reader = connector.Select("select * from Przychody_wydatki where id_budzetu ="+id_budget);

            if (reader != null)
            {
                budget = 0;
                if (reader.HasRows)
                {
                    double income, outcome;

                    while (reader.Read())
                    {
                        income = 0;
                        outcome = 0;

                        if (reader.GetBoolean(6) == true)
                            income = reader.GetDouble(2);
                        else
                            outcome = reader.GetDouble(2);

                        budget += income;
                        budget -= outcome;
                    }
                }

                connector.CloseConnection();

                budget = Math.Round(budget,2);
                textBox_setBudget_mainTab.Text = budget.ToString();
                textBox_setBudget_mainTab.Text += " zł";
            }
            else
                MessageBox.Show("Błąd aktualizacji budżetu. (Brak połączenia z bazą danych.)");

            try
            {
                checkLimits.update(checkLimits.checked_());
            } catch (Exception ex)
            {
                Console.WriteLine("Window closed ex");
            }
        }

        private void buttonAdd_inc_out_mainTab_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                add_Inc_Outc_MainTab.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Window closed ex");
            }

            add_Inc_Outc_MainTab = new Add_inc_outc_mainTab(login, id_budget);
            add_Inc_Outc_MainTab.Added += this.OnAdded;
            add_Inc_Outc_MainTab.Show();

            this.Cursor = Cursors.Default;
        }

        public void OnAdded(object source, EventArgs e)
        {
            updateBudget();
            updateHistoryGridView();
        }

        public void OnAddedReg(object source, EventArgs e)
        {
            updateBudget_R();
            updateBudget();
            updateHistoryGridView();
        }

        private void button_manage_reg_mainTab_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                inAndOut_REG_MainTab.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Window closed ex");
            }

            inAndOut_REG_MainTab = new InAndOut_REG_mainTab(login, id_budget);
            inAndOut_REG_MainTab.AddedReg += this.OnAddedReg;
            inAndOut_REG_MainTab.Show();

            this.Cursor = Cursors.Default;
        }

        private void button_cat_limits_mainTab_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                add_Inc_Outc_MainTab.Close();
            } catch (Exception ex)
            {
                Console.WriteLine("Window closed ex");
            }

            try
            {
                inAndOut_REG_MainTab.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Window closed ex");
            }

            try
            {
                categoriesLimits.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Window closed ex");
            }

            try
            {
                checkLimits.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Window closed ex");
            }

            categoriesLimits = new CategoriesLimits(login,id_budget);
            categoriesLimits.Show();

            this.Cursor = Cursors.Default;
        }

        // przychody i wydatki regularne
        void updateBudget_R()
        {
            DateTime dataTeraz = DateTime.Today;

            bool add_cos = true;
            bool add_cos2;

            List<Przychod_wydatek> list = new List<Przychod_wydatek>();

            while (add_cos)
            {
                add_cos2 = false;
                list.Clear();
                reader = connector.Select("select * from Przychody_oplaty_regularne where id_budzetu = " + id_budget);

                if (reader != null && reader.HasRows)
                {


                    while (reader.Read())
                    {

                        DateTime doKiedy = reader.GetDateTime(6);
                        DateTime nastOper = reader.GetDateTime(10);

                        int co_ile_tygodni = reader.GetInt16(7);
                        int co_ile_miesiecy = reader.GetInt16(8);

                        bool co_ile_tygodni_b = true;
                        if (co_ile_tygodni == -1)
                            co_ile_tygodni_b = false;

                        if (czy_pozniej_lub_rowne(dataTeraz, nastOper) && czy_pozniej_lub_rowne(doKiedy, dataTeraz))
                        {
                            add_cos2 = true;

                            Przychod_wydatek p = new Przychod_wydatek();

                            p.id = reader.GetInt32(0);
                            p.czy_przychod = reader.GetBoolean(9);
                            p.kwota = reader.GetDouble(2);
                            p.nazwa_kategorii = reader.GetString(4);
                            p.now = nastOper;

                            if (co_ile_tygodni_b)
                                nastOper = nastOper.AddDays(co_ile_tygodni * 7);
                            else
                                nastOper = nastOper.AddMonths(co_ile_miesiecy);

                            p.nast_opr = nastOper;

                            list.Add(p);

                        }



                    }

                    connector.CloseConnection();

                    foreach (Przychod_wydatek p in list)
                    {
                        string kwota = p.kwota.ToString();
                        kwota = kwota.Replace(",",".");

                        if(connector.Query("insert into Przychody_wydatki (id_budzetu, kwota, nazwa_kategorii, data_, id_uzytkownika, czy_przychod) values(" + id_budget + ", " + kwota + ", '" + p.nazwa_kategorii + "', str_to_date('" + p.now.ToShortDateString() + "', '%d.%m.%Y'), '" + login + "', " + p.czy_przychod.ToString() + ")"))
                        connector.Query("update Przychody_oplaty_regularne set nast_operacja = str_to_date('" + p.nast_opr.ToShortDateString() + "','%d.%m.%Y') where id_przychodu_oplaty_reg = " + p.id);

                    }

                }
              

                add_cos = add_cos2;

                connector.CloseConnection();

                
            }


            

        }

        // czy pierwsza data jest pozniej niz druga bez uwzglednienia czasu
        bool czy_pozniej_lub_rowne(DateTime date1, DateTime date2)
        {
            if (date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day)
                return true;

            if (date1.Year > date2.Year)
                return true;
            else if (date1.Month > date2.Month && date1.Year == date2.Year)
                return true;
            else if (date1.Day > date2.Day && date1.Month == date2.Month && date1.Year == date2.Year)
                return true;
            else
                return false;
        }

        private void button_checkLimits_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                checkLimits.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Window closed ex");
            }

            checkLimits = new BudzetManager(id_budget, login);
            checkLimits.Show();

            Cursor = Cursors.Default;
        }

        private void comboBox_income_history_SelectedIndexChanged(object sender, EventArgs e)
        {


            string czy_przychod = "";

             if (comboBox_income_history.SelectedItem == "Wydatek")
            {
                czy_przychod = " and czy_przychod = false";
            } else if (comboBox_income_history.SelectedItem == "Przychód")
            {
                czy_przychod = " and czy_przychod = true";
            }

            reader = connector.Select("select nazwa from Kategorie where id_budzetu =" + id_budget + czy_przychod);
            
            if (reader != null && reader.HasRows)
            {
                comboBox_category_history.Items.Clear();
                comboBox_category_history.Items.Add("Wszystko");
                while (reader.Read())
                {
                    comboBox_category_history.Items.Add(reader.GetString(0));
                }
                comboBox_category_history.SelectedIndex = 0;
            }

            connector.CloseConnection();
        }

        private void buttonfiltr_history_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            updateHistoryGridView();

            Cursor = Cursors.Default;
        }

        private void buttonRenew_history_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            comboBox_user_history.SelectedIndex = 0;
            comboBox_month_history.SelectedIndex = 0;
            textBox_year_history.Clear();
            comboBox_income_history.SelectedIndex = 0;
            comboBox_category_history.SelectedIndex = 0;

            updateHistoryGridView();
            Cursor = Cursors.Default;
        }

        private void dataGridView_history_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_history.ClearSelection();
        }

        private void button_prognozaFinansowa_Click(object sender, EventArgs e)
        {
            try
            {
                forecast.Close();
            } catch(Exception ex)
            {
                Console.WriteLine("Closed window ex");
            }

            forecast = new Forecast(login, id_budget);
            forecast.Show();
        }

        private void button_zestawieniaFinansowe_Click(object sender, EventArgs e)
        {
            try
            {
                financialSt.Close();
            } catch(Exception ex)
            {

            }

            financialSt = new FinancialSt(login, id_budget);
            financialSt.Show();
        }
    }
}
