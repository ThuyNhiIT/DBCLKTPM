using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Module03_Library
{
    public class Code_Module03
    {
        // BÀI 01
        public int GetPositionOf2Cir(int firstRadius, int secRadius, int distance)
        {
            if (distance == 0)
            {
                if (firstRadius == secRadius)
                {
                    return 0;
                }
                else if (firstRadius < secRadius)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            if (distance > 0)
            {
                return 3;
            }

            throw new IndexOutOfRangeException();
        }

        // Bài 02
        public string CheckValue(int x, int y, int z)
        {
            if (x == 0 || x == 1)
            {
                return "A";
            }
            else
            {
                if (y <= 10)
                {
                    return "B";
                }
                else
                {
                    if (z < 10)
                    {
                        return "C";
                    }
                    else
                    {
                        return "D";
                    }
                }
            }
        }


        // Bài 03
        public int MaxAndMean(int A, int B, int C, out double Mean)
        {
            Mean = (A + B + C) / 3.0;
            int Maximum;
            if (A > B)
                if (A > C)
                    Maximum = A;
                else
                    Maximum = B;
            else
            if (B > C)
                Maximum = B;
            else
                Maximum = C;
            return Maximum;
        }
        // Bài 04
        public int Max(int a, int b, int c)
        {
            int max = 0;
            if (a > 0 && b > 0 && c > 0)
                max = a;
            else
                return 0;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            return max;
        }


        // Bài 05
        public String Triangle(int a, int b, int c)
        {
            int match = 0;
            if (a == b)
                match = match + 1;
            if (a == c)
                match = match + 2;
            if (b == c)
                match = match + 3;
            if (match == 0)
                if ((a + b) <= c)
                    return ("Not a Triangle");
                else if ((b + c) <= a)
                    return ("Not a Triangle");
                else if ((a + c) <= b)
                    return ("Not a Triangle");
                else return ("Triangle is Scalene");
            else if (match == 1)
                if ((a + c) <= b)
                    return ("Not a Triangle");
                else return ("Triangle is Isosceles");
            else if (match == 2)
                if ((a + c) <= b)
                    return ("Not a Triangle");
                else return ("Triangle is Isosceles");
            else if (match == 3)
                if ((b + c) <= a)
                    return ("Not a Triangle");
                else return ("Triangle is Isosceles");
            else return ("Triangle is Equilateral");
        }

        // Bài 06
        public double Average(double Sum, double Count)
        {
            if (Count == 1) return Sum;
            else if (Count > 0) return Sum / Count;
            else return 0;
        }

        // Bài 07
        public int DayInMonth(int year, int month)
        {

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            else
            {
                if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    return 30;
                }
                else if (month == 2)
                {
                    if (year % 400 == 0)
                    {
                        return 29;
                    }
                    else if (year % 100 == 0)
                    {
                        return 28;
                    }
                    else if (year % 4 == 0)
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                }
                else
                {
                    return 0;
                }
            }
        }


        // Bài 08
        public (double? x1, double? x2) PhuongTrinhBacHai(double a, double b, double c)// Bài 8
        {
        
            double delta;
            if (a == 0)
            {
                throw new Exception();
            }
            else
            {
                delta = (b * b) - (4 * a * c);
                if (delta < 0)
                {
                    throw new Exception();
                }
                else if (delta == 0)
                {
              
                    return (-b / (2 * a), -b / (2 * a));
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            
                    return (x1, x2);
                }
            }
        }


        // Bài 09
        public float Limit(float a, float b, float x)
        {
            if (a > b)
            {
                throw new Exception("a > b");
            }
            else
            {
                if (x < a)
                {
                    return a;
                }
                else if (x > b)
                {
                    return b;
                }
                else
                {
                    return x;
                }
            }
        }

        // Bài 10
        public bool KiemTraTamGiac(float a, float b, float c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }
            else
            {
                if ((a + b > c) && (a + c > b) && (b + c > a))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // Bài 11
        public (float?, float?) CanGiuaAnh(float w, float h, float ww, float wh)
        {
            float x;
            float y;
            if (w <= 0 || h <= 0 || wh <= 0 || ww <= 0)
            {
                throw new Exception("ERROR");
            }
            else
            {
                
                if (w > ww)
                {
                    x = 0;
                }
                else
                {
                    x = (ww - w) / 2;
                }
                 if (h > wh)
                {
                    y = 0;
                }
                else
                {
                    y = (wh - h) / 2;
                }
                
                return (x, y);
            }
        }

        // Bài 12
        public float TinhGiaNhieuMuc(float total, float p1, float p2, float p3)
        {
            if (p1 < 0 || p2 < 0 || p3 < 0 || total < 0)
            {
                throw new Exception("ERROR");
            }
            else
            {
                if (total <= 100)
                {
                    return total * p1;
                }
                else if (total <= 150)
                {
                    return 100 * p1 + (total - 100) * p2;
                }
                else
                {
                    return 100 * p1 + 50 * p2 + (total - 150) * p3;
                }
            }
        }

        // Bài 13
        public bool KiemTraDiemHCN(float x1, float y1, float x2, float y2, float x, float y)
        {
            if ((x1 > x2) || (y1 > y2))
            {
                throw new Exception("ERROR");

            }
            else
            {
                if (x < x1 || x > x2)
                {
                    return false;
                }
                else if (y < y1 || y > y2)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        //Bài 14

        public (float? x, float? y, float? s) TaoIcon(float w, float h)
        {
            if (w < 0 || h < 0)
            {
                throw new Exception("ERROR");
            }
            else
            {
                if (w > h)
                {
                    return ((w - h) / 2, 0, h);
                }
                else
                {
                    return (0, (h - w) / 2, w);
                }
            }
        }

        // Bài 15
        public bool KiemTraNamNhuan(int year)
        {
            if (year < 1000 || year > 10000)
            {
                return false;
            }
            else
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (year % 4 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        // Bài 16
        public bool KiemTraPassWord(string pass)
        {
            bool containsDigit = Regex.IsMatch(pass, @"\d");
            if (pass.Length >= 6 && pass.Length <= 10 && containsDigit == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Bài 17
        public bool IsValidDate(int Year, int Month, int Day)
        {
            if (Month >= 1 && Month <= 12 && Day >= 1 && (Day <= DayInMonth(Year, Month)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Bài 18
        public bool KiemTraEmail(string email)
        {
            bool hasDot = email.Contains(".");          
            bool hasAcom = email.Contains("@"); 
            
            bool hasDot2 = email.Contains("..");
            bool hasErorr1 = email.Contains("@.");
            bool hasErorr2 = email.Contains(".@");
            bool hasErorr3 = email.Contains("@@");

            if (hasDot == true)
            {
                if (hasDot2 == false)
                {
                    if (hasAcom == true)
                    {
                        if (hasErorr1 == true || hasErorr2 == true || hasErorr3 == true)
                        {
                            return false;
                        }
                        else { return true; }
                    }
                    else
                    { return false; }
                }
                else
                { return false; }
            }
            else
            { return false; }

        }

        // Bài 19
        public int BodyCheck(int height, int weight)
        {
            if (height <= 0)
            {
                return -1;
            }
            else
            {
                if (weight <= 0)
                {
                    return -1;
                }
                else
                {
                    double scale = weight * 10000 / (height * height);
                    if (scale < 18)
                    {
                        return 2;
                    }
                    else
                    {
                        if (scale > 20)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }


        // Bài 20
        public const int MAX_INT = 32767;
        public const string str = "Statement Coverage";
        public int isInString(char tmp)
        {
            int k = str.IndexOf(tmp);
            if (k == -1)
            {
                return MAX_INT;
            }
            return k;

            }
        // Bài 21
        public long HexToDec(string hexaString)
        {
            int c;
            long hexnum, nhex;
            hexnum = nhex = 0;
            int i = 0;
            while (i < hexaString.Length)
            {
                c = hexaString[i++];
                switch (c)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        /* Convert a decimal digit */
                        nhex++;
                        hexnum *= 0x10;
                        hexnum += (c - '0');
                        break;
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                        /* lower case hex digit */
                        nhex++;
                        hexnum *= 0x10;
                        hexnum += (c - 'a' + 0xa);
                        break;
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'E':
                    case 'F':
                        /*upper case hex digit */
                        nhex++;
                        hexnum *= 0x10;
                        hexnum += (c - 'A' + 0xA);
                        break;
                    default:
                        /* non-hex characters */
                        break;
                }
            }
            return hexnum;
        }

    }
}
