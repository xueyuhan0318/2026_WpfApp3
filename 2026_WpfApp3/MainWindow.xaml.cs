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

namespace _2026_WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Color strokerColor = Colors.Black;
        Color fillColor = Colors.Transparent;
        int strokeThickness = 1;
        string ShapeType = "Line";
        public MainWindow()
        {
            InitializeComponent();
            StrokerColorPicker.SelectedColor = strokerColor;
            FillColorPicker.SelectedColor = fillColor;
        }

        private void ShapeButton_Checked(object sender, RoutedEventArgs e)
        {
            var targetShapeButton = sender as RadioButton;
            ShapeType = targetShapeButton.Content.ToString();
            DisplayStutas();
        }

        private void StrokerColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            strokerColor = (Color)StrokerColorPicker.SelectedColor;
            DisplayStutas();
        }

        private void DisplayStutas()
        {
            if (ColorLabel != null) ColorLabel.Content = $"筆刷色彩:{strokerColor}      填充色彩:{fillColor}      筆刷粗細:{strokeThickness}"; 
            if (ShapeLabel != null) ShapeLabel.Content = $"形狀:{ShapeType}";
        }

        private void FillColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            fillColor = (Color)FillColorPicker.SelectedColor;
            DisplayStutas();
        }

        private void ThicknessSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            strokeThickness = (int)ThicknessSlider.Value;
            DisplayStutas();
        }
    }
}