using System.Windows;

namespace Alsoft.Recruitment.FoodStore.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = App.Current.ViewModel;           
        }
    }
}
