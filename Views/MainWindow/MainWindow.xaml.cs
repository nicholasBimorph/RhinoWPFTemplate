using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;
using RhinoWPFSample.ViewModels;

namespace RhinoWPFSample.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SampleViewModel _sampleViewModel;
        public MainWindow(SampleViewModel sampleViewModel)
        {
            ColorZoneAssist.SetMode(new Button(), ColorZoneMode.Light);

            _sampleViewModel = sampleViewModel;

            this.DataContext = sampleViewModel;

            this.SetWindowHandle();

            InitializeComponent();
        }

        private void SetWindowHandle()
        {
            
            var handle = _sampleViewModel.HostApplicationWindowHandle;

            var helper = new WindowInteropHelper(this) { Owner = handle };

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
