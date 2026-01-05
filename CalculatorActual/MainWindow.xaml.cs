using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorActual
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 





    public partial class MainWindow : Window
    {

        // our operating variables
        public float FirstNumber;
        public float LastNumber;
        public float Result;
        public string ResultString;

        public string FirstNumberString;
        public string LastNumberString;

        public float MemoryNumber;
        public string MemoryNumberString;

        public bool OperatorSelected;
        public bool PlusOperatorSelected;
        public bool MinusOperatorSelected;
        public bool MultiplyOperatorSelected;
        public bool DivisionOperatorSelected;

        //max allowed decimal number 
        public bool FirstNumberComma;
        public int MaxDecimalLenght;

        string[] decimalSeparated = new string[2];

        public MainWindow()
        {
            InitializeComponent();

            FirstNumber = 0;
            LastNumber = 0;
            Display.Text = FirstNumber.ToString();

            ResultString = string.Empty;
            FirstNumberString = string.Empty;
            LastNumberString = string.Empty;
            MemoryNumberString = string.Empty;


            OperatorSelected = false;

            PlusOperatorSelected = false;
            MinusOperatorSelected = false;
            MultiplyOperatorSelected = false;
            DivisionOperatorSelected = false;

            //for handling decimals
            FirstNumberComma = false;
            MaxDecimalLenght = 6;

            // decimalSeparated
            //decimalSeparated. ;
            //decimalSeparated[0] = "";
            //decimalSeparated[1] = "";
            decimalSeparated[0] = "";
            decimalSeparated[1] = "";


        }

        private void Button_9(object sender, RoutedEventArgs e)
        {
            if (FirstNumberString == string.Empty && !OperatorSelected)
            {
                FirstNumberString = "9";
                Display.Text = FirstNumberString;
            }
            else if ( FirstNumberString != string.Empty && !OperatorSelected && float.Parse(FirstNumberString) < 1000000.0f)
            {
                FirstNumberString = FirstNumberString + "9";
                Display.Text = FirstNumberString;
            }


        }

        private void Button_8(object sender, RoutedEventArgs e)
        {
            if (FirstNumberString == string.Empty && !OperatorSelected)
            {
                FirstNumberString = "8";
                Display.Text = FirstNumberString;
            }
            else if (FirstNumberString != string.Empty && !OperatorSelected && float.Parse(FirstNumberString) < 1000000.0f)
            {
                FirstNumberString = FirstNumberString + "8";
                Display.Text = FirstNumberString;
            }

        }

        private void Button_7(object sender, RoutedEventArgs e)
        {
            if (FirstNumberString == string.Empty && !OperatorSelected)
            {
                FirstNumberString = "7";
                Display.Text = FirstNumberString;
            }
            else if (FirstNumberString != string.Empty && !OperatorSelected && float.Parse(FirstNumberString) < 1000000.0f)
            {
                FirstNumberString = FirstNumberString + "7";
                Display.Text = FirstNumberString;
            }

        }

        private void Button_AC(object sender, RoutedEventArgs e)
        {
            FirstNumberString = string.Empty;
            LastNumberString = string.Empty;
            MemoryNumberString = string.Empty;
            Display.Text = FirstNumberString;
            MemoryDisplay.Text = string.Empty;
            FirstNumberComma = false;
        }

        private void Button_6(object sender, RoutedEventArgs e)
        {
            if (FirstNumberString == string.Empty && !OperatorSelected)
            {
                FirstNumberString = "6";
                Display.Text = FirstNumberString;
            }
            else if (FirstNumberString != string.Empty && !OperatorSelected && float.Parse(FirstNumberString) < 1000000.0f)
            {
                FirstNumberString = FirstNumberString + "6";
                Display.Text = FirstNumberString;
            }
        }

        private void Button_5(object sender, RoutedEventArgs e)
        {
            if (FirstNumberString == string.Empty && !OperatorSelected)
            {
                FirstNumberString = "5";
                Display.Text = FirstNumberString;
            }
            else if (FirstNumberString != string.Empty && !OperatorSelected && float.Parse(FirstNumberString) < 1000000.0f)
            {
                FirstNumberString = FirstNumberString + "5";
                Display.Text = FirstNumberString;
            }
        }

        private void Button_4(object sender, RoutedEventArgs e)
        {
            if (FirstNumberString == string.Empty && !OperatorSelected)
            {
                FirstNumberString = "4";
                Display.Text = FirstNumberString;
            }
            else if (FirstNumberString != string.Empty && !OperatorSelected && float.Parse(FirstNumberString) < 1000000.0f)
            {
                FirstNumberString = FirstNumberString + "4";
                Display.Text = FirstNumberString;
            }
        }

        private void Button_MC(object sender, RoutedEventArgs e)
        {
            MemoryNumber = 0;
            MemoryNumberString = MemoryNumber.ToString();
            MemoryDisplay.Text = string.Empty;
        }

        private void Button_3(object sender, RoutedEventArgs e)
        {
            if (FirstNumberString == string.Empty && !OperatorSelected)
            {
                FirstNumberString = "3";
                Display.Text = FirstNumberString;
            }
            else if (FirstNumberString != string.Empty && !OperatorSelected && float.Parse(FirstNumberString) < 1000000.0f)
            {
                FirstNumberString = FirstNumberString + "3";
                Display.Text = FirstNumberString;
            }
        }

        private void Button_2(object sender, RoutedEventArgs e)
        {
            if (FirstNumberString == string.Empty && !OperatorSelected)
            {
                FirstNumberString = "2";
                Display.Text = FirstNumberString;
            }
            else if (FirstNumberString != string.Empty && !OperatorSelected && float.Parse(FirstNumberString) < 1000000.0f)
            {
                FirstNumberString = FirstNumberString + "2";
                Display.Text = FirstNumberString;
            }

        }

        private void Button_1(object sender, RoutedEventArgs e)
        {
            if (FirstNumberString == string.Empty && !OperatorSelected)
            {
                FirstNumberString = "1";
                Display.Text = FirstNumberString;
            }
            else if (FirstNumberString != string.Empty && !OperatorSelected && float.Parse(FirstNumberString) < 1000000.0f)
            {
                FirstNumberString = FirstNumberString + "1";
                Display.Text = FirstNumberString;
            }

            //kept for notekeeping
            //if (FirstNumber == 0 && !OperatorSelected)
            //{
            //    FirstNumber = 1;
            //    FirstNumberString = FirstNumber.ToString();
            //    Display.Text = FirstNumberString;
            //}
            //else if (FirstNumber != 0 && !OperatorSelected && FirstNumber < 1000000)
            //{
            //    float newnumber = float.Parse(FirstNumber.ToString() + 1);
            //    FirstNumber = newnumber;
            //    FirstNumberString = FirstNumber.ToString();
            //    Display.Text = FirstNumberString;

            //}
        }

        private void Button_Mem(object sender, RoutedEventArgs e)
        {
            if (!OperatorSelected)
            {
                MemoryNumber = FirstNumber;
                MemoryNumberString = FirstNumberString;
                MemoryDisplay.Text = MemoryNumberString;
            }
        }

        private void Button_Comma(object sender, RoutedEventArgs e)
        {
            if (FirstNumberString == string.Empty && !OperatorSelected)
            {
                FirstNumberString = "0.";
                Display.Text = FirstNumberString;
                FirstNumberComma = true;
            }
            else if( FirstNumberString!= string.Empty && !OperatorSelected && !FirstNumberString.Contains('.') ) 
            {
                FirstNumberString += ".";
                Display.Text = FirstNumberString;
                FirstNumberComma = true;
            }
            //if (FirstNumber == 0 && !OperatorSelected)
            //{
            //    FirstNumber = 0;
            //    FirstNumberString = FirstNumber.ToString()+".";
            //    Display.Text = FirstNumberString;
            //}
            //else if (FirstNumber != 0 && !OperatorSelected && FirstNumber < 1000000)
            //{
            //    float newnumber = float.Parse(FirstNumber.ToString() + ".");
            //    FirstNumber = newnumber;
            //    FirstNumberString = FirstNumber.ToString();
            //    Display.Text = newnumber.ToString();

            //}
        }

        private void Button_0(object sender, RoutedEventArgs e)
        {

            //if (FirstNumberString != string.Empty && !OperatorSelected && float.Parse(FirstNumberString) < 1000000.0f)
            //{
            //    FirstNumberString += "0";
            //    Display.Text = FirstNumberString;
            //}

            if (FirstNumberString != string.Empty && !OperatorSelected && BeforeAfterCommaCount(FirstNumberString).X < 9 && BeforeAfterCommaCount(FirstNumberString).Y < 4)
            {
                FirstNumberString += "0";
                Display.Text = FirstNumberString;
            }
            //if (FirstNumber != 0 && !OperatorSelected && FirstNumber < 1000000)
            //{
            //    float newnumber = float.Parse(FirstNumber.ToString() + 0);
            //    FirstNumber = newnumber;
            //    FirstNumberString = FirstNumber.ToString();
            //    Display.Text = FirstNumberString;

            //}
        }

        private void Button_Enter(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Plus(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Minus(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Multiply(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Divide(object sender, RoutedEventArgs e)
        {

        }


        //to keep our decimal values low and main number high
        // :)
        private Vector BeforeAfterCommaCount(string input)
        {
            Vector a;
            if (input.Contains("."))
            {
                decimalSeparated = input.Split('.');

                a.X = decimalSeparated[0].Length;
                a.Y = decimalSeparated[1].Length;
            }
            else
            {
                a.X = input.Length;
                a.Y = 0;
            }






                return a;

        }


    }
}