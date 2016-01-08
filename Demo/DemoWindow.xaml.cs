using System.ComponentModel.Composition;
using System.Windows;

namespace CMTDeveloperRole.Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DemoWindow : Window
    {
        public DemoWindow()
        {
            InitializeComponent();
            DataContext = new DemoWindowViewModel();
        }
    }
}
