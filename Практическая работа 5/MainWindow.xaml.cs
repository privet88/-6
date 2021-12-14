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


namespace Практическая_работа_5
{
   
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }
        Triad plus1 = new Triad();//обьект, содержащий результат увеличения чисел на 1
        Triad param = new Triad();//обьект, содержащий результат увеличения чисел на 10
        Triad chisla = new Triad();//объект, содержащий числа
        Triad sum = new Triad();//объект, содержащий сумму

        private void Сброс_Click(object sender, RoutedEventArgs e)
        {
            Ch1.Text = null;
            Ch2.Text = null;
            Ch3.Text = null;
            Plus1.Text = null;          
        }

        private void Опрограмме_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Потапкин. Задание: Использовать класс Triad (тройка чисел). Разработать операцию инкремента полей на 1.Разработать операцию для получения полной суммы триады с числом");
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Plus1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                chisla.One = Convert.ToInt32(Ch1.Text);//присваиваем значение из текст бокса
                chisla.Second = Convert.ToInt32(Ch2.Text);//присваиваем значение из текст бокса
                chisla.Third = Convert.ToInt32(Ch3.Text);//присваиваем значение из текст бокса
                chisla++;//используем оператор
                Plus1.Text = chisla.One.ToString() + ";" + chisla.Second.ToString() + ";" + chisla.Third.ToString();
            }
            catch
            {
                MessageBox.Show("ОШИБКА");
            }
            }

        //private void Plus10_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        chisla.One = Convert.ToInt32(Ch1.Text);//присваиваем значение из текст бокса
        //        chisla.Second = Convert.ToInt32(Ch2.Text);//присваиваем значение из текст бокса
        //        chisla.Third = Convert.ToInt32(Ch3.Text);//присваиваем значение из текст бокса
        //        param.SetParams(chisla.One, chisla.Second, chisla.Third,out string rez1);//используем функцию
        //        Plus10.Text = rez1;//записывем результат вычислений в текст бокс
        //    }
        //    catch
        //    {
        //        MessageBox.Show("ОШИБКА");
        //    }

        //}

        

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                chisla.One = Convert.ToInt32(Ch1.Text);//присваиваем значение из текст бокса
                chisla.Second = Convert.ToInt32(Ch2.Text);//присваиваем значение из текст бокса
                chisla.Third = Convert.ToInt32(Ch3.Text);//присваиваем значение из текст бокса
                int val = Convert.ToInt32(Ch4.Text);//присваиваем значение из текст бокса
                sum = chisla + val;//используем оператор
                Sum.Text = sum.One.ToString();//записывем результат вычислений в текст бокс
            }
            catch
            {
                MessageBox.Show("ОШИБКА");
            }
        }
    }
}
