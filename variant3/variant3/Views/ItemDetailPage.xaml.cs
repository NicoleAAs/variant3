using System.ComponentModel;
using Xamarin.Forms;
using variant3.ViewModels;

namespace variant3.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}