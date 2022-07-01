using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmCataloger.Model;
using System.IO;

namespace FilmCataloger
{
    public partial class Greeting : Form
    {
        private static List<Film> listOfFilms = new List<Film>();
        internal static List<Film> ListOfFilms { get => listOfFilms; set => listOfFilms = value; }

        public Greeting()
        {
            InitializeComponent();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Hide();
            AdditionForm additionForm = new AdditionForm();
            additionForm.Show();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butView_Click(object sender, EventArgs e)
        {
            Hide();
            DisplayForm displayForm = new DisplayForm();
            displayForm.Show();
        }

        private void Greeting_Load(object sender, EventArgs e)
        {
            listOfFilms.Clear();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            Hide();
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }
    }
}
