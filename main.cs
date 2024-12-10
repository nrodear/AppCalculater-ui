using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using LibCalc.Engine;
using LibCalc.Types;
using LibCalc.UI;
using Microsoft.Win32;

namespace AppCalculator
{
    internal class AppActions()
    {
        private Window window;
        private StackPanel mainPanel = new StackPanel();
        private Grid? grid;

        public void Init(Window window, Grid grid)
        {
            if (window == null) throw new ArgumentNullException(nameof(window));
            if (grid == null) throw new ArgumentNullException(nameof(grid));

            this.window = window;
            this.grid = grid;
        }

        private void AddUiButtons(IButtonValues values)
        {
            grid?.Children.Clear();

            // load type of calc 
            // IButtonValues values = new StandardCalc.Standard.ButtonValues();
            // IButtonValues values = new ButtonValues();

            var width = values.GetX * ButtonCore.Width;

            var textBoxes = new TextBoxes();
            var textBox = textBoxes.GetTextBox(10, 20, width);
            Elements.SetTextBox(textBox);
            grid.Children.Add(textBox);

            //var values = new ButtonsStrings();
            var buttonCore = ButtonCore.GetInstance(40, 20);
            buttonCore.AddDefaultsButtons(window, grid, values);
        }


        private string GetFilenameDialog()
        {
            string path = @"C:\Users\ngerlach\source\repos\wpf_calc";
            OpenFileDialog dialog = new OpenFileDialog()
            {
                FileName = path,
              DefaultExt  = "*.dll"
                
            };
            dialog.ShowDialog();
            return dialog.FileName;
        }

        public void LoadAssembly()
        {
            var file = GetFilenameDialog();
            var assembly = Assembly.LoadFrom(file);

            Type type = assembly.GetTypes().First(t => t.Name.Contains("ButtonValues"));

            var buttonValues = Activator.CreateInstance(type) as IButtonValues;

            AddUiButtons(buttonValues);
        }
    }
}