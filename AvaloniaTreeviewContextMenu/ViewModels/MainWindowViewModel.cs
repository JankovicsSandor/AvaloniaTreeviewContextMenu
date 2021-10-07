using AvaloniaTreeviewContextMenu.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AvaloniaTreeviewContextMenu.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<PackageItem> WindowsList { get; set; }

        public ObservableCollection<MenuItemViewModel> ContextMenuItems { get; set; }


        public MainWindowViewModel()
        {

            WindowsList = new ObservableCollection<PackageItem>()
            {
                new PackageItem(){DisplayName="Item1",Children=new ObservableCollection<PackageItem>(){
                    new PackageItem(){DisplayName="Item1.1"}
                    }
                }
            };
            ContextMenuItems = new ObservableCollection<MenuItemViewModel>();
        }
    }
}
