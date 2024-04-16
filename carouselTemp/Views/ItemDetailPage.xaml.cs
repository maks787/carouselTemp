using carouselTemp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace carouselTemp.Views
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