using System.Windows;

namespace AppCalculator
{
    public partial class WindowMain : Window
    {
        private AppActions actions;

        public WindowMain()
        {
            InitializeComponent();

            actions = new AppActions(this, MainGrid);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            actions.LoadAssembly();
        }
    }
}
