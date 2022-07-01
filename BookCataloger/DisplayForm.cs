using BookCataloger;
using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;

namespace FilmCataloger
{
    public partial class DisplayForm : Form
    {
        public static short _id = 0;
        private List<Film> _list;

        public DisplayForm()
        {
            InitializeComponent();
            _list = new List<Film>();
            bsFilm.DataSource = _list;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            Hide();
            Greeting greeting = new Greeting();
            greeting.Show();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            _list.Clear();
            List<Film> list = SqlliteHelper.GetFilms();
            if (list != null && list.Count > 0)
            {
                _list.AddRange(list);
                bsFilm.ResetBindings(false);
            }
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var film = (Film)bsFilm.Current;
            Hide();
            EditingForm editing = new EditingForm();
            editing.Film = film;
            editing.Show();
        }

       
    }
}
