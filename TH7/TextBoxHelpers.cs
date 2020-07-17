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


namespace TH7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class TextBoxHelpers : DependencyObject
    {




        public static bool GetSapce(DependencyObject obj)
        {
            return (bool)obj.GetValue(SapceProperty);
        }

        public static void SetSapce(DependencyObject obj, bool value)
        {
            obj.SetValue(SapceProperty, value);
        }

        // Using a DependencyProperty as the backing store for Sapce.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SapceProperty =
            DependencyProperty.RegisterAttached("Sapce", typeof(bool), typeof(TextBoxHelpers), new PropertyMetadata(false, new PropertyChangedCallback((s, e) =>
            {
                TextBox targetTextbox = s as TextBox;
                if (targetTextbox != null)
                {
                    if ((bool)e.OldValue && !((bool)e.NewValue))
                    {
                        targetTextbox.PreviewTextInput -= targetTextbox_PreviewTextInputSpace;

                    }
                    if ((bool)e.NewValue)
                    {

                        targetTextbox.PreviewTextInput += targetTextbox_PreviewTextInputSpace;
                        targetTextbox.PreviewKeyDown += targetTextbox_PreviewKeyDownSpace;
                    }
                }
            })));

        static void targetTextbox_PreviewKeyDownSpace(object sender, KeyEventArgs e)
        {
            //e.Handled = e.Key == Key.Space;
            TextBox tb = sender as TextBox;
            if (tb.SelectionStart > 0)
            {
                if (e.Key == Key.Space)
                {
                    if ((tb.Text.ToArray()[tb.SelectionStart - 1] == ' ') || (tb.Text.ToArray()[tb.SelectionStart - 1] == '.') || (tb.Text.ToArray()[tb.SelectionStart - 1] == '-'))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        tb.Text = tb.Text;
                    }

                }
            }
        }

        static void targetTextbox_PreviewTextInputSpace(object sender, TextCompositionEventArgs e)
        {
            Char newChar = e.Text.ToString()[0];
            TextBox tb = sender as TextBox;
            if ( newChar != '-' && newChar != '.')
            {
                e.Handled = !Char.IsNumber(newChar);
            }
            else
            if  (tb.SelectionStart == 0)
            {
                if (newChar == '-')
                {
                    if (tb.Text.Contains('-'))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        tb.Text = tb.Text;
                    }

                }
                if (newChar == '.') e.Handled = true;
                   
            }
            else
            {
                if (newChar == '-')
                {
                    if (tb.Text.ToArray()[tb.SelectionStart-1] != ' ')
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        tb.Text = tb.Text;
                    }
                }
                if (newChar == '.')
                {
                    if (!Char.IsNumber(tb.Text.ToArray()[tb.SelectionStart - 1]))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        for (int i = tb.SelectionStart-1 ; i > 1; i--)
                        {
                            if (tb.Text.ToArray()[i] =='.')
                            {
                                e.Handled = true;
                                return;
                            }
                            else if (tb.Text.ToArray()[i] == ' ')
                            {
                                tb.Text = tb.Text;
                                return;
                            }                           
                        }
                    }
                }
            }
        }




        public static bool GetIsNumeric(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsNumericProperty);
        }

        public static void SetIsNumeric(DependencyObject obj, bool value)
        {
            obj.SetValue(IsNumericProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsNumeric.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsNumericProperty =
     DependencyProperty.RegisterAttached("IsNumeric", typeof(bool), typeof(TextBoxHelpers), new PropertyMetadata(false, new PropertyChangedCallback((s, e) =>
     {
         TextBox targetTextbox = s as TextBox;
         if (targetTextbox != null)
         {
             if ((bool)e.OldValue && !((bool)e.NewValue))
             {
                 targetTextbox.PreviewTextInput -= targetTextbox_PreviewTextInput;

             }
             if ((bool)e.NewValue)
             {

                 targetTextbox.PreviewTextInput += targetTextbox_PreviewTextInput;
                 targetTextbox.PreviewKeyDown += targetTextbox_PreviewKeyDown;
             }
         }
     })));

        static void targetTextbox_PreviewKeyDown(object sender, KeyEventArgs e)
      {
            e.Handled = e.Key == Key.Space;
        }

        static void targetTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Char newChar = e.Text.ToString()[0];
            TextBox tb = sender as TextBox;
            if (newChar != '-' && newChar != '.')
            {
                e.Handled = !Char.IsNumber(newChar);
            }
            else 
            if (tb.SelectionStart == 0)
            {
                if (newChar == '-')
                {
                    if (tb.Text.Contains('-'))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        tb.Text = tb.Text;
                    }

                }
                if (newChar == '.') e.Handled = true;

            }
            else if (newChar == '.')
            {
                if (tb.Text.Contains('.'))
                {
                    e.Handled = true;
                    return;
                }
                else
                {
                    tb.Text = tb.Text;
                    return;
                }

            }
            else
            if (newChar == '-')
            {
                e.Handled = true;
                return;
            }
            else
            {
                tb.Text = tb.Text;
                return;
            }

            /*
            else if (newChar == '-')
            {
                if (tb.Text.Contains('-'))
                {
                    e.Handled = true;
                }
                else
                {
                    tb.Text =  tb.Text;
                }
                //if (tb.Text.Length == 0)
                //{
                //    tb.Text.Contains('-');
                //}
                //else
                //{
                //    e.Handled = !Char.IsNumber(newChar);
                //}
            }*/

        }
    }
}
