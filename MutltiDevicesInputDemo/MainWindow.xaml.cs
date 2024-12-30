using System.Diagnostics;
using System.Diagnostics.Contracts;
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

namespace MultiDevicesInputDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.StylusDevice != null) return;
            Console.WriteLine($"UIElement_OnMouseDown");
        }
        private void UIElement_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.StylusDevice != null) return;
            Console.WriteLine("UIElement_OnMouseUp");
        }

        private void UIElement_OnStylusDown(object sender, StylusDownEventArgs e)
        {
            if (e.StylusDevice.TabletDevice.Type != TabletDeviceType.Stylus)
            {
                return;
            }
            Console.WriteLine("UIElement_OnStylusDown");
        }
        private void UIElement_OnStylusUp(object sender, StylusEventArgs e)
        {
            if (e.StylusDevice.TabletDevice.Type != TabletDeviceType.Stylus)
            {
                return;
            }
            Console.WriteLine("UIElement_OnStylusUp");
        }

        private void UIElement_OnTouchDown(object? sender, TouchEventArgs e)
        {
            Console.WriteLine("UIElement_OnTouchDown");
        }
        private void UIElement_OnTouchUp(object? sender, TouchEventArgs e)
        {
            Console.WriteLine("UIElement_OnTouchUp");
        }

        private void UIElement_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.StylusDevice != null) return;
            Console.WriteLine("UIElement_OnPreviewMouseDown");
        }

        private void UIElement_OnPreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.StylusDevice != null) return;
            Console.WriteLine("UIElement_OnPreviewMouseUp");
        }
    }
}