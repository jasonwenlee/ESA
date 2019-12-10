﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateProcedure : ContentPage
    {
        public CreateProcedure()
        {
            InitializeComponent();
        }

        private async void CreateButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProcedureType());
        }

        private async void ListButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListProcedures());
        }
    }
}