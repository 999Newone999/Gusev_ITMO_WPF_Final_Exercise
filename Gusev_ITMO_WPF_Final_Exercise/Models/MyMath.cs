using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Gusev_ITMO_WPF_Final_Exercise
{
    static class MyMath
    {
        public static double GetCircumferenceFromRadius(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double Summ(double operand1, double operand2)
        {
            return operand1 + operand2;
        }

        public static double Subt(double operand1, double operand2)
        {
            return operand2 - operand1;
        }

        public static double Mult(double operand1, double operand2)
        {
            return operand1 * operand2;
        }

        public static double Div(double operand1, double operand2)
        {
            return operand2 / operand1;
        }

        public static double Sqrtt(double operand1)
        {
            return Math.Sqrt(operand1);
        }

        public static double RevX(double operand1)
        {
            return 1/operand1;
        }

        public static double Procent(double operand1)
        {
            return operand1/100;
        }
    }
}