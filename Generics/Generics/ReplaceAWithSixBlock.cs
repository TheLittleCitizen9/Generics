using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class ReplaceAWithSixBlock : IBlock<string>
    {
        public string Process(string input)
        {
            if (input != string.Empty)
            {
                Char[] chars = input.ToCharArray();
                if(chars.Contains('A'))
                {
                    for (int i = 0; i < chars.Length; i++)
                    {
                        if(chars[i] == 'A')
                        {
                            chars[i] = '6';
                        }
                    }
                    return new string(chars);
                }
                else
                {
                    return input;
                }
                
            }
            else
            {
                throw new ArgumentException("The input is an empty string");
            }
        }
    }
}
