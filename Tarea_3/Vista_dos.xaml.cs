using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea_3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vista_dos : ContentPage
    {
        public Vista_dos( )
        {
            InitializeComponent();
            
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new MainPage());

        }
    }
}