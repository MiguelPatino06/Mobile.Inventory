using App.Core.Inventory.Data;
using App.Core.Inventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace App.Core.Inventory.ViewModels
{
    public class MainMenuMasterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

     
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ObservableCollection<MainMenuItem> MainMenuItems { get; set; }

        public DataMenu Data { get; set; }

        public ObservableCollection<MainMenuItem> MenuItems { get; set; }

        public MainMenuMasterViewModel()
        {
            Data = new DataMenu();
            MenuItems = Data.MainMenuItems;
        }

        public void MenuItemTapped(MainMenuItem item)
        {
            var mdp = App.Current.MainPage as MasterDetailPage;
            var nmspace = App.Instance.GetType().Namespace;
            var clsname = string.Format("{0}.{1}", nmspace, item.ClassName);
            Type pagetyp = Type.GetType(clsname, true);
            var page = (Page)Activator.CreateInstance(pagetyp);
            page.Title = item.Text;
            if (mdp != null)
                mdp.Detail = new MasterDetailPage();

            mdp.IsPresented = false;
           
        }
    }
}
