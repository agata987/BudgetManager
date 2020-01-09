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
    public partial class FinancialSt : Form
    {
        string login;
        int id_budget;
        MySqlConnector connector;
        MySqlDataReader reader;
        DataTable table;

        public FinancialSt(string login, int id_budget)
        {
            this.login = login;
            this.id_budget = id_budget;
            connector = new MySqlConnector();
            table = new DataTable();

            InitializeComponent();

            prepare();
        }

        void prepare()
        {
            comboBox_month.Items.Add("Wszystko");
            comboBox_month.Items.Add("Styczeń");
            comboBox_month.Items.Add("Luty");
            comboBox_month.Items.Add("Marzec");
            comboBox_month.Items.Add("Kwiecień");
            comboBox_month.Items.Add("Maj");
            comboBox_month.Items.Add("Czerwiec");
            comboBox_month.Items.Add("Lipiec");
            comboBox_month.Items.Add("Sierpień");
            comboBox_month.Items.Add("Wrzesień");
            comboBox_month.Items.Add("Październik");
            comboBox_month.Items.Add("Listopad");
            comboBox_month.Items.Add("Grudzień");

            comboBox_month.SelectedIndex = 0;

            table.Columns.Add("DataUtworzenia", typeof(string));
            table.Columns.Add("SumaWydatkow", typeof(string));
            table.Columns.Add("SumaPrzychodow", typeof(string));
            table.Columns.Add("Miesiac", typeof(string));
            table.Columns.Add("Rok", typeof(string));

            updateGridView();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string miesiac = getSelectQueryMonth();
            string rok = getSelectQueryYear();

            if (rok != "bad")
            {
                string query = "select czy_przychod, kwota from Przychody_wydatki where id_budzetu = " + id_budget + rok + miesiac;
                reader = connector.Select(query);

                double sumP = 0;
                double sumW = 0;

                if (reader.HasRows && reader != null)
                {
                    
                    while (reader.Read())
                    {

                        if (reader.GetBoolean(0))
                            sumP += reader.GetDouble(1);
                        else
                            sumW += reader.GetDouble(1);
                    }

                }

                connector.CloseConnection();

                miesiac = comboBox_month.Text;

                if (miesiac == "Wszystko")
                    miesiac = "---";

                rok = textBox_year.Text;

                if (String.IsNullOrEmpty(rok) || String.IsNullOrWhiteSpace(rok))
                    rok = "---";

                DateTime now = DateTime.Today;
                string now_s = now.ToShortDateString();

                sumP = Math.Round(sumP,2);
                sumW = Math.Round(sumW, 2);

                string sumP_s = sumP.ToString();
                string sumW_s = sumW.ToString();

                sumP_s = sumP_s.Replace(",",".");
                sumW_s = sumW_s.Replace(",",".");

                connector.Query("insert into Zestawienia_finansowe (id_budzetu, suma_wydatkow, suma_przychodow, miesiac, rok, data_utworzenia) values ("+id_budget+", "+sumW_s+", "+sumP_s+", '"+miesiac+"', '"+rok+ "', str_to_date('" + now_s + "','%d.%m.%Y'))");

                comboBox_month.SelectedIndex = 0;
                textBox_year.Clear();


                updateGridView();
            }

            
        }

        void updateGridView()
        {
            string miesiac = comboBox_month.SelectedItem.ToString();
            string rok;

            if (miesiac == "Wszystko")
                miesiac = "";
            else
                miesiac = " and miesiac = '" + miesiac + "'";

            bool good_rok = true;
            if (String.IsNullOrEmpty(textBox_year.Text) || String.IsNullOrWhiteSpace(textBox_year.Text))
                rok = "";
            else
            {
                rok = textBox_year.Text;

                try
                {
                    int rok_int = Convert.ToInt16(rok);

                    if (rok_int < 0)
                        good_rok = false;

                }
                catch (Exception ex)
                {
                    good_rok = false;
                }

                if (!good_rok)
                    MessageBox.Show("Niepoprawny rok.");
                else
                {
                    rok = " and rok= '" + rok +"'";
                }

            }

            if (good_rok)
            {
                reader = connector.Select("select data_utworzenia, suma_wydatkow, suma_przychodow, miesiac, rok From Zestawienia_finansowe where id_budzetu = " + id_budget + miesiac + rok + " order by data_utworzenia desc");
                table.Rows.Clear();

                if (reader != null && reader.HasRows)
                {
                    DateTime d;
                    string d_s;

                    while (reader.Read())
                    {
                        d = reader.GetDateTime(0);
                        d_s = d.ToShortDateString();

                        table.Rows.Add(d_s, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                    }
                }

                connector.CloseConnection();
            }

            dataGridView.AutoGenerateColumns = false;
            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView.DataSource = table;
        }

        string getSelectQueryMonth()
        {
            string miesiac;

            // miesiac
            if (comboBox_month.Text == "Wszystko")
                miesiac = "";
            else if (comboBox_month.Text == "Styczeń")
                miesiac = " and MONTH(data_) = 1";
            else if (comboBox_month.Text == "Luty")
                miesiac = " and MONTH(data_) = 2";
            else if (comboBox_month.Text == "Marzec")
                miesiac = " and MONTH(data_) = 3";
            else if (comboBox_month.Text == "Kwiecień")
                miesiac = " and MONTH(data_) = 4";
            else if (comboBox_month.Text == "Maj")
                miesiac = " and MONTH(data_) = 5";
            else if (comboBox_month.Text == "Czerwiec")
                miesiac = " and MONTH(data_) = 6";
            else if (comboBox_month.Text == "Lipiec")
                miesiac = " and MONTH(data_) = 7";
            else if (comboBox_month.Text == "Sierpień")
                miesiac = " and MONTH(data_) = 8";
            else if (comboBox_month.Text == "Wrzesień")
                miesiac = " and MONTH(data_) = 9";
            else if (comboBox_month.Text == "Październik")
                miesiac = " and MONTH(data_) = 10";
            else if (comboBox_month.Text == "Listopad")
                miesiac = " and MONTH(data_) = 11";
            else
                miesiac = " and MONTH(data_) = 12";

            return miesiac;
        }

        string getSelectQueryYear()
        {
            string rok;

            // rok
            bool good_rok = true;
            if (String.IsNullOrEmpty(textBox_year.Text) || String.IsNullOrWhiteSpace(textBox_year.Text))
                rok = "";
            else
            {
                rok = textBox_year.Text;

                try
                {
                    int rok_int = Convert.ToInt16(rok);

                    if (rok_int < 0)
                        good_rok = false;

                }
                catch (Exception ex)
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

            if (!good_rok)
                rok = "bad";

            return rok;
        }

        private void buttonfiltr_Click(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void buttonRenew_Click(object sender, EventArgs e)
        {
            comboBox_month.SelectedIndex = 0;
            textBox_year.Clear();

            updateGridView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string dataUtworzenia = dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[0].Value.ToString();
            string sumaWydatkow = dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[1].Value.ToString();
            string sumaPrzychodow = dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[2].Value.ToString();
            string miesiac = dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[3].Value.ToString();
            string rok = dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[4].Value.ToString();


            reader = connector.Select("select id_zestawienia from Zestawienia_finansowe where data_utworzenia = str_to_date('" + dataUtworzenia + "','%d.%m.%Y') and suma_wydatkow = " + sumaWydatkow +" and suma_przychodow = " + sumaPrzychodow + " and miesiac = '" + miesiac + "' and rok = '" + rok + "'");

            if(reader != null && reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt16(0);

                connector.CloseConnection();

                connector.Query("delete from Zestawienia_finansowe where id_zestawienia =" + id);

                updateGridView();
            }

            connector.CloseConnection();
        }
    }
}
