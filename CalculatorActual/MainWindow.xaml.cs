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





        }

        private void Button_9(object sender, RoutedEventArgs e)
        {
            if (FirstNumber == 0 && !OperatorSelected)
            {
                FirstNumber = 9;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;
            }
            else if (FirstNumber != 0 && !OperatorSelected && FirstNumber<1000000)
            {
                float newnumber = float.Parse(FirstNumber.ToString() + 9);
                FirstNumber= newnumber;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;

            }

        }

        private void Button_8(object sender, RoutedEventArgs e)
        {
            if (FirstNumber == 0 && !OperatorSelected)
            {
                FirstNumber = 8;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;
            }
            else if (FirstNumber != 0 && !OperatorSelected && FirstNumber < 1000000)
            {
                float newnumber = float.Parse(FirstNumber.ToString() + 8);
                FirstNumber = newnumber;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;

            }
        }

        private void Button_7(object sender, RoutedEventArgs e)
        {
            if (FirstNumber == 0 && !OperatorSelected)
            {
                FirstNumber = 7;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;
            }
            else if (FirstNumber != 0 && !OperatorSelected && FirstNumber < 1000000)
            {
                float newnumber = float.Parse(FirstNumber.ToString() + 7);
                FirstNumber = newnumber;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;

            }
        }

        private void Button_AC(object sender, RoutedEventArgs e)
        {
            FirstNumber = 0;
            FirstNumberString = FirstNumber.ToString();
            LastNumber = 0;
            LastNumberString = LastNumber.ToString();
            MemoryNumber = 0;
            MemoryNumberString= MemoryNumber.ToString();
            Display.Text = FirstNumberString;
            MemoryDisplay.Text = string.Empty;
        }

        private void Button_6(object sender, RoutedEventArgs e)
        {
            if (FirstNumber == 0 && !OperatorSelected)
            {
                FirstNumber = 6;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;
            }
            else if (FirstNumber != 0 && !OperatorSelected && FirstNumber < 1000000)
            {
                float newnumber = float.Parse(FirstNumber.ToString() + 6);
                FirstNumber = newnumber;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;

            }
        }

        private void Button_5(object sender, RoutedEventArgs e)
        {
            if (FirstNumber == 0 && !OperatorSelected)
            {
                FirstNumber = 5;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;
            }
            else if (FirstNumber != 0 && !OperatorSelected && FirstNumber < 1000000)
            {
                float newnumber = float.Parse(FirstNumber.ToString() + 5);
                FirstNumber = newnumber;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;

            }
        }

        private void Button_4(object sender, RoutedEventArgs e)
        {
            if (FirstNumber == 0 && !OperatorSelected)
            {
                FirstNumber = 4;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;
            }
            else if (FirstNumber != 0 && !OperatorSelected && FirstNumber < 1000000)
            {
                float newnumber = float.Parse(FirstNumber.ToString() + 4);
                FirstNumber = newnumber;
                FirstNumberString = FirstNumber.ToString();
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
            if (FirstNumber == 0 && !OperatorSelected)
            {
                FirstNumber = 3;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;
            }
            else if (FirstNumber != 0 && !OperatorSelected && FirstNumber < 1000000)
            {
                float newnumber = float.Parse(FirstNumber.ToString() + 3);
                FirstNumber = newnumber;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;

            }
        }

        private void Button_2(object sender, RoutedEventArgs e)
        {
            if (FirstNumber == 0 && !OperatorSelected)
            {
                FirstNumber = 2;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;
            }
            else if (FirstNumber != 0 && !OperatorSelected && FirstNumber < 1000000)
            {
                float newnumber = float.Parse(FirstNumber.ToString() + 2);
                FirstNumber = newnumber;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;

            }
        }

        private void Button_1(object sender, RoutedEventArgs e)
        {
            if (FirstNumber == 0 && !OperatorSelected)
            {
                FirstNumber = 1;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;
            }
            else if (FirstNumber != 0 && !OperatorSelected && FirstNumber < 1000000)
            {
                float newnumber = float.Parse(FirstNumber.ToString() + 1);
                FirstNumber = newnumber;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;

            }
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
            if (FirstNumber == 0 && !OperatorSelected)
            {
                FirstNumber = 0;
                FirstNumberString = FirstNumber.ToString()+".";
                Display.Text = FirstNumberString;
            }
            else if (FirstNumber != 0 && !OperatorSelected && FirstNumber < 1000000)
            {
                float newnumber = float.Parse(FirstNumber.ToString() + ".");
                FirstNumber = newnumber;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;

            }
        }

        private void Button_0(object sender, RoutedEventArgs e)
        {

            if (FirstNumber != 0 && !OperatorSelected && FirstNumber < 1000000)
            {
                float newnumber = float.Parse(FirstNumber.ToString() + 0);
                FirstNumber = newnumber;
                FirstNumberString = FirstNumber.ToString();
                Display.Text = FirstNumberString;

            }
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


    }
}