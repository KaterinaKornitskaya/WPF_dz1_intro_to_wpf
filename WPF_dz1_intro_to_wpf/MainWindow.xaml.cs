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

namespace WPF_dz1_intro_to_wpf
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

        // обработка клика по кнопке AddName
        private void buttonAddName_Click(object sender, RoutedEventArgs e)
        {
            myListBox.Items.Add(txtBox1.Text);  // добавляем в список текст из текст.поля
            txtBox1.Text = string.Empty;        // очищаем текстовое поле
        }

        // обработка клика по кнопке ClearAll
        private void buttonClearAll_Click(object sender, RoutedEventArgs e)
        {
            myListBox.Items.Clear();  // очищаем весь список
        }
    }
}
