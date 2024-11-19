using System.Windows;
using System.Windows.Controls;
using WpfApp1;
using WpfApp1.CalcVariants;
using WpfAppCalculate.Types;

namespace WpfAppCalculate.Ui
{
    internal class MainTask
    {
        public void AddDefaultsButtons(MainWindow that, Grid mainGrid, ButtonValues values)
        {
            for (var y = 0; y <= values.GetLengthY; y++)
            {
                for (var x = 0; x <= values.GetLengthX; x++)
                {
                    var item = values.GetItem(y, x);
                    AddButton(that, mainGrid, x, y, item);
                }
            }
        }

        private void AddButton(MainWindow that, Grid mainGrid, int x, int y, IItem item)
        {
            if (that == null) throw new ArgumentNullException(nameof(that));
            if (mainGrid == null) throw new ArgumentNullException(nameof(mainGrid));
            if (item == null) throw new ArgumentNullException(nameof(item));

            const int width = 40;
            const int height = 40;

            var button = OneCharButton.CreateInstance("oneCharButton" + x + y,
                item.Name, width, height);

            that.RegisterName(button.Name, button);
            mainGrid.Children.Add(button);

            if (item is FunctionItem)
            {
                var itemF = (FunctionItem)item;
                //if (itemF != null) button.Click += null; //itemF.Method;
            }


            button.Margin = new Thickness
            {
                Top = y * height + 20,
                Left = x * width + 40
            };
        }
    }
}