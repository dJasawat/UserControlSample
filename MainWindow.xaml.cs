using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserControlSample.ViewModels;

namespace UserControlSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TextViewModel model = new TextViewModel();
            DataContext = model;
        }


        private void btnDatePickerButton_Click(object sender, RoutedEventArgs e)
        {
            DatePickerViewModel model = new DatePickerViewModel();

            DataContext = model;

        }

        private void btnComboButton_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxViewModel model = new ComboBoxViewModel();
            DataContext = model;

        }

        private void btnTextButton_Click(object sender, RoutedEventArgs e)
        {
            TextViewModel model = new TextViewModel();
            DataContext = model;
        }
    }
}