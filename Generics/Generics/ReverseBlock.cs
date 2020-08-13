using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class ReverseBlock : IBlock<string>
    {
        public string Process(string input)
        {
            if(input != string.Empty)
            {
                Char[] chars = input.ToCharArray();
                var reversedChars = chars.Reverse().ToArray();
                return new string(reversedChars);
            }
            else
            {
                throw new ArgumentException("The input is an empty string");
            }
        }
    }
}
