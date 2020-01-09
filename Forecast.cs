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
    public partial class Forecast : Form
    {
        string login;
        int id_budget;

        MySqlConnector connector;
        MySqlDataReader reader;

        public Forecast(string login, int id_budget)
        {
            InitializeComponent();

            this.login = login;
            this.id_budget = id_budget;
            connector = new MySqlConnector();

            textBox_months.Text = "12";
        }

        private void textBox_months_TextChanged(object sender, EventArgs e)
        {
            
            string months_s = textBox_months.Text;

            if (!String.IsNullOrEmpty(months_s) && !String.IsNullOrWhiteSpace(months_s))
            {
                int months = 0;

                try
                {
                    months = Convert.ToInt16(months_s);
                }
                catch (Exception ex)
                {
                    if (ex is FormatException)
                        MessageBox.Show("Niepoprawna liczba miesięcy.");
                    else if (ex is OverflowException)
                        MessageBox.Show("Zbyt duża liczba.");
                }

                if (months < 0)
                    MessageBox.Show("Liczba miesięcy nie może być ujemna");
                else
                {
                    DateTime now = DateTime.Today;
                    now = now.AddMonths(-3);

                    reader = connector.Select("select czy_przychod, kwota from Przychody_wydatki where id_budzetu = " + id_budget + " and data_ > str_to_date('" + now.ToShortDateString() + "','%d.%m.%Y')");

                    double sum = 0;

                    if (reader != null && reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (reader.GetBoolean(0))
                                sum += reader.GetDouble(1);
                            else
                                sum -= reader.GetDouble(1);
                        }
                    }

                    connector.CloseConnection();

                    sum /= 3.0;

                    sum *= months;

                    sum = Math.Round(sum, 2);

                    textBox_forecast.Text = sum.ToString();
                    textBox_forecast.Text += " zł";
                }
            }
        }
    }
}
