
using ESA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ESA.Models;
using ESA.ViewModels;

namespace ESA.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TasoconjuctivalFlapSteps : ContentPage
    {
        public TasoconjuctivalFlapSteps()
        {
            InitializeComponent();
            BindingContext = new TasoconjuctivalFlapStepsViewModel();
        }

        async private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var syselecteditem = e.Item as MyListModel;
             switch(syselecteditem.id)
            {
                case 1:
                    await Navigation.PushAsync(new TasoconjuctivalFlapSteps1());
                    break;
                case 2:
                    await Navigation.PushAsync(new TasoconjuctivalFlapSteps2());
                    break;
            }
        }
    }
}