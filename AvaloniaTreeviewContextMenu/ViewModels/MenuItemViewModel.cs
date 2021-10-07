using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AvaloniaTreeviewContextMenu.ViewModels
{
    /// <summary>
    /// Based on <see cref="https://docs.avaloniaui.net/docs/controls/menu#dynamically-creating-menus"/>
    /// </summary>
    public class MenuItemViewModel : ReactiveObject
    {

        private string _header;
        private ICommand _command;
        private object _commandParameter;
        public ObservableCollection<MenuItemViewModel> Items;

        public string Header
        {
            get { return _header; }
            set { this.RaiseAndSetIfChanged(ref _header, value); }
        }

        public ICommand Command
        {
            get { return _command; }
            set { this.RaiseAndSetIfChanged(ref _command, value); }
        }

        public object CommandParameter
        {
            get { return _commandParameter; }
            set { this.RaiseAndSetIfChanged(ref _commandParameter, value); }
        }

    }
}
