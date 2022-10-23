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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rect_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox.Background = Brushes.Beige;
        }

        private void Rect_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBox.Background = Brushes.Gainsboro;
        }

        static string[] SplitString(string Phrase)
        {
            string[] arrayWords = Phrase.Split(' ');
            return arrayWords;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox.Text))
            {
                MessageBox.Show("Введите фразу", this.Title, MessageBoxButton.YesNo, MessageBoxImage.Information);
            }
            else
            {
                string[] arrayWords = SplitString(TextBox.Text);
                string resultString = "";
                for (int i = arrayWords.Length; i > 0; i--)
                {
                    resultString += arrayWords[i - 1] + " ";
                }
                //Label.Content = resultString;                
                Text.Text = resultString;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox.Text))
            {
                MessageBox.Show("Введите фразу", this.Title, MessageBoxButton.YesNo, MessageBoxImage.Information);
            }
            else
            {
                ListBox.Items.Clear();
                string[] arrayWords = SplitString(TextBox.Text);
                foreach(var word in arrayWords)
                {
                    ListBox.Items.Add(word);
                }
            }
        }
    }
}
