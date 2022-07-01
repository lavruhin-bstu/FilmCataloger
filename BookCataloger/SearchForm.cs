using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FilmCataloger
{
    public partial class SearchForm : Form
    {
        string connectionString = $@"Data Source={System.Environment.CurrentDirectory}\filmDB;Version=3;";
        private List<Film> _list;
        public SearchForm()
        {
            InitializeComponent();
            
            dataGridView1.AutoGenerateColumns = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Greeting greeting = new Greeting();
            greeting.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Keyword = textBox1.Text;

            DataSet ds = new DataSet(); 

            string sql = $"SELECT * FROM films   WHERE Author = '{Keyword}' OR Name = '{Keyword}'  OR Year = '{Keyword}'  OR Category= '{Keyword}' OR Status = '{Keyword}' OR Watched = '{Keyword}' OR Film_lenght = '{Keyword}'; "; //Sql запрос (достать все из таблицы customer)


            string keyword = string.Format("%{0}%", textBox1.Text);


            SQLiteConnection conn = new SQLiteConnection(connectionString); 

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
           
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            conn.Close();
        }
    }
}
