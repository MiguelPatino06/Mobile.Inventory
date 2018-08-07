using App.Core.Inventory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace App.Core.Inventory.Data
{
    public class DataMenu : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ObservableCollection<MainMenuItem> MainMenuItems { get; set; }

        public DataMenu()
        {
            LoadMenu();
        }

        void LoadMenu()
        {
            MainMenuItems = new ObservableCollection<MainMenuItem>
            {
                new MainMenuItem{ NavigationPageId=1, Text="Recepcion", Icon="", ClassName="Views.MainMenu.MainMenuDetails" },
                new MainMenuItem{ NavigationPageId=2, Text="Conteo", Icon="", ClassName="" },
                new MainMenuItem{ NavigationPageId=3, Text="Transferencia entre Bodegas", Icon="", ClassName="" },

            };

        }

    }
}
