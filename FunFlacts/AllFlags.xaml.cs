using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlagData;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlagData
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllFlags : ContentPage
    {
        public AllFlags()
        {
            InitializeComponent();
            flags.ItemsSource = DependencyService.Get<FunFlactsViewModel>().Flags;
            BindingContext = DependencyService.Get<FunFlactsViewModel>();
        }
    }
}