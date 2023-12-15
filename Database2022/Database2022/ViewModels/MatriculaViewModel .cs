using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Database2022.ViewModels
{
    public class MatriculaViewModel : BaseViewModel
    {
        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Matricula> matriculas;
        public List<Matricula> Matriculas
        {
            get { return this.matriculas; }
            set { SetValue(ref this.matriculas, value); }
        }


        public ICommand SearchCommand { get; set; }

        public MatriculaViewModel()
        {

            SearchCommand = new Command(() =>
            {
                MatriculaService service = new MatriculaService();
                Matriculas = service.GetByText(Filter);

            });


        }
    }
}