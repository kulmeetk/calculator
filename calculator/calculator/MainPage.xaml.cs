using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        float num1 = 0,num2=0, result=0,i=0;
      string str = "";
        char operation;
       
        //this.display.Text = "";
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           /* if (sender == button1)
                str = "1";
            else if (sender == button2)
                str = "2";
            else if (sender == button3)
                str = "3";
            else if (sender == button4)
                str = "4";
            else if (sender == button5)
                str = "5";
            else if (sender == button6)
                str = "6";
            else if (sender == button7)
                str = "7";
            else if (sender == button8)
                str = "8";
            else if (sender == button9)
                str = "9";
            else str = "0";*/
            Button btn = (Button)sender;

            str = btn.Name;
            int len = str.Length;
           char c = str[len-1]; 
            if (this.display.Text == "+" || this.display.Text == "-" || this.display.Text == "*" || this.display.Text == "/" || this.display.Text == "%")
            {
                this.display2.Text = this.display.Text;
                this.display.Text = "";
                this.display.Text = this.display.Text + c;
            }
            else

                this.display.Text = this.display.Text + c;
           
        }

      /*  private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (this.display.Text == "+" || this.display.Text == "-" || this.display.Text == "*" || this.display.Text == "/" || this.display.Text == "%")
            {
                this.display2.Text =  this.display.Text;
                this.display.Text = "";
                this.display.Text = this.display.Text + this.button2.Content;
            }
            else
                this.display.Text = this.display.Text + this.button2.Content;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (this.display.Text == "+" || this.display.Text == "-" || this.display.Text == "*" || this.display.Text == "/" || this.display.Text == "%")
            {
                this.display2.Text = this.display.Text;
                this.display.Text = "";
                this.display.Text = this.display.Text + this.button3.Content;
            }
            else
                this.display.Text = this.display.Text + this.button3.Content;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (this.display.Text == "+" || this.display.Text == "-" || this.display.Text == "*" || this.display.Text == "/" || this.display.Text == "%")
            {
                this.display2.Text = this.display.Text;
                this.display.Text = "";
                this.display.Text = this.display.Text + this.button4.Content;
            }
            else
                this.display.Text = this.display.Text + this.button4.Content;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (this.display.Text == "+" || this.display.Text == "-" || this.display.Text == "*" || this.display.Text == "/" || this.display.Text == "%")
            {
                this.display2.Text = this.display.Text;
                this.display.Text = "";
                this.display.Text = this.display.Text + this.button5.Content;
            }
            else
                this.display.Text = this.display.Text + this.button5.Content;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (this.display.Text == "+" || this.display.Text == "-" || this.display.Text == "*" || this.display.Text == "/" || this.display.Text == "%")
            {
                this.display2.Text = this.display.Text;
                this.display.Text = "";
                this.display.Text = this.display.Text + this.button6.Content;
            }
            else
                this.display.Text = this.display.Text + this.button6.Content;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (this.display.Text == "+" || this.display.Text == "-" || this.display.Text == "*" || this.display.Text == "/" || this.display.Text == "%")
            {
                this.display2.Text = this.display.Text;
                this.display.Text = "";
                this.display.Text = this.display.Text + this.button7.Content;
            }
            else
                this.display.Text = this.display.Text + this.button7.Content;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (this.display.Text == "+" || this.display.Text == "-" || this.display.Text == "*" || this.display.Text == "/" || this.display.Text == "%")
            {
                this.display2.Text = this.display.Text;
                this.display.Text = "";
                this.display.Text = this.display.Text + this.button8.Content;
            }
            else
                this.display.Text = this.display.Text + this.button8.Content;
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (this.display.Text == "+" || this.display.Text == "-" || this.display.Text == "*" || this.display.Text == "/" || this.display.Text == "%")
            {
                this.display2.Text = this.display.Text;
                this.display.Text = "";
                this.display.Text = this.display.Text + this.button9.Content;
            }
            else
                this.display.Text = this.display.Text + this.button9.Content;
        }*/
        private void buttonDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (this.display.Text == "+" || this.display.Text == "-" || this.display.Text == "*" || this.display.Text == "/" || this.display.Text == "%")
            {
                this.display2.Text = this.display.Text;
                this.display.Text = "";
                this.display.Text = this.display.Text + this.buttonDecimal.Content;
            }
            else
            this.display.Text = this.display.Text + this.buttonDecimal.Content;
        }

        /*private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (this.display.Text == "+" || this.display.Text == "-" || this.display.Text == "*" || this.display.Text == "/" || this.display.Text == "%")
            {
                this.display2.Text = this.display.Text;
                this.display.Text = "";
                this.display.Text = this.display.Text + this.button0.Content;
            }
            else
                this.display.Text = this.display.Text + this.button0.Content;
        }*/

             private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(display.Text);
            this.display2.Text = this.display.Text + this.buttonAdd.Content;
           this.display.Text = "";
          //  this.display.Text = this.display.Text + this.buttonAdd.Content;

            result = +num1;
            operation = '+';
        }

        private void buttonSubtract_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(display.Text);
            this.display2.Text = this.display.Text + this.buttonSubtract.Content;
            this.display.Text = "";
           // this.display.Text = this.display.Text + this.buttonSubtract.Content;
            operation = '-';
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(display.Text);
            this.display2.Text = this.display.Text + this.buttonMultiply.Content;
            this.display.Text = "";
           // this.display.Text = this.display.Text + this.buttonMultiply.Content;
            operation = '*';
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(display.Text);
            this.display2.Text = this.display.Text + this.buttonDivide.Content;
            this.display.Text = "";
          //  this.display.Text = this.display.Text + this.buttonDivide.Content;
            operation = '/';
        }
        private void buttonPercent_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(display.Text);
            this.display2.Text = this.display.Text + this.buttonPercent.Content;
            this.display.Text = "";
          //  this.display.Text = this.display.Text + this.buttonPercent.Content;
            operation = '%';
        }
        private void buttonResult_Click(object sender, RoutedEventArgs e)
        {
            this.display2.Text = this.display2.Text + this.display.Text;
            //this.display.Text = "";
            num2 = float.Parse(display.Text);
            if (operation == '+')
            {
                result = num1 + num2;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }
            else if (operation == '/')
            {
                result = num1 / num2;
            }
            else if (operation == '%')
            {
                result = num1 / num2*100;
            }
            this.display.Text = result.ToString();

        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {

            this.display.Text = "";
            this.display2.Text = "";
    }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            string st = this.display.Text;
            if (st.Length > 1)
            {
                this.display.Text = st.Substring(0, st.Length - 1);
            }
            else
            {

                this.display.Text = "";
                this.display2.Text = "";
            }
        }

       
    }
}
