using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinMaxDefaultWPF;

namespace MinMaxDefaultWPF.Controller
{
    class MainWindowController
    {
        private string[] _numTypeArray = new string[11] { "byte", "sbyte","short",
            "ushort","int","uint","long","ulong","float","double", "decimal"};

        private MainWindow _mainWindow;

        public MainWindowController(MainWindow linkToActiveMainWindow)
        {
            this._mainWindow = linkToActiveMainWindow;
            linkToActiveMainWindow.NumericTypeCB.ItemsSource = _numTypeArray;
        }

        public void DisplayData(object selectedItem)
        {
            switch(selectedItem as string)
            {
                case "byte":
                    {
                        _mainWindow.MinValueTBck.Text = byte.MinValue.ToString();
                        _mainWindow.DefaultValueTBck.Text = 0.ToString();
                        _mainWindow.MaxValueTBck.Text = byte.MaxValue.ToString();
                        break;
                    }
                case "sbyte":
                    {
                        _mainWindow.MinValueTBck.Text = sbyte.MinValue.ToString();
                        _mainWindow.DefaultValueTBck.Text = 0.ToString();
                        _mainWindow.MaxValueTBck.Text = sbyte.MaxValue.ToString();
                        break;
                    }
                case "short":
                    {
                        _mainWindow.MinValueTBck.Text = short.MinValue.ToString();
                        _mainWindow.DefaultValueTBck.Text = 0.ToString();
                        _mainWindow.MaxValueTBck.Text = short.MaxValue.ToString();
                        break;
                    }
                case "ushort":
                    {
                        _mainWindow.MinValueTBck.Text = ushort.MinValue.ToString();
                        _mainWindow.DefaultValueTBck.Text = 0.ToString();
                        _mainWindow.MaxValueTBck.Text = ushort.MaxValue.ToString();
                        break;
                    }
                case "int":
                    {
                        _mainWindow.MinValueTBck.Text = int.MinValue.ToString();
                        _mainWindow.DefaultValueTBck.Text = 0.ToString();
                        _mainWindow.MaxValueTBck.Text = int.MaxValue.ToString();
                        break;
                    }
                case "uint":
                    {
                        _mainWindow.MinValueTBck.Text = uint.MinValue.ToString();
                        _mainWindow.DefaultValueTBck.Text = 0.ToString();
                        _mainWindow.MaxValueTBck.Text = uint.MaxValue.ToString();
                        break;
                    }
                case "long":
                    {
                        _mainWindow.MinValueTBck.Text = long.MinValue.ToString();
                        _mainWindow.DefaultValueTBck.Text = "0L";
                        _mainWindow.MaxValueTBck.Text = long.MaxValue.ToString();
                        break;
                    }
                case "ulong":
                    {
                        _mainWindow.MinValueTBck.Text = ulong.MinValue.ToString();
                        _mainWindow.DefaultValueTBck.Text = 0.ToString();
                        _mainWindow.MaxValueTBck.Text = ulong.MaxValue.ToString();
                        break;
                    }
                case "float":
                    {
                        _mainWindow.MinValueTBck.Text = float.MinValue.ToString();
                        _mainWindow.DefaultValueTBck.Text = "0.0F";
                        _mainWindow.MaxValueTBck.Text = float.MaxValue.ToString();
                        break;
                    }
                case "double":
                    {
                        _mainWindow.MinValueTBck.Text = double.MinValue.ToString();
                        _mainWindow.DefaultValueTBck.Text = "0.0D";
                        _mainWindow.MaxValueTBck.Text = double.MaxValue.ToString();
                        break;
                    }
                case "decimal":
                    {
                        _mainWindow.MinValueTBck.Text = decimal.MinValue.ToString();
                        _mainWindow.DefaultValueTBck.Text = "0.0M";
                        _mainWindow.MaxValueTBck.Text = decimal.MaxValue.ToString();
                        break;
                    }
            }
        }
    }
}
