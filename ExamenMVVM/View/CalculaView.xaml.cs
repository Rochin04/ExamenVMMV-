using ExamenMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenMVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculaView : ContentPage
    {
        public CalculaView()
        {
            InitializeComponent();
            BindingContext = new FrecuenciaCardiaca(Navigation);
        }
    }
}