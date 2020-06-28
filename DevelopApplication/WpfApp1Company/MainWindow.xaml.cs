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
using WpfApp1Company.Models;

namespace WpfApp1Company
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

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            Geekbrains _geekbrains = new Geekbrains(10, 100);
            GridMain.DataContext = _geekbrains;

            ButtonAdd.Click += delegate
            {
                _geekbrains.AddCourse(new Course("Курс Java", _geekbrains.Students));
            };
            ButtonDelete.Click += delegate
            {
                Course select = (Course)ListBoxCourses.SelectedItem;
                if (select == null)
                    return;
                _geekbrains.DelCourse(select);
            };
        }
    }
}
