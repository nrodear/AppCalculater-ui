using WpfAppCalculate.Types;

namespace WpfApp1.Engine
{
    internal class Core
    {
        public List<IItem> Stack = new List<IItem>();

        public Core()
        {
        }

        public Core(List<IItem>? stack)
        {
            if (stack != null)
            {
                this.Stack = stack;
            }
        }


        public void Add(FunctionItem item)
        {
            Stack.Add(item);
        }

        public string TaskToString()
        {
            var result = "";
            foreach (var item in Stack)
            {
                if (item is FunctionItem)
                {
                    var castedItem = (FunctionItem)item;
                    if (castedItem.CalcType == CalcType.Value)
                    {
                        result += castedItem.Value.ToString();
                    }
                    else if (castedItem.CalcType == CalcType.Func)
                    {
                        result += castedItem.Name;
                    }
                }
            }

            return result;
        }

        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}