using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace FilmCataloger
{
    public partial class AdditionForm : Form
    {
        string connectionString;
        public AdditionForm()
        {
            InitializeComponent();
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.ShowUpDown = true;
            connectionString = $@"Data Source={System.Environment.CurrentDirectory}\filmDB;Version=3;";
        }


        private void butAdd_Click(object sender, EventArgs e)
        {

            DateTime film_len = DateTime.Parse(dateTimePicker1.Text);
            DateTime watch_film = DateTime.Parse(dateTimePicker2.Text);
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty && Convert.ToInt32(textBox3.Text) >= 1896 && film_len >= watch_film)
            {

                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {

                    try
                    {
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.CommandText = @"INSERT INTO films (
                      Author,
                      Name,
                      Year,
                      Category,
                      Status,
                      Watched,
                      Film_lenght
                  )
                  VALUES (
                      @Author,
                      @Name,
                      @Year,
                      @Category,
                      @Status,
                      @Watched,
                      @Film_lenght
                  );";
                        cmd.Connection = con;
                        cmd.Parameters.Add(new SQLiteParameter("@Author", textBox1.Text));
                        cmd.Parameters.Add(new SQLiteParameter("@Name", textBox2.Text));
                        cmd.Parameters.Add(new SQLiteParameter("Year", textBox3.Text));
                        cmd.Parameters.Add(new SQLiteParameter("@Category", textBox4.Text));
                        cmd.Parameters.Add(new SQLiteParameter("@Status", comboBox1.Text));
                        cmd.Parameters.Add(new SQLiteParameter("@Watched", dateTimePicker2.Text));
                        cmd.Parameters.Add(new SQLiteParameter("@Film_lenght", dateTimePicker1.Text));
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("Сохранение!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    Hide();
                    Greeting greeting = new Greeting();
                    greeting.Show();
                }

            }

            else
            {
                string lineFour = "Не заполнены следущие поля:\r\n";
                if (textBox1.Text == string.Empty) { lineFour += "- Автор\r\n"; textBox1.BackColor = Color.DarkRed; }
                else textBox1.BackColor = Color.White;
                if (textBox2.Text == string.Empty) { lineFour += "- Название\r\n"; textBox2.BackColor = Color.DarkRed; }
                else textBox2.BackColor = Color.White;
                if (textBox3.Text == string.Empty) { lineFour += "- Год \r\n"; textBox3.BackColor = Color.DarkRed; }
                else textBox3.BackColor = Color.White;
                if (textBox4.Text == string.Empty) { lineFour += "- Жанр\r\n"; textBox4.BackColor = Color.DarkRed; }
                else textBox4.BackColor = Color.White;
                if (comboBox1.Text == string.Empty) { lineFour += "- Cтатус\r\n"; comboBox1.BackColor = Color.DarkRed; }
                else comboBox1.BackColor = Color.White;

                if (film_len < watch_film)
                {
                    { lineFour += "- Просмотренно\r\n"; dateTimePicker2.BackColor = Color.DarkRed; }
                    MessageBox.Show("Хронометраж меньше просмотренного времени");
                }
                if (textBox3.Text != string.Empty)
                    if (Convert.ToInt16(textBox3.Text) < 1896)
                        MessageBox.Show("Не верный год");
                MessageBox.Show(lineFour, "Не заполнены поля!", MessageBoxButtons.OK);
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            Hide();
            Greeting greeting = new Greeting();
            greeting.Show();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char buff = e.KeyChar;
            if (!Char.IsLetter(buff))
            {
                if (e.KeyChar != (char)Keys.Back)
                    if (e.KeyChar != (char)Keys.Space)
                        e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char buff = e.KeyChar;
            if (!Char.IsLetter(buff))
            {
                if (e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            }

        }



    }
}
