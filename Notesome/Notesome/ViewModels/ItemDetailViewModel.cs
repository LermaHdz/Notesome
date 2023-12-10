using Notesome.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Notesome.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string titulo;
        private string descripcion;
        public string Id { get; set; }

        public string Titulo
        {
            get => titulo;
            set => SetProperty(ref titulo, value);
        }

        public string Descripcion
        {
            get => descripcion;
            set => SetProperty(ref descripcion, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Titulo = item.Titulo;
                Descripcion = item.Descripcion;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
