using CalcLib;
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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CalcLib.UI;

namespace WpfAppCalculate
{
    public partial class WindowMain : Window
    {
        public WindowMain()
        {
            InitializeComponent();

            var actions = new AppActions();
            actions.Init(this, MainGrid);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var uiElements = UiElements.Instance;
            uiElements.TextBox.Text = "done";
        }
    }
}
