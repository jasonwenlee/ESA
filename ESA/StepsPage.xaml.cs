﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StepsPage : ContentPage
    {
        public StepsPage()
        {
            InitializeComponent();
        }

        private void SegmentedControlView_SelectedTabIndexChanged(object sender, Controls.SelectedTabIndexEventArgs e)
        {

            if (e.SelectedTabIndex == 0)
            {
                ContentView1.IsVisible = true;
                ContentView2.IsVisible = false;
            }
            if (e.SelectedTabIndex == 1)
            {
                ContentView1.IsVisible = false;
                ContentView2.IsVisible = true;
            }
        }
    }
}