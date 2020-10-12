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
using System.Windows.Threading;
using System.IO;
using Microsoft.Win32;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string action = null;

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            action = "coding";
            Key();
            OpenFileDialog OpenFile = new OpenFileDialog();
            string file = null;
            if (OpenFile.ShowDialog() == true)
            {
               file = OpenFile.FileName;
            }
            StreamReader stream1 = new StreamReader(file);
            string text = stream1.ReadLine();
            stream1.Close();
            Cesar(text);
        }

        public void Cesar(string text)
        {
            string textCoding = null;
            int textLength = text.Length;
            // if not to take key from file => int key = Convert.ToInt32(TextBox1.Text);
            StreamReader key = new StreamReader("Key.txt");
            int key1 = Convert.ToInt32(key.ReadLine());
            key.Close();
            if (action == "coding")
            {
                for (int i = 0; i < textLength; i++)
                {
                    textCoding = textCoding + (char)((int)text[i] + key1);
                }
                StreamWriter input1 = new StreamWriter("Input.txt");
                input1.WriteLine(textCoding);
                input1.Close();
            }
            else if (action == "decoding")
            {
                for (int i = 0; i < textLength; i++)
                {
                    textCoding = textCoding + (char)((int)text[i] - key1);
                }
                StreamWriter input1 = new StreamWriter("Output.txt");
                input1.WriteLine(textCoding);
                input1.Close();
            }
        
        }

        public void Key()
        {
            StreamWriter key = new StreamWriter("Key.txt");
            key.WriteLine(TextBox1.Text);
            key.Close();
        }

        private void Output_Click(object sender, RoutedEventArgs e)
        {
            action = "decoding";
            OpenFileDialog OpenFile = new OpenFileDialog();
            string file = null;
            if (OpenFile.ShowDialog() == true)
            {
                file = OpenFile.FileName;
            }
            StreamReader stream2 = new StreamReader(file);
            string text = stream2.ReadLine();
            stream2.Close();
            Cesar(text);
        }

        //public void DecodingCesar (string text1)
        //{
        //    string textCoding = null;
        //    int textLength = text1.Length;
        //    StreamReader key = new StreamReader("Key.txt");
        //    int key1 = Convert.ToInt32(key.ReadLine());
        //    key.Close();
        //    for (int i = 0; i < textLength; i++)
        //    {
        //        textCoding = textCoding + (char)((int)text1[i] - key1);
        //    }
        //    StreamWriter output1 = new StreamWriter("Output.txt"); // ("C://...//Output.txt")
        //    output1.WriteLine(textCoding);
        //    output1.Close();
        //}
    }
}
