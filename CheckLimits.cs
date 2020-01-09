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
    public partial class BudzetManager : Form
    {
        int id_budget;
        string login;

        MySqlConnector connector;
        MySqlDataReader reader;

        DataTable table;

        struct Limit
        {
            public string nazwa;
            public string limit;
            public double wydane_p;
            public string przekroczone;
        }

        List<Limit> list;

        public BudzetManager(int id_budget, string login)
        {
            InitializeComponent();

            this.id_budget = id_budget;
            this.login = login;

            connector = new MySqlConnector();
            table = new DataTable();
            list = new List<Limit>();

            table.Columns.Add("Nazwa kategorii", typeof(string));
            table.Columns.Add("Limit", typeof(string));
            table.Columns.Add("Wydane pieniądze", typeof(double));
            table.Columns.Add("Limit przekroczony o...", typeof(string));

            update(false);
        }

        public void update(bool tylkoPrzekroczone)
        {
            Cursor = Cursors.WaitCursor;


            reader = connector.Select("select nazwa, limit_ from Kategorie where id_budzetu = " + id_budget + " and czy_przychod = false");

            if (reader != null && reader.HasRows)
            {
                list.Clear();

                while (reader.Read())
                {
                    Limit limit = new Limit();
                    limit.nazwa = reader.GetString(0);
                    limit.limit = reader.GetString(1);

                    list.Add(limit);

                }

                connector.CloseConnection();

                double wydane_, przekroczone_, limit_d;


                Limit[] array = list.ToArray();

                for (int i = 0; i < array.Length; i++)
                {
                    reader = connector.Select("select kwota from Przychody_wydatki where id_budzetu = " + id_budget + " and czy_przychod = false and nazwa_kategorii = '" + array[i].nazwa + "'");

                    wydane_ = 0;
                    if (reader != null && reader.HasRows)
                    {
                        while (reader.Read())
                            wydane_ += reader.GetDouble(0);
                    }

                    array[i].wydane_p = wydane_;

                    connector.CloseConnection();

                    try
                    {
                        string limit_s = array[i].limit;
                        limit_s = limit_s.Replace(".", ",");
                        limit_d = Convert.ToDouble(limit_s);

                    } catch (Exception ex)
                    {
                        Console.WriteLine("Covertion exception");
                        limit_d = 0;
                    }

                    przekroczone_ = wydane_ - limit_d;

                    if (przekroczone_ > 0 && limit_d != 0)
                        array[i].przekroczone = przekroczone_.ToString();
                    else
                        array[i].przekroczone = "---";
                }

                // update table
                table.Rows.Clear();

                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.BackColor = Color.PaleVioletRed;

                for (int i = 0; i < array.Length; i++)
                {
                    if (tylkoPrzekroczone)
                    {
                        if (array[i].przekroczone != "---")
                            table.Rows.Add(array[i].nazwa, array[i].limit, array[i].wydane_p, array[i].przekroczone);
                    }
                    else
                        table.Rows.Add(array[i].nazwa, array[i].limit, array[i].wydane_p, array[i].przekroczone);
                }



            }

            dataGridView.AutoGenerateColumns = false;
            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView.DataSource = table;

            Cursor = Cursors.Default;

        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[3].Value.ToString() != "---")
                {
                    row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                }
            }
        }

        public bool checked_()
        {
            if (checkBox_przekroczone_filtr.Checked)
                return true;
            else return false;
        }

        private void checkBox_przekroczone_filtr_CheckedChanged(object sender, EventArgs e)
        {
            update(checkBox_przekroczone_filtr.Checked);
        }
    }
}
