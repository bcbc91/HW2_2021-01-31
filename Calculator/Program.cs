using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba! Lütfen bir sayı giriniz.");
            string input1 = Console.ReadLine();
            double output1 = Convert.ToDouble(input1);
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: Toplama için \"+\" Çıkarma için \"-\" Çarpma için \"*\" Bölme için \"/\" girin");
            string input2 = Console.ReadLine();
            
            Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
            string input3 = Console.ReadLine();
            double output3 = Convert.ToDouble(input3);


            if (input2== "+")
            {
                double result1 = Sum(output1, output3);
                Console.WriteLine("Sonuç: "+ result1);

            }
            else if (input2== "-")
            {
                double result2 = Sub(output1, output3);
                Console.WriteLine("Sonuç: "+ result2);
            }
            else if (input2== "*")
            {
                double result3 = Multi(output1, output3);
                Console.WriteLine("Sonuç: "+ result3);
            }
            else if (input2== "/")
            {
                double result4 = Div(output1, output3);
                Console.WriteLine("Sonuç: "+ result4);
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir operatör giriniz!");
            }

            Console.ReadLine();
        }

        static double Sum(double number1, double number2)
        {
            double result = number1 + number2;
            return result;
        }

        static double Sub(double number1, double number2)
        {
            double result = number1 - number2;
            return result;
        }

        static double Multi(double number1, double number2)
        {
            double result = number1 * number2;
            return result;

        }
        static double Div(double number1,double number2)
        {
            double result = number1 / number2;
            return result;
        }
    }
}
