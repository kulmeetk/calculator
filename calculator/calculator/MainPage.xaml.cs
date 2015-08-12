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
        decimal num1 = 0,num2=0, result=0 ,i=0,sum=0;
      string str = "";
        char operation;
       // decimal operate(decimal num1, char operation);
        //decimal MemoryStore = 0;
       
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
            {
                this.display.Text = this.display.Text + c;
                
            }
          
            
        }

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

        
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
                this.display2.Text = this.display.Text + this.buttonAdd.Content;
                num1 = Convert.ToDecimal(display.Text);
                this.display.Text = "";
                operation = '+';
               
            }
            
         private void buttonSubtract_Click(object sender, RoutedEventArgs e)
        {
            this.display2.Text = this.display.Text + this.buttonSubtract.Content;
            num1 = Convert.ToDecimal(display.Text);
            this.display.Text = "";
            operation = '-';
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
         {
             this.display2.Text = this.display.Text + this.buttonMultiply.Content;
             num1 = Convert.ToDecimal(display.Text);
             this.display.Text = "";
             operation = '*';

        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            this.display2.Text = this.display.Text + this.buttonDivide.Content;
            num1 = Convert.ToDecimal(display.Text);
            this.display.Text = "";
            operation = '/';

        }
        private void buttonPercent_Click(object sender, RoutedEventArgs e)
        {
            this.display2.Text = this.display.Text + this.buttonAdd.Content;
            num1 = Convert.ToDecimal(display.Text);
            this.display.Text = "";
            operation = '+';
            }
        
        private void buttonResult_Click(object sender, RoutedEventArgs e)
        {
            this.display2.Text = this.display2.Text + this.display.Text;
          
           num2 = Convert.ToDecimal(display.Text);
           if (operation == '+')
           {
               result = num1 + num2;
             //  num1 = r;

           }
           else if (operation == '-')
           {
               result = num1 - num2;
               //num1 = r;
           }
           else if (operation == '*')
           {
               result = num1 * num2;
               //num1 = r;
           }
           else if (operation == '/')
           {
               result = num1 / num2;
              // num1 = r;
           }
           else if (operation == '%')
           {
               result = num1 / num2 * 100;
               //num1 = r;
           }
            this.display.Text = result.ToString();

        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {

            this.display.Text = "";
            this.display2.Text = "";
            result = 0;
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


        /*decimal operate(decimal num1,decimal num2, char operation)
        {
            decimal r=0;
            
            
            if (operation == '+')
            {
                r = num1 + num2;
                num1 = r; 
                
            }
            else if (operation == '-')
            {
                r = num1 - num2;
                num1 = r;
            }
            else if (operation == '*')
            {
                r = num1 * num2;
                num1 = r;
            }
            else if (operation == '/')
            {
                r = num1 / num2;
                num1 = r;
            }
            else if (operation == '%')
            {
                r = num1 / num2 * 100;
                num1 = r;
            }
            return r;
        }*/

     /*   private void buttonMC_Click(object sender, RoutedEventArgs e)
        {
            MemoryStore = 0;
            
        }

        private void buttonMR_Click(object sender, RoutedEventArgs e)
        {
            if (MemoryStore == 0)
            {
                MemoryStore = Convert.ToDecimal(display.Text);
            }
            else
            {
                this.display.Text = Convert.ToString(MemoryStore);
            }
        }

        private void buttonMM_Click(object sender, RoutedEventArgs e)
        {
            if (MemoryStore == 0)
            {
                MemoryStore = Convert.ToDecimal(display.Text);
            }
            else
            {
                this.display.Text = Convert.ToString(MemoryStore);
            }

        }

        private void buttonMP_Click(object sender, RoutedEventArgs e)
        {
            if (MemoryStore == 0)
            {
                MemoryStore = Convert.ToDecimal(display.Text);
            }
            else
            {
                this.display.Text = Convert.ToString(MemoryStore);
            }

        }
       */ 
       
    }
}
