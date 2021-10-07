using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using AvaloniaTreeviewContextMenu.ViewModels;
using ReactiveUI;

namespace AvaloniaTreeviewContextMenu.Views
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public async void PointerPressedOnWinNode(object sender, PointerPressedEventArgs e)
        {
            if (sender is DockPanel packageItem)
            {

                if (e.MouseButton == MouseButton.Right)
                {
                    ((MainWindowViewModel)this.DataContext).ContextMenuItems.Clear();
                    ((MainWindowViewModel)this.DataContext).ContextMenuItems.Add(new MenuItemViewModel()
                    {
                        Header = "New Root Package Item"
                    });

                }
            }
        }
    }
}
