﻿using ESA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        PersonViewModel pvm;
        public AboutPage()
        {
            InitializeComponent();
            pvm = new PersonViewModel();
            BindingContext = pvm;
        }
    }
}