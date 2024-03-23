using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class AddBinary
    {
        /*
         * 1010
         * 1011
         *    
         * 10101
         * 
         * 
         */

        public string AddBinarySolution(string a, string b)
        {

            if (a.Length > b.Length)
            {
                b = b.PadLeft(a.Length, '0');
            }
            else if (b.Length > a.Length)
            {
                a = a.PadLeft(b.Length, '0');
            }

            char reminder = ' ';
            string result = "";


            for (int i = a.Length - 1; i >= 0; i--)
            {
                char achar = a[i];
                char bchar = b[i];
                if (reminder != ' ' && reminder == '1')
                {
                    if (achar == '1')
                    {
                        achar = '0';
                        reminder = '1';
                    }
                    else
                    {
                        achar = '1';
                        reminder = '0';
                    }
                }

                if (achar == '1' && bchar == '1')
                {
                    result = '0' + result;
                    reminder = '1';
                }
                else if ((achar == '1' && bchar == '0') || (bchar == '1' && achar == '0'))
                {
                    result = "1" + result;
                }
                else
                {

                    result = "0" + result;
                }

            }

            if (reminder == '1')
            {
                result = reminder + result;
            }
            return result;

        }

    }
}
