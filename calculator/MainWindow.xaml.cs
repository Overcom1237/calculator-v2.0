using System.Windows;
using System.Windows.Forms;

namespace calculator
{
    public partial class MainWindow : Window
    {
        
        float x, y;
        int action;
        bool sing;

        public MainWindow()
        {
            InitializeComponent();

            
        }
        private void Button_poditive_or_paternal(object sender, RoutedEventArgs e)
        {
            if (sing)
            {
                Tb.Text = "-" + Tb.Text;
                sing = false;
            }
            else if (!sing)
            {
                Tb.Text = Tb.Text.Replace("-", "");
                sing = true;
            }
        }

        private void Button_del(object sender, RoutedEventArgs e)
        {
            int sim = Tb.Text.Length - 1;
            string text = Tb.Text;
            Tb.Clear();
            for (int q = 0; q < sim; q++)
            {
                Tb.Text = Tb.Text + text[q];
            }
        }

        private void Button_C(object sender, RoutedEventArgs e)
        {
            Tb.Text = "";
            la.Content = "";
            x = 0;
            y = 0;
        }
        private void Button_0(object sender,  RoutedEventArgs e)
        {
            Tb.Text = Tb.Text + 0;
        }

        private void Button_1(object sender,  RoutedEventArgs e)
        {
            Tb.Text = Tb.Text + 1;
        }

        private void Button_2(object sender,  RoutedEventArgs e)
        {
            Tb.Text = Tb.Text + 2;
        }

        private void Button_3(object sender,  RoutedEventArgs e)
        {
            Tb.Text = Tb.Text + 3;
        }

        private void Button_4(object sender,  RoutedEventArgs e)
        {
            Tb.Text = Tb.Text + 4;
        }

        private void Button_5(object sender,  RoutedEventArgs e)
        {
            Tb.Text = Tb.Text + 5;
        }

        private void Button_6(object sender,  RoutedEventArgs e)
        {
            Tb.Text = Tb.Text + 6;
        }

        private void Button_7(object sender,  RoutedEventArgs e)
        {
            Tb.Text = Tb.Text + 7;
        }

        private void Button_8(object sender,  RoutedEventArgs e)
        {
            Tb.Text = Tb.Text + 8;
        }

        private void Button_9(object sender,  RoutedEventArgs e)
        {
            Tb.Text = Tb.Text + 9;
        }

        private void Button_point(object sender,  RoutedEventArgs e)
        {
            Tb.Text = Tb.Text + ",";
        }

        private void Button_result(object sender, RoutedEventArgs e)
        {
            if (Tb.Text == "") Tb.Text = "0";
            Col();
            x = 0;
            la.Content = "";
        }

        private void Button_sum(object sender, RoutedEventArgs e)
        {
            if (x != 0) 
            {
                Col();
                la.Content = y.ToString() + "+";
                Tb.Clear();
                x = y;
                action = 1;
            } 
            else
            {
                x = float.Parse(Tb.Text);
                Tb.Clear();
                action = 1;
                la.Content = x.ToString() + "+";
            }
        }

        private void Button_difference(object sender,  RoutedEventArgs e)
        {
            if (x != 0)
            {
                Col();
                la.Content = y.ToString() + "-";
                Tb.Clear();
                x = y;
                action = 2;
            }
            else
            {
                x = float.Parse(Tb.Text);
                Tb.Clear();
                action = 2;
                la.Content = x.ToString() + "-";
            }
        }

        private void Button_multiplier(object sender, RoutedEventArgs e)
        {
            if (x != 0)
            {
                Col();
                la.Content = y.ToString() + "*";
                Tb.Clear();
                x = y;
                action = 3;
            }
            else
            {
                x = float.Parse(Tb.Text);
                Tb.Clear();
                action = 3;
                la.Content = x.ToString() + "*";
            }
        }

        private void Button_division(object sender, RoutedEventArgs e)
        {
            if (x != 0)
            {
                Col();
                la.Content = y.ToString() + "/";
                Tb.Clear();
                x = y;
                action = 4;
            }
            else
            {
                x = float.Parse(Tb.Text);
                Tb.Clear();
                action = 4;
                la.Content = x.ToString() + "/";
            }
        }

        private void Col()
        {

          
            switch (action)
            {
                case 1:
                    y = x + float.Parse(Tb.Text);
                    Tb.Text = y.ToString();
                    break;
                case 2:
                    y = x - float.Parse(Tb.Text);
                    Tb.Text = y.ToString();
                    break;
                case 3:
                    y = x * float.Parse(Tb.Text);
                    Tb.Text = y.ToString();
                    break;
                case 4:
                    y = x / float.Parse(Tb.Text);
                    Tb.Text = y.ToString();
                    break;
                default:
                    break;
                     
            }
        }
    }
}
