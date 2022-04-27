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

namespace WpfControlLibrary1
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            MinuteMarks();
        }
        public void MinuteMarks()
        {
            for (int i = 0; i < 60; i++)
            {
                // Контейнер для метки. 
                // Необходим для вращения пространства
                // в котором расположена декоративная метка. 
                var b = new Border()
                {
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Center,
                    RenderTransformOrigin = new Point(0.5, 0.5),

                    // Базовая ориентация контейнера метки горизонтальное,
                    // поэтому высота играет роль толщины метки.
                    Height = 2
                };


                // В роли метки выступает элемент Border.
                var b1 = new Border()
                {
                    Background = Brushes.Brown,

                    // Базовая ориентация горизонтальная,
                    // поэтому ширина визуально является длиной метки.
                    Width = 10,
                    HorizontalAlignment = HorizontalAlignment.Right
                };


                b.Child = b1;


                // Вращаем только сам контейнер.
                var rotate = new RotateTransform(i * 6);
                b.RenderTransform = rotate;


                // Исключаем из маркировки метки 0 и 
                // через каждые 30 градусов. 
                // В этих местах будут часовые метки.
                if (i * 6 % 30 != 0)
                {
                    // Добавляем на циферблат контейнеры с метками.
                    ClockFace.Children.Add(b);
                }
            }

        }
    }
}
