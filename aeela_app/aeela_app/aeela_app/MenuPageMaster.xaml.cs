using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aeela_app.MenuPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPageMaster : ContentPage
    {
        public ListView ListView => ListViewMenuItems;

        public MenuPageMaster()
        {
            InitializeComponent();
            BindingContext = new MenuPageMasterViewModel();
        }



        class MenuPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MenuPageMenuItem> MenuItems { get; }
            public MenuPageMasterViewModel()
            {
                MenuPageMenuItems = new ObservableCollection<MenuPageMenuItem>(new[]
                {
                    new MenuPageMenuItem { Id = 0, Title = "Page 1" },
                    new MenuPageMenuItem { Id = 1, Title = "Page 2" },
                    new MenuPageMenuItem { Id = 2, Title = "Page 3" },
                    new MenuPageMenuItem { Id = 3, Title = "Page 4" },
                    new MenuPageMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }
    }
}
