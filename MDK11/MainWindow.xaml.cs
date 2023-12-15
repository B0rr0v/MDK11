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
using System.Text.RegularExpressions;

namespace MDK11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Дана строка 'aa aba abba abbba abca abea'.
        //Напишите регулярное выражение, которое найдет строки aa, aba, abba, abbba.
        //Дана строка 'a1a a2a a3a a4a a5a aba aca'.
        //Напишите регулярное выражение, которое найдет строки, в которых по краям стоят буквы 'a',
        //а между ними одна цифра.
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Агальцов Д. ИСП-31 Практическая работа №11:Дана строка 'aa aba abba abbba abca abea'. Напишите регулярное выражение, которое найдет строки aa, aba, abba, abbba. Дана строка 'a1a a2a a3a a4a a5a aba aca'.Напишите регулярное выражение, которое найдет строки, в которых по краям стоят буквы 'a', а между ними одна цифра.");
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            string s = tb1.Text;
            Regex regex=new Regex(@"ab*a");
            MatchCollection matches= regex.Matches(s);
            object[] mas = new object[matches.Count];
            matches.CopyTo(mas, 0);
            lb1.ItemsSource=mas;

            string s1 = tb2.Text;
            Regex regex1 = new Regex(@"a\da") ;
            MatchCollection matches1 = regex1.Matches(s1);
            object[] mas1 = new object[matches1.Count];
            matches1.CopyTo(mas1, 0);
            lb2.ItemsSource = mas1;
        }

      
    }
}
