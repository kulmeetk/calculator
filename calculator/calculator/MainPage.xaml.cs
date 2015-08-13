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
        decimal num1 = 0,num2=0, result=0 ;
      string str = "";
        string operation = string.Empty;
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
            if(operation == "=")
            {
                this.display.Text = "";
                this.display2.Text = "";
                operation = string.Empty;
       }
            Button btn = (Button)sender;
            str = btn.Content.ToString();
            this.display.Text = this.display.Text + str;
            num2=Convert.ToDecimal(this.display.Text);
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
               
            if(operation==string.Empty)
            {
                this.display2.Text = this.display.Text;
                num1 = Convert.ToDecimal(display2.Text);
                this.display2.Text = this.display2.Text + this.buttonAdd.Content;
                this.display.Text = ""; 
                num2 = 0;
                operation = "+";
            }
            else
            {
                result = operate(num1,num2,operation);
                num1 = result;
                this.display2.Text = Convert.ToString(result) + this.buttonAdd.Content;
                this.display.Text = "";
                operation = "+";
                num2 = 0;
            }
            }
            
         private void buttonSubtract_Click(object sender, RoutedEventArgs e)
        {

            if (operation == string.Empty)
            {
                this.display2.Text = this.display.Text;
                num1 = Convert.ToDecimal(display2.Text);
                this.display2.Text = this.display2.Text + this.buttonSubtract.Content;
                this.display.Text = "";
                num2 = 0;
                operation = "-";
            }
            else
            {
                result = operate(num1, num2, operation);
                num1 = result;
                this.display2.Text = Convert.ToString(result) + this.buttonSubtract.Content;
                this.display.Text = "";
                operation = "-";
                num2 = 0;
            }
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
         {
             if (operation == string.Empty)
             {
                 this.display2.Text = this.display.Text;
                 num1 = Convert.ToDecimal(display2.Text);
                 this.display2.Text = this.display2.Text + this.buttonMultiply.Content;
                 this.display.Text = "";
                 num2 = 0;
                 operation = "*";
             }
             else
             {
                 result = operate(num1, num2, operation);
                 num1 = result;
                 this.display2.Text = Convert.ToString(result) + this.buttonMultiply.Content;
                 this.display.Text = "";
                 operation = "*";
                 num2 = 0;
             }
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            if (operation == string.Empty)
            {
                this.display2.Text = this.display.Text;
                num1 = Convert.ToDecimal(display2.Text);
                this.display2.Text = this.display2.Text + this.buttonDivide.Content;
                this.display.Text = "";
                num2 = 0;
                operation = "/";
            }
            else
            {
                result = operate(num1, num2, operation);
                num1 = result;
                this.display2.Text = Convert.ToString(result) + this.buttonDivide.Content;
                this.display.Text = "";
                operation = "/";
                num2 = 0;
            }

        }
        private void buttonPercent_Click(object sender, RoutedEventArgs e)
        {
            if (operation == string.Empty)
            {
                this.display2.Text = this.display.Text;
                num1 = Convert.ToDecimal(display2.Text);
                this.display2.Text = this.display2.Text + this.buttonPercent.Content;
                this.display.Text = "";
                num2 = 0;
                operation = "/";
            }
            else
            {
                result = operate(num1, num2, operation);
                num1 = result;
                this.display2.Text = Convert.ToString(result) + this.buttonPercent.Content;
                this.display.Text = "";
                operation = "/";
                num2 = 0;
            }
            }
        
        private void buttonResult_Click(object sender, RoutedEventArgs e)
        {
            
            this.display2.Text = this.display2.Text + this.display.Text;
            result = operate(num1, num2, operation);
            operation = "=";
            this.display.Text = result.ToString();
            //operation = string.Empty;
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {

            this.display.Text = "";
            this.display2.Text = "";
            result = 0;
            num1 = 0;
            num2 = 0;
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


        decimal operate(decimal num1,decimal num2,string operation)
        {
            decimal r=0;      
            if (operation == "+")
            {
                r = num1 + num2;
                
                
            }
            else if (operation == "-")
            {
                r = num1 - num2;
               
            }
            else if (operation == "*")
            {
                r = num1 * num2;
                
            }
            else if (operation == "/")
            {
                r = num1 / num2;
               
            }
            else if (operation == "%")
            {
                r = num1 / num2 * 100;
                
            }
            return r;
        }

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
