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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double temp = 0;
        string output = "";
        string operation = "Minus";

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            DivideBtn.Content = "\u00F7";
        }

        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch(name)
            {
                case "ZeroBtn":
                    output += "0";
                    OutputTextBlock.Text = output;
                    break;

                case "OneBtn":
                    output += "1";
                    OutputTextBlock.Text = output;
                    break;

                case "TwoBtn":
                    output += "2";
                    OutputTextBlock.Text = output;
                    break;

                case "ThreeBtn":
                    output += "3";
                    OutputTextBlock.Text = output;
                    break;

                case "FourBtn":
                    output += "4";
                    OutputTextBlock.Text = output;
                    break;

                case "FiveBtn":
                    output += "5";
                    OutputTextBlock.Text = output;
                    break;

                case "SixBtn":
                    output += "6";
                    OutputTextBlock.Text = output;
                    break;

                case "SevenBtn":
                    output += "7";
                    OutputTextBlock.Text = output;
                    break;

                case "EightBtn":
                    output += "8";
                    OutputTextBlock.Text = output;
                    break;

                case "NineBtn":
                    output += "9";
                    OutputTextBlock.Text = output;
                    break;

                case "PlusBtn":
                    output += "+";
                    OutputTextBlock.Text = output;
                    break;

                case "MinusBtn":
                    output += "-";
                    OutputTextBlock.Text = output;
                    break;
            }
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if(output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Minus";
            }
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Plus";
            }
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "Minus":
                    double MinusoutputTemp = temp - double.Parse(output);
                    output = MinusoutputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "Plus":
                    double PlusoutputTemp = temp + double.Parse(output);
                    output = PlusoutputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;
            }
        }

        
    }
}
