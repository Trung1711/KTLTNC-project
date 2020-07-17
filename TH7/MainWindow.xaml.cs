using System;
using System.Windows;
using System.Windows.Input;

namespace TH7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public delegate double HamMotBien(double x);
    public partial class MainWindow : Window
    {
        //public delegate double HamMotBien(double x);
        public MainWindow()
        {
            InitializeComponent();
        }
        
        
        public double HamBacMot(double x)
        {
            return (Convert.ToDouble(TextBac1A.Text) * x + Convert.ToDouble(TextBac1B.Text));
        }
        public double HamBacHai(double x)
        {
            return (Convert.ToDouble(TextBac2A.Text) * x * x + Convert.ToDouble(TextBac2B.Text) * x + Convert.ToDouble(TextBac2C.Text));
        }
       
        public void CalculateBacMot()

        {
            string Khoanphanly = TextBac1KPLN.Text;
            TextBac1KetQua.Text = " ";
            double a = 0;
            double b = 0;
            double c = 0;
            StatBarTextBac1.Text = "TINH";
            if (!double.TryParse(TextBac1A.Text, out a))
            {
                StatBarTextBac1.Text = "Error  a";

                return;
            }
            if (!double.TryParse(TextBac1B.Text, out b))
            {
                StatBarTextBac1.Text = "Error  b";
                return;
            }
            if (!double.TryParse(TextBac1SS.Text, out c))
            {
                StatBarTextBac1.Text = "Error  sai so";
                return;
            }
            if (Khoanphanly == "")
            {
                StatBarTextBac1.Text = "Chua nhap khoan phan ly nghiem";
                return;
            }
            else
            {
                string[] temp = Khoanphanly.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length <= 1)
                {
                    StatBarTextBac1.Text = "Error, vui long nhap ['a b'] khoan phan ly";
                    return;
                }
                if (!double.TryParse(temp[0], out a))
                {
                    StatBarTextBac1.Text = "Error khoan phan ly thu nhat";
                    return;
                }
                if (!double.TryParse(temp[1], out b))
                {
                    StatBarTextBac1.Text = "Error khoan phan ly thu nhat";
                    return;
                }

                if (!String.IsNullOrEmpty(TextBac1A.Text) && !String.IsNullOrEmpty(TextBac1B.Text) && !String.IsNullOrEmpty(TextBac1SS.Text))
                {
                    if (a > b )
                    {
                        StatBarTextBac1.Text = "KPLN co Gia tri dau khong duoc lon hon Gia tri cuoi ";
                        return;
                    }
                    
                    if (HamBacMot(b) * HamBacMot(a) > 0)
                    {
                        StatBarTextBac1.Text = "Error, nghiem khong nam trong khoan phan ly nay";
                        return;
                    }
                    if (( HamBacMot(a))== 0 )
                    {
                        TextBac1KetQua.Text = a.ToString();
                        return;
                    }
                    if ((HamBacMot(b) == 0) )
                    {
                        TextBac1KetQua.Text = b.ToString();
                        return;
                    }

                    if ((Convert.ToDouble(TextBac1A.Text)==0)&&(Convert.ToDouble(TextBac1B.Text)==0))
                    {
                        TextBac1KetQua.Text = "Phuong trinh nay co vo so nghiem, vui long nhap a va b khong bang 0";
                        return;
                    }

                    ChiaDoi chia_doi = new ChiaDoi();

                    double Nghiem = chia_doi.TimNgiem(a, b, Convert.ToDouble(TextBac1SS.Text), hamfx: HamBacMot);
                    TextBac1KetQua.Text = Nghiem.ToString();

                }
                else
                {
                    TextBac1KetQua.Text = "Error";
                    StatBarTextBac1.Text = "Chua nhap a hoac b hoac sai so";
                }
            }
            

        }
        public void CalculateBacHai()
        {
            string Khoanphanly = TextBac2KPLN.Text;
            TextBac2KetQua.Text = " ";
            double a = 0;
            double b = 0;
            double saiso = 0;
            StatBarTextBac2.Text = "TINH";
            if (!double.TryParse(TextBac2A.Text, out a))
            {
                StatBarTextBac2.Text = "Error  a";

                return;
            }
            if (!double.TryParse(TextBac2B.Text, out b))
            {
                StatBarTextBac2.Text = "Error  b";
                return;
            }
           
            if (!double.TryParse(TextBac2SS.Text, out saiso))
            {
                StatBarTextBac2.Text = "Error  ss";
                return;
            }
            if (Khoanphanly == "")
            {
                StatBarTextBac2.Text = "Chua nhap khoan phan ly nghiem";
                return;
            }
            else
            {
                string[] temp = Khoanphanly.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length <= 1)
                {
                    StatBarTextBac2.Text = "Error, vui long nhap ['a b'] khoan phan ly";
                    return;
                }
                if (!double.TryParse(temp[0], out a))
                {
                    StatBarTextBac2.Text = "Error khoan phan ly thu nhat";
                    return;
                }
                if (!double.TryParse(temp[1], out b))
                {
                    StatBarTextBac2.Text = "Error khoan phan ly thu nhat";
                    return;
                }              

                if (!String.IsNullOrEmpty(TextBac2A.Text)&& !String.IsNullOrEmpty(TextBac2B.Text) && !String.IsNullOrEmpty(TextBac2C.Text) && !String.IsNullOrEmpty(TextBac2SS.Text))
                {
                    if (a > b)
                    {
                        StatBarTextBac2.Text = "KPLN co Gia tri dau khong duoc lon hon Gia tri cuoi ";
                        return;
                    }

                    if (HamBacHai(b) * HamBacHai(a) > 0)
                    {
                        StatBarTextBac2.Text = "Error, Nhap sao khoan phan li nghiem hoac pt co nghiem kep trong khoan nay!!! vui long nhap dung";
                        return;

                    }
                    if ( (HamBacHai(a)) == 0)
                    {
                        TextBac2KetQua.Text = a.ToString();
                        return;
                    }
                    if ((HamBacHai(b) == 0) )
                    {
                        TextBac2KetQua.Text = b.ToString();
                        return;
                    }
                    if ((Convert.ToDouble(TextBac2B.Text) == 0) && (Convert.ToDouble(TextBac2A.Text) == 0) && (Convert.ToDouble(TextBac2C.Text) == 0))
                    {
                        TextBac2KetQua.Text = "Phuong trinh nay co vo so nghiem, vui long nhap a va b khong bang 0";
                        return;
                    }

                    ChiaDoi chia_doi = new ChiaDoi();

                    double Nghiem = chia_doi.TimNgiem(a, b, Convert.ToDouble(TextBac2SS.Text), HamBacHai);
                    TextBac2KetQua.Text = Nghiem.ToString();

                }
                else
                {
                    TextBac2KetQua.Text = "Error";
                    StatBarTextBac2.Text = "Chua nhap a hoac b hoac sai so";
                }
            }


        }

        



        private void TextChangedBac1A(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CalculateBacMot();
        }

        private void TextChangedBac1B(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CalculateBacMot();
        }

        private void TextChangedBac1KPLN(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CalculateBacMot();
        }

        private void TextChangedBac1SS(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CalculateBacMot();
        }

        private void targetTextbox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Char newChar = e.Text.ToString()[0];
            e.Handled = !(Char.IsNumber(newChar) || (newChar == '.') || (newChar == '-'));
        }


        private void KeyDownBac1(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                CalculateBacMot();
            }
        }

        private void targetTextbox_PreviewTextInputSS(object sender, TextCompositionEventArgs e)
        {
            Char newChar = e.Text.ToString()[0];
            e.Handled = !(Char.IsNumber(newChar) || (newChar == '.'));
        }

        private void textBox_PreviewKeyDownKPLN(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.Space)&& ((TextBac1KPLN.Text.IndexOf(" ") != -1)))
            {
                e.Handled = true;
            }
        }

        private void TextChangedBac2A(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CalculateBacHai();
        }

        private void TextChangedBac2B(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CalculateBacHai();
        }

        private void TextChangedBac2C(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CalculateBacHai();
        }

        private void TextChangedBac2KPLN(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CalculateBacHai();
        }

        private void TextChangedBac2SS(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CalculateBacHai();
        }

        private void KeyDownBac2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                CalculateBacHai();
            }
        }

        private void textBox_PreviewKeyDownKPLN2(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.Space) && ((TextBac2KPLN.Text.IndexOf(" ") != -1)))
            {
                e.Handled = true;
            }
        }

       
      

        private void textBox_PreviewTextInputHTsodoan(object sender, TextCompositionEventArgs e)
        {
            Char newChar = e.Text.ToString()[0];
            e.Handled = !(Char.IsNumber(newChar));
        }

       

        

        
    }
}
