using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class UpperCaseBlock : IBlock<string>
    {
        public string Process(string input)
        {
            if(input != string.Empty)
            {
                return input.ToUpper();
            }
            else
            {
                throw new ArgumentException("The input is an empty string");
            }
        }
    }
}
