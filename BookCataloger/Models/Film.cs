using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FilmCataloger.Model
{
   public class Film :IBindableComponent
    {
        ISite iSite;
        ControlBindingsCollection dataBindings;
        BindingContext bindingContext = new BindingContext();

        public Film()
        {
            dataBindings = new ControlBindingsCollection(this);
        }
        [Browsable(false)]
        public event EventHandler Disposed;
        [Browsable(false)]
        public void Dispose()
        {
            //your code for disposing
        }
        [Browsable(false)]
        public BindingContext BindingContext
        {
            get { return bindingContext; }
            set { bindingContext = value; }
        }
        [Browsable(false)]
        public ControlBindingsCollection DataBindings
        {
            get { return dataBindings; }
        }
        [Browsable(false)]
        public ISite Site
        {
            get { return iSite; }
            set { iSite = value; }
        }

        [DisplayName("ID")]
        [Browsable(false)]
        public int ID { get; set; }
        [DisplayName("Автор")]
        public string Author { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Год выпуска")]
        public string Year { get; set; }
        [DisplayName("Жанр")]
        public string Category { get; set; }
        [DisplayName("Статус")]
        public string Status { get; set; }
        [DisplayName("Просмотренно")]
        public string Watched { get; set; }
        [DisplayName("Хронометраж")]
        public string Film_lenght { get; set; }

    }
}
