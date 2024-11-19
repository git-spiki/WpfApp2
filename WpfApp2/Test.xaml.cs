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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        private int Stage = 1;
        private int Success;
        private string[] tituls = { "как вы попали на этот тест", "дино", "тиктокер", "студент", "хз кто, придумай сам" };

        private void UpdateRender()
        {
            bool IsPassed = (Stage > 4);
            Quest1.Visibility = (Stage == 1 ? Visibility.Visible : Visibility.Hidden);
            Quest2.Visibility = (Stage == 2 ? Visibility.Visible : Visibility.Hidden);
            Quest3.Visibility = (Stage == 3 ? Visibility.Visible : Visibility.Hidden);
            Quest4.Visibility = (Stage == 4 ? Visibility.Visible : Visibility.Hidden);
            ResultFrame.Visibility = (Stage == 5 ? Visibility.Visible : Visibility.Hidden);
            QuestionLabel.Content = $"ВОПРОС №{Stage}";
            ActionButton.Content = (Stage < 4 ? "Далее" : "Результаты");
            ActionButton.Visibility = (Stage < 5 ? Visibility.Visible : Visibility.Hidden);
            QuestionLabel.Visibility = ActionButton.Visibility;
            ResulLabel.Content = $"{Success}/4";
            ResultTitul.Content = $"Выше звание:\n{tituls[Success]}";
        }
        public Test()
        {
            InitializeComponent();
            UpdateRender();
        }

        private void ActionButton_Click(object sender, RoutedEventArgs e)
        {
            switch (Stage)
            {
                case 1:
                    if (Quest1_1.IsChecked == true)
                    {
                        Success += 1;
                    }
                    break;
                case 2:
                    if (Quest2_3.IsChecked == true)
                    {
                        Success += 1;
                    }
                    break;
                case 3:
                    if (Quest3_3.IsChecked == true)
                    {
                        Success += 1;
                    }
                    break;
                case 4:
                    if (Quest4_2.IsChecked == true)
                    {
                        Success += 1;
                    }
                    break;
            }
            Stage += 1;
            UpdateRender();
        }
    }
}
