using ESA.Models;
using ESA.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StepsView : ContentView
    {
        private ObservableCollection<StepsPageViewModel> getContents;
        private ObservableCollection<StepsPageViewModel> _expandedContent;
        public StepsView()
        {
            InitializeComponent();
               
  //          BindingContext = new StepsPageViewModel();
            getContents = StepsPageViewModel.Contents;
            UpdateListContent();
        }
        private void HeaderTapped(object sender, EventArgs args)
        {
            int ListselectedIndex = _expandedContent.IndexOf(
                ((StepsPageViewModel)((Button)sender).CommandParameter));
            getContents[ListselectedIndex].Expanded = !getContents[ListselectedIndex].Expanded;

            UpdateListContent();
        }
        private void UpdateListContent()
        
            {
            _expandedContent = new ObservableCollection<StepsPageViewModel>();
                foreach (StepsPageViewModel group in getContents)
                {
                    StepsPageViewModel steps = new StepsPageViewModel(group.Title, group.Expanded);
                    steps.StepsItems = group.Count;
                    if (group.Expanded)
                    {
                        foreach (StepsPageModel step in group)
                        {
                            steps.Add(step);
                        }
                    }
                _expandedContent.Add(steps);
            }
                MyListView.ItemsSource =_expandedContent;
            }
        }
    }
