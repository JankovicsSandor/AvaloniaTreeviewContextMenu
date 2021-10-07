using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaTreeviewContextMenu.Models
{
    public class PackageItem : ReactiveObject
    {
        private string _sumName;


        /// <summary>
        /// This property holds the name which will be displayed in the treeview
        /// </summary>
        public string DisplayName
        {
            get
            {
                return _sumName;
            }
            set
            {
                _sumName = value;
            }
        }

        /// <summary>
        /// Stores the children list. In case need to add a new item, use AddChildren method.
        /// </summary>
        public ObservableCollection<PackageItem> Children { get; set; }
    }
}
