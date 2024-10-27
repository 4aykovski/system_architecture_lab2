using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using Utils.Database;

namespace View.Forms
{
    public partial class MainForm : Form
    {
        Database _db;

        public MainForm(Database database)
        {
            _db = database;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand();

            command.Connection = _db.GetConnection();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = stmtBox.Text;

            try
            {
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    sqlView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("smth went wrong", ex.Message);
            }

            command.Dispose();
        }
    }
}