using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            DataFlow dataFlow = new DataFlow();
            UpperCaseBlock upperCaseBlock = new UpperCaseBlock();
            ReverseBlock reverseBlock = new ReverseBlock();
            ReplaceAWithSixBlock replaceAWithSixBlock = new ReplaceAWithSixBlock();

            dataFlow.AddBlock(upperCaseBlock);
            dataFlow.AddBlock(reverseBlock);
            dataFlow.AddBlock(replaceAWithSixBlock);

            Console.WriteLine(dataFlow.RunFlow("dar"));
        }
    }
}
