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
using Lib_7;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] mas;
        double[] res;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая№2 вариант№7, Разработчик ИСП-31 Корняков Д.Д.");
        }

        private void Cozdanie_Click(object sender, RoutedEventArgs e)
        {
            Vuvodmas0.Clear();
            int Minznach = -9;
            if (int.TryParse(RazmerMas.Text, out int Znach1))
            {
                if (Znach1 > 0)
                {
                    Class1.InitMas(Minznach, Znach1, out mas);
                    for (int i = 0; i < mas.Length; i++)
                    {
                        int y = mas[i];
                        Vuvodmas0.Text += Convert.ToString(y) + " ";

                    }

                }
            }
            else
            {
                MessageBox.Show("Введи число");
            }
        }

        private void Obrabotka_Click(object sender, RoutedEventArgs e)
        {

            if (Vuvodmas0.Text == null)
            {
                MessageBox.Show("Массив не создан");
            }
            else
            {
                Class2.Raschet(mas, out res);
                for (int i = 0; i < res.Length; i++)
                {
                    double kvadrat = res[i];
                    Vuvodmas1.Text += Convert.ToString(kvadrat) + " ";
                }
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

            Vuvodmas0.Clear();
            Vuvodmas1.Clear();
        }
    }
}
