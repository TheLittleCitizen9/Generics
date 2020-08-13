using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class DataFlow : IDataFlow<string>
    {
        public List<IBlock<string>> Blocks = new List<IBlock<string>>();
        public void AddBlock(IBlock<string> block)
        {
            Blocks.Add(block);
        }

        public string RunFlow(string input)
        {
            if(Blocks.Count == 0)
            {
                return "No Blocks in DataFlow";
            }
            if(Blocks.Count == 1)
            {
                return Blocks[0].Process(input);
            }
            string output = input;
            for (int i = 0; i < Blocks.Count; i++)
            {
                output = Blocks[i].Process(output);
            }

            return output;
        }
    }
}
