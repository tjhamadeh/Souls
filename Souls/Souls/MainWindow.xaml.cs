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

namespace Souls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int str;
        private int str2Str
        {
            get { return str; }
            set
            {
                str = value;
                strBox.Text = value.ToString();
            }
        }
        private int dex;
        private int dex2Str
        {
            get { return dex; }
            set
            {
                dex = value;
                dexBox.Text = value.ToString();
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 0;
            str2Str = 0;
            dex2Str = 0;
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void addStrButton_Click(object sender, RoutedEventArgs e)
        {
            str2Str++;
        }

        private void remStrButton_Click(object sender, RoutedEventArgs e)
        {
            if (str2Str == 0)
                return;
            str2Str--;
        }

        private void addDexButton_Click(object sender, RoutedEventArgs e)
        {
            dex2Str++;
        }

        private void remDexButton_Click(object sender, RoutedEventArgs e)
        {
            if (dex2Str == 0)
                return;
            dex2Str--;
        }

    }

    public enum SOULS : int
    {
        DARKSOULS  = 0,
        DARKSOULS2 = 1,
        DARKSOULS3 = 2,
        BLOODBORNE = 3
    }
}
