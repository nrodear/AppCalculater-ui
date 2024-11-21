using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using CalcLib;
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
            //var values = new ButtonsStrings();
            var buttonCore = CalcLib.UI.ButtonCore.GetInstance(40, 20);
            buttonCore.AddDefaultsButtons(that, grid, values);

            var width = values.GetX * CalcLib.UI.ButtonCore.Width;

            var textBoxes = new CalcLib.UI.TextBoxes();
            var uiElements = UiElements.Instance;
            uiElements.TextBox = textBoxes.GetTextBox(10, 20, width);
            that.RegisterName("textBox", uiElements.TextBox);
            grid.Children.Add(uiElements.TextBox);
        }
    }
}