using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using ESA.Models.Model;

namespace ESA.ViewModels
{
    public class AzureProceduresViewModel : BaseViewModel
    {
        public ObservableCollection<Procedure> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public AzureProceduresViewModel()
        {
            Items = new ObservableCollection<Procedure>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
