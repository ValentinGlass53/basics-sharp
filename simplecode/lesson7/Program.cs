using System;
using System.Globalization;
string str = "5.3";
NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
{
    NumberDecimalSeparator = ".",
};

double a = double.Parse(str, numberFormatInfo);
System.Console.WriteLine(a);