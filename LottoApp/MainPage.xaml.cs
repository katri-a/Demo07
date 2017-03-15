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
            int RowsAmount;
            try
            {
                RowsAmount = int.Parse(drawTextBox.Text);
            } catch
            {
                RowsAmount = 0;
            }
            if (RowsAmount != 0)
            {
                // olioioio Lotto-luokasta
                Lotto Arvonta = new Lotto();
                string Rows = Arvonta.GetRows(RowsAmount);
                randNumTextBlock.Text += Rows + System.Environment.NewLine;
            }
        }

        //clear button
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            randNumTextBlock.Text = "";
        }

    }
}
