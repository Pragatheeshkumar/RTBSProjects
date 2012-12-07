using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Design
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Window MainWindow = Application.Current.MainWindow;
            //PresentationSource MainWindowPresentationSource = PresentationSource.FromVisual(MainWindow);
            //Matrix m = MainWindowPresentationSource.CompositionTarget.TransformToDevice;
            //DpiWidthFactor = m.M11;
            //DpiHeightFactor = m.M22;
            //double ScreenHeight = SystemParameters.PrimaryScreenHeight * DpiHeightFactor;
            //double ScreenWidth = SystemParameters.PrimaryScreenWidth * DpiWidthFactor;
        }

        
    }
}
