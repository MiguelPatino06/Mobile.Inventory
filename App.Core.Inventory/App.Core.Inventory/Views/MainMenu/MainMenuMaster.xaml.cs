using App.Core.Inventory.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using App.Core.Inventory.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Core.Inventory.Views.MainMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuMaster : ContentPage
    {
        public ListView ListView;
        private MainMenuMasterViewModel Model;

        public MainMenuMaster()
        {
            InitializeComponent();
            Model = new MainMenuMasterViewModel();
            BindingContext = Model;
            ListView = MenuItemsListView;
        }

        private void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as MainMenuItem;
            if (item == null)
                return;

            Model.MenuItemTapped(item);
        }
    }
}