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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LottoApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {

            // random number from range 1-39
            Random rand = new Random();
            int num1 = rand.Next(1, 39 + 1);
            int num2 = rand.Next(1, 39 + 1);
            int num3 = rand.Next(1, 39 + 1);
            int num4 = rand.Next(1, 39 + 1);
            int num5 = rand.Next(1, 39 + 1);
            int num6 = rand.Next(1, 39 + 1);
            int num7 = rand.Next(1, 39 + 1);


          /*  int number1 = num1;
            int number2 = num2;*/

            randNumTextBlock.Text = num1.ToString() + " " + num2.ToString() + " " + num3.ToString() + " " + num4.ToString() + " "
                + num5.ToString() + " " + num6.ToString() + " " + num7.ToString();

        }

    }
}
