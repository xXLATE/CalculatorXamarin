using Calc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calc.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalcPage : ContentPage
    {
        public CalcPage()
        {
            InitializeComponent();
            BindingContext = new CalcPageViewModel();
        }
    }
}