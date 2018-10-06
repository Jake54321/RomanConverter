using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace RomanNumeralGenerator.Models
{

    /*  Symbol 	I 	V 	X 	L 	C 	D   M
        Value 	1 	5 	10 	50 	100 500	1,000 
    **/
    public class NumeralGenerator
    {
        //Possible results returned from parsed input
        //[0-9] = Arabic
        //[I,V,X,L,C,D,M] = Numeral
        public enum InputType { Arabic, Numeral, Error };

        public static InputType DetermineInputType(string inputValues)
        {
            Regex reg;
            Match match;
                            
            reg = new Regex(@"^[0-9]\d*(\.\d+)?$");
            match = reg.Match(inputValues);
            if (match.Success)
                return InputType.Arabic;
            
            reg = new Regex(@"^(?=[MDCLXVI])M*(C[MD]|D?C{0,3})(X[CL]|L?X{0,3})(I[XV]|V?I{0,3})$");
            match = reg.Match(inputValues);
            if (match.Success)
                return InputType.Numeral;

            return InputType.Error;
        }

        public static string ConvertToNumeral(string inputValues)
        {
            long value;
            string result;

            try
            {
                value = Convert.ToInt64(inputValues);
                result = "";

                while (value > 0)
                {
                    result = FindArabicValue(ref value, result);
                };

            }catch(Exception ex)
            {
                return ex.Message;
            }

            return result;

        }

        public static string ConvertToArabic(string inputValues)
        {
            long result = 0;
            int i = 0;
            int NextIncrement = 0;

            try
            {
                while (i < inputValues.Length)
                {
                    NextIncrement= FindNumeralValue(inputValues,ref i);

                    if (NextIncrement == 0)
                        return "";
                    else
                        result = result + Convert.ToInt64(NextIncrement);
                }

            }catch(Exception ex)
            {
                return ex.Message;
            }

            return result.ToString();
        }

        private static string FindArabicValue(ref long value, string result)
        {           
            if (value >= 1000)
            {
                value = value - 1000;
                return result + "M";
                
            }

            if (value >= 900)
            {
                value = value - 900;
                return result + "CM";
            }

            if (value >= 500)
            {
                value = value - 500;
                return result + "D";
            }

            if (value >= 400)
            {
                value = value - 400;
                return result + "CD";
            }


            if (value >= 100)
            {
                value = value - 100;
                return result + "C";
            }

            if (value >= 90)
            {
                value = value - 90;
                return result + "XC";
            }

            if (value >= 50)
            {
                value = value - 50;
                return result + "L";
            }

            if (value >= 40)
            {
                value = value - 40;
                return result + "XL";
            }


            if (value >= 10)
            {
                value = value - 10;
                return result + "X";
            }

            if (value >= 9)
            {
                value = value - 9;
                return result + "IX";
            }

            if (value >= 5)
            {
                value = value - 5;
                return result + "V";
            }

            if (value >= 4)
            {
                value = value - 4;
                return result + "IV";
            }

            if (value >= 1)
            {
                value = value - 1;
                return result + "I";
            }

            value = 0;
            return result;
        }

        private static int FindNumeralValue(string inputValues, ref int i)
        {
            char current = inputValues[i];
            char next;

            if (i + 1 > inputValues.Length - 1)
                next = ' ';
            else
                next = inputValues[i + 1];

            switch (current)
            {
                case 'I':
                    if (next == 'V')
                    {
                        i = i + 2;
                        return 4;
                    }
                    if (next == 'X')
                    {
                        i = i + 2;
                        return 9;
                    }

                    i++;
                    return 1;

                case 'V':
                    i++;
                    return 5;

                case 'X':
                    if (next == 'L')
                    {
                        i = i + 2;
                        return 40;
                    }
                    if (next == 'C')
                    {
                        i = i + 2;
                        return 90;
                    }
                    i++;
                    return 10;

                case 'L':
                    i++;
                    return 50;

                case 'C':
                    if (next == 'D')
                    {
                        i = i + 2;
                        return 400;
                    }
                    if (next == 'M')
                    {
                        i = i + 2;
                        return 900;
                    }

                    i++;
                    return 100;

                case 'D':
                    i++;
                    return 500;

                case 'M':
                    i++;
                    return 1000;
            }

            return 0;
        }
    }
}
 