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
    public partial class EditCategory : Form
    {
        public delegate void EditedEventHandler(object source, EventArgs args);
        public event EditedEventHandler Edited;

        string id_category;
        MySqlConnector connector;
        MySqlDataReader reader;

        string name = "";
        string opis = "";
        string limit = "";

        public EditCategory(string id_category)
        {
            this.id_category = id_category;
            connector = new MySqlConnector();

            InitializeComponent();

            prepare();
        }

        void prepare()
        {
            reader = connector.Select("select nazwa, opis, limit_ from Kategorie where id_kategorii = "+id_category);

            if (reader != null && reader.HasRows)
            {
                reader.Read();
                name = reader.GetString(0);
                opis = reader.GetString(1);
                limit = reader.GetString(2);
            }
            connector.CloseConnection();

            textBoxLimit.Text = limit;
            this.richTextBoxOpis.Text = opis;
            label_category_name.Text = "EDYTOWANIE KATEGORII\n" + name;
        }

        private void button_submit_confirm_Click(object sender, EventArgs e)
        {
            edit();
        }

        protected virtual void OnEdited()
        {
            if (Edited != null)
                Edited(this, EventArgs.Empty);
        }

        private void textBoxLimit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                edit();
        }

        void edit()
        {
            this.Cursor = Cursors.WaitCursor;

            opis = richTextBoxOpis.Text;

            limit = textBoxLimit.Text;


            bool good = true;

            if (!String.IsNullOrEmpty(limit) && !String.IsNullOrWhiteSpace(limit))
            {
                double limit_d;
                try
                {
                    limit = limit.Replace(".", ",");
                    limit_d = Convert.ToDouble(limit);

                    if (limit_d < 0)
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
            else limit = "---";

            if (good)
            {
                if (connector.Query("update Kategorie set opis = '" + opis + "',limit_ = '" + limit + "' where id_kategorii = " + id_category))
                {
                    OnEdited();
                    Close();
                }
                else
                    MessageBox.Show("Błąd połączenia z bazą danych.");
            }

            this.Cursor = Cursors.Default;
        }
    }
}
