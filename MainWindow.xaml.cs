using System.Windows;
using System.Windows.Controls;
using WpfApp1.CalcVariants;
using WpfAppCalculate.Ui;

namespace WpfAppCalculate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            var mainPanel = new StackPanel();
            RegisterName("MainPanel", mainPanel);

            var values = new ButtonValues();
            //var values = new ButtonsStrings();
            var main2 = new MainTask();
            main2.AddDefaultsButtons(this, mainGrid, values);
        }
    }
}