using System.Windows;
using System.Windows.Controls;
using CalcLib.Engine;
using CalcLib.UI;

namespace WpfAppCalculate
{
    internal class AppActions()
    {
        public void Init(Window that, Grid grid)
        {
            var mainPanel = new StackPanel();
            that.RegisterName("MainPanel", mainPanel);

            // load type of calc 
            var values = new CalcLib.CalcVariants.ButtonDefaultValues();

            var width = values.GetX * ButtonCore.Width;

            var textBoxes = new TextBoxes();
            var textBox = textBoxes.GetTextBox(10, 20, width);
            Elements.SetTextBox(textBox);
            that.RegisterName("textBox", textBox);
            grid.Children.Add(textBox);

            //var values = new ButtonsStrings();
            var buttonCore = ButtonCore.GetInstance(40, 20);
            buttonCore.AddDefaultsButtons(that, grid, values);
        }
    }
}