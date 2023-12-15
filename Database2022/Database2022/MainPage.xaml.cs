﻿using Database2022.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Database2022
{
    public partial class MainPage : ContentPage
    {        
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MatriculaService service = new MatriculaService();
            List<Person> people = new List<Person>();

            for (int i = 0; i < 3; i++)            
                people.Add(new Person { FirstName = txtName.Text, Fecharegister = txtName.Text, NameCurso = txtName.Text, Sexo = txtName.Text });

            //service.Create(new Person { LastName = txtLastName.Text, FirstName = txtName.Text });

            service.CreateRange(people);
            
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            MatriculaService service = new MatriculaService();
            lvPeople.ItemsSource= service.Get();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            MatriculaService service = new MatriculaService();            
            lvPeople.ItemsSource = service.GetByText(txtFilter.Text.Trim());
        }
    }
}