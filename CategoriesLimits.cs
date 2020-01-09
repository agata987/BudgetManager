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
    
    public partial class CategoriesLimits : Form
    {
       

        MySqlConnector connector;
        MySqlDataReader reader;

        DataTable table;

        string login;
        int id_budget;

        EditCategory editCategory;

        public CategoriesLimits(string login, int id_budget)
        {
            InitializeComponent();
            connector = new MySqlConnector();

            this.login = login;
            this.id_budget = id_budget;

            table = new DataTable();
            table.Columns.Add("Kategoria",typeof(string));
            table.Columns.Add("Limit miesięczny", typeof(string));
            table.Columns.Add("Opis", typeof(string));
            table.Columns.Add("Rodzaj", typeof(string));

            comboBox_inOr_out.Items.Add("Wydatek");
            comboBox_inOr_out.Items.Add("Przychód");

            comboBox_inOr_out.SelectedIndex = 0;

            comboBox_filtr.Items.Add("Wszystko");
            comboBox_filtr.Items.Add("Wydatek");
            comboBox_filtr.Items.Add("Przychód");

            comboBox_filtr.SelectedIndex = 0;

            string query = "select nazwa, opis, czy_przychod, limit_ from Kategorie where id_budzetu =" + id_budget;
            updateTable(query);
        }

        void updateTable(string query)
        {
            reader = connector.Select(query);

            if(reader != null && reader.HasRows)
            {
                table.Clear();
                while (reader.Read())
                {
                    bool income = reader.GetBoolean(2);
                    String przychod = "";

                    if (income)
                        przychod = "Przychód";
                    else
                        przychod = "Wydatek";

                    table.Rows.Add(reader.GetString(0),reader.GetString(3),reader.GetString(1),przychod);
                }

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.DataSource = table;
            }
            connector.CloseConnection();
        }


        private void button_add_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string opis = richTextBoxOpis.Text;
            string nazwa = textBox_nazwa.Text;
            string limit = textBox_limit.Text;

            bool przychod = false;

            if (comboBox_inOr_out.SelectedItem.ToString() == "Przychód")
                przychod = true;
           
            bool good = true;
            if(String.IsNullOrEmpty(nazwa) || String.IsNullOrWhiteSpace(nazwa))
            {
 
                MessageBox.Show("Podaj nazwę.");
            }
            else
            {
                reader = connector.Select("select nazwa from Kategorie where nazwa ='" +nazwa+"' and czy_przychod = " + przychod);

                if(reader!=null)
                {
                    if(reader.HasRows)
                    {
                        if(przychod)
                        MessageBox.Show("Kategoria o tej nazwie już istnieje dla przychodów.\nWybierz inną nazwę.");
                        else
                        MessageBox.Show("Kategoria o tej nazwie już istnieje dla wydatków.\nWybierz inną nazwę.");

                        good = false;
                    }
                }

                connector.CloseConnection();
                connector.CloseConnection();

                if (good)
                {
                    if (!String.IsNullOrEmpty(limit) && !String.IsNullOrWhiteSpace(limit) && !przychod)
                    {
                        try
                        {
                            limit = limit.Replace(".", ",");
                            double limit_ = Convert.ToDouble(limit);

                            if(limit_ < 0)
                            {
                                good = false;
                                MessageBox.Show("Limit nie może być ujemny.");
                            }
                        }
                        catch (Exception ex)
                        {
                            if (ex is FormatException)
                                MessageBox.Show("Niepoprawna wartość pola 'limit'");

                            else if (ex is OverflowException)
                                MessageBox.Show("Za duża wartość w polu limit.");

                            good = false;
                        }
                    }
                    else
                    {
                        limit = "---";
                    }


                    if (String.IsNullOrEmpty(opis) && String.IsNullOrWhiteSpace(opis))
                        opis = "---";

                    

                    if (good)
                    {
                        if(connector.Query("insert into Kategorie (nazwa, id_budzetu, opis, czy_przychod, limit_) values ('" + nazwa + "'," + id_budget + ", '" + opis + "'," + przychod + ", '" + limit + "')"))
                        {
                            MessageBox.Show("Dodano.");

                            string filtr = comboBox_filtr.Text;
                            string query;

                            if (filtr == "Wszystko")
                                query = "select nazwa, opis, czy_przychod, limit_ from Kategorie where id_budzetu =" + id_budget;
                            else if (filtr == "Wydatek")
                                query = "select nazwa, opis, czy_przychod, limit_ from Kategorie where id_budzetu =" + id_budget + " and czy_przychod = false";
                            else
                                query = query = "select nazwa, opis, czy_przychod, limit_ from Kategorie where id_budzetu =" + id_budget + " and czy_przychod = true";

                            updateTable(query);
                        }
                        
                    }
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if(dataGridView1.Rows.Count>0)
            {
                string kategoria = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
                string rodzaj = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3].Value.ToString();

                bool income = false;
                if (rodzaj == "Przychód")
                    income = true;

                reader = connector.Select("select id_kategorii from Kategorie where nazwa = '" +kategoria+ "' and czy_przychod = " + income);


                if(reader != null && reader.HasRows)
                {
                    reader.Read();
                    string id_ = reader.GetString(0);

                    connector.CloseConnection();

                    if(connector.Query("delete from Kategorie where id_kategorii = "+id_))
                    {
                        //MessageBox.Show("Kategoria usunięta");

                        string filtr = comboBox_filtr.Text;
                        string query;

                        if (filtr == "Wszystko")
                            query = "select nazwa, opis, czy_przychod, limit_ from Kategorie where id_budzetu =" + id_budget;
                        else if (filtr == "Wydatek")
                            query = "select nazwa, opis, czy_przychod, limit_ from Kategorie where id_budzetu =" + id_budget + " and czy_przychod = false";
                        else
                            query = query = "select nazwa, opis, czy_przychod, limit_ from Kategorie where id_budzetu =" + id_budget + " and czy_przychod = true";


                        updateTable(query);
                    }

                    
                }
                connector.CloseConnection();


            }

            this.Cursor = Cursors.Default;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows[0].Index > -1)
            {
                string kategoria = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
                string rodzaj = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3].Value.ToString();
                string id_ = "";

                bool income = false;
                if (rodzaj == "Przychód")
                    income = true;

                reader = connector.Select("select id_kategorii from Kategorie where nazwa = '" + kategoria + "' and czy_przychod = " + income);

                if (reader != null && reader.HasRows)
                {
                    reader.Read();
                    id_ = reader.GetString(0);

                    connector.CloseConnection();
                }
                connector.CloseConnection();



                editCategory = new EditCategory(id_);
                editCategory.Edited += this.OnEdited;
                editCategory.Show();
            }

            this.Cursor = Cursors.Default;
        }

        public void OnEdited(object o, EventArgs eventArgs)
        {
            string filtr = comboBox_filtr.Text;
            string query;

            if (filtr == "Wszystko")
                query = "select nazwa, opis, czy_przychod, limit_ from Kategorie where id_budzetu =" + id_budget;
            else if (filtr == "Wydatek")
                query = "select nazwa, opis, czy_przychod, limit_ from Kategorie where id_budzetu =" + id_budget + " and czy_przychod = false";
            else
                query = query = "select nazwa, opis, czy_przychod, limit_ from Kategorie where id_budzetu =" + id_budget + " and czy_przychod = true";

            updateTable(query);
        }

        private void comboBox_filtr_SelectedIndexChanged(object sender, EventArgs e)
        {

            string filtr = comboBox_filtr.Text;
            string query;

            if (filtr == "Wszystko")
                query = "select nazwa, opis, czy_przychod, limit_ from Kategorie where id_budzetu =" + id_budget;
            else if (filtr == "Wydatek")
                query = "select nazwa, opis, czy_przychod, limit_ from Kategorie where id_budzetu =" + id_budget + " and czy_przychod = false";
            else
                query = query = "select nazwa, opis, czy_przychod, limit_ from Kategorie where id_budzetu =" + id_budget + " and czy_przychod = true";


            updateTable(query);
        }
    }
}
