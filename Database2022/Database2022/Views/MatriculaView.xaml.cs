using Database2022.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Database2022.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatriculaView : ContentPage
    {
        public MatriculaView()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MatriculaService service = new MatriculaService();
            List<Matricula> matriculas = new List<Matricula>();
            matriculas.Add(new Matricula { Date = dpDate.Date, Name = txtName.Text, Curso = txtCurso.Text, Gender = rbHombre.IsChecked == true ? "Hombre" : "Mujer" });
            service.CreateRange(matriculas);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            MatriculaService service = new MatriculaService();
            lvMatriculas.ItemsSource = service.Get();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            MatriculaService service = new MatriculaService();
            lvMatriculas.ItemsSource = service.GetByText(txtFilter.Text.Trim());
        }
    }
}